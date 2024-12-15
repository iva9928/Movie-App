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
            return await dbContext.Movies.ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesDetails(string id)
        {
            return await dbContext.Movies.Where(m => m.Id.ToString() == id).ToListAsync();
        }

        public async Task AddMovieAsync(Movie movie)
        {
            movie.Id = Guid.NewGuid(); // Assign a new GUID
            dbContext.Movies.Add(movie);
            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteMovieAsync(string id)
        {
            var movie = await dbContext.Movies.FindAsync(id);
            if (movie == null)
            {
                return false;
            }

            dbContext.Movies.Remove(movie);
            await dbContext.SaveChangesAsync();
            return true;
        }
    }

}