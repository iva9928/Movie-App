namespace MovieApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using DataModels;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using System.Reflection;
    using Microsoft.AspNetCore.Identity;
    using System.Reflection.Emit;
    using MovieApp.Data.Configuration;

    public class MovieAppDbContext : IdentityDbContext
    {
        public MovieAppDbContext(DbContextOptions<MovieAppDbContext> options) : base(options)
        {
        }


        public virtual DbSet<Actor> Actors { get; set; } = null!;

        public virtual DbSet<Movie> Movies { get; set; } = null!;

        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Director> Directors { get; set; } = null!;
        public virtual DbSet<Quote> Quotes { get; set; } = null!;
        public virtual DbSet<TVShows> TVShows { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-QQ34EL6\\SQLEXPRESS;Database=MovieApp2024;Trusted_Connection=True;TrustServerCertificate=True;",
                b => b.MigrationsAssembly("MovieApp.Data"));
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Actor>()
             .HasKey(a => a.Id);

            builder.Entity<Director>()
             .HasKey(d => d.Id);

            builder.Entity<IdentityRole>(role =>
            {
                role.Property(r => r.Name).HasMaxLength(256);
                role.Property(r => r.NormalizedName).HasMaxLength(256);
            });

            base.OnModelCreating(builder);

            //builder.ApplyConfiguration(new TVShowsConfiguration());
            Assembly assembly = Assembly.GetAssembly(typeof(MovieAppDbContext)) ?? Assembly.GetExecutingAssembly();

            builder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(builder);
        }
    }
}
