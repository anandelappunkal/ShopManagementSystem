using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopManagementSystem.Data;
using ShopManagementSystem.Models;

namespace ShopManagementSystem.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.User.Include(u => u.UserType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.User == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .Include(u => u.UserType)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            User user= new User();
            ViewData["UserTypeID"] = new SelectList(_context.UserType, "UserTypeId", "UserTypeId");
            var UserTypes = new SelectList(_context.UserType.OrderBy(l => l.Name)
           .ToDictionary(us => us.UserTypeId, us => us.Name), "Key", "Value");
            ViewBag.UserTypes = UserTypes;
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserName,Password,Email,FirstName,LastName,DateOfBirth,Address,AadharID,PanCard,MobileNumber,UserTypeID")] User user)
        {
            var userType = _context.UserType.Find(user.UserTypeID);
            if (userType == null)
            {
                return NotFound();
            }
            else
            {
                user.UserType = userType;
            }
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var UserTypes = new SelectList(_context.UserType.OrderBy(l => l.Name)
           .ToDictionary(us => us.UserTypeId, us => us.Name), "Key", "Value");
            ViewBag.UserTypes = UserTypes;
            ViewData["UserTypeID"] = new SelectList(_context.UserType, "UserTypeId", "UserTypeId", user.UserTypeID);
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.User == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            var UserTypes = new SelectList(_context.UserType.OrderBy(l => l.Name)
           .ToDictionary(us => us.UserTypeId, us => us.Name), "Key", "Value");
            ViewBag.UserTypes = UserTypes;
            ViewData["UserTypeID"] = new SelectList(_context.UserType, "UserTypeId", "UserTypeId", user.UserTypeID);
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,Email,FirstName,LastName,DateOfBirth,Address,AadharID,PanCard,MobileNumber,UserTypeID")] User user)
        {
            //var userDetails = _context.User.Find(user.UserId);
            //if(userDetails !=null)
            //{
            //    user.UserName = userDetails.UserName;
            //    user.Password = userDetails.Password;
            //}
            var userType = _context.UserType.Find(user.UserTypeID);
            if (userType == null)
            {
                return NotFound();
            }
            else
            {
                user.UserType = userType;
            }
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            var UserTypes = new SelectList(_context.UserType.OrderBy(l => l.Name)
           .ToDictionary(us => us.UserTypeId, us => us.Name), "Key", "Value");
            ViewBag.UserTypes = UserTypes;
            ViewData["UserTypeID"] = new SelectList(_context.UserType, "UserTypeId", "UserTypeId", user.UserTypeID);
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.User == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .Include(u => u.UserType)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.User == null)
            {
                return Problem("Entity set 'ApplicationDbContext.User'  is null.");
            }
            var user = await _context.User.FindAsync(id);
            if (user != null)
            {
                _context.User.Remove(user);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
          return _context.User.Any(e => e.UserId == id);
        }
    }
}
