using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebApp.Web.ViewModels.Movie
{
    public class AllMoviesViewModel
    {
        public string Id { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string Genre { get; set; } = null!;

        public string ReleaseDate { get; set; } = null!;

        public string Casts { get; set; } = null!;

        public string Duration { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Production { get; set; } = null!;
        public string Description { get; set; } = null!;

        public string? ImageUrl { get; set; }

    }
}
