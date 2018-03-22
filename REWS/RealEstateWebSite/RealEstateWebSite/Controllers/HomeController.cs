using Microsoft.AspNetCore.Mvc;
using RealEstateWebSite.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace RealEstateWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string latitude, string longitude)
        {
            ViewBag.Lat = latitude;
            ViewBag.Long = longitude;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
