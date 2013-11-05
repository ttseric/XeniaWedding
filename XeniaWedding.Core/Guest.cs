using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeniaWedding.Core
{
    public class Guest
    {
        public int GuestId { get; set; }
        public string GuestGroup { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public bool? RSVP { get; set; }
        public string Remark { get; set; }
    }

}