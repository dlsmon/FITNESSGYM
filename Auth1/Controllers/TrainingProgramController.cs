using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FITNESSGYM.Data;
using FITNESSGYM.Models;

namespace FITNESSGYM.Controllers
{
    public class TrainingProgramController : Controller
    {
        private readonly FITNESSGYMDBContext _context;

        public TrainingProgramController(FITNESSGYMDBContext context)
        {
            _context = context;
        }

        // GET: TrainingProgram
        public async Task<IActionResult> Index()
        {
              return _context.TrainingProgram != null ? 
                          View(await _context.TrainingProgram.ToListAsync()) :
                          Problem("Entity set 'FITNESSGYMDBContext.TrainingProgram'  is null.");
        }

        // GET: TrainingProgram/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TrainingProgram == null)
            {
                return NotFound();
            }

            var trainingProgram = await _context.TrainingProgram
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainingProgram == null)
            {
                return NotFound();
            }

            return View(trainingProgram);
        }

        // GET: TrainingProgram/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TrainingProgram/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Intensity,Duration,Calories")] TrainingProgram trainingProgram)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trainingProgram);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trainingProgram);
        }

        // GET: TrainingProgram/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TrainingProgram == null)
            {
                return NotFound();
            }

            var trainingProgram = await _context.TrainingProgram.FindAsync(id);
            if (trainingProgram == null)
            {
                return NotFound();
            }
            return View(trainingProgram);
        }

        // POST: TrainingProgram/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Intensity,Duration,Calories")] TrainingProgram trainingProgram)
        {
            if (id != trainingProgram.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trainingProgram);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainingProgramExists(trainingProgram.Id))
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
            return View(trainingProgram);
        }

        // GET: TrainingProgram/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TrainingProgram == null)
            {
                return NotFound();
            }

            var trainingProgram = await _context.TrainingProgram
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainingProgram == null)
            {
                return NotFound();
            }

            return View(trainingProgram);
        }

        // POST: TrainingProgram/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TrainingProgram == null)
            {
                return Problem("Entity set 'FITNESSGYMDBContext.TrainingProgram'  is null.");
            }
            var trainingProgram = await _context.TrainingProgram.FindAsync(id);
            if (trainingProgram != null)
            {
                _context.TrainingProgram.Remove(trainingProgram);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Sessions(int id, string searchString)
        {
            if (_context.TrainingProgram.Find(id) == null)
            {
                string name = _context.TrainingProgram.Find(id).Name;
                if (_context.TrainingProgram.Find(id).Sessions == null)
                {
                    return Problem("No Sessions available for the " + name + " Training Program found.");
                }
            }

            ViewBag.TrainingProgram = _context.TrainingProgram.Find(id);

            var sessions = from m in _context.Session.Where(s => s.IdTrainingProgram == id)
                           select m;

            /*if (!String.IsNullOrEmpty(searchString))
            {
                sessions = sessions.Where(s => s.!.Contains(searchString));
            }*/

            return View(await sessions.ToListAsync());
        }
        private bool TrainingProgramExists(int id)
        {
          return (_context.TrainingProgram?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
