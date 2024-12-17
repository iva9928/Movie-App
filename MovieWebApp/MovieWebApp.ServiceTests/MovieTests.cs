using Humanizer;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.Web.ViewModels.Movie;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Tests
{
    [TestFixture]
    public class MovieServiceTests
    {
        private DbContextOptions<MovieAppDbContext> options;
        private MovieAppDbContext dbCtx;
        private IMovieService movieService;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            this.options = new DbContextOptionsBuilder<MovieAppDbContext>()
                .UseInMemoryDatabase(databaseName: $"MovieAppTestDb_{Guid.NewGuid()}")
                .Options;

            this.dbCtx = new MovieAppDbContext(this.options);
            this.dbCtx.Database.EnsureCreated();

            // Seed the test database
            DbSeeder.SeedDb(this.dbCtx);

            // Initialize the service
            this.movieService = new MovieService(this.dbCtx);
        }

        [Test]
        public async Task GetAllMoviesAsyncShouldReturnAllMovies()
        {
            // Act
            var result = await this.movieService.GetAllMoviesAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count()); // Only 1 movie is seeded
        }

        [Test]
        public async Task GetMovieDetailsAsyncValidId_ShouldReturnCorrectMovie()
        {
            // Arrange
            var existingMovie = DbSeeder.Movie;

            // Act
            var result = await this.movieService.GetMovieDetailsAsync(existingMovie.Id.ToString());

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingMovie.Title, result.Title);
            Assert.AreEqual(existingMovie.Genre, result.Genre);
        }
        //[Test]
        //public async Task GetMovieDetailsByIdAsync()
        //{
         
        //    var movieInDb = this.dbCtx.Movies.FirstOrDefault();

        //    Assert.IsNotNull(movieInDb, "Movie data was not seeded correctly.");

        //    MovieDetailsViewModel expectedResult = new MovieDetailsViewModel()
        //    {
        //        Id = movieInDb.Id.ToString(),
        //        Title = movieInDb.Title,
        //        Genre = movieInDb.Genre,
        //        ReleaseDate = movieInDb.ReleaseDate,
        //        Casts = movieInDb.Casts,
        //        Duration = movieInDb.Duration,
        //        Country = movieInDb.Country,
        //        Production = movieInDb.Production,
        //        ImageUrl = movieInDb.ImageUrl,
        //        Description = movieInDb.Description
        //    };

           
        //    MovieDetailsViewModel actualResult = await this.movieService.GetMovieDetailsAsync(movieInDb.Id.ToString());

        //    Assert.IsNotNull(actualResult, "The result should not be null.");
        //    Assert.That(expectedResult.Id, Is.EqualTo(actualResult.Id));
        //    Assert.That(expectedResult.Title, Is.EqualTo(actualResult.Title));
        //    Assert.That(expectedResult.Genre, Is.EqualTo(actualResult.Genre));
        //    Assert.That(expectedResult.ReleaseDate, Is.EqualTo(actualResult.ReleaseDate));
        //    Assert.That(expectedResult.Casts, Is.EqualTo(actualResult.Casts));
        //    Assert.That(expectedResult.Duration, Is.EqualTo(actualResult.Duration));
        //    Assert.That(expectedResult.Country, Is.EqualTo(actualResult.Country));
        //    Assert.That(expectedResult.Production, Is.EqualTo(actualResult.Production));
        //    Assert.That(expectedResult.ImageUrl, Is.EqualTo(actualResult.ImageUrl));
        //    Assert.That(expectedResult.Description, Is.EqualTo(actualResult.Description));
        //}



        [Test]
        public async Task GetMovieDetailsAsyncInvalidId_ShouldReturnNull()
        {
            // Act
            var result = await this.movieService.GetMovieDetailsAsync(Guid.NewGuid().ToString());

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void GetMovieDetailsAsync_InvalidGuidFormatShouldThrowArgumentException()
        {
            // Act & Assert
            Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await this.movieService.GetMovieDetailsAsync("invalid-guid");
            });
        }

        [Test]
        public async Task AddMovieAsyncValidDataShouldAddMovieToDatabase()
        {
            // Arrange
            var newMovie = new Movie
            {
                Title = "The Matrix",
                Genre = "Sci-Fi",
                Duration = 136,
                ReleaseDate = new DateTime(1999, 03, 31),
                Casts = "Keanu Reeves, Laurence Fishburne",
                Country = "USA",
                Production = "Warner Bros.",
                ImageUrl = "https://matrix-image-url.com",
                Description = "A hacker discovers reality is simulated by machines."
            };

            // Act
            await this.movieService.AddMovieAsync(newMovie);
            var result = this.dbCtx.Movies.ToList();

            // Assert
            Assert.AreEqual(2, result.Count); // 1 from seeding + 1 new
            Assert.IsTrue(result.Any(m => m.Title == "The Matrix"));
        }

        [Test]
        public async Task DeleteMovieAsyncValidIdShouldDeleteMovie()
        {
            // Arrange
            var existingMovie = DbSeeder.Movie;

            // Act
            var result = await this.movieService.DeleteMovieAsync(existingMovie.Id.ToString());
            var movieInDb = await this.dbCtx.Movies.FindAsync(existingMovie.Id);

            // Assert
            Assert.IsTrue(result);
            Assert.IsNull(movieInDb);
        }

        [Test]
        public async Task DeleteMovieAsyncInvalidIdShouldReturnFalse()
        {
            // Act
            var result = await this.movieService.DeleteMovieAsync(Guid.NewGuid().ToString());

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void DeleteMovieAsyncInvalidGuidFormatShouldThrowArgumentException()
        {
            // Act & Assert
            Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await this.movieService.DeleteMovieAsync("invalid-guid");
            });
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            this.dbCtx.Dispose();
        }
    }
}
