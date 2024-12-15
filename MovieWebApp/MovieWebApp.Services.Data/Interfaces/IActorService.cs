using MovieApp.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Data.Interfaces
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAllActorsAsync();
        Task<Actor?> GetAllActorsDetails(string id);
        Task AddActorAsync(Actor actor);
        Task<bool> DeleteActorAsync(string id);
    }
}
