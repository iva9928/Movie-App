
namespace MovieWebApp.Services.Tests;

using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Web.ViewModels.Actor;
using MovieWebApp.Web.ViewModels.Country;
using MovieWebApp.Web.ViewModels.Director;
using MovieWebApp.Web.ViewModels.Movie;
using MovieWebApp.Web.ViewModels.Quote;
using MovieWebApp.Web.ViewModels.TVShows;

public static class DbSeeder
{
   
    public static Movie Movie;
    public static MovieAllViewModel MovieAllViewModel;
    public static MovieDetailsViewModel MovieDetailsViewModel;


    public static Actor Actor;
    public static ActorAllViewModel ActorAllViewModel;
    public static ActorDetailsViewModel ActorDetailsViewModel;

    public static Country Country;
    public static CountryAllViewModel CountryAllViewModel;
    public static CountryDetailsViewModel CountryDetailsViewModel;

    public static Director Director;
    public static DirectorAllViewModel DirectorAllViewModel;
    public static DirectorDetailsViewModel DirectorrDetailsViewModel;

    public static Quote Quote;
    public static QuoteAllViewModel QuoteAllViewModel;
    public static QuoteDetailsViewModel QuoteDetailsViewModel;

    public static TVShows TVShows;
    public static TVShowAllViewModel TVShowAllViewModel;
    public static TVShowDetailsViewModel TVShowDetailsViewModel;

  
    public static void SeedDb(MovieAppDbContext dbCtx)
    {
       
        Movie = new Movie()
        {
            Title = "Split",
            Genre = "Horror",
            ReleaseDate = new DateTime(1974, 08, 05),
            Casts = "Marilyn Burns, Allen Danziger",
            Duration = 83,
            Country = "UK",
            Production = "New Line Cinema",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTZjNmVjMzAtZjg2Mi00MWNmLTk5NTItOTExZDYwNTE2YmExXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg"
        };
        Actor = new Actor()
        {
            FirstName = "Dylan",
            Surname = "O`Brien",
            Description = "Plays in the TVShow TeenWolf",
            ActorImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBeBk3SYvXQzVI0nrOesW6VealjVk753AE6g&s"
        };
        Country = new Country()
        {
            Name = "Bulgaria",
            Description = "Famous Production",
            CountryImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQsyfIYUuzntfd5GCNvYv0eLT9XH4hFxs7o5g&s"

        };
        Director = new Director
        {
            Id = Guid.NewGuid(),
            FirstName = "Greta",
            Surname = "Gerwig",
            FamousMovies = "Greenberg (2010), Frances Ha (2012)",
            Description = "Christopher Nolan is a visionary British-American filmmaker celebrated for his innovative storytelling.",
            DirectorImageUrl = "https://m.media-amazon.com/images/M/MV5BNDE5MTIxMTMzMV5BMl5BanBnXkFtZTcwMjMxMDYxOQ@@._V1_.jpg"
        };
        Quote = new Quote()
        {
            Description = "'When a chick has a sense of humor, there's nothing more attractive.'",
            CharacterName = "Dylan O`Brien",
            MovieOrShow = "Teen Wolf",
            CharacterImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9qfQmiRMOSoCAE3MAH6XzvDVEEz4b_Lqe8w&s"
        };
        new TVShows()
        {
            Title = "Teen Wolf",
            Genre = "Action & Fantasy",
            ReleaseDate = new DateTime(2018, 03, 29),
            Casts = "Dylan O`Brien...",
            Duration = 47,
            Country = "United States of America",
            Production = "21th Century Fox Television",
            TVSeriesImageUrl = "https://m.media-amazon.com/images/M/MV5BNjc2NGJkMzgtYzMxNy00YWZiLTk0MjUtNTRmNGU3NzA2NDc2XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
            Description = "A boy had got beeten by a hunan or wolf?"
        };
      
        dbCtx.Movies.Add(Movie);
        dbCtx.Actors.Add(Actor);
        dbCtx.Countries.Add(Country);
        dbCtx.Directors.Add(Director);
        dbCtx.Quotes.Add(Quote);
        dbCtx.Movies.Add(Movie);

        dbCtx.SaveChanges();
    }
}

