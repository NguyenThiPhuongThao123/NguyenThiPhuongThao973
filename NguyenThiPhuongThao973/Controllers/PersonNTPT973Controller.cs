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
    public class PersonNTPT973Controller : Controller
    {
        private readonly NguyenThiPhuongThao973Context _context;

        public PersonNTPT973Controller(NguyenThiPhuongThao973Context context)
        {
            _context = context;
        }

        // GET: PersonNTPT973
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonNTPT973.ToListAsync());
        }

        // GET: PersonNTPT973/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTPT973 = await _context.PersonNTPT973
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personNTPT973 == null)
            {
                return NotFound();
            }

            return View(personNTPT973);
        }

        // GET: PersonNTPT973/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonNTPT973/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonNTPT973 personNTPT973)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personNTPT973);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personNTPT973);
        }

        // GET: PersonNTPT973/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTPT973 = await _context.PersonNTPT973.FindAsync(id);
            if (personNTPT973 == null)
            {
                return NotFound();
            }
            return View(personNTPT973);
        }

        // POST: PersonNTPT973/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonId,PersonName")] PersonNTPT973 personNTPT973)
        {
            if (id != personNTPT973.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personNTPT973);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonNTPT973Exists(personNTPT973.PersonId))
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
            return View(personNTPT973);
        }

        // GET: PersonNTPT973/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTPT973 = await _context.PersonNTPT973
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personNTPT973 == null)
            {
                return NotFound();
            }

            return View(personNTPT973);
        }

        // POST: PersonNTPT973/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personNTPT973 = await _context.PersonNTPT973.FindAsync(id);
            _context.PersonNTPT973.Remove(personNTPT973);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonNTPT973Exists(int id)
        {
            return _context.PersonNTPT973.Any(e => e.PersonId == id);
        }
    }
}
