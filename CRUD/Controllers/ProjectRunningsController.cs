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
    public class ProjectRunningsController : Controller
    {
        private readonly ProjectContext _context;

        public ProjectRunningsController(ProjectContext context)
        {
            _context = context;
        }

        // GET: ProjectRunnings
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProjectRunning.ToListAsync());
        }

        // GET: ProjectRunnings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectRunning = await _context.ProjectRunning
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (projectRunning == null)
            {
                return NotFound();
            }

            return View(projectRunning);
        }

        // GET: ProjectRunnings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectRunnings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,projectDeadline,ProjectManager,ProjectName,ProjectId")] ProjectRunning projectRunning)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectRunning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projectRunning);
        }

        // GET: ProjectRunnings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectRunning = await _context.ProjectRunning.FindAsync(id);
            if (projectRunning == null)
            {
                return NotFound();
            }
            return View(projectRunning);
        }

        // POST: ProjectRunnings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,projectDeadline,ProjectManager,ProjectName,ProjectId")] ProjectRunning projectRunning)
        {
            if (id != projectRunning.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectRunning);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectRunningExists(projectRunning.EmployeeId))
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
            return View(projectRunning);
        }

        // GET: ProjectRunnings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectRunning = await _context.ProjectRunning
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (projectRunning == null)
            {
                return NotFound();
            }

            return View(projectRunning);
        }

        // POST: ProjectRunnings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectRunning = await _context.ProjectRunning.FindAsync(id);
            _context.ProjectRunning.Remove(projectRunning);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectRunningExists(int id)
        {
            return _context.ProjectRunning.Any(e => e.EmployeeId == id);
        }
    }
}
