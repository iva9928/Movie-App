using System;
using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Web.ViewModels.Movie
{
    public class AddMovieViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Title must be between 1 and 100 characters.")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Description must be between 10 and 500 characters.")]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Genre { get; set; } = string.Empty;

        [Required]
        public int Duration { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(300, ErrorMessage = "Casts list must not exceed 300 characters.")]
        public string Casts { get; set; } = string.Empty;

        [Required]
        [StringLength(100, ErrorMessage = "Country name must not exceed 100 characters.")]
        public string Country { get; set; } = string.Empty;

        [Required]
        [StringLength(200, ErrorMessage = "Production details must not exceed 200 characters.")]
        public string Production { get; set; } = string.Empty;

        [Required]
        [Url(ErrorMessage = "Invalid URL format.")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
