using FITNESSGYM.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FITNESSGYM.Controllers
{
    public class MyAccountController : Controller
    {
        private readonly FITNESSGYMDBContext _context;

        public MyAccountController(FITNESSGYMDBContext context)
        {
            _context = context;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var client = await _context.Client.FirstAsync(m => m.IdUser == User.Identity.Name);

            return View(client);
        }

        //must be logged in
        [Authorize]
        public async Task<IActionResult> MyInformation() // Show details
        {
            var client = await _context.Client.FirstAsync(m => m.IdUser == User.Identity.Name);
                
            return View(client);
        }

        [Authorize]
        public async Task<IActionResult> ChangePassword()
        {
            var client = await _context.Client.FirstAsync(m => m.IdUser == User.Identity.Name);

            return View(client);
        }

        [Authorize]
        public IActionResult MySubscription()
        {
            return View();
        }

        [Authorize]
        public IActionResult MyReservations()   //MyReservation = my planning
        {
            return View();
        }

        [Authorize]
        public IActionResult MyFavourites()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> MyGoal()
        {
            var client = await _context.Client.FirstAsync(m => m.IdUser == User.Identity.Name);

            return View(client);
        }

        [Authorize]
        public async Task<IActionResult> MyStatGraph()
        {
            var client = await _context.Client.FirstAsync(m => m.IdUser == User.Identity.Name);

            return View(client);
        }
    }
}
