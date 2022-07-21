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
            Repoitory.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }

        [HttpGet]
        public ViewResult ListResponses()
        {
            return View(Repoitory.Responses.Where(r => r.WillAttend == true));
        }
        
    }
}
