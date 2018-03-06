using System.ComponentModel.DataAnnotations;

namespace RealEstateWebSite.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
