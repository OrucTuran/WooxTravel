using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WooxTravel.Entities;
using WooxTravel.Context;

namespace WooxTravel.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: Admin/AdminLayout
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
        
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialSidebar()//navbar
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()//sidebar
        {
            var username = Session["x"]; //kullanıcı adı alındı
            var email = context.Admins.Where(x => x.Username == username).Select(y => y.Email).FirstOrDefault();//kullanıcı adının e maili laındı
            var values = context.Messages.Where(x => x.ReceiverMail == email).ToList(); //e maile gelen mesajları aldık
            return PartialView(values);
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialDestinationNavbar()
        {
            var last4Destination = context.Destinations.OrderByDescending(d => d.DestinationID).Take(4).ToList();

            return PartialView(last4Destination);
        }
        public PartialViewResult PartialAdminNavbar()
        {
            var username = Session["x"]; //kullanıcı adı alındı
            var admin = context.Admins.Where(x => x.Username == username).FirstOrDefault();
            return PartialView(admin);
        }
    }
}