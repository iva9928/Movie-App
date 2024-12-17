using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;

namespace MovieWebApp.Services
{
    public class MovieService : IMovieService
    {
        private readonly MovieAppDbContext dbContext;

        public MovieService(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Add Movie
        public async Task AddMovieAsync(Movie movie)
        {
            movie.Id = Guid.NewGuid(); // Assign a new GUID
            dbContext.Movies.Add(movie);
            await dbContext.SaveChangesAsync();
        }

        // Delete Movie
        public async Task<bool> DeleteMovieAsync(string id)
        {
            if (!Guid.TryParse(id, out Guid movieId))
            {
                throw new ArgumentException("The provided ID is not a valid GUID.", nameof(id));
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

        //public Task<IEnumerable<string>> GetAllDurationAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IEnumerable<string>> GetAllGenresAsync()
        //{
        //    IEnumerable<string> allGenres = await this.movieRepository
        //        .GetAllAttached()
        //        .Select(m => m.Genre)
        //        .Distinct()
        //        .ToArrayAsync();

        //    return allGenres;
        //}

        // Get all Movies
        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            IEnumerable<Movie> allMovies = await this.dbContext
                .Movies
                .ToListAsync();
            return allMovies;
        }

        // Get Movie details by ID
        public async Task<Movie?> GetMovieDetailsAsync(string id)
        {
            if (!Guid.TryParse(id, out Guid movieId))
            {
                throw new ArgumentException("The provided ID is not a valid GUID.", nameof(id));
            }

            Movie? movie = await this.dbContext.Movies.FindAsync(movieId);
            return movie;
        }
    }
}
