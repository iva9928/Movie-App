using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Web.ViewModels.Actor;
using MovieWebApp.Web.ViewModels.Country;
using MovieWebApp.Web.ViewModels.Director;
using MovieWebApp.Web.ViewModels.Movie;
using MovieWebApp.Web.ViewModels.Quote;
using MovieWebApp.Web.ViewModels.TVShows;

namespace MovieWebApp.ServiceTests
{
    public static class DbSeeder
    {
        public static Movie Movie;
        public static AddMovieViewModel AddMovieViewModel;
        public static EditMovieViewModel EditMovieViewModel;


        public static Actor Actor;
        public static AddActorViewModel AddActorViewModel;
        public static EditActorViewModel EditActorViewModel;

        public static Country Country;
        public static AddCountryViewModel AddCountryViewModel;
        public static EditCountryViewModel EditCountryViewModel;

        public static Director Director;
        public static AddDirectorViewModel AddDirectorViewModel;
        public static EditDirectorViewModel EditDirectorViewModel;

        public static Quote Quote;
        public static AddQuoteViewModel AddQuoteViewModel;
        public static EditQuoteViewModel EditQuoteViewModel;

        public static TVShows TVShows;
        public static AddTVShowViewModel AddTVShowViewModel;
        public static EditTVShowViewModel EditTVShowViewModel;


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
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTZjNmVjMzAtZjg2Mi00MWNmLTk5NTItOTExZDYwNTE2YmExXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                 Description = "Very good horror"
            };
            AddMovieViewModel = new AddMovieViewModel()
            {
                Title = "Split",
                Genre = "Horror",
                ReleaseDate = new DateTime(1974, 08, 05),
                Casts = "Marilyn Burns, Allen Danziger",
                Duration = 82,
                Country = "UK",
                Production = "New Line Cinema",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTZjNmVjMzAtZjg2Mi00MWNmLTk5NTItOTExZDYwNTE2YmExXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                Description = "Very good horror"
            };

            EditMovieViewModel = new EditMovieViewModel()
            {
                Title = "Split",
                Genre = "Horror",
                ReleaseDate = new DateTime(1974, 08, 05),
                Casts = "Marilyn Burns, Allen Danziger",
                Duration = 80,
                Country = "UK",
                Production = "New Line Cinema",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTZjNmVjMzAtZjg2Mi00MWNmLTk5NTItOTExZDYwNTE2YmExXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                Description = "Very good horror"
            };

            Actor = new Actor()
            {
                FirstName = "Dylan",
                Surname = "O`Brien",
                Description = "Plays in the TVShow TeenWolf",
                ActorImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBeBk3SYvXQzVI0nrOesW6VealjVk753AE6g&s"
            };
            AddActorViewModel = new AddActorViewModel()
            {
                FirstName = "Nina",
                Surname = "Dobrev",
                Description = "Plays in the TVShow TVD",
                ActorImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBeBk3SYvXQzVI0nrOesW6VealjVk753AE6g&s"
            };
            EditActorViewModel = new EditActorViewModel()
            {
                FirstName = "Dylan",
                Surname = "O`Brien",
                Description = "Plays in the move the maze runner",
                ActorImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBeBk3SYvXQzVI0nrOesW6VealjVk753AE6g&s"
            };
            Country = new Country()
            {
                Name = "Bulgaria",
                Description = "Famous Production",
                CountryImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQsyfIYUuzntfd5GCNvYv0eLT9XH4hFxs7o5g&s"

            };
            AddCountryViewModel = new AddCountryViewModel()
            {
                Name = "UK",
                Description = "Famous Production",
                CountryImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQsyfIYUuzntfd5GCNvYv0eLT9XH4hFxs7o5g&s"

            };
            EditCountryViewModel = new EditCountryViewModel()
            {
                Name = "USA",
                Description = "Famous Actors",
                CountryImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQsyfIYUuzntfd5GCNvYv0eLT9XH4hFxs7o5g&s"

            };
            AddDirectorViewModel = new AddDirectorViewModel
            {
                FirstName = "Greta",
                Surname = "Gerwig",
                Description = "Christopher Nolan is a visionary British-American filmmaker celebrated for his innovative storytelling.",
                DirectorImageUrl = "https://m.media-amazon.com/images/M/MV5BNDE5MTIxMTMzMV5BMl5BanBnXkFtZTcwMjMxMDYxOQ@@._V1_.jpg"
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
            AddQuoteViewModel = new AddQuoteViewModel()
            {
                Description = "'When a chick has a sense of humor, there's nothing more attractive.'",
                CharacterName = "Dylan O`Brien",
                MovieOrShow = "The maze runner",
                CharacterImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9qfQmiRMOSoCAE3MAH6XzvDVEEz4b_Lqe8w&s"
            };
            EditQuoteViewModel = new EditQuoteViewModel()
            {
                Description = "'When a chick has a sense of humor, there's nothing more awful.'",
                CharacterName = "Dylan O`Brien",
                MovieOrShow = "Teen Wolf",
                CharacterImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9qfQmiRMOSoCAE3MAH6XzvDVEEz4b_Lqe8w&s"
            };
            TVShows = new TVShows()
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
            EditTVShowViewModel = new EditTVShowViewModel()
            {
                Title = "Teen Wolf",
                Genre = "Action & Fantasy",
                ReleaseDate = new DateTime(2018, 03, 29),
                Casts = "Dylan O`Brien...",
                Duration = 45,
                Country = "United States of America",
                Production = "21th Century Fox Television",
                TVSeriesImageUrl = "https://m.media-amazon.com/images/M/MV5BNjc2NGJkMzgtYzMxNy00YWZiLTk0MjUtNTRmNGU3NzA2NDc2XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                Description = "A boy had got beeten by a hunan or wolf?"
            };
            AddTVShowViewModel = new AddTVShowViewModel()
            {
                Title = "Teen Wolf",
                Genre = "Action & Fantasy",
                ReleaseDate = new DateTime(2018, 03, 29),
                Casts = "Dylan O`Brien...",
                Duration = 40,
                Country = "United States of America",
                Production = "21th Century Fox Television",
                TVSeriesImageUrl = "https://m.media-amazon.com/images/M/MV5BNjc2NGJkMzgtYzMxNy00YWZiLTk0MjUtNTRmNGU3NzA2NDc2XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                Description = "A boy had got beeten by a hunan or wolf?"
            };


            dbCtx.Actors.Add(Actor);
            dbCtx.Countries.Add(Country);
            dbCtx.Directors.Add(Director);
            dbCtx.Quotes.Add(Quote);
            dbCtx.Movies.Add(Movie);

            dbCtx.SaveChanges();
        }
   
          
    }
}

