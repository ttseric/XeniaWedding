using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeniaWedding.Core
{
    public class WeddingEvent
    {
        private int _weddingEventId;
        private string _name;
        private List<Guest> _guests = new List<Guest>(); 

        public int WeddingEventId
        {
            get { return _weddingEventId; }
            set { _weddingEventId = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<Guest> Guests
        {
            get { return _guests; }
            set { _guests = value; }
        }

        public int Accepted
        {
            get { return Guests.Count(x => x.RSVP == "accepted"); }
        }

        public int NoAnswer
        {
            get { return Guests.Count(x=>x.RSVP == "no answer"); }
        }

        public int Declined
        {
            get { return Guests.Count(x => x.RSVP == "declined"); }
        }
    }
}
