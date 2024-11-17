using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WooxTravel.Context;
using WooxTravel.Entities;
using PagedList;
using PagedList.Mvc;

namespace WooxTravel.Areas.Admin.Controllers
{
    public class ReservationController : Controller
    {
        // GET: Admin/Reservation
        readonly TravelContext context = new TravelContext();

        public ActionResult ReservationList(int page = 1)
        {
            var values = context.Rezervations.ToList().ToPagedList(page, 5);
            ViewBag.pageNum = page;
            return View(values);
        }
        public ActionResult DeleteReservation(int id)
        {
            var value = context.Rezervations.Find(id);
            context.Rezervations.Remove(value);
            context.SaveChanges();
            return RedirectToAction(nameof(ReservationList));
        }
        [HttpGet]
        public ActionResult UpdateReservation(int id)
        {
            var value = context.Rezervations.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateReservation(Rezervation rezervation)
        {
            var value = context.Rezervations.Find(rezervation.RezervationID);
            if (value != null)
            {
                value.Name = rezervation.Name;
                value.Email = rezervation.Email;
                value.Phone = rezervation.Phone;
                value.PersonCount = rezervation.PersonCount;
                value.RezervationDate = rezervation.RezervationDate;
                value.Description = rezervation.Description;
                context.SaveChanges();
            }
            return RedirectToAction(nameof(ReservationList));
        }
    }
}