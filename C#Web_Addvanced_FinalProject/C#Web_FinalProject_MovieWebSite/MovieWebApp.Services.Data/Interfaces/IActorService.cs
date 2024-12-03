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
        Task<IEnumerable<Actor>> GetAllActorsDetails(string id);
    }
}
