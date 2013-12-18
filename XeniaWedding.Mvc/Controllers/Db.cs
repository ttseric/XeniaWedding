using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Providers.Entities;
using XeniaWedding.Core;

namespace XeniaWedding.Mvc.Controllers
{
    public class Db
    {
        List<WeddingEvent> _weddingEvents = new List<WeddingEvent>();

        public Db()
        {
            var banquetEvent = new WeddingEvent();
            banquetEvent.Name = "晚宴";
            banquetEvent.WeddingEventId = 1;

            _weddingEvents.Add(banquetEvent);
        }

        public void AddGuest(Guest guest, int weddingEventId)
        {
            var weddingEvent = _weddingEvents.First(x => x.WeddingEventId == weddingEventId);

            weddingEvent.Guests.Add(guest);
        }

        public List<WeddingEvent> WeddingEvents
        {
            get { return _weddingEvents; }
        }

    }
}