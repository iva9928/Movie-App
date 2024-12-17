using Microsoft.AspNetCore.Identity;

namespace Identity.Models
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole()
            :base()
        {
                
        }
        public ApplicationRole(string roleName)
            :base(roleName)
        {
                
        }
    }
}
