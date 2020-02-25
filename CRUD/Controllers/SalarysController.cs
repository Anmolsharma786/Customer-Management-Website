using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUD.Models;

namespace CRUD.Controllers
{
    public class SalarysController : Controller
    {
        private readonly salaryContext _context;

        public SalarysController(salaryContext context)
        {
            _context = context;
        }

        // GET: Salarys
        public async Task<IActionResult> Index()
        {
            return View(await _context.Salary.ToListAsync());
        }

        // GET: Salarys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salarys = await _context.Salary
                .FirstOrDefaultAsync(m => m.salaryId == id);
            if (salarys == null)
            {
                return NotFound();
            }

            return View(salarys);
        }

        // GET: Salarys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Salarys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("startingDate,endingDate,salary,salaryId,emp_id")] Salarys salarys)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salarys);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salarys);
        }

        // GET: Salarys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salarys = await _context.Salary.FindAsync(id);
            if (salarys == null)
            {
                return NotFound();
            }
            return View(salarys);
        }

        // POST: Salarys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("startingDate,endingDate,salary,salaryId,emp_id")] Salarys salarys)
        {
            if (id != salarys.salaryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salarys);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalarysExists(salarys.salaryId))
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
            return View(salarys);
        }

        // GET: Salarys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salarys = await _context.Salary
                .FirstOrDefaultAsync(m => m.salaryId == id);
            if (salarys == null)
            {
                return NotFound();
            }

            return View(salarys);
        }

        // POST: Salarys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salarys = await _context.Salary.FindAsync(id);
            _context.Salary.Remove(salarys);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalarysExists(int id)
        {
            return _context.Salary.Any(e => e.salaryId == id);
        }
    }
}
