using System.ComponentModel.DataAnnotations;

namespace RealEstateWebSite.Data.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
