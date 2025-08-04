using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Web.ViewModels.Actor
{
    public class AddActorViewModel
    {
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Surname is required.")]
        [StringLength(50, ErrorMessage = "Surname cannot exceed 50 characters.")]
        public string Surname { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Actor image URL is required.")]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        public string ActorImageUrl { get; set; } = string.Empty;
    }
}
