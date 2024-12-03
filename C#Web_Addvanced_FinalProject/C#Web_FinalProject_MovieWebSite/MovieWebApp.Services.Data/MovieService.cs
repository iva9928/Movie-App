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

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            IEnumerable<Movie> allMovies = await this.dbContext
            .Movies
            .ToListAsync();
            return allMovies;
            
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesDetails(string id)
        {
            Movie? movie = await this.dbContext
           .Movies
           .FindAsync(Guid.Parse(id));

            if (movie == null)
            {
                return Enumerable.Empty<Movie>();
            }
            return new List<Movie> { movie };

        }

    }

}