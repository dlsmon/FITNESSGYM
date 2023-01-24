using FITNESSGYM.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

using System.Data;
using FITNESSGYM.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FITNESSGYM.Controllers
{
    public class CoachController : Controller
    {
        private readonly FITNESSGYMDBContext _context;
        private readonly IHostingEnvironment environment;


     
    
        public CoachController(FITNESSGYMDBContext _context, IHostingEnvironment environment)
        {   this._context = _context;
            this.environment = environment;
        } 
        private bool CoachExists(int id)
        {
            return (_context.Coach?.Any(e => e.ID == id)).GetValueOrDefault();
        }
        string UploadFile(IFormFile file, string urlImage)
        {
            try
            {
              if (file != null)
                { 
                    string uploads = Path.Combine(environment.WebRootPath, "Assets\\Images\\Coach\\");
                    string newPath = Path.Combine(uploads, file.FileName);
                    if (!string.IsNullOrEmpty(urlImage))
                    {
                        string oldPath = Path.Combine(uploads, urlImage);
                        if (oldPath != newPath)
                        {
                            System.IO.File.Delete(oldPath);
                            file.CopyTo(new FileStream(newPath, FileMode.Create));
                        }
                    }
                    else
                    {
                        file.CopyTo(new FileStream(newPath, FileMode.Create));
                    }

                    return file.FileName;
                }

                return urlImage;
            }
            catch (Exception)
            {
            throw;
            }
         }

        public IActionResult Create()
        { 
            ViewData["IdSpeciality"] = new SelectList(_context.Speciality, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,IdSpeciality,Photo,File")] Coach coach)
        {
            if (ModelState.IsValid)
            { 
                string fileName = UploadFile(coach.File, coach.Photo);
                coach.Photo = fileName != null ? "Assets\\Images\\Coach\\" + fileName : string.Empty;
                _context.Add(coach);
                await _context.SaveChangesAsync();
                ViewData["IdSpeciality"] = new SelectList(_context.Speciality, "Id", "Name");
                return RedirectToAction(nameof(Index));
            }
            return View(coach);
        }
        public IActionResult Index()
        {
            var data = _context.Coach.Include(t => t.Speciality).ToList();
            return View(data);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Coach == null)
            {
                return NotFound();
            }

            var coach = await _context.Coach.FirstOrDefaultAsync(m => m.ID == id);

            if (coach == null)
            {
                return NotFound();
            }
            ViewData["IdSpeciality"] = new SelectList(_context.Set<Speciality>(), "Id", "Name", coach.IdSpeciality);
            return View(coach);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,IdSpeciality,Photo,File")] Coach coach)
        {
          if (id != coach.ID)
            {
              return NotFound();
            }
             if (ModelState.IsValid)
             {
                try
                {   
                    string fileName = string.Empty;
                    if (coach.File != null)
                        fileName = UploadFile(coach.File, coach.Photo);
                    coach.Photo = !string.IsNullOrEmpty(fileName) ? fileName : coach.Photo;
                    coach.Photo = fileName != null ? "Assets\\Images\\Coach\\" + fileName : string.Empty;
                    _context.Update(coach);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoachExists(coach.ID))
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
            ViewData["IdSpeciality"] = new SelectList(_context.Set<Speciality>(), "Id", "Name", coach.IdSpeciality);

            return View(coach);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Coach == null)
            {
                return NotFound();
            }

            var coach = await _context.Coach
                .Include(c => c.Speciality)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (coach == null)
            {
                return NotFound();
            }

            return View(coach);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Coach == null)
            {
                return Problem("Entity set 'FITNESSGYMDBContext.Coach'  is null.");
            }
            var coach = await _context.Coach.FindAsync(id);
            if (coach != null)
            {
                _context.Coach.Remove(coach);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Coach == null)
            {
                return NotFound();
            }

            var coach = await _context.Coach
                .Include(c => c.Speciality)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (coach == null)
            {
                return NotFound();
            }

            return View(coach);
        }
    }
}
