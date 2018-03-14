using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RealEstateWebSite.Data.Models
{
    public class Agency
    {
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        [MaxLength(50)]
        public string Adress { get; set; }

        [Required]
        [MaxLength(50)]
        public string TelNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string Fax { get; set; }

        public double StartWorkTime { get; set; }

        public double EndWorkTime { get; set; }

        public List<Broker> Brokers { get; set; } = new List<Broker>();

        public List<Estate> Estates { get; set; } = new List<Estate>();

        public List<AgencyEstate> AgencyEstate { get; set; } = new List<AgencyEstate>();
    }
}
