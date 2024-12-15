using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.DataModels
{
    public class TVShows
    {
        public TVShows() 
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
        public string Casts { get; set; } = null!;
        //minutes
        public int Duration { get; set; }
        public string Country { get; set; } = null!;
        public string Production { get; set; } = null!;
        public string TVSeriesImageUrl { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
