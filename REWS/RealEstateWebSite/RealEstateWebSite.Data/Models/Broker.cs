using RealEstateWebSite.Models;
using System.Collections.Generic;

namespace RealEstateWebSite.Data.Models
{
    public class Broker : User
    {
        public string PictureUrl { get; set; }

        public string AgencyId { get; set; }

        public Agency Agency { get; set; }
        
    }
}
