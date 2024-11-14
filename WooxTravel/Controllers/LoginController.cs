using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WooxTravel.Entities;
using WooxTravel.Context;
using System.Web.Security;

namespace WooxTravel.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var values = context.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            TempData["Success"] = true;

            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Username, false);
                Session["x"] = values.Username;
                return RedirectToAction("Index", "Profile", new { area = "Admin" });
            }
            else
            {
                TempData["Error"] = "Kullanıcı adı veya şifre yanlış."; // Hata mesajını ayarlayın
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut(); // AuthCookie'yi sil
            Session.Clear(); // Tüm oturum verilerini temizle
            return RedirectToAction("Index", "Login"); // Giriş sayfasına yönlendir
        }
    }
}