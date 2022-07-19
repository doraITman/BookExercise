using BookExercise.Models;
using Microsoft.AspNetCore.Mvc;

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
            Repoitory.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }
        
    }
}
