namespace MovieApp.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MovieApp.DataModels;
    using static MovieWebApp.Common.EntityValidationConstants.Actor;
    public class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            //Fluent API
            builder.HasKey(a => a.Id);
            builder.Property(a => a.FirstName)
                .IsRequired()
                .HasMaxLength(FirstNameMaxLength);

            builder.Property(a => a.Surname)
               .IsRequired()
               .HasMaxLength(LastNameMaxLength);

            builder.Property(a => a.Description)
              .IsRequired()
              .HasMaxLength(DescriptionActorMaxLength);

            builder.HasData(this.SeedMovies());

        }
        private List<Actor> SeedMovies()
        {
            List<Actor> actorAll = new List<Actor>()
            {
                new Actor()
              {
                FirstName = "Bradley",
                Surname = "Cooper",
                Description = "Bradley Cooper is a highly acclaimed American actor and filmmaker known for his versatility and dedication to his craft. He was born on January 5, 1975, in Philadelphia, Pennsylvania. Over the years, he has established himself as one of the most talented and bankable stars in Hollywood.",
                ActorImageUrl = "https://images.fandango.com/ImageRenderer/300/0/redesign/static/img/default_poster.png/0/images/masterrepository/performer%20images/132947/BradleyCooper-2022_r.jpg"
              },
              new Actor()
              {
                FirstName = "Colman",
                Surname = "Domingo",
                Description = "Colman Domingo is an acclaimed American actor, playwright, and director known for his versatile performances across theater, film, and television. Born on November 28, 1969, in Philadelphia, Pennsylvania, he has built a career marked by powerful storytelling and emotional depth.",
                ActorImageUrl = "https://i0.gmx.ch/image/610/39010610,pd=1,f=sdata11/colman-domingo.jpg"
              },
              new Actor()
              {
                FirstName = "Paul",
                Surname = "Giamatti",
                Description = "Paul Giamatti is a celebrated American actor known for his versatility and compelling performances in both leading and supporting roles. Born on June 6, 1967, in New Haven, Connecticut, he has built a distinguished career across film, television, and theater.",
                ActorImageUrl = "https://s.abcnews.com/images/GMA/240222_gma_digital_paul_giamatti_hpMain_4x5_608.jpg"
              },
              new Actor()
              {
                FirstName = "Scarlett",
                Surname = "Johansson",
                Description = "Scarlett Johansson is an award-winning American actress and singer, widely regarded as one of the most talented and versatile performers of her generation. Born on November 22, 1984, in New York City, she has achieved immense success in both independent films and blockbuster franchises.",
                ActorImageUrl = "https://m.media-amazon.com/images/M/MV5BMTM3OTUwMDYwNl5BMl5BanBnXkFtZTcwNTUyNzc3Nw@@._V1_.jpg"
              },

              new Actor()
              {
                FirstName ="Cillian",
                Surname = "Murphy",
                Description = "Cillian Murphy is an Irish actor renowned for his intense performances and transformative roles across film, television, and theater. Born on May 25, 1976, in Douglas, County Cork, Ireland, Murphy is celebrated for his versatility and ability to portray complex, nuanced characters.",
                ActorImageUrl = "https://i.pinimg.com/736x/b0/86/f1/b086f106f5f95f68df6d86b8fab10b6d.jpg"
              },

           };

            return actorAll;
        }
    }
}





