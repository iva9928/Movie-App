using System.ComponentModel.DataAnnotations;

namespace MovieApp.DataModels
{
    public class Movie
    {
        public Movie()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        //Искам филтрите да бъдат избирани по жанр след това да се визуализира самия филм,
        //тогава филма трябва ли да има жанр?
        public string Genre { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
        public string Casts { get; set; } = null!;
        //minutes
        public int Duration { get; set; }
        public string Country { get; set; } = null!;
        public string Production { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
