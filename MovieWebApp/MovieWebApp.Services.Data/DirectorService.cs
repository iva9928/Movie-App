using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieWebApp.Services.Data
{
    public class DirectorService : IDirectorService
    {
        private readonly MovieAppDbContext dbContext;

        public DirectorService(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task AddDirectorAsync(Director director)
        {
            director.Id = Guid.NewGuid(); // Assign a new GUID
            dbContext.Directors.Add(director);
            await dbContext.SaveChangesAsync();
        }
        public async Task<bool> DeleteDirectorAsync(string id)
        {
            var director = await dbContext.Directors.FindAsync(id);
            if (director == null)
            {
                return false;
            }

            dbContext.Directors.Remove(director);
            await dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<Director?> GetAllDirectorDetails(string id)
        {
            // Validate if the id can be parsed to a Guid
            if (!Guid.TryParse(id, out Guid directorId))
            {
                throw new ArgumentException("The provided id is not a valid GUID.", nameof(id));
            }

            // Use the parsed Guid to find the director
            Director? director = await this.dbContext.Directors.FindAsync(directorId);
            return director;
        }


        public async Task<IEnumerable<Director>> GetAllDirectorsAsync()
        {
            IEnumerable<Director> allDirector = await this.dbContext
             .Directors
             .ToListAsync();
            return allDirector;

        }

    }
}
