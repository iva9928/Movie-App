using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.Web.ViewModels.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Services
{
    public class ActorService : IActorService
    {
        private readonly MovieAppDbContext dbContext;

        public ActorService(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Get all actors as ViewModels
        public async Task<IEnumerable<ActorAllViewModel>> GetAllActorsAsync()
        {
            return await dbContext.Actors
                .Select(a => new ActorAllViewModel
                {
                    Id = a.Id.ToString(),
                    FirstName = a.FirstName,
                    Surname = a.Surname,
                    ActorImageUrl = a.ActorImageUrl
                })
                .ToListAsync();
        }

        // Get actor details
        public async Task<ActorDetailsViewModel?> GetActorDetailsAsync(string id)
        {
            if (!Guid.TryParse(id, out Guid actorId))
            {
                throw new ArgumentException("Invalid actor ID format.", nameof(id));
            }

            return await dbContext.Actors
                .Where(a => a.Id == actorId)
                .Select(a => new ActorDetailsViewModel
                {
                    Id = a.Id.ToString(),
                    FirstName = a.FirstName,
                    Surname = a.Surname,
                    Description = a.Description,
                    ActorImageUrl = a.ActorImageUrl
                })
                .FirstOrDefaultAsync();
        }


        // Add a new actor
        public async Task AddActorAsync(AddActorViewModel model)
        {
            var actor = new Actor
            {
                Id = Guid.NewGuid(),
                FirstName = model.FirstName,
                Surname = model.Surname,
                Description = model.Description,
                ActorImageUrl = model.ActorImageUrl
            };

            dbContext.Actors.Add(actor);
            await dbContext.SaveChangesAsync();
        }

        // Delete an actor
        public async Task<bool> DeleteActorAsync(string id)
        {
            if (!Guid.TryParse(id, out Guid actorId))
            {
                throw new ArgumentException("Invalid actor ID format.", nameof(id));
            }

            var actor = await dbContext.Actors.FindAsync(actorId);
            if (actor == null)
            {
                return false;
            }

            dbContext.Actors.Remove(actor);
            await dbContext.SaveChangesAsync();
            return true;
        }

        // Get actor edit model
        public async Task<EditActorViewModel?> GetEditModelAsync(string id)
        {
            if (!Guid.TryParse(id, out Guid actorId))
            {
                throw new ArgumentException("Invalid actor ID format.", nameof(id));
            }

            return await dbContext.Actors
                .Where(a => a.Id == actorId)
                .Select(a => new EditActorViewModel
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    Surname = a.Surname,
                    Description = a.Description,
                    ActorImageUrl = a.ActorImageUrl
                })
                .FirstOrDefaultAsync();
        }

        // Edit an actor
        public async Task<bool> EditActorAsync(EditActorViewModel model)
        {
            var actor = await dbContext.Actors.FindAsync(model.Id);
            if (actor == null)
            {
                return false;
            }

            actor.FirstName = model.FirstName;
            actor.Surname = model.Surname;
            actor.Description = model.Description;
            actor.ActorImageUrl = model.ActorImageUrl;

            await dbContext.SaveChangesAsync();
            return true;
        }

        // Get filtered actors
       public async Task<IEnumerable<ActorAllViewModel>> GetFilteredActorsAsync(string searchQuery, string firstNameFilter, string surnameFilter, string descriptionFilter)
{
    var query = dbContext.Actors.AsQueryable();

    if (!string.IsNullOrEmpty(searchQuery))
    {
        query = query.Where(a => a.FirstName.Contains(searchQuery) || a.Surname.Contains(searchQuery));
    }

    if (!string.IsNullOrEmpty(firstNameFilter))
    {
        query = query.Where(a => a.FirstName.Contains(firstNameFilter));
    }

    if (!string.IsNullOrEmpty(surnameFilter))
    {
        query = query.Where(a => a.Surname.Contains(surnameFilter));
    }

    if (!string.IsNullOrEmpty(descriptionFilter))
    {
        query = query.Where(a => a.Description.Contains(descriptionFilter));
    }

    return await query
        .Select(a => new ActorAllViewModel
        {
            Id = a.Id.ToString(),
            FirstName = a.FirstName,
            Surname = a.Surname,
            ActorImageUrl = a.ActorImageUrl
        })
        .ToListAsync();
}

    }
}
