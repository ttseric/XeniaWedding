using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeniaWedding.Core
{
    public class SeatTable
    {
        private List<Guest> _guests;

        public int Capacity { get; set; }

        public string Name { get; set; }

        public int TableNumber { get; set; }

        public string Remark { get; set; }

        public List<Guest> Guests
        {
            get { return _guests ?? (_guests = new List<Guest>()); }
        }


    }
}
