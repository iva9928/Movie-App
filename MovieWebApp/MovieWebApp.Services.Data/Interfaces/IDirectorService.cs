using MovieWebApp.Web.ViewModels.Director;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Data.Interfaces
{
    public interface IDirectorService
    {
        Task<IEnumerable<DirectorAllViewModel>> GetAllDirectorsAsync();
        Task<IEnumerable<DirectorAllViewModel>> GetFilteredDirectorsAsync(string searchQuery, string firstNameFilter, string surnameFilter);
        Task<DirectorDetailsViewModel?> GetDirectorDetailsAsync(string id);
        Task AddDirectorAsync(AddDirectorViewModel model);
        Task<bool> DeleteDirectorAsync(string id);
        Task<EditDirectorViewModel?> GetEditModelAsync(string id);
        Task<bool> EditDirectorAsync(EditDirectorViewModel model);
    }
}
