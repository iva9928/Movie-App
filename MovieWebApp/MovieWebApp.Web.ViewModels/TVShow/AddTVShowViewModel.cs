using System;
using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Web.ViewModels.TVShows
{
    public class AddTVShowViewModel
    {
        [Required(ErrorMessage = "Title is required.")]
        [StringLength(500, MinimumLength = 2, ErrorMessage = "Title must be between 2 and {1} characters.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Genre is required.")]
        [StringLength(400, ErrorMessage = "Genre cannot exceed {1} characters.")]
        public string Genre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Release Date is required.")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Casts are required.")]
        public string Casts { get; set; } = string.Empty;

        [Required(ErrorMessage = "Duration is required.")]
        [Range(1, 500, ErrorMessage = "Duration must be between {1} and {2} minutes.")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = "Production is required.")]
        public string Production { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(20000, ErrorMessage = "Description cannot exceed {1} characters.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "TV Series Image URL is required.")]
        [Url(ErrorMessage = "Invalid URL format.")]
        public string TVSeriesImageUrl { get; set; } = string.Empty;
    }
}
