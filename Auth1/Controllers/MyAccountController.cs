using FITNESSGYM.Data;
using FITNESSGYM.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            var client = await _context.Client.FirstOrDefaultAsync(m => m.IdUser == User.Identity.Name);

            return View(client);
        }



        //must be logged in
        [Authorize]
        public async Task<IActionResult> MyInformation() // Show details
        {
            var client = await _context.Client.FirstOrDefaultAsync(m => m.IdUser == User.Identity.Name);

            if (client == null)
            {
                return RedirectToAction("Index", "MyAccount");
            }
            return View(client);
        }


        // POST: MyAccount/SaveMyInformation/{IdClient}
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditMyInformation(int id, [Bind("ID,FirstName,LastName,Sex,Height,Weight,Birthdate,Phonenumber,Adresse,Diseases,Hobbies,Newsletter,Freetrial")] Client client)
        {
            if (id != client.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.ID))
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
            return View(client);
        }

        private bool ClientExists(int id)
        {
            return (_context.Client?.Any(e => e.ID == id)).GetValueOrDefault();
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
            var client = await _context.Client.Include(r => r.Goal).FirstAsync(m => m.IdUser == User.Identity.Name);

            return View(client);
        }

        [Authorize]
        public async Task<IActionResult> MyStatGraph()  //Faire tableau de préférence ?
        {
            var client = await _context.Client.FirstAsync(m => m.IdUser == User.Identity.Name);

            return View(client);
        }



        [Authorize]
        public async Task<IActionResult> MyQuiz1() // Require client information
        {
            IsClientNull();

            return View();

        }


        // POST: MyAccount/MyQuiz1/{IdClient}
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateMyQuiz1([Bind("ID,FirstName,LastName,Sex,Height,Weight,Birthdate,Phonenumber,Adresse,Diseases,Hobbies,Newsletter,Freetrial")] Client client)
        {

            if (ModelState.IsValid)
            {
                client.IdUser = User.Identity.Name;
                _context.Add(client);
                await _context.SaveChangesAsync();
                return RedirectToAction("MyQuiz2", "MyAccount");
            }
            return View(client);
        }



        [Authorize]
        public async Task<IActionResult> MyQuiz2() // Require client goal
        {
            IsClientNull();

            return View();
        }


        // POST: MyAccount/MyQuiz2/{IdClient}
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateMyQuiz2([Bind("Id,Weight,UpdateDate,GoalDate,Frequency,CaloriesBurnt,IdClient")] Goal goal)
        {
            IsClientNull();
            if (ModelState.IsValid)
            {
                var client = _context.Client.FirstOrDefault(m => m.IdUser == User.Identity.Name);
                goal.IdClient = client.ID;
                _context.Add(goal);
                await _context.SaveChangesAsync();
                return RedirectToAction("Welcome", "MyAccount");
            }
            
            return View(goal);
        }




        [Authorize]
        public async Task<IActionResult> Welcome()
        {
            return View();
        }

        
        private bool IsClientNull()
        {
            var client = _context.Client.FirstOrDefault(m => m.IdUser == User.Identity.Name);

            if (client == null)
            {
                return true;
            }
            return false;
        }

        //private async Task<IActionResult> IsClientNull()
        //{
        //    var client = _context.Client.FirstOrDefault(m => m.IdUser == User.Identity.Name);

        //    if (client == null)
        //    {
        //        return RedirectToAction("MyQuiz1", "MyAccount");
        //    }
        //    return View(client);
        //}


    }
}
