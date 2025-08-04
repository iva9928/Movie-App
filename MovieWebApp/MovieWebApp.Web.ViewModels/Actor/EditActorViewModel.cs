using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebApp.Web.ViewModels.Actor
{
    public class EditActorViewModel
    {
        [Required]
        public Guid Id { get; set; }  // Change from string to Guid

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Surname { get; set; } = null!;

        [Required]
        [StringLength(1000, MinimumLength = 10)]
        public string Description { get; set; } = null!;

        [Required, Url]
        public string ActorImageUrl { get; set; } = null!;
    }
}
