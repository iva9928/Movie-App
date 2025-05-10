using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.Web.ViewModels.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Services
{
    public class CountryService : ICountryService
    {
        private readonly MovieAppDbContext dbContext;

        public CountryService(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<CountryAllViewModel>> GetAllCountriesAsync()
        {
            return await dbContext.Countries
                .Select(c => new CountryAllViewModel
                {
                    Id = c.Id.ToString(),
                    Name = c.Name,
                    CountryImageUrl = c.CountryImageUrl
                })
                .ToListAsync();
        }

        public async Task<CountryDetailsViewModel?> GetCountryDetailsAsync(string id)
        {
            if (!Guid.TryParse(id, out var countryId))
            {
                return null;
            }

            return await dbContext.Countries
                .Where(c => c.Id == countryId)
                .Select(c => new CountryDetailsViewModel
                {
                    Id = c.Id.ToString(),
                    Name = c.Name,
                    Description = c.Description,
                    CountryImageUrl = c.CountryImageUrl
                })
                .FirstOrDefaultAsync();
        }

        public async Task AddCountryAsync(AddCountryViewModel model)
        {
            var country = new Country
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Description = model.Description,
                CountryImageUrl = model.CountryImageUrl
            };

            dbContext.Countries.Add(country);
            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteCountryAsync(string id)
        {
            if (!Guid.TryParse(id, out var countryId))
            {
                return false;
            }

            var country = await dbContext.Countries.FindAsync(countryId);
            if (country == null)
            {
                return false;
            }

            dbContext.Countries.Remove(country);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<EditCountryViewModel?> GetEditModelAsync(string id)
        {
            if (!Guid.TryParse(id, out var countryId))
            {
                return null;
            }

            return await dbContext.Countries
                .Where(c => c.Id == countryId)
                .Select(c => new EditCountryViewModel
                {
                    Id = c.Id.ToString(),
                    Name = c.Name,
                    Description = c.Description,
                    CountryImageUrl = c.CountryImageUrl
                })
                .FirstOrDefaultAsync();
        }

        public async Task<bool> EditCountryAsync(EditCountryViewModel model)
        {
            if (!Guid.TryParse(model.Id, out var countryId))
            {
                return false;
            }

            var country = await dbContext.Countries.FindAsync(countryId);
            if (country == null)
            {
                return false;
            }

            country.Name = model.Name;
            country.Description = model.Description;
            country.CountryImageUrl = model.CountryImageUrl;
            await dbContext.SaveChangesAsync();
            return true;
        }
    }
}
