using BookExercise.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookExercise.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm([FromBody]GuestResponse guestResponse)
        {
            Repoitory.AddResponse(guestResponse);
            return View("Thanks",guestResponse);
        }
        
    }
}
