using GoogleMaps.LocationServices;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebSite.Models.SearchViewModels;
using System.Collections.Generic;
using System.Threading;

namespace RealEstateWebSite.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SearchViewModel model)
        {   
            var address = model.Location;
            if(address == null)
            {
                address = "Sofia";
            }

            var locationService = new GoogleLocationService();
            var point = locationService.GetLatLongFromAddress(address);

            var LatLeng = new Dictionary<string, string>();
            var latitude = point.Latitude.ToString();
            var longitude = point.Longitude.ToString();
            LatLeng[latitude] = longitude;

            return RedirectToAction("Index", "Home", LatLeng);
        }        
    }
}
