using PongKey.Models.Welcome.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PongKey.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        public ActionResult Index()
        {
            WelcomeViewModel model = new WelcomeViewModel();
            //Get Events
            return View();
        }
         
        [HttpPost]
        public ActionResult Index(WelcomeViewModel model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}