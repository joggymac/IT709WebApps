using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Car_Database.Data;
using Car_Database.Models;

namespace Car_Database.Controllers
{
    public class CarBrandsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarBrandsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: CarBrands
        public async Task<IActionResult> Index()
        {
            return View(await _context.CarBrand.ToListAsync());
        }

        // GET: CarBrands/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carBrand = await _context.CarBrand.SingleOrDefaultAsync(m => m.CarBrandID == id);
            if (carBrand == null)
            {
                return NotFound();
            }

            return View(carBrand);
        }

        // GET: CarBrands/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarBrands/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CarBrandID,Name")] CarBrand carBrand)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carBrand);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(carBrand);
        }

        // GET: CarBrands/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carBrand = await _context.CarBrand.SingleOrDefaultAsync(m => m.CarBrandID == id);
            if (carBrand == null)
            {
                return NotFound();
            }
            return View(carBrand);
        }

        // POST: CarBrands/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CarBrandID,Name")] CarBrand carBrand)
        {
            if (id != carBrand.CarBrandID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carBrand);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarBrandExists(carBrand.CarBrandID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(carBrand);
        }

        // GET: CarBrands/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carBrand = await _context.CarBrand.SingleOrDefaultAsync(m => m.CarBrandID == id);
            if (carBrand == null)
            {
                return NotFound();
            }

            return View(carBrand);
        }

        // POST: CarBrands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carBrand = await _context.CarBrand.SingleOrDefaultAsync(m => m.CarBrandID == id);
            _context.CarBrand.Remove(carBrand);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CarBrandExists(int id)
        {
            return _context.CarBrand.Any(e => e.CarBrandID == id);
        }
    }
}
