using System.Collections.Generic;

namespace MovieWebApp.Web.ViewModels.TVShows
{
    public class PaginatedTVShowsViewModel
    {
        public IEnumerable<TVShowAllViewModel> TVShows { get; set; } = new List<TVShowAllViewModel>();

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public int PageSize { get; set; }
    }
}
