using System.ComponentModel.DataAnnotations;
using static MovieWebApp.Common.EntityValidationConstants.Movie;

namespace MovieWebApp.Web.ViewModels.Movie
{
    public class MovieDetailsViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = 2)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMovieMaxLength, MinimumLength = 10)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(GenreMaxLength, MinimumLength = 2)]
        public string Genre { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Range(1, 500)]
        public int Duration { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(CastsMaxLength, MinimumLength = 5)]
        public string Casts { get; set; } = "Not Available"; // Default if missing

        [Required]
        [StringLength(CountryMaxLength, MinimumLength = 2)]
        public string Country { get; set; } = "Not Available"; // Default if missing

        [Required]
        [StringLength(ProductionMaxLength, MinimumLength = 2)]
        public string Production { get; set; } = "Not Available"; // Default if missing
    }
}
