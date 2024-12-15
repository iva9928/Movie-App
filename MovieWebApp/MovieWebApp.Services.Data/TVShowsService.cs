
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MovieWebApp.Common.EntityValidationConstants;

namespace MovieWebApp.Services.Data
{
    public class TVShowsService : ITVShowsService
    {
        private readonly MovieAppDbContext dbContext;

        public TVShowsService(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<TVShows>> GetAllTVShowsAsync()
        {
            return await dbContext.TVShows.ToListAsync();

        }

        public async Task<IEnumerable<TVShows>> GetAllTVShowsDetails(string id)
        {
            return await dbContext.TVShows.Where(s => s.Id.ToString() == id).ToListAsync();

        }

        public async Task AddTVShowsAsync(TVShows TVshows)
        {
            TVshows.Id = Guid.NewGuid(); // Assign a new GUID
            dbContext.TVShows.Add(TVshows);
            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteTVShowsAsync(string id)
        {
            var TVshows = await dbContext.TVShows.FindAsync(id);
            if (TVshows == null)
            {
                return false;
            }

            dbContext.TVShows.Remove(TVshows);
            await dbContext.SaveChangesAsync();
            return true;
        }
    }
}
