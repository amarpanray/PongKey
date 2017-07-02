using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PongKey.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult Index(string Id)
        {
            var ID = Convert.ToInt32(Id);
            return View();
        }

        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }
    }
}