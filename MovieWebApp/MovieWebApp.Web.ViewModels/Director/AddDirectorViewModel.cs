using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Web.ViewModels.Director
{
    public class AddDirectorViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First Name must be between 2 and 50 characters.")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Surname must be between 2 and 50 characters.")]
        public string Surname { get; set; } = string.Empty;

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Famous movies description cannot exceed {1} characters.")]
        public string FamousMovies { get; set; } = string.Empty;


        [Required]
        public string DirectorImageUrl { get; set; } = string.Empty;

        public string? Description { get; set; }
    }
}
