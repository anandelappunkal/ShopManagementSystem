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
    public class SoundBoxesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SoundBoxesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SoundBoxes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SoundBox.Include(s => s.ShopName);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SoundBoxes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SoundBox == null)
            {
                return NotFound();
            }

            var soundBox = await _context.SoundBox
                .Include(s => s.ShopName)
                .FirstOrDefaultAsync(m => m.SoundBoxId == id);
            if (soundBox == null)
            {
                return NotFound();
            }

            return View(soundBox);
        }

        // GET: SoundBoxes/Create
        public IActionResult Create()
        {
            ViewData["ShopId"] = new SelectList(_context.Shop, "ShopId", "ShopId");
            return View();
        }

        // POST: SoundBoxes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SoundBoxId,ShopId,Category,ItemPlan,NoOfItems,Price,Total,CreatedDate,ModifiedDate")] SoundBox soundBox)
        {
            if (ModelState.IsValid)
            {
                _context.Add(soundBox);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ShopId"] = new SelectList(_context.Shop, "ShopId", "ShopId", soundBox.ShopId);
            return View(soundBox);
        }

        // GET: SoundBoxes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SoundBox == null)
            {
                return NotFound();
            }

            var soundBox = await _context.SoundBox.FindAsync(id);
            if (soundBox == null)
            {
                return NotFound();
            }
            ViewData["ShopId"] = new SelectList(_context.Shop, "ShopId", "ShopId", soundBox.ShopId);
            return View(soundBox);
        }

        // POST: SoundBoxes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SoundBoxId,ShopId,Category,ItemPlan,NoOfItems,Price,Total,CreatedDate,ModifiedDate")] SoundBox soundBox)
        {
            if (id != soundBox.SoundBoxId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(soundBox);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SoundBoxExists(soundBox.SoundBoxId))
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
            ViewData["ShopId"] = new SelectList(_context.Shop, "ShopId", "ShopId", soundBox.ShopId);
            return View(soundBox);
        }

        // GET: SoundBoxes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SoundBox == null)
            {
                return NotFound();
            }

            var soundBox = await _context.SoundBox
                .Include(s => s.ShopName)
                .FirstOrDefaultAsync(m => m.SoundBoxId == id);
            if (soundBox == null)
            {
                return NotFound();
            }

            return View(soundBox);
        }

        // POST: SoundBoxes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SoundBox == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SoundBox'  is null.");
            }
            var soundBox = await _context.SoundBox.FindAsync(id);
            if (soundBox != null)
            {
                _context.SoundBox.Remove(soundBox);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SoundBoxExists(int id)
        {
          return _context.SoundBox.Any(e => e.SoundBoxId == id);
        }
    }
}
