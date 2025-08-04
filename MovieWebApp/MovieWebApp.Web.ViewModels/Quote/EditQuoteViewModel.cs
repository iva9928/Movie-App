using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Web.ViewModels.Quote
{
    public class EditQuoteViewModel
    {
        [Required]
        public string Id { get; set; } = string.Empty;

        [Required(ErrorMessage = "Quote is required.")]
        [StringLength(1000, ErrorMessage = "Quote cannot exceed {1} characters.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Character name is required.")]
        [StringLength(200, ErrorMessage = "Character name cannot exceed {1} characters.")]
        public string CharacterName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Movie/TV Show is required.")]
        [StringLength(300, ErrorMessage = "Movie/TV Show name cannot exceed {1} characters.")]
        public string MovieOrShow { get; set; } = string.Empty;

        [Required]
        [Url(ErrorMessage = "Invalid URL format.")]
        public string CharacterImageUrl { get; set; } = null!;

    }
}
