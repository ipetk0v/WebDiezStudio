using RealEstateWebSite.Data.Helpers;
using System.ComponentModel.DataAnnotations;

namespace RealEstateWebSite.Models.SearchViewModels
{
    public class SearchViewModel
    {
        public RentOrSaleEnum RentOrSale { get; set; }

        public TypePropertyEnum TypeProparty { get; set; }

        [Required]
        public string Location { get; set; }
    }
}
