
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    
    public class AccountController : Controller  
    {
        private readonly RoleManager<IdentityRole<Guid>> roleManager;
        private readonly UserManager<IdentityRole> userManager;
        public AccountController(RoleManager<IdentityRole<Guid>> _roleManager, UserManager<IdentityRole> _userManager)
        {
            roleManager = _roleManager;
            userManager = _userManager;
        }

        [Authorize]
        public async Task<IActionResult> MaleMeAdmin()
        {
            string roleName = "Admin";
            IdentityResult? result = null;
            if (await roleManager.RoleExistsAsync(roleName)==false)
            {
                result = await roleManager.CreateAsync(new IdentityRole<Guid>(roleName));
            }

            if (User.IsInRole(roleName) == false && (result == null || result.Succeeded))
            {
                var user = await userManager.FindByNameAsync(User.Identity.Name);

                if (user != null)
                {
                   await userManager.AddToRoleAsync(user, roleName);
                }
            }

            return RedirectToAction("Index", "Home");   
        }

    }
}
