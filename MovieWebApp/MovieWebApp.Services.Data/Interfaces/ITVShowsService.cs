using MovieApp.DataModels;
using MovieWebApp.Web.ViewModels.TVShows;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface ITVShowsService
{
    Task<IEnumerable<TVShows>> GetFilteredTVShowsAsync(string searchQuery, string genreFilter, string countryFilter);
    Task<TVShows?> GetTVShowDetailsAsync(string id);
    Task AddTVShowAsync(TVShows tvShow);
    Task<bool> DeleteTVShowAsync(string id);
    Task<TVShows?> GetEditModelAsync(string id);
    Task<bool> EditTVShowAsync(EditTVShowViewModel model);
}
