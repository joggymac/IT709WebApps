using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Car_Database.Models;
using Carinfo.Data;

namespace Carinfo.Controllers
{
    public class CylindersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CylindersController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Cylinders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cylinder.ToListAsync());
        }

        // GET: Cylinders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cylinder = await _context.Cylinder.SingleOrDefaultAsync(m => m.CylinderID == id);
            if (cylinder == null)
            {
                return NotFound();
            }

            return View(cylinder);
        }

        // GET: Cylinders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cylinders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CylinderID,Type")] Cylinder cylinder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cylinder);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cylinder);
        }

        // GET: Cylinders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cylinder = await _context.Cylinder.SingleOrDefaultAsync(m => m.CylinderID == id);
            if (cylinder == null)
            {
                return NotFound();
            }
            return View(cylinder);
        }

        // POST: Cylinders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CylinderID,Type")] Cylinder cylinder)
        {
            if (id != cylinder.CylinderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cylinder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CylinderExists(cylinder.CylinderID))
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
            return View(cylinder);
        }

        // GET: Cylinders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cylinder = await _context.Cylinder.SingleOrDefaultAsync(m => m.CylinderID == id);
            if (cylinder == null)
            {
                return NotFound();
            }

            return View(cylinder);
        }

        // POST: Cylinders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cylinder = await _context.Cylinder.SingleOrDefaultAsync(m => m.CylinderID == id);
            _context.Cylinder.Remove(cylinder);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CylinderExists(int id)
        {
            return _context.Cylinder.Any(e => e.CylinderID == id);
        }
    }
}
