using Gym_Membership.Models;
using Gym_Membership.Models.Context;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gym_Membership.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            var ctx = new GymMembershipContext();
            var view = ctx.Uyeler.ToList();
            return View(view);
        }

    }
}
