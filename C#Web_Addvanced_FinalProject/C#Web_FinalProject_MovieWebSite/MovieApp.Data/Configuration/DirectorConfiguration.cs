namespace MovieApp.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MovieApp.DataModels;
    using System;
    using System.Collections.Generic;
    using static Common.EntityValidationConstants.Movie;

    public class DirectorConfiguration : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.FirstName)
                .IsRequired()
                .HasMaxLength(FirstNameMaxLength);

            builder.Property(d => d.Surname)
                .IsRequired()
                .HasMaxLength(SurnameMaxLength);

            builder.Property(d => d.Description)
                .IsRequired()
                .HasMaxLength(DescriptionMaxLength);

            builder.HasData(SeedDirectors());
        }

        private List<Director> SeedDirectors()
        {
            return new List<Director>
            {
                new Director
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Christopher",
                    Surname = "Nolan",
                    FamousMovies = "Oppenheimer (2023), Tenet (2020), Dunkirk (2017)",
                    Description = "Christopher Nolan is a visionary British-American filmmaker celebrated for his innovative storytelling.",
                    DirectorImageUrl = "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_FMjpg_UX1000_.jpg"
                },
                new Director
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Rajkumar",
                    Surname = "Hirani",
                    FamousMovies = "Dunki (2023), PK (2014), Munna Bhai M.B.B.S. (2003)",
                    Description = "Rajkumar Hirani is a renowned Indian filmmaker celebrated for his ability to blend humor and emotion.",
                    DirectorImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/44/Rajkumar_Hirani_2014.jpg"
                },
                new Director
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Frank",
                    Surname = "Darabont",
                    FamousMovies = "The Mist (2007), The Shawshank Redemption (1994), The Green Mile (1999)",
                    Description = "Frank Darabont is known for his mastery in adapting emotionally resonant films from Stephen King's works.",
                    DirectorImageUrl = "https://m.media-amazon.com/images/M/MV5BNjk0MTkxNzQwOF5BMl5BanBnXkFtZTcwODM5OTMwNA@@._V1_.jpg"
                },
                new Director
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Andrei",
                    Surname = "Tarkovsky",
                    FamousMovies = "The Sacrifice (1986), Nostalghia (1983), Stalker (1979)",
                    Description = "Andrei Tarkovsky was a legendary Soviet filmmaker known for his poetic and visually stunning films.",
                    DirectorImageUrl = "https://images.mubicdn.net/images/cast_member/1039/cache-4-1337461025/image-w856.jpg"
                },
                new Director
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Stanley",
                    Surname = "Kubrick",
                    FamousMovies = "The Shining (1980), 2001: A Space Odyssey (1968), Eyes Wide Shut (1999)",
                    Description = "Stanley Kubrick was an iconic filmmaker celebrated for his innovative techniques and cinematic mastery.",
                    DirectorImageUrl = "https://www.all-about-photo.com/images/photographer/K/PHOT-stanley-kubrick-30.jpg"
                }
            };
        }
    }
}
