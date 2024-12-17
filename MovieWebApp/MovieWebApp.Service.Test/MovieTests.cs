using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Controllers;
using MovieWebApp.Services;
using MovieWebApp.Services.Data.Interfaces;
using System.Diagnostics;

namespace MovieWebApp.Service.Test
{
    public class MovieTests
    {
        [TestFixture]
        public class MovieControllerTests
        {
            private DbContextOptions<MovieAppDbContext> options;
            private MovieAppDbContext dbCtx;

            private IMovieService movieService;

            [OneTimeSetUp]
            public void OneTimeSetup()
            {
                var options = new DbContextOptionsBuilder<MovieAppDbContext>()
                .UseInMemoryDatabase(databaseName: $"MovieAppTestDb_{Guid.NewGuid()}")
                .Options;

                this.dbCtx = new MovieAppDbContext(options);

                // Ensure the database schema is created
                this.dbCtx.Database.EnsureCreated();

                // Seed the database
                SeedDb(this.dbCtx);
            }
            private void SeedDb(MovieAppDbContext dbContext)
            {
                // Ensure the database is empty before seeding
                dbContext.Movies.RemoveRange(dbContext.Movies);
                dbContext.SaveChanges();

                // Add initial test data for Movies
                var movies = new List<Movie>
    {
        new Movie
        {
            Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
            Title = "Inception",
            Genre = "Sci-Fi",
            ReleaseDate = new DateTime(2010, 7, 16),
            Duration = 148,
            Country = "USA",
            Production = "Warner Bros",
            ImageUrl = "https://example.com/inception.jpg",
            Description = "A mind-bending thriller about dreams and reality."
        },
        new Movie
        {
            Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
            Title = "Titanic",
            Genre = "Romance",
            ReleaseDate = new DateTime(1997, 12, 19),
            Duration = 195,
            Country = "USA",
            Production = "20th Century Fox",
            ImageUrl = "https://example.com/titanic.jpg",
            Description = "A tragic love story set aboard the ill-fated Titanic."
        },
        new Movie
        {
            Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
            Title = "The Dark Knight",
            Genre = "Action",
            ReleaseDate = new DateTime(2008, 7, 18),
            Duration = 152,
            Country = "USA",
            Production = "Warner Bros",
            ImageUrl = "https://example.com/darkknight.jpg",
            Description = "The rise of the Joker in Gotham City."
        }
    };

                // Add movies to the database
                dbContext.Movies.AddRange(movies);

                // Save changes to persist the data
                dbContext.SaveChanges();
            }

            [OneTimeTearDown]
            public void OneTimeTearDown()
            {
                dbCtx.Database.EnsureDeleted();
                dbCtx.Dispose();
            }
            
            [Test]
            public async Task GetAllMoviesAsync_ShouldReturnAllMovies()
            {
                // Act
                var result = await movieService.GetAllMoviesAsync();

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(2, result.Count());
            }

            [Test]
            public void Test1()
            {
                Assert.Pass();
            }






























            //[Test]
            //public async Task AddCargoAsyncShouldCreateNewCargoAndAddItToTheDbIfDataIsValid()
            //{
            //    await this.cargoService.AddCargoAsync(DbSeeder.CargoAddViewModel, "061f4e83-853f-4f44-aad4-8b526aad1993");
            //    await this.dbCtx.SaveChangesAsync();

            //    int expectedResult = 1;
            //    int actualResult = this.dbCtx.Cargoes.Count();

            //    Assert.That(expectedResult.Equals(actualResult));
            //}
            //[Test]
            //public async Task AllMovies_ShouldReturnViewResult_WithListOfMovies()
            //{
            //    // Act
            //    var result = await movieController.AllMovies();

            //    // Assert
            //    var viewResult = result as ViewResult;
            //    Assert.IsNotNull(viewResult);

            //    var model = viewResult.Model as IEnumerable<Movie>;
            //    Assert.IsNotNull(model);
            //    Assert.AreEqual(2, model.Count());
            //}
            //[Test]
            //public async Task AddTruckAsyncShouldCreateTruckAndAddItToTheDatabase()
            //{
            //    await this.truckService.AddTruckAsync(DbSeeder.TruckAddViewModel, "0c87b02f-3c9b-456a-bf1d-83ec84739da0");
            //    await this.dbCtx.SaveChangesAsync();

            //    int expectedResult = 2;
            //    int actualResult = this.dbCtx.Trucks.Count();

            //    Assert.That(expectedResult.Equals(actualResult));
            //}
            //[Test]
            //public async Task DeleteByIdAsyncShouldDeleteTruckFromTheDatabaseIfItExists()
            //{
            //    Truck existingTruck = await this.dbCtx.Trucks.FirstAsync(x => x.Make == "Daf");

            //    string existingTruckId = existingTruck.Id.ToString();

            //    await this.movieService.DeletebyIdAsync(existingTruckId);
            //    await this.dbCtx.SaveChangesAsync();

            //    int expectedResult = 1;
            //    int actualResult = this.dbCtx.Movies.Count();

            //    Assert.That(expectedResult.Equals(actualResult));
            //}
            //[Test]
            //public async Task AllMoviesShouldReturnViewResultWithListOfMovies()
            //{
            //    // Act
            //    var result = await movieController.AllMovies();

            //    // Assert
            //    var viewResult = result as ViewResult;
            //    Assert.IsNotNull(viewResult);

            //    var model = viewResult.Model as IEnumerable<Movie>;
            //    Assert.IsNotNull(model);
            //    Assert.AreEqual(2, model.Count());
            //}
        }
       
    }
}