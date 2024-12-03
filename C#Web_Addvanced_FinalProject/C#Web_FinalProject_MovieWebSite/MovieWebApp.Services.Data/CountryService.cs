using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Data
{
    public class CountryService : ICountryService
    {
        private readonly MovieAppDbContext dbContext;

        public CountryService(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Country>> GetAllCountriesAsync()
        {
            return await this.dbContext.Countries.ToListAsync();
        }

        public async Task<Country?> GetCountryDetailsAsync(string id)
        {
            if (!Guid.TryParse(id, out var countryId))
            {
                return null; // Invalid ID format
            }

            return await this.dbContext.Countries
                .FirstOrDefaultAsync(c => c.Id == countryId);
        }
    }
}
