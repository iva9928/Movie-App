using MovieWebApp.Web.ViewModels.Movie;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Data.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<AllMoviesViewModel>> GetAllMoviesAsync();
        Task<IEnumerable<AllMoviesViewModel>> GetFilteredMoviesAsync(string searchQuery, string genreFilter);
        Task<List<string>> GetGenresAsync();
        Task<MovieDetailsViewModel?> GetMovieDetailsAsync(string id);
        Task AddMovieAsync(AddMovieViewModel model);
        Task<bool> DeleteMovieAsync(string id);
        Task<EditMovieViewModel?> GetEditModelAsync(string id);
        Task<bool> EditMovieAsync(EditMovieViewModel model);

        Task<IEnumerable<AllMoviesViewModel>> GetAllMoviesAsync(string searchQuery, string genreFilter);

    }
}
