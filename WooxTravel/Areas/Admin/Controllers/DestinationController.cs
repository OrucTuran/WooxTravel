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
    public class DestinationController : Controller
    {
        // GET: Admin/Destination
        readonly TravelContext context = new TravelContext();
        public ActionResult DestinationList()
        {
            var values = context.Destinations.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateDestination()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateDestination(Destination destination)
        {
            context.Destinations.Add(destination);
            context.SaveChanges();
            return RedirectToAction(nameof(DestinationList));
        }
        public ActionResult DeleteDestination(int id)
        {
            var values = context.Destinations.Find(id);
            context.Destinations.Remove(values);
            context.SaveChanges();
            return RedirectToAction(nameof(DestinationList));
        }
        [HttpGet]
        public ActionResult UpdateDestination(int id)
        {
            var values = context.Destinations.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateDestination(Destination destination)
        {
            var value = context.Destinations.Find(destination.DestinationID);
            value.Description = destination.Description;
            value.City = destination.City;
            value.DayNight = destination.DayNight;
            value.Country = destination.Country;
            value.ImageURL = destination.ImageURL;
            value.Price = destination.Price;
            value.Title = destination.Title;
            context.SaveChanges();
            return RedirectToAction(nameof(DestinationList));
        }
    }
}