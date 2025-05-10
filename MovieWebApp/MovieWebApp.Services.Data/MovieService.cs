using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.Web.ViewModels.Movie;

namespace MovieWebApp.Services
{
    public class MovieService : IMovieService
    {
        private readonly MovieAppDbContext dbContext;

        public MovieService(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Get all movies as ViewModels
        public async Task<IEnumerable<AllMoviesViewModel>> GetAllMoviesAsync()
        {
            return await dbContext.Movies
                .Select(m => new AllMoviesViewModel
                {
                    Id = m.Id.ToString(),
                    Title = m.Title,
                    Genre = m.Genre,
                    ReleaseDate = m.ReleaseDate.ToString("yyyy-MM-dd"),
                    Duration = m.Duration,
                    ImageUrl = m.ImageUrl
                })
                .ToListAsync();
        }
        // Get movie details
        public async Task<MovieDetailsViewModel?> GetMovieDetailsAsync(string id)
        {
            if (!Guid.TryParse(id, out Guid movieId))
            {
                throw new ArgumentException("Invalid movie ID format.", nameof(id));
            }

            return await dbContext.Movies
                .Where(m => m.Id == movieId)
                .Select(m => new MovieDetailsViewModel
                {
                    Id = m.Id.ToString(),
                    Title = m.Title,
                    Description = m.Description,
                    Genre = m.Genre,
                    ImageUrl = m.ImageUrl,
                    Duration = m.Duration,
                    ReleaseDate = m.ReleaseDate,
                    Casts = string.IsNullOrEmpty(m.Casts) ? "Not Available" : m.Casts,
                    Country = string.IsNullOrEmpty(m.Country) ? "Not Available" : m.Country,
                    Production = string.IsNullOrEmpty(m.Production) ? "Not Available" : m.Production
                })
                .FirstOrDefaultAsync();
        }


        // Add a new movie using ViewModel
        public async Task AddMovieAsync(AddMovieViewModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));
            var movie = new Movie
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                Genre = model.Genre,
                ReleaseDate = model.ReleaseDate,
                Duration = model.Duration,
                ImageUrl = model.ImageUrl,
                Casts = model.Casts,
                Country = model.Country,
                Description = model.Description,
                Production = model.Production
            };

            dbContext.Movies.Add(movie);
            await dbContext.SaveChangesAsync();
        }

        // Delete a movie
        public async Task<bool> DeleteMovieAsync(string id)
        {
            if (!Guid.TryParse(id, out Guid movieId))
            {
                throw new ArgumentException("Invalid movie ID format.", nameof(id));
            }

            var movie = await dbContext.Movies.FindAsync(movieId);
            if (movie == null)
            {
                return false;
            }

            dbContext.Movies.Remove(movie);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<EditMovieViewModel?> GetEditModelAsync(string id)
        {
            if (!Guid.TryParse(id, out Guid movieId))
            {
                throw new ArgumentException("Invalid movie ID format.", nameof(id));
            }

            return await dbContext.Movies
                .Where(m => m.Id == movieId)
                .Select(m => new EditMovieViewModel
                {
                    Id = m.Id,
                    Title = m.Title,
                    Genre = m.Genre,
                    ReleaseDate = m.ReleaseDate,
                    Description = m.Description,
                    Casts = m.Casts,
                    Duration = m.Duration,
                    Country = m.Country,
                    Production = m.Production,
                    ImageUrl = m.ImageUrl
                })
                .FirstOrDefaultAsync();
        }

        public async Task<bool> EditMovieAsync(EditMovieViewModel model)
        {
            var movie = await dbContext.Movies.FindAsync(model.Id);
            if (movie == null)
            {
                return false;
            }

            movie.Title = model.Title;
            movie.Genre = model.Genre;
            movie.ReleaseDate = model.ReleaseDate;
            movie.Description = model.Description;
            movie.Casts = model.Casts;
            movie.Duration = model.Duration;
            movie.Country = model.Country;
            movie.Production = model.Production;
            movie.ImageUrl = model.ImageUrl;

            await dbContext.SaveChangesAsync();
            return true;
        }


        public async Task<IEnumerable<AllMoviesViewModel>> GetFilteredMoviesAsync(string searchQuery, string genreFilter)
        {
            var query = dbContext.Movies.AsQueryable();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                query = query.Where(m => m.Title.Contains(searchQuery));
            }

            if (!string.IsNullOrEmpty(genreFilter) && genreFilter != "All")
            {
                query = query.Where(m => m.Genre == genreFilter);
            }

            return await query
                .Select(m => new AllMoviesViewModel
                {
                    Id = m.Id.ToString(),
                    Title = m.Title,
                    Genre = m.Genre,
                    ReleaseDate = m.ReleaseDate.ToString("yyyy-MM-dd"),
                    Duration = m.Duration,
                    ImageUrl = m.ImageUrl
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<AllMoviesViewModel>> GetAllMoviesAsync(string searchQuery, string genreFilter)
        {
            var query = dbContext.Movies.AsQueryable();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                query = query.Where(m => m.Title.Contains(searchQuery));
            }

            if (!string.IsNullOrEmpty(genreFilter))
            {
                query = query.Where(m => m.Genre == genreFilter);
            }

            return await query
                .Select(m => new AllMoviesViewModel
                {
                    Id = m.Id.ToString(),
                    Title = m.Title,
                    Description = m.Description, // Added
                    Genre = m.Genre,
                    ReleaseDate = m.ReleaseDate.ToString("dd-MM-yyyy"), // Added
                    Duration = m.Duration,
                    Casts = string.IsNullOrEmpty(m.Casts) ? "Not Available" : m.Casts, // Added
                    Country = string.IsNullOrEmpty(m.Country) ? "Not Available" : m.Country, // Added
                    Production = string.IsNullOrEmpty(m.Production) ? "Not Available" : m.Production, // Added
                    ImageUrl = m.ImageUrl
                })
                .ToListAsync();
        }
        public async Task<List<string>> GetGenresAsync()
        {
            return await dbContext.Movies
                .Select(m => m.Genre)
                .Distinct()
                .ToListAsync();
        }

    }
}