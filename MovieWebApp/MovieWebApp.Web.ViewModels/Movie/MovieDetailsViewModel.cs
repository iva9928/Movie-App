using System.ComponentModel.DataAnnotations;
using static MovieWebApp.Common.EntityValidationConstants.Movie;

namespace MovieWebApp.Web.ViewModels.Movie
{
    public class MovieDetailsViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = 2, ErrorMessage = "Title must be between 2 and {1} characters.")]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(GenreMaxLength, MinimumLength = 2, ErrorMessage = "Genre must be between 2 and {1} characters.")]
        public string Genre { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Range(1, 500, ErrorMessage = "Duration must be between 1 and 500 minutes.")]
        public int Duration { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(CastsMaxLength, MinimumLength = 5, ErrorMessage = "Casts must be between 5 and {1} characters.")]
        public string Casts { get; set; } = null!;

        [Required]
        [StringLength(ProductionMaxLength, MinimumLength = 2, ErrorMessage = "Production must be between 2 and {1} characters.")]
        public string Production { get; set; } = null!;

        [Required]
        [StringLength(CountryMaxLength, MinimumLength = 2, ErrorMessage = "Country must be between 2 and {1} characters.")]
        public string Country { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMovieMaxLength, MinimumLength = 10, ErrorMessage = "Description must be between 10 and {1} characters.")]
        public string Description { get; set; } = null!;
    }
}
