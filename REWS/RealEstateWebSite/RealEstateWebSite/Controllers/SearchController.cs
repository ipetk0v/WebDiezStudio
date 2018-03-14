using GoogleMaps.LocationServices;
using GuigleAPI;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebSite.Models.SearchViewModels;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Web;

namespace RealEstateWebSite.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SearchViewModel model)
        {   
            var address = model.Location;            
            var result = await GoogleGeocodingAPI.GetCoordinatesFromAddressAsync("Sofia");

            var LatLeng = new Dictionary<string, string>();
            var latitude = result.Item1.ToString();
            var longitude = result.Item2.ToString();
            LatLeng[latitude] = longitude;

            return RedirectToAction("Index", "Home", LatLeng);
        }        
    }
}
