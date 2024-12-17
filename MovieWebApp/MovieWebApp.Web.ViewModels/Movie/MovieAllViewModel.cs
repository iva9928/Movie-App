using System.ComponentModel.DataAnnotations;
using static MovieWebApp.Common.EntityValidationConstants.Movie;

namespace MovieWebApp.Web.ViewModels.Movie
{
    public class MovieAllViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = 2, ErrorMessage = "Title must be between 2 and {1} characters.")]
        public string Title { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Range(1, 500, ErrorMessage = "Duration must be between 1 and 500 minutes.")]
        public int Duration { get; set; }
    }
}
