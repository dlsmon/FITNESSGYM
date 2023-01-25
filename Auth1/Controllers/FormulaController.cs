using FITNESSGYM.Data;
using FITNESSGYM.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FITNESSGYM.Controllers
{
  
        public class FormulaController : Controller
        {
            private readonly FITNESSGYMDBContext _context;

            public FormulaController(FITNESSGYMDBContext context)
            {
                _context = context;
            }

        // GET: Formula
        
        public async Task<IActionResult> Index()
            {
                return _context.Formula != null ?
                            View(await _context.Formula.ToListAsync()) :
                            Problem("Entity set 'FITNESSGYMDBContext.Formula'  is null.");
            }

            // GET: Formula/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null || _context.Formula == null)
                {
                    return NotFound();
                }

                var formula = await _context.Formula
                    .FirstOrDefaultAsync(m => m.ID == id);
                if (formula == null)
                {
                    return NotFound();
                }

                return View(formula);
            }

            // GET: Formula/Create
            public IActionResult Create()
            {
                return View();
            }

        // POST: Formula/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         [Authorize(Roles = "Admin")]
         [HttpPost]
         [ValidateAntiForgeryToken]
            
            public async Task<IActionResult> Create([Bind("ID,Name,Description,FormulaRank,Price,Commitement")] Formula formula)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(formula);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(formula);
            }



        [Authorize]
        public async Task<IActionResult> CreateSupscription(int id,[Bind("ID,Name,Description,FormulaRank,Price,Discount,Commitement")] Formula formula)
        {
            if (id == null)
            {
                return NotFound();
            }
            IsClientNull();
            Client client = _context.Client.Include(s => s.Subscriptions).FirstOrDefault(m => m.IdUser == User.Identity.Name);

            if (client.Subscriptions.Count == 0)
            {
                Subscription newsubscription = new Subscription();
                newsubscription.Price = newsubscription.Formula.Price*newsubscription.Discount/100;
                newsubscription.Entrydate = DateTime.Now; 
                newsubscription.Sortdate  = DateTime.Now.AddYears(1);
                newsubscription.IdClient = client.ID;
                newsubscription.IdFormula = id;

                _context.Add(newsubscription);
                await _context.SaveChangesAsync();
                TempData["Message"] = "You have subscribed to Formula "+ newsubscription.Formula.Name;
                return RedirectToAction(nameof(Index));
            }
            TempData["Message"] = "You have already subscribed to the Formula. ";
            return RedirectToAction(nameof(Index));
        }

        // GET: Formula/Edit/5
        public async Task<IActionResult> Edit(int? id)
            {
                if (id == null || _context.Formula == null)
                {
                    return NotFound();
                }

                var formula = await _context.Formula.FindAsync(id);
                if (formula == null)
                {
                    return NotFound();
                }
                return View(formula);
            }

        public async Task<IActionResult> IsClientNull()
        {
            var client = _context.Client.FirstOrDefault(m => m.IdUser == User.Identity.Name);
            if (client == null)
            {
                return RedirectToAction("MyQuiz1", "MyAccount");
            }
            return View(client);
        }

        // POST: Formula/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,FormulaRank,Price,Commitement")] Formula formula)
            {
                if (id != formula.ID)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(formula);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!FormulaExists(formula.ID))
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
                return View(formula);
            }

            // GET: Formula/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null || _context.Formula == null)
                {
                    return NotFound();
                }

                var formula = await _context.Formula
                    .FirstOrDefaultAsync(m => m.ID == id);
                if (formula == null)
                {
                    return NotFound();
                }

                return View(formula);
            }

            // POST: Formula/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                if (_context.Formula == null)
                {
                    return Problem("Entity set 'FITNESSGYMDBContext.Formula'  is null.");
                }
                var formula = await _context.Formula.FindAsync(id);
                if (formula != null)
                {
                    _context.Formula.Remove(formula);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool FormulaExists(int id)
            {
                return (_context.Formula?.Any(e => e.ID == id)).GetValueOrDefault();
            }
        }
    }

