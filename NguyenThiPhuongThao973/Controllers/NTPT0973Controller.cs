using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenThiPhuongThao973.Data;
using NguyenThiPhuongThao973.Models;

namespace NguyenThiPhuongThao973.Controllers
{
    public class NTPT0973Controller : Controller
    {
        private readonly NguyenThiPhuongThao973Context _context;

        public NTPT0973Controller(NguyenThiPhuongThao973Context context)
        {
            _context = context;
        }

        // GET: NTPT0973
        public async Task<IActionResult> Index()
        {
            return View(await _context.NTPT0973.ToListAsync());
        }

        // GET: NTPT0973/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTPT0973 = await _context.NTPT0973
                .FirstOrDefaultAsync(m => m.NTPTId == id);
            if (nTPT0973 == null)
            {
                return NotFound();
            }

            return View(nTPT0973);
        }

        // GET: NTPT0973/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTPT0973/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NTPTId,NTPTName,NTPTGender")] NTPT0973 nTPT0973)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTPT0973);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTPT0973);
        }

        // GET: NTPT0973/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTPT0973 = await _context.NTPT0973.FindAsync(id);
            if (nTPT0973 == null)
            {
                return NotFound();
            }
            return View(nTPT0973);
        }

        // POST: NTPT0973/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NTPTId,NTPTName,NTPTGender")] NTPT0973 nTPT0973)
        {
            if (id != nTPT0973.NTPTId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTPT0973);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTPT0973Exists(nTPT0973.NTPTId))
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
            return View(nTPT0973);
        }

        // GET: NTPT0973/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTPT0973 = await _context.NTPT0973
                .FirstOrDefaultAsync(m => m.NTPTId == id);
            if (nTPT0973 == null)
            {
                return NotFound();
            }

            return View(nTPT0973);
        }

        // POST: NTPT0973/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nTPT0973 = await _context.NTPT0973.FindAsync(id);
            _context.NTPT0973.Remove(nTPT0973);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTPT0973Exists(int id)
        {
            return _context.NTPT0973.Any(e => e.NTPTId == id);
        }
    }
}
