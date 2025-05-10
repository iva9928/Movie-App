using MovieApp.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovieWebApp.Web.ViewModels.Country;

namespace MovieWebApp.Services.Data.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryAllViewModel>> GetAllCountriesAsync();
        Task<CountryDetailsViewModel?> GetCountryDetailsAsync(string id);
        Task AddCountryAsync(AddCountryViewModel model);
        Task<bool> DeleteCountryAsync(string id);
        Task<EditCountryViewModel?> GetEditModelAsync(string id);
        Task<bool> EditCountryAsync(EditCountryViewModel model);
    }
}