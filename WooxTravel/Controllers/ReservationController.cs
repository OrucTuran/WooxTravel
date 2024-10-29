using System.Web.Mvc;
using WooxTravel.Context;
using WooxTravel.Entities;

namespace WooxTravel.Controllers
{
    public class ReservationController : Controller
    {
        TravelContext context = new TravelContext();

        [HttpPost]
        public ActionResult CreateReservation(Rezervation rezervation)
        {
            if (ModelState.IsValid)
            {
                context.Rezervations.Add(rezervation);
                context.SaveChanges();
                return Json(new { success = true }); // Başarılı ise success true döndür
            }
            else
            {
                return Json(new { success = false });
            }
        }
    }
}
