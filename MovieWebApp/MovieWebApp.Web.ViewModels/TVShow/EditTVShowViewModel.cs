using System;
using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Web.ViewModels.TVShows
{
    public class EditTVShowViewModel
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
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Casts { get; set; } = null!;

        [Required]
        [StringLength(1000, ErrorMessage = "Production cannot exceed {1} characters.")]
        public string Production { get; set; } = null!;

        [Required]
        [StringLength(200, ErrorMessage = "Country cannot exceed {1} characters.")]
        public string Country { get; set; } = null!;

        [Required]
        [StringLength(20000, ErrorMessage = "Description cannot exceed {1} characters.")]
        public string Description { get; set; } = null!;

        [Required]
        [Url(ErrorMessage = "Invalid URL format.")]
        public string TVSeriesImageUrl { get; set; } = null!;
    }
}
