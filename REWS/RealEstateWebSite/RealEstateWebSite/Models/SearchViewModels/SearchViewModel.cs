using RealEstateWebSite.Data.Helpers;

namespace RealEstateWebSite.Models.SearchViewModels
{
    public class SearchViewModel
    {
        public RentOrSaleEnum RentOrSale { get; set; }

        public TypePropartyEnum TypeProparty { get; set; }

        public Geometry Location { get; set; }
    }

    public class Geometry
    {
        public Location Location { get; set; }
    }

    public class Location
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
}
