using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XeniaWedding.Mvc.Models
{
    public class GuestViewModel
    {
        public int GuestId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Phone { get; set; }
        public string Rvsp { get; set; }
        public string Table { get; set; }
        public int HeadCount { get; set; }
        public string InviteDate { get; set; }
        public GuestGroupViewModel GuestGroup { get; set; }
        public string Remark { get; set; }
    }
}