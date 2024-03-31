using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Controllers;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        private Context c = new Context();
        public ActionResult Index()
        {
            var values = c.AboutMes.ToList();
            return View(values);
        }
    }
}