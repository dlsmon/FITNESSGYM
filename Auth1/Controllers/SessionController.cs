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
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using SendGrid.Helpers.Mail;
using NuGet.Protocol;
using Microsoft.IdentityModel.Tokens;

namespace FITNESSGYM.Controllers
{
    public class SessionController : Controller
    {
        private readonly FITNESSGYMDBContext _context;
        

        public SessionController(FITNESSGYMDBContext context)
        {
            _context = context;
        }

        // GET: Session
        public async Task<IActionResult> Index()
        {
              return _context.Session != null ? 
                          View(await _context.Session.ToListAsync()) :
                          Problem("Entity set 'FITNESSGYMDBContext.Session'  is null.");
        }

        // GET: Session/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Session == null)
            {
                return NotFound();
            }

            var session = await _context.Session
                .FirstOrDefaultAsync(m => m.Id == id);
            if (session == null)
            {
                return NotFound();
            }

            return View(session);
        }

        // GET: Session/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Session/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SessionDate,SessionHour,MaxParticipants,FormulaRank,IdCoach,IdLocation")] Session session)
        {
            if (ModelState.IsValid)
            {
                _context.Add(session);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(session);
        }

        // GET: Session/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Session == null)
            {
                return NotFound();
            }

            var session = await _context.Session.FindAsync(id);
            if (session == null)
            {
                return NotFound();
            }
            return View(session);
        }

        // POST: Session/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SessionDate,SessionHour,MaxParticipants,FormulaRank,IdCoach,IdLocation")] Session session)
        {
            if (id != session.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(session);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SessionExists(session.Id))
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
            return View(session);
        }

        // GET: Session/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Session == null)
            {
                return NotFound();
            }

            var session = await _context.Session
                .FirstOrDefaultAsync(m => m.Id == id);
            if (session == null)
            {
                return NotFound();
            }

            return View(session);
        }

        // POST: Session/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Session == null)
            {
                return Problem("Entity set 'FITNESSGYMDBContext.Session'  is null.");
            }
            var session = await _context.Session.FindAsync(id);
            if (session != null)
            {
                _context.Session.Remove(session);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: 
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateReservation(int id)
        {
            if (id == null || _context.Session == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Session session = await _context.Session
                                    .FirstOrDefaultAsync(m => m.Id == id);
                    //show all reservations of session.Id that were not cancelled by the user
                    var reservations = await _context.Reservation
                        .Where(m => m.IdSession == id)
                        .Where(m => m.Cancelled == Reservation.eCancelled.No)
                        .ToListAsync();
                    Client client = await _context.Client.FirstOrDefaultAsync(m => m.IdUser == User.Identity.Name);
                        
                    if (session != null)
                    {
                        //Check if Session will start in more than 30 minutes from now
                        if (session.SessionDate > DateTime.Now.AddMinutes(-30))
                        {
                            //Check if there is space to create a reservation on the training program session
                            if (reservations.Count() < session.MaxParticipants)
                            {
                                //Check if the user already reserved and not cancelled
                                //if (!reservations.Any(e => e.IdUser == User.Identity.Name))
                                if (!reservations.Any(e => e.IdClient == client.ID))
                                {
                                    //User can create a resevation 
                                    //FormulaRanking not added yet
                                    Reservation newReservation = new Reservation(session.Id, client.ID);
                                    _context.Add(newReservation);
                                    await _context.SaveChangesAsync();
                                }
                            }
                        }
                    }
                    
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SessionExists(id))
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
            return View(id);
        }

        private bool SessionExists(int id)
        {
          return (_context.Session?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
