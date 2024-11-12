using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WooxTravel.Entities;
using WooxTravel.Context;

namespace WooxTravel.Areas.Admin.Controllers
{
    public class WidgetController : Controller
    {
        // GET: Admin/Widget
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            ViewBag.adminSayisi = context.Admins.Count();
            ViewBag.kategoriSayisi = context.Categories.Count();
            ViewBag.destinasyonSayisi = context.Destinations.Count();
            ViewBag.kirkbinUcuzDest = context.Destinations.Where(x => x.Price <= 40000).Count();
            ViewBag.kapasiteOtuzYuksekDest = context.Destinations.Where(x => x.Capacity >= 30).Count();
            ViewBag.mesajSayisi = context.Messages.Count();
            ViewBag.konuTesekkurMesajSay = context.Messages.Where(m => m.Subject == "Teşekkür").Count();
            ViewBag.rezSayisi = context.Rezervations.Count();
            ViewBag.kisiKiRezSay = context.Rezervations.Where(x => x.PersonCount == 2).Count();
            ViewBag.konuOneriMesajSay = context.Messages.Where(m => m.Subject == "Öneri").Count();
            ViewBag.sehirAlmanyaTurSay = context.Destinations.Where(m => m.Country == "Almanya").Count();
            ViewBag.kisiDortYuksekRezSay = context.Rezervations.Where(m => m.PersonCount > 4).Count();
            return View();

        }
    }
}