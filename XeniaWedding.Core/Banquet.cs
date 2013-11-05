using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeniaWedding.Core
{
    public class Banquet
    {
        private List<Guest> _guests;
        private List<Helper> _helpers;

        public int BanquetId { get; set; }
        public Rundown Rundown { get; set; }
        public SeatingPlan SeatingPlan { get; set; }
        public Menu Menu { get; set; }
        
        public List<Helper> Helpers
        {
            get { return _helpers ?? (_helpers = new List<Helper>()); }
        }

        public List<Guest> Guests
        {
            get { return _guests ?? (_guests = new List<Guest>());}
        }


    }
}
