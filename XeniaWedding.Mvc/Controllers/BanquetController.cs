using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XeniaWedding.Mvc.Controllers
{
    public class BanquetController : Controller
    {
        //
        // GET: /Banquet/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GuestList()
        {
            return View();
        }
    }
}
