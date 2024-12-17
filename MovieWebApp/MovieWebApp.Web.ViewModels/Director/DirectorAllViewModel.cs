using System.ComponentModel.DataAnnotations;
using static MovieWebApp.Common.EntityValidationConstants.Director;

namespace MovieWebApp.Web.ViewModels.Director
{
    public class DirectorAllViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = 2, ErrorMessage = "First name must be between 2 and {1} characters.")]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = 2, ErrorMessage = "Surname must be between 2 and {1} characters.")]
        public string Surname { get; set; } = null!;

        [Required]
        [Url(ErrorMessage = "Invalid URL format.")]
        public string DirectorImageUrl { get; set; } = null!;
    }
}
