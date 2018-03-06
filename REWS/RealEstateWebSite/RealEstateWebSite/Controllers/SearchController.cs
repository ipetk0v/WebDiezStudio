using Microsoft.AspNetCore.Mvc;
using RealEstateWebSite.Models.SearchViewModels;
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
            var s = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            var a = model.RentOrSale;
            var b = model.RentOrSale;
            var c = model.Location;

            return RedirectToRoute("/Home/Index");
        }
    }
}
