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
    public class JioPoslitesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JioPoslitesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: JioPoslites
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.JioPsoslite.Include(j => j.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: JioPoslites/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.JioPsoslite == null)
            {
                return NotFound();
            }

            var jioPoslite = await _context.JioPsoslite
                .Include(j => j.User)
                .FirstOrDefaultAsync(m => m.JioPosliteId == id);
            if (jioPoslite == null)
            {
                return NotFound();
            }

            return View(jioPoslite);
        }

        // GET: JioPoslites/Create
        public IActionResult Create()
        {
            var Customers = new SelectList(_context.User.OrderBy(l => l.FirstName)
          .ToDictionary(us => us.UserId, us => us.FirstName), "Key", "Value");
            ViewBag.Customers = Customers;
            ViewData["CustomerId"] = new SelectList(_context.User, "UserId", "UserId");
            return View();
        }

        // POST: JioPoslites/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JioPosliteId,CustomerId,TarifPlan,Amount,Total,CreatedDate,ModifiedDate")] JioPoslite jioPoslite)
        {
            var userDetails = _context.User.Find(jioPoslite.CustomerId);
            if (userDetails == null)
            {
                return NotFound();
            }
            else
            {
                jioPoslite.User = userDetails;
            }
            if (ModelState.IsValid)
            {
                _context.Add(jioPoslite);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var Customers = new SelectList(_context.User.OrderBy(l => l.FirstName)
           .ToDictionary(us => us.UserId, us => us.FirstName), "Key", "Value");
            ViewBag.Customers = Customers;
            ViewData["CustomerId"] = new SelectList(_context.User, "UserId", "UserId", jioPoslite.CustomerId);
            return View(jioPoslite);
        }

        // GET: JioPoslites/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.JioPsoslite == null)
            {
                return NotFound();
            }

            var jioPoslite = await _context.JioPsoslite.FindAsync(id);
            if (jioPoslite == null)
            {
                return NotFound();
            }
            var Customers = new SelectList(_context.User.OrderBy(l => l.FirstName)
           .ToDictionary(us => us.UserId, us => us.FirstName), "Key", "Value");
            ViewBag.Customers = Customers;
            ViewData["CustomerId"] = new SelectList(_context.User, "UserId", "UserId", jioPoslite.CustomerId);
            return View(jioPoslite);
        }

        // POST: JioPoslites/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JioPosliteId,CustomerId,TarifPlan,Amount,Total,CreatedDate,ModifiedDate")] JioPoslite jioPoslite)
        {
            if (id != jioPoslite.JioPosliteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jioPoslite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JioPosliteExists(jioPoslite.JioPosliteId))
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
            ViewData["CustomerId"] = new SelectList(_context.User, "UserId", "UserId", jioPoslite.CustomerId);
            return View(jioPoslite);
        }

        // GET: JioPoslites/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.JioPsoslite == null)
            {
                return NotFound();
            }

            var jioPoslite = await _context.JioPsoslite
                .Include(j => j.User)
                .FirstOrDefaultAsync(m => m.JioPosliteId == id);
            if (jioPoslite == null)
            {
                return NotFound();
            }

            return View(jioPoslite);
        }

        // POST: JioPoslites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.JioPsoslite == null)
            {
                return Problem("Entity set 'ApplicationDbContext.JioPsoslite'  is null.");
            }
            var jioPoslite = await _context.JioPsoslite.FindAsync(id);
            if (jioPoslite != null)
            {
                _context.JioPsoslite.Remove(jioPoslite);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JioPosliteExists(int id)
        {
          return _context.JioPsoslite.Any(e => e.JioPosliteId == id);
        }
    }
}
