using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Car_Database.Models;
using Database_Cars.Data;

namespace Database_Cars.Controllers
{
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Cars
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Car.Include(c => c.CarBrands).Include(c => c.CarModels).Include(c => c.DriveTypes).Include(c => c.FuelTypes);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Car.SingleOrDefaultAsync(m => m.CarID == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // GET: Cars/Create
        public IActionResult Create()
        {
            ViewData["CarBrandID"] = new SelectList(_context.CarBrand, "CarBrandID", "Name");
            ViewData["CarModelID"] = new SelectList(_context.CarModel, "CarModelID", "Name");
            ViewData["DriveTypeID"] = new SelectList(_context.DriveType, "DrveTypeID", "Name");
            ViewData["FuelTypeID"] = new SelectList(_context.FuelType, "FuelTypeID", "Fuel");
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CarID,CarBrandID,CarModelID,Displacement,DriveTypeID,FuelTypeID,Power,Torque,Weight,Year")] Car car)
        {
            if (ModelState.IsValid)
            {
                _context.Add(car);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["CarBrandID"] = new SelectList(_context.CarBrand, "CarBrandID", "Name", car.CarBrandID);
            ViewData["CarModelID"] = new SelectList(_context.CarModel, "CarModelID", "Name", car.CarModelID);
            ViewData["DriveTypeID"] = new SelectList(_context.DriveType, "DrveTypeID", "Name", car.DriveTypeID);
            ViewData["FuelTypeID"] = new SelectList(_context.FuelType, "FuelTypeID", "Fuel", car.FuelTypeID);
            return View(car);
        }

        // GET: Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Car.SingleOrDefaultAsync(m => m.CarID == id);
            if (car == null)
            {
                return NotFound();
            }
            ViewData["CarBrandID"] = new SelectList(_context.CarBrand, "CarBrandID", "Name", car.CarBrandID);
            ViewData["CarModelID"] = new SelectList(_context.CarModel, "CarModelID", "Name", car.CarModelID);
            ViewData["DriveTypeID"] = new SelectList(_context.DriveType, "DrveTypeID", "Name", car.DriveTypeID);
            ViewData["FuelTypeID"] = new SelectList(_context.FuelType, "FuelTypeID", "Fuel", car.FuelTypeID);
            return View(car);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CarID,CarBrandID,CarModelID,Displacement,DriveTypeID,FuelTypeID,Power,Torque,Weight,Year")] Car car)
        {
            if (id != car.CarID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(car);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(car.CarID))
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
            ViewData["CarBrandID"] = new SelectList(_context.CarBrand, "CarBrandID", "Name", car.CarBrandID);
            ViewData["CarModelID"] = new SelectList(_context.CarModel, "CarModelID", "Name", car.CarModelID);
            ViewData["DriveTypeID"] = new SelectList(_context.DriveType, "DrveTypeID", "Name", car.DriveTypeID);
            ViewData["FuelTypeID"] = new SelectList(_context.FuelType, "FuelTypeID", "Fuel", car.FuelTypeID);
            return View(car);
        }

        // GET: Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Car.SingleOrDefaultAsync(m => m.CarID == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var car = await _context.Car.SingleOrDefaultAsync(m => m.CarID == id);
            _context.Car.Remove(car);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CarExists(int id)
        {
            return _context.Car.Any(e => e.CarID == id);
        }
    }
}
