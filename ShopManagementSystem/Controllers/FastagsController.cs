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
    public class FastagsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FastagsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Fastags
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Fastag.Include(f => f.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Fastags/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Fastag == null)
            {
                return NotFound();
            }

            var fastag = await _context.Fastag
                .Include(f => f.User)
                .FirstOrDefaultAsync(m => m.FastagId == id);
            if (fastag == null)
            {
                return NotFound();
            }

            return View(fastag);
        }

        // GET: Fastags/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId");
            return View();
        }

        // POST: Fastags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FastagId,UserId,AmountTotal,CreatedDate,ModifiedDate")] Fastag fastag)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fastag);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", fastag.UserId);
            return View(fastag);
        }

        // GET: Fastags/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Fastag == null)
            {
                return NotFound();
            }

            var fastag = await _context.Fastag.FindAsync(id);
            if (fastag == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", fastag.UserId);
            return View(fastag);
        }

        // POST: Fastags/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FastagId,UserId,AmountTotal,CreatedDate,ModifiedDate")] Fastag fastag)
        {
            if (id != fastag.FastagId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fastag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FastagExists(fastag.FastagId))
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
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", fastag.UserId);
            return View(fastag);
        }

        // GET: Fastags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Fastag == null)
            {
                return NotFound();
            }

            var fastag = await _context.Fastag
                .Include(f => f.User)
                .FirstOrDefaultAsync(m => m.FastagId == id);
            if (fastag == null)
            {
                return NotFound();
            }

            return View(fastag);
        }

        // POST: Fastags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Fastag == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Fastag'  is null.");
            }
            var fastag = await _context.Fastag.FindAsync(id);
            if (fastag != null)
            {
                _context.Fastag.Remove(fastag);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FastagExists(int id)
        {
          return _context.Fastag.Any(e => e.FastagId == id);
        }
    }
}
