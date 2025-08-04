using System.ComponentModel.DataAnnotations;
using static MovieWebApp.Common.EntityValidationConstants.Quote;

namespace MovieWebApp.Web.ViewModels.Quote
{
    public class AddQuoteViewModel
    {
        [Required]
        [StringLength(DescriptionQuoteMaxLength, MinimumLength = 5, ErrorMessage = "Description must be between 5 and {1} characters.")]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(CharacterMaxLength, MinimumLength = 2, ErrorMessage = "Character name must be between 2 and {1} characters.")]
        public string CharacterName { get; set; } = null!;

        [Required]
        public string MovieOrShow { get; set; } = null!;

        [Required]
        [Url(ErrorMessage = "Invalid URL format.")]
        public string CharacterImageUrl { get; set; } = null!;
    }
}
