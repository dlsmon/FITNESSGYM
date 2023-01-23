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
    public class ReservationController : Controller
    {
        private readonly FITNESSGYMDBContext _context;

        public ReservationController(FITNESSGYMDBContext context)
        {
            _context = context;
        }

        // GET: Reservation
        public async Task<IActionResult> Index()
        {
            var reservations = _context.Reservation.Include(r => r.Session).ToListAsync();
            return View(await reservations);
        }

        // GET: Reservation
        public async Task<IActionResult> MyReservations()
        {
            var FITNESSGYMDBContext = _context.Reservation.Include(r => r.Session)
                .Include(r => r.Client)
                .Where(m => m.Client.IdUser == User.Identity.Name);
            return View(await FITNESSGYMDBContext.ToListAsync());
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
                    var session = await _context.Session
                                    .FirstOrDefaultAsync(m => m.Id == id);
                    //show all reservations of session.Id that were not cancelled by the user
                    var reservations = await _context.Reservation
                        .Where(m => m.IdSession == id)
                        .Where(m => m.Cancelled == Reservation.eCancelled.No)
                        .ToListAsync();
                    var client = await _context.Client.FirstOrDefaultAsync(m => m.IdUser == User.Identity.Name);

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
                    if (!ReservationExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(MyReservations));
            }
            return View(id);
        }



        // POST: 
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CancelReservation(int id)
        {
            if (id == null || _context.Reservation == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            { 
                try
                {
                    var reservation = await _context.Reservation
                                    .FirstOrDefaultAsync(m => m.Id == id);
                    if (reservation != null)
                    {
                        if (reservation.Cancelled == Reservation.eCancelled.No)
                        {
                            reservation.Cancelled = Reservation.eCancelled.Yes;
                            _context.Update(reservation);
                            await _context.SaveChangesAsync();
                        }
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("MyReservations");
            }
            return View(id);
        }

        private bool ReservationExists(int id)
        {
          return (_context.Reservation?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
