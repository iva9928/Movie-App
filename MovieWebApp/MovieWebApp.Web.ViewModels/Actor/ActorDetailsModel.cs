using System.ComponentModel.DataAnnotations;
using static MovieWebApp.Common.EntityValidationConstants.Actor;

namespace MovieWebApp.Web.ViewModels.Actor
{
    public class ActorDetailsViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = 2, ErrorMessage = "First Name must be between 2 and {1} characters.")]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = 2, ErrorMessage = "Surname must be between 2 and {1} characters.")]
        public string Surname { get; set; } = null!;

        [Required]
        public string ActorImageUrl { get; set; } = null!;

        [Required]
        [StringLength(DescriptionActorMaxLength, MinimumLength = 10, ErrorMessage = "Description must be between 10 and {1} characters.")]
        public string Description { get; set; } = null!;
    }
}
