using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WooxTravel.Context;
using WooxTravel.Entities;

namespace WooxTravel.Areas.Admin.Controllers
{
    public class ChartsController : Controller
    {
        // GET: Admin/ChartsController
        TravelContext context = new TravelContext();
        public ActionResult LineChart()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
        public ActionResult BarChart()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
        public ActionResult MultiLineChart()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
        public ActionResult MultiBarChart()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
        public ActionResult DonutChart()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
    }
}
