using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;

namespace MovieWebApp.Services
{
    public class TVShowsService : ITVShowsService
    {
        private readonly MovieAppDbContext dbContext;

        public TVShowsService(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Add TV show
        public async Task AddTVShowAsync(TVShows tvShow)
        {
            tvShow.Id = Guid.NewGuid(); // Assign a new GUID
            dbContext.TVShows.Add(tvShow);
            await dbContext.SaveChangesAsync();
        }

        // Delete TV show
        public async Task<bool> DeleteTVShowAsync(string id)
        {
            if (!Guid.TryParse(id, out Guid showId))
            {
                throw new ArgumentException("The provided ID is not a valid GUID.", nameof(id));
            }

            var tvShow = await dbContext.TVShows.FindAsync(showId);
            if (tvShow == null)
            {
                return false;
            }

            dbContext.TVShows.Remove(tvShow);
            await dbContext.SaveChangesAsync();
            return true;
        }

        // Get all TV shows
        public async Task<IEnumerable<TVShows>> GetAllTVShowsAsync()
        {
            return await dbContext.TVShows.ToListAsync();
        }

        // Get TV show details
        public async Task<TVShows?> GetTVShowDetailsAsync(string id)
        {
            if (!Guid.TryParse(id, out Guid showId))
            {
                throw new ArgumentException("The provided ID is not a valid GUID.", nameof(id));
            }

            return await dbContext.TVShows.FindAsync(showId);
        }
    }
}
