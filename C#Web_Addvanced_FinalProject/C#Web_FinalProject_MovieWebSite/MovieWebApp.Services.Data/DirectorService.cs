using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MovieApp.Common.EntityValidationConstants;

namespace MovieWebApp.Services.Data
{
    public class DirectorService : IDirectorService
    {
        private readonly MovieAppDbContext dbContext;

        public DirectorService(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Director>> GetAllDirectorDetails(string id)
        {
            Director? director = await this.dbContext
           .Directors
           .FindAsync(Guid.Parse(id));

            if (director == null)
            {
                return Enumerable.Empty<Director>();
            }
            return new List<Director> { director };

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
