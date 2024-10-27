using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WooxTravel.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: Admin/AdminLayout
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
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}