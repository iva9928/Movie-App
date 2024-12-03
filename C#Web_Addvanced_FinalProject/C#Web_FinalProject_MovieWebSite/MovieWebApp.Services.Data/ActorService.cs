using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;

namespace MovieWebApp.Services
{
    public class ActorService : IActorService
    {
        private readonly MovieAppDbContext dbContext;

        public ActorService(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Actor>> GetAllActorsAsync()
        {
            IEnumerable<Actor> allActors = await this.dbContext
            .Actors
            .ToListAsync();
            return allActors;

        }

        public async Task<IEnumerable<Actor>> GetAllActorsDetails(string id)
        {
            Actor? actor = await this.dbContext
           .Actors
           .FindAsync(Guid.Parse(id));

            if (actor == null)
            {
                return Enumerable.Empty<Actor>();
            }
            return new List<Actor> { actor };

        }

    }

}