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
    public class ODCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ODCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ODCategories
        public async Task<IActionResult> Index()
        {
              return View(await _context.ODCategory.ToListAsync());
        }

        // GET: ODCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ODCategory == null)
            {
                return NotFound();
            }

            var oDCategory = await _context.ODCategory
                .FirstOrDefaultAsync(m => m.ODCategoryId == id);
            if (oDCategory == null)
            {
                return NotFound();
            }

            return View(oDCategory);
        }

        // GET: ODCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ODCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ODCategoryId,Name,Description,CreatedDate,ModifiedDate")] ODCategory oDCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oDCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(oDCategory);
        }

        // GET: ODCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ODCategory == null)
            {
                return NotFound();
            }

            var oDCategory = await _context.ODCategory.FindAsync(id);
            if (oDCategory == null)
            {
                return NotFound();
            }
            return View(oDCategory);
        }

        // POST: ODCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ODCategoryId,Name,Description,CreatedDate,ModifiedDate")] ODCategory oDCategory)
        {
            if (id != oDCategory.ODCategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oDCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ODCategoryExists(oDCategory.ODCategoryId))
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
            return View(oDCategory);
        }

        // GET: ODCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ODCategory == null)
            {
                return NotFound();
            }

            var oDCategory = await _context.ODCategory
                .FirstOrDefaultAsync(m => m.ODCategoryId == id);
            if (oDCategory == null)
            {
                return NotFound();
            }

            return View(oDCategory);
        }

        // POST: ODCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ODCategory == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ODCategory'  is null.");
            }
            var oDCategory = await _context.ODCategory.FindAsync(id);
            if (oDCategory != null)
            {
                _context.ODCategory.Remove(oDCategory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ODCategoryExists(int id)
        {
          return _context.ODCategory.Any(e => e.ODCategoryId == id);
        }
    }
}
