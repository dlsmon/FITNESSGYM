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
            var FITNESSGYMDBContext = _context.Reservation.Include(r => r.Session).Include(r => r.Client).Where(m => m.Client.IdUser == User.Identity.Name);
            return View(await FITNESSGYMDBContext.ToListAsync());
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
                return RedirectToAction(nameof(Index));
            }
            return View(id);
        }

        private bool ReservationExists(int id)
        {
          return (_context.Reservation?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
