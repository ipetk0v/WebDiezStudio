using Microsoft.AspNetCore.Identity;
using RealEstateWebSite.Data.Models;
using System.Collections.Generic;

namespace RealEstateWebSite.Models
{
    public class User : IdentityUser
    {
        public List<Estate> Estaties { get; set; } = new List<Estate>();
    }
}
