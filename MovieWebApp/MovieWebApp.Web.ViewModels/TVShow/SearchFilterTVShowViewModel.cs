using System.Collections.Generic;

namespace MovieWebApp.Web.ViewModels.TVShows
{
    public class SearchFilterTVShowViewModel
    {
        public string SearchQuery { get; set; } = string.Empty;
        public string GenreFilter { get; set; } = string.Empty;
        public string CountryFilter { get; set; } = string.Empty;
        public List<string> AvailableGenres { get; set; } = new List<string>();
        public List<string> AvailableCountries { get; set; } = new List<string>();
    }
}
