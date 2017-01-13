using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HRMCore.Data;
using HRMCore.Models;

namespace HRMCore.Controllers
{
    public class DeptsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DeptsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Depts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Depts.ToListAsync());
        }

        // GET: Depts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dept = await _context.Depts.SingleOrDefaultAsync(m => m.DeptId == id);
            if (dept == null)
            {
                return NotFound();
            }

            return View(dept);
        }

        // GET: Depts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Depts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DeptId,ActionDate,Location,Name")] Dept dept)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dept);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(dept);
        }

        // GET: Depts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dept = await _context.Depts.SingleOrDefaultAsync(m => m.DeptId == id);
            if (dept == null)
            {
                return NotFound();
            }
            return View(dept);
        }

        // POST: Depts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DeptId,ActionDate,Location,Name")] Dept dept)
        {
            if (id != dept.DeptId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dept);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeptExists(dept.DeptId))
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
            return View(dept);
        }

        // GET: Depts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dept = await _context.Depts.SingleOrDefaultAsync(m => m.DeptId == id);
            if (dept == null)
            {
                return NotFound();
            }

            return View(dept);
        }

        // POST: Depts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dept = await _context.Depts.SingleOrDefaultAsync(m => m.DeptId == id);
            _context.Depts.Remove(dept);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool DeptExists(int id)
        {
            return _context.Depts.Any(e => e.DeptId == id);
        }
    }
}
