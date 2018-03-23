using GuigleAPI;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebSite.Models.SearchViewModels;
using System.Threading.Tasks;

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
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            GoogleGeocodingAPI.GoogleAPIKey = "AIzaSyCGsNbs9jtuhItVf8d26SejNlAgfpRF-Oo";
            var result = await GoogleGeocodingAPI.GetCoordinatesFromAddressAsync(model.Location);
            var latitude = result.Item1;
            var longitude = result.Item2;

            return RedirectToAction("Index", "Home",new { latitude, longitude });
        }        
    }
}
