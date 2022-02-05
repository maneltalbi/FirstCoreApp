using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FirstCoreApp.Models;

namespace FirstCoreApp.Controllers
{
    public class TeammembersController : Controller
    {
        private readonly NewsDBContext _context;

        public TeammembersController(NewsDBContext context)
        {
            _context = context;
        }

        // GET: Teammembers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Teammember.ToListAsync());
        }

        // GET: Teammembers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teammember = await _context.Teammember
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teammember == null)
            {
                return NotFound();
            }

            return View(teammember);
        }

        // GET: Teammembers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teammembers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,JobTitle,Image")] Teammember teammember)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teammember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teammember);
        }

        // GET: Teammembers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teammember = await _context.Teammember.FindAsync(id);
            if (teammember == null)
            {
                return NotFound();
            }
            return View(teammember);
        }

        // POST: Teammembers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,JobTitle,Image")] Teammember teammember)
        {
            if (id != teammember.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teammember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeammemberExists(teammember.Id))
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
            return View(teammember);
        }

        // GET: Teammembers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teammember = await _context.Teammember
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teammember == null)
            {
                return NotFound();
            }

            return View(teammember);
        }

        // POST: Teammembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teammember = await _context.Teammember.FindAsync(id);
            _context.Teammember.Remove(teammember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeammemberExists(int id)
        {
            return _context.Teammember.Any(e => e.Id == id);
        }
    }
}
