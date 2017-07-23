using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Carinfo.Data;
using Carinfo.Models;

namespace Carinfo.Controllers
{
    public class SubarusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubarusController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Subarus
        //public async Task<IActionResult> Index()
        //{
        //    var applicationDbContext = _context.Subaru.Include(s => s.CarModels).Include(s => s.Cylinders).Include(s => s.DriveTypes).Include(s => s.FuelTypes).Include(s => s.GearBoxes);
        //    return View(await applicationDbContext.ToListAsync());
        //}

        public ActionResult Index(string sortOrder)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            var subarus = from s in db.Subaru
                           select s;
            switch (sortOrder)
            {
                case "name_desc":
                    subarus = subarus.OrderByDescending(s => s.CarModel);
                    break;

                default:
                    subarus = subarus.OrderBy(s => s.CarModel);
                    break;
            }
            return View(subarus.ToList());
        }

        // GET: Subarus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subaru = await _context.Subaru.SingleOrDefaultAsync(m => m.SubaruID == id);
            if (subaru == null)
            {
                return NotFound();
            }

            return View(subaru);
        }

        // GET: Subarus/Create
        public IActionResult Create()
        {
            ViewData["CarModelID"] = new SelectList(_context.CarModel, "CarModelID", "Name");
            ViewData["CylinderID"] = new SelectList(_context.Cylinder, "CylinderID", "Type");
            ViewData["DriveTypeID"] = new SelectList(_context.DriveType, "DrveTypeID", "Name");
            ViewData["FuelTypeID"] = new SelectList(_context.FuelType, "FuelTypeID", "Fuel");
            ViewData["GearBoxID"] = new SelectList(_context.GearBox, "GearBoxID", "GearBoxType");
            return View();
        }

        // POST: Subarus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubaruID,CarModelID,CylinderID,Displacement,DriveTypeID,FuelTypeID,GearBoxID,Power,Torque,Weight,Year,img")] Subaru subaru)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subaru);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["CarModelID"] = new SelectList(_context.CarModel, "CarModelID", "Name", subaru.CarModelID);
            ViewData["CylinderID"] = new SelectList(_context.Cylinder, "CylinderID", "Type", subaru.CylinderID);
            ViewData["DriveTypeID"] = new SelectList(_context.DriveType, "DrveTypeID", "Name", subaru.DriveTypeID);
            ViewData["FuelTypeID"] = new SelectList(_context.FuelType, "FuelTypeID", "Fuel", subaru.FuelTypeID);
            ViewData["GearBoxID"] = new SelectList(_context.GearBox, "GearBoxID", "GearBoxType", subaru.GearBoxID);
            return View(subaru);
        }

        // GET: Subarus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subaru = await _context.Subaru.SingleOrDefaultAsync(m => m.SubaruID == id);
            if (subaru == null)
            {
                return NotFound();
            }
            ViewData["CarModelID"] = new SelectList(_context.CarModel, "CarModelID", "Name", subaru.CarModelID);
            ViewData["CylinderID"] = new SelectList(_context.Cylinder, "CylinderID", "Type", subaru.CylinderID);
            ViewData["DriveTypeID"] = new SelectList(_context.DriveType, "DrveTypeID", "Name", subaru.DriveTypeID);
            ViewData["FuelTypeID"] = new SelectList(_context.FuelType, "FuelTypeID", "Fuel", subaru.FuelTypeID);
            ViewData["GearBoxID"] = new SelectList(_context.GearBox, "GearBoxID", "GearBoxType", subaru.GearBoxID);
            return View(subaru);
        }

        // POST: Subarus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SubaruID,CarModelID,CylinderID,Displacement,DriveTypeID,FuelTypeID,GearBoxID,Power,Torque,Weight,Year,img")] Subaru subaru)
        {
            if (id != subaru.SubaruID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subaru);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubaruExists(subaru.SubaruID))
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
            ViewData["CarModelID"] = new SelectList(_context.CarModel, "CarModelID", "Name", subaru.CarModelID);
            ViewData["CylinderID"] = new SelectList(_context.Cylinder, "CylinderID", "Type", subaru.CylinderID);
            ViewData["DriveTypeID"] = new SelectList(_context.DriveType, "DrveTypeID", "Name", subaru.DriveTypeID);
            ViewData["FuelTypeID"] = new SelectList(_context.FuelType, "FuelTypeID", "Fuel", subaru.FuelTypeID);
            ViewData["GearBoxID"] = new SelectList(_context.GearBox, "GearBoxID", "GearBoxType", subaru.GearBoxID);
            return View(subaru);
        }

        // GET: Subarus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subaru = await _context.Subaru.SingleOrDefaultAsync(m => m.SubaruID == id);
            if (subaru == null)
            {
                return NotFound();
            }

            return View(subaru);
        }

        // POST: Subarus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subaru = await _context.Subaru.SingleOrDefaultAsync(m => m.SubaruID == id);
            _context.Subaru.Remove(subaru);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool SubaruExists(int id)
        {
            return _context.Subaru.Any(e => e.SubaruID == id);
        }
    }
}
