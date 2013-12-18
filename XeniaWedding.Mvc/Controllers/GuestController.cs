using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using XeniaWedding.Core;
using XeniaWedding.Mvc.Models;

namespace XeniaWedding.Mvc.Controllers
{
    public class GuestController : Controller
    {

        private Db _db;

        public GuestController() { }

        public GuestController(Db db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewGuest()
        {
            return View();
        }

        [HttpPost]
        public JsonResult EventList()
        {
            //var result1 = new { eventTitle = "晚宴", invited = 20, accepted = 10, declined = 5 };

            var result1 =
                new
                {
                    eventTitle = _db.WeddingEvents[0].Name,
                    invited = _db.WeddingEvents[0].Guests.Count,
                    accepted = _db.WeddingEvents[0].Guests.Count(x => x.RSVP == "accepted"),
                    declined = _db.WeddingEvents[0].Guests.Count(x => x.RSVP == "declined")
                };

            var result2 = new { eventTitle = "教堂", invited = 20, accepted = 10, declined = 5 };
            var result3 = new { eventTitle = "教堂", invited = 20, accepted = 10, declined = 5 };
            return Json(new[] { result1, result2, result3 }, JsonRequestBehavior.DenyGet);
        }

        [HttpPost]
        public JsonResult Add(string guestJson, int weddingEventId)
        {
            var guestViewModel = JsonConvert.DeserializeObject<GuestViewModel>(guestJson);

            var guest = new Guest();

            try
            {
                guest.Email = guestViewModel.Email;
                guest.GuestGroupId = guestViewModel.GuestGroup.GuestGroupId;
                guest.HeadCount = guestViewModel.HeadCount;
                guest.InviteDate = DateTime.ParseExact(guestViewModel.InviteDate, "dd/MM/yyyy", null);
                guest.Name = guestViewModel.Name;
                guest.Phone = guestViewModel.Phone;
                guest.RSVP = guestViewModel.Rvsp;
                guest.Remark = guestViewModel.Remark;
                guest.Sex = guestViewModel.Sex;
                guest.Table = guestViewModel.Table;

                _db.AddGuest(guest, weddingEventId);

                return Json(new {success = true, message = "Saved successfully."});
            }
            catch (Exception ex)
            {
                return Json(new {success = false, message = ex.Message});
            }
        }
    }
}
