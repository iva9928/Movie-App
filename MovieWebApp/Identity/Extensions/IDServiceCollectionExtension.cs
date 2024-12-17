using Identity.Data;
using Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace Microsoft.Extensions.DependencyInjection
{
    public static class IDServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MovieApp2024");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            return services;
        }
        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentity<ApplicationUser, ApplicationRole>(options => options.SignIn.RequireConfirmedAccount = true)
              .AddEntityFrameworkStores<ApplicationDbContext>()
              .AddDefaultTokenProviders()
              .AddDefaultUI();
             
            
            services.ConfigureApplicationCookie(options=>
            {
                options.LoginPath = "/Idedntity/Account/Login";
               
            });

            services.AddAuthentication().AddFacebook(options=>
            {
                options.AppId = "11029";
                options.AppSecret = "";

            }
            );

            services.AddAuthorization(options =>
            {
                options.AddPolicy("SuperNeededClaim", policy => policy.RequireClaim("GoldenClaim"));

            });

            return services;    

        }
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
