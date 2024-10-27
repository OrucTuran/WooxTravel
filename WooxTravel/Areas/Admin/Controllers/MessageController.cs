using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WooxTravel.Entities;
using WooxTravel.Context;

namespace WooxTravel.Areas.Admin.Controllers
{
    public class MessageController : Controller
    {
        // GET: Admin/Message
        TravelContext context = new TravelContext();
        public ActionResult Inbox()
        {
            var username = Session["x"]; //kullanıcı adı alındı
            var email = context.Admins.Where(x => x.Username == username).Select(y => y.Email).FirstOrDefault();//kullanıcı adının e maili laındı
            var values = context.Messages.Where(x => x.ReceiverMail == email).ToList(); //e maile gelen mesajları aldık
            return View(values);
        }
        public ActionResult SendBox()
        {
            var username = Session["x"]; //kullanıcı adı alındı
            var email = context.Admins.Where(x => x.Username == username).Select(y => y.Email).FirstOrDefault();//kullanıcı adının e maili laındı
            var values = context.Messages.Where(x => x.SendMail == email).ToList(); //e maile gelen mesajları aldık
            return View(values);
        }
        public ActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(Message message)
        {
            var username = Session["x"]; //kullanıcı adı alındı
            var email = context.Admins.Where(x => x.Username == username).Select(y => y.Email).FirstOrDefault();
            message.SendMail = email;
            message.SendDate = DateTime.Today;
            message.IsRead = false;
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction(nameof(SendBox));
        }
    }
}