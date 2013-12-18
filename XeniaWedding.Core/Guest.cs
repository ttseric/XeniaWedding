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
        public int GuestGroupId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public string RSVP { get; set; }
        public string Phone { get; set; }
        public string Table { get; set; }
        public int HeadCount { get; set; }
        public DateTime? InviteDate { get; set; }
        public string Remark { get; set; }
    }

}