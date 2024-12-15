namespace MovieApp.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MovieApp.DataModels;
    using static MovieWebApp.Common.EntityValidationConstants.Movie;
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
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

            builder.HasData(this.SeedMovies());

        }
        private List<Movie> SeedMovies()
        {
            List<Movie> movies = new List<Movie>()
           {
              new Movie()
              {
                Title = "The Texas Chain Saw Massacre",
                Genre = "Horror",
                ReleaseDate = new DateTime(1974, 08, 09),
                Casts = "Marilyn Burns, Allen Danziger, Paul A. Partain, William Vail, Teri McMinn",
                Duration = 83,
                Country = "United States of America",
                Production = "New Line Cinema, Vortex",
                MovieImageUrl = "https://waxworkrecords.com/cdn/shop/files/TCSM-Game_Cover_1080x.jpg?v=1691613262.jpg",
                Description = "A chain-saw wielding his category of cannibals and killer hunts and terrorized five friends visiting their grandfather's house from the country"
              },
              new Movie()
              {
                Title = "The Exorcist",
                Genre = "Horror",
                ReleaseDate = new DateTime(1973, 12, 26),
                Casts = "Ellen Burstyn, Jason Miller, Max von Sydow, Linda Blair, Lee J. Cobb",
                Duration = 122,
                Country = "United States of America",
                Production = "Hoya Productions, Warner Bros. Pictures",
                MovieImageUrl = "https://m.media-amazon.com/images/I/716Gr-3e6rL._AC_UF894,1000_QL80_.jpg.jpg",
                Description = "As strange events befall the place of Georgetown 12-year-old Regan MacNeil begins to adapt an explicit personality. Her mum ultimately turns into her hope, and becomes torn between superstition and science at a desperate bid to save her daughter: a priest who's currently fighting along with his own faith Father Damien Karras."
              },
              new Movie()
              {
                Title = "The Shining",
                Genre = "Horror",
                ReleaseDate = new DateTime(1980, 05, 22),
                Casts = "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson",
                Duration = 144,
                Country = "United Kingdom, United States of America",
                MovieImageUrl = "https://m.media-amazon.com/images/M/MV5BNmM5ZThhY2ItOGRjOS00NzZiLWEwYTItNDgyMjFkOTgxMmRiXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                Production = "Hawk Films, Peregrine, Warner Bros. Pictures, Producers Circle",
                Description = "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, together with his wife Wendy and their son Danny, has to live isolated. But they aren't ready for the insanity that lurks within."
              },
              new Movie()
              {
                Title = "The Conjuring",
                Genre = "Horror",
                ReleaseDate = new DateTime(2013, 03, 20),
                Casts = "Patrick Wilson, Vera Farmiga, Lili Taylor, Ron Livingston, Mackenzie Foy",
                Duration = 112,
                MovieImageUrl = "https://m.media-amazon.com/images/I/5147F62RsML._AC_UF1000,1000_QL80_.jpg",
                Country = "United States of America",
                Production = "New Line Cinema, The Safran Company, Evergreen Media Group",
                Description = "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes."
              },
              new Movie()
              {
                Title = "The Ring",
                Genre = "Horror",
                ReleaseDate = new DateTime(2002, 10, 18),
                Casts = "Naomi Watts, Martin Henderson, David Dorfman, Brian Cox, Jane Alexander",
                Duration = 115,
                MovieImageUrl = "https://m.media-amazon.com/images/M/MV5BMTY2ODc2NTQ2OF5BMl5BanBnXkFtZTYwNzA4OTU3._V1_.jpg",
                Country = "Japan, United States of America",
                Production = "BenderSpink, Parkes+MacDonald Image Nation, DreamWorks",
                Description = "It seemed leading to a cellular mobile cell phone call foretelling the viewer's death in exactly seven days. Like a newspaper reporter, Rachel Keller was clearly skeptical of this story, until four teenagers all met with mysterious deaths exactly 1 week. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video... and watches it. She has just seven days to unravel the mystery of the Ring."
              },
              new Movie()
              {
                Title = "The Nun",
                Genre = "Horror",
                ReleaseDate = new DateTime(2018, 09, 05),
                Casts = "Beatrice Rubica, Lili Bordán, Jared Morgan, Lynnette Gaza, David Horovitch",
                Duration = 96,
                MovieImageUrl = "https://m.media-amazon.com/images/I/61QaDRRcTrL._AC_UF894,1000_QL80_.jpg.jpg",
                Country = "United States of America",
                Production = "New Line Cinema, Atomic Monster, The Safran Company",
                Description = "The Vatican sends a priest with a past and a novitiate on the brink of her final cries to explore Every time a nun in a abbey at Romania takes her own life. They uncover the order secret. Risking not only their lives but their faith and their very souls, they face a malevolent force at the kind of the same demonic nun that terrorized audiences at\"The Conjuring 2\" as the abbey gets to be a dreadful battle ground between the alive and the damned."
              },
              new Movie()
              {
                Title = "Sinister",
                Genre = "Horror",
                ReleaseDate = new DateTime(2012, 03, 29),
                Casts = "Ethan Hawke, Juliet Rylance, Vincent D'Onofrio, James Ransone, Fred Dalton Thompson",
                Duration = 110,
                MovieImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQaS6dDLX1WEgUs2vVn9JhE-MDaXF3BDMFdIw&s.jpg",
                Country = "United States of America",
                Production = "Automatik Entertainment, Blumhouse Productions, Alliance Films, IM Global, Possessed Pictures",
                Description = "Footage helps a truecrime novelist realize a household has been killed inside his new residence, though his discoveries put his family."
              },
              new Movie()
              {
                Title = "It Follows",
                Genre = "Horror",
                ReleaseDate = new DateTime(2014, 11, 13),
                Casts = "Maika Monroe, Keir Gilchrist, Daniel Zovatto, Olivia Luccardi, Lili Sepe",
                Duration = 101,
                MovieImageUrl = "https://m.media-amazon.com/images/M/MV5BNGZiYWRiYjAtODU0NS00YzAzLTk2MzQtZGVlMzVjM2M3MGQ3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg.jpg",
                Country = "United States of America",
                Production = "Two Flints, Northern Lights Films, Animal Kingdom",
                Description = "To get 19-year-old Jay, autumn should be all about boys school and weekends out at the lake. But a seemingly innocent encounter gives her inescapable sense that some one , or something, is after her and turns sour. Up against this weight, Jay and her friends must find a means to flee."
              },
              new Movie()
              {
                Title = "The Babadook",
                Genre = "Horror",
                ReleaseDate = new DateTime(2014, 05, 22),
                Casts = "Essie Davis, Noah Wiseman, Hayley McElhinney, Daniel Henshall, Barbara West",
                Duration = 94,
                MovieImageUrl = "https://silver.afi.com/CDN/Image/Entity/FilmPosterGraphic/f-0100004762?width=48&height=48.jpg",
                Country = "Canada, Australia",
                Production = "Screen Australia, Smoking Gun Productions, Causeway Films, South Australian Film Corporation, Entertainment One",
                Description = "A single mommy, harassed with her husband's brutal death , struggles with her son's anxiety about a monster lurking in your house, but soon discovers a menacing presence all."
              },
              new Movie()
              {
                Title = "The Others",
                Genre = "Horror",
                ReleaseDate = new DateTime(2001, 08, 02),
                Casts = "Nicole Kidman, Christopher Eccleston, Alakina Mann, James Bentley, Eric Sykes",
                Duration = 101,
                MovieImageUrl = "https://m.media-amazon.com/images/I/61cVO6WvabL._AC_UF894,1000_QL80_.jpg",
                Country = "Spain, United States of America, France, Italy",
                Production = " Cruise/Wagner Productions, Canal+, Sogecine, Las Producciones del Escorpion, Lucky Red, Dimension Films, Miramax",
                Description = "Grace is really actually a woman who resides in a older house kept dark because her two children have a rare sensitivity. When your household begins to suspect your house is haunted, Grace fights to protect her kids at any cost at the face of strange events and disturbing fantasies."
              },
           };

            return movies;
        }
    }
}





