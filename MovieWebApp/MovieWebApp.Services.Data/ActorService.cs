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

        public async Task AddActorAsync(Actor actor)
        {
            actor.Id = Guid.NewGuid(); // Assign a new GUID
            dbContext.Actors.Add(actor);
            await dbContext.SaveChangesAsync();
        }
        public async Task<bool> DeleteActorAsync(string id)
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
        public async Task<IEnumerable<Actor>> GetAllActorsAsync()
        {
            IEnumerable<Actor> allActors = await this.dbContext
            .Actors
            .ToListAsync();
            return allActors;

        }

        public async Task<Actor?> GetAllActorsDetails(string id)
        {
            // Validate if the id can be parsed to a Guid
            if (!Guid.TryParse(id, out Guid actorId))
            {
                throw new ArgumentException("The provided id is not a valid GUID.", nameof(id));
            }

            // Use the parsed Guid to find the actor
            Actor? actor = await this.dbContext.Actors.FindAsync(actorId);
            return actor;
        }



    }

}