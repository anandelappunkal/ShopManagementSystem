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
    public class InsurancesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InsurancesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Insurances
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Insurance.Include(i => i.CompanyName).Include(i => i.ODCategory).Include(i => i.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Insurances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Insurance == null)
            {
                return NotFound();
            }

            var insurance = await _context.Insurance
                .Include(i => i.CompanyName)
                .Include(i => i.ODCategory)
                .Include(i => i.User)
                .FirstOrDefaultAsync(m => m.InsuranceId == id);
            if (insurance == null)
            {
                return NotFound();
            }

            return View(insurance);
        }

        // GET: Insurances/Create
        public IActionResult Create()
        {
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "CompanyId");
            ViewData["ODCategoryId"] = new SelectList(_context.ODCategory, "ODCategoryId", "ODCategoryId");
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId");
            return View();
        }

        // POST: Insurances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InsuranceId,UserId,NomineeName,PolicyNumber,ODCategoryId,Premium,ODPremium,ODPercentage,Commission,NoClaimBonusPercentage,CompanyId,VehicleModel,VehicleNumber,ExpireDate,Broker,EngineNumber,ChaiseNumber,ManufactureMonthyear,Income,Expense,CreatedDate,ModifiedDate")] Insurance insurance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(insurance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "CompanyId", insurance.CompanyId);
            ViewData["ODCategoryId"] = new SelectList(_context.ODCategory, "ODCategoryId", "ODCategoryId", insurance.ODCategoryId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", insurance.UserId);
            return View(insurance);
        }

        // GET: Insurances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Insurance == null)
            {
                return NotFound();
            }

            var insurance = await _context.Insurance.FindAsync(id);
            if (insurance == null)
            {
                return NotFound();
            }
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "CompanyId", insurance.CompanyId);
            ViewData["ODCategoryId"] = new SelectList(_context.ODCategory, "ODCategoryId", "ODCategoryId", insurance.ODCategoryId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", insurance.UserId);
            return View(insurance);
        }

        // POST: Insurances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InsuranceId,UserId,NomineeName,PolicyNumber,ODCategoryId,Premium,ODPremium,ODPercentage,Commission,NoClaimBonusPercentage,CompanyId,VehicleModel,VehicleNumber,ExpireDate,Broker,EngineNumber,ChaiseNumber,ManufactureMonthyear,Income,Expense,CreatedDate,ModifiedDate")] Insurance insurance)
        {
            if (id != insurance.InsuranceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insurance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsuranceExists(insurance.InsuranceId))
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
            ViewData["CompanyId"] = new SelectList(_context.Company, "CompanyId", "CompanyId", insurance.CompanyId);
            ViewData["ODCategoryId"] = new SelectList(_context.ODCategory, "ODCategoryId", "ODCategoryId", insurance.ODCategoryId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "UserId", insurance.UserId);
            return View(insurance);
        }

        // GET: Insurances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Insurance == null)
            {
                return NotFound();
            }

            var insurance = await _context.Insurance
                .Include(i => i.CompanyName)
                .Include(i => i.ODCategory)
                .Include(i => i.User)
                .FirstOrDefaultAsync(m => m.InsuranceId == id);
            if (insurance == null)
            {
                return NotFound();
            }

            return View(insurance);
        }

        // POST: Insurances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Insurance == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Insurance'  is null.");
            }
            var insurance = await _context.Insurance.FindAsync(id);
            if (insurance != null)
            {
                _context.Insurance.Remove(insurance);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsuranceExists(int id)
        {
          return _context.Insurance.Any(e => e.InsuranceId == id);
        }
    }
}
