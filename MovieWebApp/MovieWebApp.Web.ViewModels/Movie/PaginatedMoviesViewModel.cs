using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebApp.Web.ViewModels.Movie
{
    public class PaginatedMoviesViewModel
    {
        public IEnumerable<AllMoviesViewModel> Movies { get; set; } = new List<AllMoviesViewModel>();

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }

        public int TotalPages { get; set; }
    }
}
