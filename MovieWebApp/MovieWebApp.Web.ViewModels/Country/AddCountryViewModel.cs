using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Web.ViewModels.Country
{
    public class AddCountryViewModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Country name cannot exceed 50 characters.")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters.")]
        public string Description { get; set; } = null!;

        [Required]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        public string CountryImageUrl { get; set; } = null!;
    }
}
