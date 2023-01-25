using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FITNESSGYM.Data;
using FITNESSGYM.Models;
using Microsoft.AspNetCore.Authorization;

namespace FITNESSGYM.Controllers
{
    public class SubscriptionController : Controller
    {
        private readonly FITNESSGYMDBContext _context;

        public SubscriptionController(FITNESSGYMDBContext context)
        {
            _context = context;
        }

        // GET: Subscription
        public async Task<IActionResult> Index()
        {
            var fITNESSGYMDBContext = _context.Subscription.Include(s => s.Client).Include(s => s.Formula);
            return View(await fITNESSGYMDBContext.ToListAsync());
        }

        // GET: Subscription/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Subscription == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscription
                .Include(s => s.Client)
                .Include(s => s.Formula)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscription == null)
            {
                return NotFound();
            }

            return View(subscription);
        }

        // GET: Subscription/Create
        public IActionResult Create()
        {
            ViewData["ClientEmail"] = new SelectList(_context.Client, "ID", "IdUser").OrderBy(s => s.Value);
            ViewData["IdFormula"] = new SelectList(_context.Formula, "ID", "Name").OrderBy(s => s.Value); ;
            return View();
        }

        // POST: Subscription/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("Id,Entrydate,Sortdate,Price,Discount,IdClient,IdFormula")] Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                //int price = subscription.Formula.Price;
                //int? discountS = subscription.Discount;
                
                _context.Add(subscription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdClient"] = new SelectList(_context.Client, "ID", "ID", subscription.IdClient);
            ViewData["IdFormula"] = new SelectList(_context.Formula, "ID", "Name", subscription.IdFormula);
            return View(subscription);
        }

        // GET: Subscription/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Subscription == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscription.FindAsync(id);
            if (subscription == null)
            {
                return NotFound();
            }
            ViewData["IdClient"] = new SelectList(_context.Client, "ID", "ID", subscription.IdClient);
            ViewData["IdFormula"] = new SelectList(_context.Formula, "ID", "Name", subscription.IdFormula);
            return View(subscription);
        }

        // POST: Subscription/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Entrydate,Sortdate,Price,Discount,IdClient,IdFormula")] Subscription subscription)
        {
            if (id != subscription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subscription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubscriptionExists(subscription.Id))
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
            ViewData["IdClient"] = new SelectList(_context.Client, "ID", "ID", subscription.IdClient);
            ViewData["IdFormula"] = new SelectList(_context.Formula, "ID", "Name", subscription.IdFormula);
            return View(subscription);
        }

        // GET: Subscription/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Subscription == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscription
                .Include(s => s.Client)
                .Include(s => s.Formula)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscription == null)
            {
                return NotFound();
            }

            return View(subscription);
        }

        // POST: Subscription/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Subscription == null)
            {
                return Problem("Entity set 'FITNESSGYMDBContext.Subscription'  is null.");
            }
            var subscription = await _context.Subscription.FindAsync(id);
            if (subscription != null)
            {
                _context.Subscription.Remove(subscription);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubscriptionExists(int id)
        {
          return (_context.Subscription?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
