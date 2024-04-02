﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();


        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}