namespace RealEstateWebSite.Data.Models
{
    public class AgencyEstate
    {
        public string Id { get; set; }

        public string AgencyId { get; set; }

        public Agency Agency { get; set; }

        public string EstateId { get; set; }

        public Estate Estate { get; set; }
    }
}
