using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WooxTravel.Entities;
using WooxTravel.Context;

namespace WooxTravel.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            context.Admins.Add(admin);
            context.SaveChanges();
            TempData["Success"] = true;
            return RedirectToAction("Index", "Register");
        }
    }
}