using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyTermProject.Models;

namespace MyTermProject.Controllers
{
    public class MembershipController : Controller
    {
        private readonly CatalogContext _context;

        public MembershipController(CatalogContext context)
        {
            _context = context;
        }

        // GET: Membership
        public async Task<IActionResult> Index()
        {
              return _context.Memberships != null ? 
                          View(await _context.Memberships.ToListAsync()) :
                          Problem("Entity set 'CatalogContext.Memberships'  is null.");
        }

        // GET: Membership/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Memberships == null)
            {
                return NotFound();
            }

            var membership = await _context.Memberships
                .FirstOrDefaultAsync(m => m.ID == id);
            if (membership == null)
            {
                return NotFound();
            }

            return View(membership);
        }

        // GET: Membership/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Membership/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Address,City,State,PostalCode,Country,Email,Username,Password,ConfirmPassword")] Membership membership)
        {
            if (ModelState.IsValid)
            {
                _context.Add(membership);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(membership);
        }

        // GET: Membership/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Memberships == null)
            {
                return NotFound();
            }

            var membership = await _context.Memberships.FindAsync(id);
            if (membership == null)
            {
                return NotFound();
            }
            return View(membership);
        }

        // POST: Membership/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,Address,City,State,PostalCode,Country,Email,Username,Password,ConfirmPassword")] Membership membership)
        {
            if (id != membership.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(membership);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MembershipExists(membership.ID))
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
            return View(membership);
        }

        // GET: Membership/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Memberships == null)
            {
                return NotFound();
            }

            var membership = await _context.Memberships
                .FirstOrDefaultAsync(m => m.ID == id);
            if (membership == null)
            {
                return NotFound();
            }

            return View(membership);
        }

        // POST: Membership/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Memberships == null)
            {
                return Problem("Entity set 'CatalogContext.Memberships'  is null.");
            }
            var membership = await _context.Memberships.FindAsync(id);
            if (membership != null)
            {
                _context.Memberships.Remove(membership);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MembershipExists(int id)
        {
          return (_context.Memberships?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
