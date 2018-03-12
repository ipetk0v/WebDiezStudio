﻿using RealEstateWebSite.Data.Helpers;

namespace RealEstateWebSite.Models.SearchViewModels
{
    public class SearchViewModel
    {
        public RentOrSaleEnum RentOrSale { get; set; }

        public TypePropertyEnum TypeProparty { get; set; }

        public string Location { get; set; }
    }
}
