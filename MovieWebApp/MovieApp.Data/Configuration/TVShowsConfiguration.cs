using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApp.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MovieWebApp.Common.EntityValidationConstants.Movie;
namespace MovieApp.Data.Configuration
{
    public class TVShowsConfiguration : IEntityTypeConfiguration<TVShows>
    {
        public void Configure(EntityTypeBuilder<TVShows> builder)
        {
            //Fluent API
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(TitleMaxLength);

            builder.Property(m => m.Genre)
               .IsRequired()
               .HasMaxLength(GenreMaxLength);

            builder.Property(m => m.Casts)
              .IsRequired()
              .HasMaxLength(CastsMaxLength);

            builder.Property(m => m.Country)
             .IsRequired()
             .HasMaxLength(CountryMaxLength);

            builder.Property(m => m.Production)
              .IsRequired()
              .HasMaxLength(ProductionMaxLength);

            builder.Property(m => m.Description)
              .IsRequired()
              .HasMaxLength(DescriptionMovieMaxLength);

            builder.HasData(this.SeedTVSeries());

        }
        private List<TVShows> SeedTVSeries()
        {
            List<TVShows> TVseries = new List<TVShows>()
            {
                new TVShows()
                {
                    Title = "Prison Break",
                    Genre = "Action & Adventure, Crime, Drama",
                    ReleaseDate = new DateTime(2005, 08, 29),
                    Casts = "Wentworth Miller, Dominic Purcell, Sarah Wayne Callies, Paul Adelstein, Rockmond Dunbar",
                    Duration = 45,
                    Country = "United States of America",
                    Production = "Prison Break Productions, Adelstein-Parouse Productions, Original Television, 20th Century Fox Television",
                    TVSeriesImageUrl = "https://f.woowoowoowoo.net/resize/250x400/90/35/9035e9fd6129b4d5bbecd6a8351269cc/9035e9fd6129b4d5bbecd6a8351269cc.jpg",
                    Description = "Due to a political warfare, an innocent man has been sent to death row and his only hope is his own brother, who makes it his obligation to deliberately get himself shipped to the identical prison as a way to break both of them out, from the inside out."
                },
                new TVShows()
                {
                    Title = "Breaking Bad",
                    Genre = "Drama",
                    ReleaseDate = new DateTime(2008, 01, 20),
                    Casts = "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris, Betsy Brandt",
                    Duration = 45,
                    Country = " United States of America",
                    Production = "Sony Pictures Television, High Bridge Entertainment, Gran Via Productions",
                    TVSeriesImageUrl = "https://f.woowoowoowoo.net/resize/250x400/7a/78/7a78d2a44e33d64d6c35e1a2c1e2cdc9/7a78d2a44e33d64d6c35e1a2c1e2cdc9.jpg",
                    Description = "When a New Mexico chemistry educator, Walter White, has been diagnosed with Stage III cancer and given a prognosis of two years ago to live. He's filled to secure his family's financial future at any cost since he enters the dangerous environment of crime and drugs."
                },
                new TVShows()
                {
                    Title = "Peaky Blinders",
                    Genre = "Drama, Crime",
                    ReleaseDate = new DateTime(2013, 09, 12),
                    Casts = "Cillian Murphy, Paul Anderson, Helen McCrory, Sophie Rundle, Joe Cole",
                    Duration = 60,
                    Country = "United Kingdom",
                    Production = "Tiger Aspect Productions, BBC Studios, Caryn Mandabach Productions, Screen Yorkshire",
                    TVSeriesImageUrl = "https://f.woowoowoowoo.net/resize/250x400/ea/b4/eab48fa4c71804c00008616715dd3777/eab48fa4c71804c00008616715dd3777.jpg",
                    Description = "A gangster family epic set in England, 1919 Birmingham and predicated on their boss Tommy Shelby, who means to maneuver on earth, along with a gang that sew razor blades from the peaks of their caps."
                },
                new TVShows()
                {
                    Title = "The Vampire Diaries",
                    Genre = "Drama, Fantasy, Horror, Romance",
                    ReleaseDate = new DateTime(2009, 09, 10),
                    Casts = "Paul Wesley, Ian Somerhalder, Nina Dobrev, Kat Graham, Candice King",
                    Duration = 45,
                    Country = "United States of America",
                    Production = "Warner Bros. Television, Alloy Entertainment, Outerbanks Entertainment, Bonanza Productions, CBS Television Studios",
                    TVSeriesImageUrl = "https://f.woowoowoowoo.net/resize/250x400/9a/2e/9a2e3494b96d12dcaded262e7a5ef061/9a2e3494b96d12dcaded262e7a5ef061.jpg",
                    Description = "The story of two brothers obsessed with the same girl, that bears a striking resemblance to the beautiful but ruthless vampire they knew and adored from 1864."
                },
                new TVShows()
                {
                    Title = "Gossip Girl",
                    Genre = "Comedy",
                    ReleaseDate = new DateTime(2008, 01, 19),
                    Casts = "Blake Lively, Leighton Meester, Penn Badgley, Chace Crawford, Ed Westwick",
                    Duration = 45,
                    Country = "United States of America",
                    Production = " Warner Bros. Television, Alloy Entertainment, Fake Empire Productions, CBS Television Studios",
                    TVSeriesImageUrl = "https://f.woowoowoowoo.net/resize/250x400/3c/f4/3cf4de4ae0c57a86347943b8f75ef0e5/3cf4de4ae0c57a86347943b8f75ef0e5.jpg",
                    Description = "A private group of privileged teens out of the prep school on Manhattan's Upper East Side whose lives revolve round the allknowing albeit ultra-secretive Gossip Girl's site."
                },
            };
            return TVseries;

        }
    }
}

