using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WooxTravel.Context;
using WooxTravel.Entities;

namespace WooxTravel.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialBanner()
        {
            return PartialView();
        }
        public PartialViewResult PartialCountry()
        {
            var values = context.Destinations.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
    }
}