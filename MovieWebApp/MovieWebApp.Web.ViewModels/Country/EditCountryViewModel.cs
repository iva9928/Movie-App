using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Web.ViewModels.Country
{
    public class EditCountryViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required, StringLength(50, MinimumLength = 2)]
        public string Name { get; set; } = null!;

        [Required, StringLength(500, MinimumLength = 10)]
        public string Description { get; set; } = null!;

        [Required, Url]
        public string CountryImageUrl { get; set; } = null!;
    }
}