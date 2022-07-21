using BookExercise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BookExercise.Controllers
{
    [Route("/[action]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm([FromForm] GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repoitory.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
            
        }

        [HttpGet]
        public ViewResult ListResponses()
        {
            return View(Repoitory.Responses.Where(r => r.WillAttend == true));
        }
        
    }
}
