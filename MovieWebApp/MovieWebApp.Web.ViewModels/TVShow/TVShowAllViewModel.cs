using System.ComponentModel.DataAnnotations;
namespace MovieWebApp.Web.ViewModels.TVShows
{
    public class TVShowAllViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [StringLength(500, MinimumLength = 2, ErrorMessage = "Title must be between 2 and {1} characters.")]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(400, ErrorMessage = "Genre cannot exceed {1} characters.")]
        public string Genre { get; set; } = null!;

        [Required]
        public int Duration { get; set; }

        [Required]
        [Url(ErrorMessage = "Invalid URL format.")]
        public string TVSeriesImageUrl { get; set; } = null!;
    }
}
