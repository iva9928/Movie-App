
namespace MovieApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Reflection;

    public class MovieDbContext : DbContext
    {
        //testovi celi
        public MovieDbContext()
        {
                
        }
        public MovieDbContext(DbContextOptions options)
            : base (options)
        {
                
        }

        public virtual DbSet<Movie> Movies { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-QQ34EL6\\SQLEXPRESS;Database=MovieApp2024;Trusted_Connection=True;TrustServerCertificate=True;",
                b => b.MigrationsAssembly("MovieApp.Web"));
        }
    }
}
