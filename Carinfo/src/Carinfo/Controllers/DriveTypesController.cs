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
    public class DriveTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DriveTypesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: DriveTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.DriveType.ToListAsync());
        }

        // GET: DriveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driveType = await _context.DriveType.SingleOrDefaultAsync(m => m.DrveTypeID == id);
            if (driveType == null)
            {
                return NotFound();
            }

            return View(driveType);
        }

        // GET: DriveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DriveTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DrveTypeID,Name")] DriveType driveType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(driveType);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(driveType);
        }

        // GET: DriveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driveType = await _context.DriveType.SingleOrDefaultAsync(m => m.DrveTypeID == id);
            if (driveType == null)
            {
                return NotFound();
            }
            return View(driveType);
        }

        // POST: DriveTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DrveTypeID,Name")] DriveType driveType)
        {
            if (id != driveType.DrveTypeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(driveType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DriveTypeExists(driveType.DrveTypeID))
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
            return View(driveType);
        }

        // GET: DriveTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driveType = await _context.DriveType.SingleOrDefaultAsync(m => m.DrveTypeID == id);
            if (driveType == null)
            {
                return NotFound();
            }

            return View(driveType);
        }

        // POST: DriveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var driveType = await _context.DriveType.SingleOrDefaultAsync(m => m.DrveTypeID == id);
            _context.DriveType.Remove(driveType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool DriveTypeExists(int id)
        {
            return _context.DriveType.Any(e => e.DrveTypeID == id);
        }
    }
}
