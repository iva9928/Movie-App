using MovieApp.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Data.Interfaces
{
    public interface IDirectorService
    {
        Task<IEnumerable<Director>> GetAllDirectorsAsync();
        Task<IEnumerable<Director>> GetAllDirectorDetails(string id);
    }
}
