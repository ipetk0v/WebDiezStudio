using RealEstateWebSite.Data.Helpers;
using RealEstateWebSite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RealEstateWebSite.Data.Models
{
    public class Estate
    {
        public string Id { get; set; }

        public string References { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(200)]
        public string Adress { get; set; }

        public double SquareMeter { get; set; }

        public decimal PricePerSQM { get; set; }

        [Required]
        public double Lat { get; set; }

        [Required]
        public double Long { get; set; }

        public string PicUrl { get; set; }

        [Required]
        public RentOrSaleEnum RentOrSale { get; set; }

        [Required]
        public TypePropertyEnum TypeProperty { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public int CounterVisible { get; set; }

        [Required]
        public DateTime DateOfPublication { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public string BrokerId { get; set; }

        public Broker Broker { get; set; }

        public List<AgencyEstate> AgencyEstate { get; set; } = new List<AgencyEstate>();
    }
}
