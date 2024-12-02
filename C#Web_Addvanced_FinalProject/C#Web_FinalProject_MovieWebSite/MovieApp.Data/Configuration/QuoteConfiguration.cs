namespace MovieApp.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MovieApp.DataModels;
    using static Common.EntityValidationConstants.Movie;
    public class QuoteConfiguration : IEntityTypeConfiguration<Quote>
    {
        public void Configure(EntityTypeBuilder<Quote> builder)
        {
            //Fluent API
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Description)
             .IsRequired()
             .HasMaxLength(DescriptionMaxLength);

            builder.Property(q => q.CharacterName)
                .IsRequired()
                .HasMaxLength(CharacterMaxLength);

            builder.Property(q => q.MovieOrShow)
               .IsRequired()
               .HasMaxLength(MovieOrShowMaxLength);

            builder.HasData(this.SeedMovies());

        }
        private List<Quote> SeedMovies()
        {
            List<Quote> quotes = new List<Quote>()
            {
               new Quote()
               {
                  Description = "'Sometimes, the only way to truly escape the past is to keep moving forward.'",
                  CharacterName = "Michael Scofield",
                  MovieOrShow = "Prison Break",
                  CharacterImageUrl = "https://i.pinimg.com/736x/1a/2b/b5/1a2bb5bcb59578199ee35f7f03c97876.jpg"
               },
               new Quote()
               {
                  Description = "“Never forget what you are. The rest of the world will not. Wear it like armor, and it can never be used to hurt you.”",
                  CharacterName = "Tyrion Lannister",
                  MovieOrShow = "Game og Thrones",
                  CharacterImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/50/Tyrion_Lannister-Peter_Dinklage.jpg"
               },
               new Quote()
               {
                  Description = "“When you love someone, you’ll do anything for them. Even if it means breaking every rule in the book.”",
                  CharacterName = "Fernando Sucre",
                  MovieOrShow = "Prison Break",
                  CharacterImageUrl = "https://i.pinimg.com/originals/a9/74/12/a97412747c6d13646367d5e5912cee4c.jpg"
               },
               new Quote()
               {
                  Description = "“Do, or do not. There is no try.”",
                  CharacterName = "Yoda",
                  MovieOrShow = "Star Wars",
                  CharacterImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/9b/Yoda_Empire_Strikes_Back.png"
               },
               new Quote()
               {
                  Description = "“Life is like a box of chocolates. You never know what you’re gonna get.”",
                  CharacterName = "Forest Gump",
                  MovieOrShow = "Forest Gump",
                  CharacterImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/94/Forest_Gump_Character.jpg"
               },

           };

            return quotes;
        }
    }
}





