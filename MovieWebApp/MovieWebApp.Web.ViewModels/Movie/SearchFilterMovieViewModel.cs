using System.Collections.Generic;

namespace MovieWebApp.Web.ViewModels.Movie
{
    public class SearchFilterMovieViewModel
    {
        public string SearchQuery { get; set; } = string.Empty;
        public string GenreFilter { get; set; } = string.Empty;
        public List<string> AvailableGenres { get; set; } = new List<string>();
    }
}
