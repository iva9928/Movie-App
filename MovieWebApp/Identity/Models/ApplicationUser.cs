using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [PersonalData]
        [MaxLength(50)]    
        public string? FirstName { get; set; } 

        [PersonalData]
        [MaxLength(50)]
        public string? LastName { get; set; } 

    }
}
