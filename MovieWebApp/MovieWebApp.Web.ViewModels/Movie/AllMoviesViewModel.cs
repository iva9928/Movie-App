using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebApp.Web.ViewModels.Movie
{
    public class AllMoviesViewModel
    {
        public string Id { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        public int Duration { get; set; }

        public string ReleaseDate { get; set; } = string.Empty;

        public string Casts { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public string Production { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

    }
}
