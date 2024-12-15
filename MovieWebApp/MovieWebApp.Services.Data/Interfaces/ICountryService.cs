using MovieApp.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Data.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetAllCountriesAsync();
        Task<Country?> GetCountryDetailsAsync(string id);
    }
}
