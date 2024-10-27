using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WooxTravel.Context;
using WooxTravel.Entities;

namespace WooxTravel.Areas.Admin.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        // GET: Admin/Profile
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            var username = Session["x"];
            var values = context.Admins.Where(x => x.Username == username).FirstOrDefault();
            return View(values);
        }
     
    }
}