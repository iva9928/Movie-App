using MovieApp.DataModels;

namespace MovieWebApp.Services.Data.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<Movie?> GetMovieDetailsAsync(string id);
        Task AddMovieAsync(Movie movie);
        Task<bool> DeleteMovieAsync(string id);
        //Task<IEnumerable<string>> GetAllDurationAsync();

        //Task<int> GetMoviesCountByFilterAsync(AllMoviesSearchanFilterViewModel inputModel);

    }
}
