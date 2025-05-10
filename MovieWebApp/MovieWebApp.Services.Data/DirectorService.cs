using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.Web.ViewModels.Director;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Services
{
    public class DirectorService : IDirectorService
    {
        private readonly MovieAppDbContext dbContext;

        public DirectorService(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Get all directors
        public async Task<IEnumerable<DirectorAllViewModel>> GetAllDirectorsAsync()
        {
            return await dbContext.Directors
                .Select(d => new DirectorAllViewModel
                {
                    Id = d.Id.ToString(),
                    FirstName = d.FirstName,
                    Surname = d.Surname,
                    DirectorImageUrl = d.DirectorImageUrl
                })
                .ToListAsync();
        }

        // Get filtered directors
        public async Task<IEnumerable<DirectorAllViewModel>> GetFilteredDirectorsAsync(string searchQuery, string firstNameFilter, string surnameFilter)
        {
            var query = dbContext.Directors.AsQueryable();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                query = query.Where(d => d.FirstName.Contains(searchQuery) || d.Surname.Contains(searchQuery));
            }

            if (!string.IsNullOrEmpty(firstNameFilter))
            {
                query = query.Where(d => d.FirstName.Contains(firstNameFilter));
            }

            if (!string.IsNullOrEmpty(surnameFilter))
            {
                query = query.Where(d => d.Surname.Contains(surnameFilter));
            }

            return await query
                .Select(d => new DirectorAllViewModel
                {
                    Id = d.Id.ToString(),
                    FirstName = d.FirstName,
                    Surname = d.Surname,
                    DirectorImageUrl = d.DirectorImageUrl
                })
                .ToListAsync();
        }

        // Get director details
        public async Task<DirectorDetailsViewModel?> GetDirectorDetailsAsync(string id)
        {
            if (!Guid.TryParse(id, out Guid directorId))
            {
                throw new ArgumentException("Invalid director ID format.", nameof(id));
            }

            return await dbContext.Directors
                .Where(d => d.Id == directorId)
                .Select(d => new DirectorDetailsViewModel
                {
                    Id = d.Id.ToString(),
                    FirstName = d.FirstName,
                    Surname = d.Surname,
                    Description = d.Description,
                    DirectorImageUrl = d.DirectorImageUrl
                })
                .FirstOrDefaultAsync();
        }


        // Add a new director
        public async Task AddDirectorAsync(AddDirectorViewModel model)
        {
            var director = new Director
            {
                Id = Guid.NewGuid(),
                FirstName = model.FirstName,
                Surname = model.Surname,
                Description = model.Description,
                DirectorImageUrl = model.DirectorImageUrl
            };

            dbContext.Directors.Add(director);
            await dbContext.SaveChangesAsync();
        }

        // Delete a director
        public async Task<bool> DeleteDirectorAsync(string id)
        {
            if (!Guid.TryParse(id, out Guid directorId))
            {
                throw new ArgumentException("Invalid director ID format.", nameof(id));
            }

            var director = await dbContext.Directors.FindAsync(directorId);
            if (director == null)
            {
                return false;
            }

            dbContext.Directors.Remove(director);
            await dbContext.SaveChangesAsync();
            return true;
        }

        // Get director edit model
        public async Task<EditDirectorViewModel?> GetEditModelAsync(string id)
        {
            if (!Guid.TryParse(id, out Guid directorId))
            {
                throw new ArgumentException("Invalid director ID format.", nameof(id));
            }

            return await dbContext.Directors
                .Where(d => d.Id == directorId)
                .Select(d => new EditDirectorViewModel
                {
                    Id = d.Id.ToString(),
                    FirstName = d.FirstName,
                    Surname = d.Surname,
                    Description = d.Description,
                    DirectorImageUrl = d.DirectorImageUrl
                })
                .FirstOrDefaultAsync();
        }

        // Edit a director
        public async Task<bool> EditDirectorAsync(EditDirectorViewModel model)
        {
            var director = await dbContext.Directors.FindAsync(Guid.Parse(model.Id));
            if (director == null)
            {
                return false;
            }

            director.FirstName = model.FirstName;
            director.Surname = model.Surname;
            director.Description = model.Description;
            director.DirectorImageUrl = model.DirectorImageUrl;

            await dbContext.SaveChangesAsync();
            return true;
        }
    }
}
