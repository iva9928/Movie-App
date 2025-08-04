using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebApp.Web.ViewModels.Movie
{
    public class DeleteMovieViewModel
    {
        [Required]
        public string Id { get; set; } = string.Empty;

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public DateTime ReleaseDate { get; set; }
    }
}
