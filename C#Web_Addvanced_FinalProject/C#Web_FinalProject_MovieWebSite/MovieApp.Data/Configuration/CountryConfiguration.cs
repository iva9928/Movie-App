
namespace MovieApp.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MovieApp.DataModels;
    using static Common.EntityValidationConstants.Movie;
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            //Fluent API
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(NameMaxLength);

            builder.Property(a => a.Description)
             .IsRequired()
             .HasMaxLength(DescriptionMaxLength);

            builder.HasData(this.SeedMovies());
        }
        private List<Country> SeedMovies()
        {
            List<Country> countries = new List<Country>()
            {
               new Country()
              {
                Name = "United States",
                Description = "The U.S. film industry, centered in Hollywood, is the largest and most influential in the world, known for its high-budget productions and global reach. It produces a diverse range of films, from independent projects to blockbuster franchises like Star Wars and the Marvel Cinematic Universe. As a cultural powerhouse, it shapes global trends in storytelling, technology, and entertainment.",
                CountryImageUrl = "https://cdn.britannica.com/33/4833-050-F6E415FE/Flag-United-States-of-America.jpg"

              },
                new Country()
              {
                Name = "China",
                Description = "The Chinese film industry is one of the largest in the world, known for its blend of traditional storytelling and modern blockbusters. It boasts a massive domestic audience, government support, and global recognition, with hits like The Wandering Earth and directors such as Zhang Yimou. China's industry continues to expand, influencing both local culture and the global market.",
                CountryImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_India.svg/2560px-Flag_of_India.svg.png"

              },
                new Country()
              {
                Name = "India",
                Description = "India's film industry, known as Bollywood and regional cinema hubs like Tollywood and Kollywood, is the largest in the world by volume, producing over 1,500 films annually. Renowned for its vibrant musicals, emotional storytelling, and diverse languages, it caters to a massive domestic audience and a growing global fanbase. Iconic productions like RRR and Dangal highlight its increasing international influence.",
                CountryImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People%27s_Republic_of_China.svg/800px-Flag_of_the_People%27s_Republic_of_China.svg.png"

              },
                 new Country()
              {
                Name = "United Kingdom",
                Description = "The UK film industry is renowned for its rich cinematic heritage and world-class talent, contributing significantly to global cinema. Known for iconic franchises like James Bond and Harry Potter, it blends independent filmmaking with major international co-productions. Supported by institutions like the British Film Institute (BFI), it remains a hub for creativity and innovation in film.",
                CountryImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Flag_of_the_United_Kingdom_%281-2%29.svg/1200px-Flag_of_the_United_Kingdom_%281-2%29.svg.png"

              },
                  new Country()
              {
                Name = "France",
                Description = "The French film industry, often regarded as the birthplace of cinema, is celebrated for its artistic innovation and rich storytelling tradition. Known for iconic directors like François Truffaut and Jean-Luc Godard, it produces a mix of auteur-driven films and popular comedies. Supported by strong government funding, France remains a global leader in cinematic culture and hosts the prestigious Cannes Film Festival.",
                CountryImageUrl = "https://cdn.britannica.com/82/682-050-8AA3D6A6/Flag-France.jpg"

              },
            };
            return countries;
        }
    }

}
