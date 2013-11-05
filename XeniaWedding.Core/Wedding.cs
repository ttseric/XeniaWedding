using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeniaWedding.Core
{
    public class Wedding
    {
        public string GroomName { get; set; }
        public string BrideName { get; set; }
        public DateTime WeddingDate { get; set; }
        public Banquet Banquet { get; set; }
    }
}
