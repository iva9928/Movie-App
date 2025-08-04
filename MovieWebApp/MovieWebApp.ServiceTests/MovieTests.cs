using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.ServiceTests;
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
                .UseInMemoryDatabase($"MovieAppTestDb_{Guid.NewGuid()}")
                .Options;

            this.dbCtx = new MovieAppDbContext(this.options);
            this.dbCtx.Database.EnsureCreated();

            DbSeeder.SeedDb(this.dbCtx);

            this.movieService = new MovieService(this.dbCtx);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            this.dbCtx.Dispose();
        }

        [Test]
        public async Task AddMovieAsyncShouldCreateNewMovieAndAddItToTheDbIfDataIsValid()
        {
            await this.movieService.AddMovieAsync(DbSeeder.AddMovieViewModel);
            await this.dbCtx.SaveChangesAsync();

            int expected = 2; // one seeded + one added
            int actual = this.dbCtx.Movies.Count();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public async Task DeleteMovieAsyncShouldDoNithingIfMovieDoesNotExist()
        {
            await this.movieService.DeleteMovieAsync("cfa73a5c-0a71-4ab2-8893-e295a0636769");
            await this.dbCtx.SaveChangesAsync();

            int expectedResult = 1;
            int actualResult = this.dbCtx.Movies.Count();

            Assert.That(expectedResult.Equals(actualResult));
        }
        [Test]
        public async Task DeleteMovieByIdAsyncShouldRemoveTheGivenMovieFromTheDbIfExists()
        {
            Movie movie = await this.dbCtx.Movies.FirstAsync(x => x.Title == "Split");

            await this.movieService.DeleteMovieAsync(movie.Id.ToString());
            await this.dbCtx.SaveChangesAsync();

            int expectedResult = 0;
            int actualResult = this.dbCtx.Movies.Count();

            Assert.That(expectedResult.Equals(actualResult));
        }
        [Test]
        public async Task TestGetAllMoviesAsync()
        {
            // Arrange
            var movies = new[]
            {
                new Movie
                {
                    Title = "Glass",
            Genre = "Horror",
            ReleaseDate = new DateTime(1974, 08, 05),
            Casts = "Marilyn Burns, Allen Danziger",
            Duration = 83,
            Country = "UK",
            Production = "New Line Cinema",
            Description = "jsfkodf jsokf jsdkf ljdfklds jfkdls fjdkls ufjkdls fjilsjsfkodf jsokf jsdkf ljdfklds jfkdls fjdkls ufjkdls fjilsjsfkodf jsokf jsdkf ljdfklds jfkdls fjdkls ufjkdls fjilsjsfkodf jsokf jsdkf ljdfklds jfkdls fjdkls ufjkdls fjils",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTZjNmVjMzAtZjg2Mi00MWNmLTk5NTItOTExZDYwNTE2YmExXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg"
                },
                new Movie
                {
                    Title = "The toy",
            Genre = "Horror",
            ReleaseDate = new DateTime(1974, 08, 05),
            Casts = "Marilyn Burns, Allen Danziger",
            Duration = 83,
            Country = "UK",
            Production = "New Line Cinema",
            Description = "jsfkodf jsokf jsdkf ljdfklds jfkdls fjdkls ufjkdls fjilsjsfkodf jsokf jsdkf ljdfklds jfkdls fjdkls ufjkdls fjilsjsfkodf jsokf jsdkf ljdfklds jfkdls fjdkls ufjkdls fjilsjsfkodf jsokf jsdkf ljdfklds jfkdls fjdkls ufjkdls fjils",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTZjNmVjMzAtZjg2Mi00MWNmLTk5NTItOTExZDYwNTE2YmExXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg"
                },
            };

            dbCtx.Movies.AddRange(movies);
            await dbCtx.SaveChangesAsync();

           
            var allmovies = await this.movieService.GetAllMoviesAsync();


            Assert.That(allmovies.Count(), Is.EqualTo(3));
        }

        [Test]
        public async Task GanersCount()
        {
            DbSeeder.SeedDb(this.dbCtx);

            var genres = await this.movieService.GetGenresAsync();
       
            Assert.That(genres, Is.Not.Null);
            Assert.That(genres.Count, Is.EqualTo(1)); 
            Assert.That(genres, Does.Contain("Horror"));
            


        }
        [Test]
        public async Task GetEditModelAsync_ShouldReturnCorrectViewModel()
        {
            // Arrange: взимаме ID от вече зареден филм
            var movie = this.dbCtx.Movies.First();
            var expectedTitle = movie.Title;

            // Act
            var editModel = await this.movieService.GetEditModelAsync(movie.Id.ToString());

            // Assert
            Assert.That(editModel, Is.Not.Null);
            Assert.That(editModel!.Id, Is.EqualTo(movie.Id));
            Assert.That(editModel.Title, Is.EqualTo(expectedTitle));
            Assert.That(editModel.Genre, Is.EqualTo(movie.Genre));
        }

        [Test]
        public async Task EditMovieAsync_ShouldUpdateExistingMovie()
        {
            // Arrange
            var movie = this.dbCtx.Movies.First();

            var editModel = new EditMovieViewModel
            {
                Id = movie.Id,
                Title = "Updated Title",
                Genre = movie.Genre,
                ReleaseDate = movie.ReleaseDate,
                Description = "Updated description",
                Casts = movie.Casts,
                Duration = movie.Duration,
                Country = movie.Country,
                Production = movie.Production,
                ImageUrl = movie.ImageUrl
            };

            // Act
            var result = await this.movieService.EditMovieAsync(editModel);
            var updated = await this.dbCtx.Movies.FindAsync(movie.Id);

            // Assert
            Assert.That(result, Is.True);
            Assert.That(updated!.Title, Is.EqualTo("Updated Title"));
            Assert.That(updated.Description, Is.EqualTo("Updated description"));
        }

        [Test]
        public async Task EditMovieAsync_ShouldReturnFalse_IfMovieDoesNotExist()
        {
            // Arrange
            var fakeId = Guid.NewGuid();

            var model = new EditMovieViewModel
            {
                Id = fakeId,
                Title = "Non-existing",
                Genre = "Thriller",
                ReleaseDate = DateTime.Today,
                Description = "Should not update",
                Casts = "None",
                Duration = 90,
                Country = "N/A",
                Production = "N/A",
                ImageUrl = "https://example.com/image.jpg"
            };

            // Act
            var result = await this.movieService.EditMovieAsync(model);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void GetEditModelAsync_ShouldThrowArgumentException_IfIdIsInvalid()
        {
            // Arrange
            string invalidId = "not-a-guid";

            // Act & Assert
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await this.movieService.GetEditModelAsync(invalidId);
            });

            Assert.That(ex!.Message, Does.Contain("Invalid movie ID format"));
        }
        [Test]
        public async Task GetFilteredMoviesAsync_WithOnlySearch_ShouldReturnMatchingMovies()
        {
            DbSeeder.SeedDb(this.dbCtx);

            var result = await this.movieService.GetFilteredMoviesAsync("Split", "");
            var list = result.ToList();

            Assert.That(list.Count, Is.EqualTo(2));
            Assert.That(list[0].Title, Is.EqualTo("Split"));
        }

        [Test]
        public async Task GetFilteredMoviesAsync_WithOnlyGenre_ShouldReturnMatchingMovies()
        {
            DbSeeder.SeedDb(this.dbCtx);

            var result = await this.movieService.GetFilteredMoviesAsync("", "Horror");
            var list = result.ToList();

            Assert.That(list.Count, Is.EqualTo(2));
            Assert.That(list[0].Genre, Is.EqualTo("Horror"));
        }


        [Test]
        public async Task GetFilteredMoviesAsync_WithSearchAndGenre_ShouldReturnCorrectMovie()
        {
            DbSeeder.SeedDb(this.dbCtx);

            var result = await this.movieService.GetFilteredMoviesAsync("Split", "Horror");
            var list = result.ToList();

            Assert.That(list.Count, Is.EqualTo(2));
            Assert.That(list[0].Title, Is.EqualTo("Split"));
        }

        [Test]
        public async Task GetFilteredMoviesAsync_WithInvalidData_ShouldReturnEmpty()
        {
            DbSeeder.SeedDb(this.dbCtx);

            var result = await this.movieService.GetFilteredMoviesAsync("DoesNotExist", "Sci-Fi");
            var list = result.ToList();

            Assert.That(list, Is.Empty);
        }

        [Test]
        public async Task GetFilteredMoviesAsync_WithGenreAll_ShouldIgnoreGenreFilter()
        {
            DbSeeder.SeedDb(this.dbCtx);

            var result = await this.movieService.GetFilteredMoviesAsync("", "All");
            var list = result.ToList();

            Assert.That(list.Count, Is.EqualTo(2)); // Split + Angel of death
        }

        [Test]
        public async Task GetAllMoviesAsync_WithGenreFilterOnly_ShouldReturnMatchingGenre()
        {
            var result = (await this.movieService.GetAllMoviesAsync("", "Horror")).ToList();

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].Genre, Is.EqualTo("Horror"));
        }

        [Test]
        public async Task GetAllMoviesAsync_WithSearchAndGenreFilter_ShouldReturnMatchingMovies()
        {
            // Arrange
            DbSeeder.SeedDb(this.dbCtx); // Увери се, че имаме Angel of death (Comedy) и Split (Horror)

            // Act
            var result = (await this.movieService.GetAllMoviesAsync("Split", "Horror")).ToList();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result.First().Title, Is.EqualTo("Split"));
        }


        [Test]
        public async Task GetMovieDetailsAsyncShouldReturnCorrectMovie()
        {
            var movie = await this.dbCtx.Movies.FirstAsync(m => m.Title == "Split");

            var result = await this.movieService.GetMovieDetailsAsync(movie.Id.ToString());

            Assert.That(result, Is.Not.Null);
            Assert.That(result!.Title, Is.EqualTo("Split"));
            Assert.That(result.Description, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void GetMovieDetailsAsyncShouldThrowOnInvalidId()
        {
            Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await this.movieService.GetMovieDetailsAsync("invalid-guid");
            });
        }
        [Test]
        public async Task GetAllMoviesAsync_NoParameters_ShouldReturnAllMovies()
        {
            DbSeeder.SeedDb(this.dbCtx);

            var result = (await this.movieService.GetAllMoviesAsync()).ToList();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(2)); // Adjust based on your seed count
            Assert.That(result.Any(m => m.Title == "Split"), Is.True);
        }
        [Test]
        public async Task GetMovieDetailsAsync_NonExistentId_ShouldReturnNull()
        {
            var result = await this.movieService.GetMovieDetailsAsync(Guid.NewGuid().ToString());

            Assert.That(result, Is.Null);
        }
        [Test]
        public async Task GetGenresAsync_ShouldReturnEmptyList_IfNoMoviesExist()
        {
            var options = new DbContextOptionsBuilder<MovieAppDbContext>()
                .UseInMemoryDatabase($"EmptyGenreTest_{Guid.NewGuid()}")
                .Options;

            await using var emptyDbCtx = new MovieAppDbContext(options);
            var service = new MovieService(emptyDbCtx);

            var result = await service.GetGenresAsync();

            Assert.That(result, Is.Empty);
        }
        [Test]
        public void AddMovieAsync_ShouldThrow_IfModelIsNull()
        {
            Assert.ThrowsAsync<ArgumentNullException>(async () =>
            {
                await this.movieService.AddMovieAsync(null!);
            });
        }

        [Test]
        public async Task GetAllMoviesAsync_ShouldReturnCorrectReleaseDateFormat()
        {
            var result = await this.movieService.GetAllMoviesAsync();
            Assert.That(result.First().ReleaseDate, Does.Match("\\d{4}-\\d{2}-\\d{2}"));
        }

        [Test]
        public async Task GetAllMoviesAsync_Filtered_ShouldReturnCorrectFormattedFields()
        {
            var result = await this.movieService.GetAllMoviesAsync("Split", "Horror");
            var movie = result.First();

            Assert.That(movie.ReleaseDate, Does.Match("\\d{2}-\\d{2}-\\d{4}"));
            Assert.That(movie.Casts, Is.EqualTo("Not Available").Or.Not.Empty);
            Assert.That(movie.Country, Is.EqualTo("Not Available").Or.Not.Empty);
            Assert.That(movie.Production, Is.EqualTo("Not Available").Or.Not.Empty);
        }

        [Test]
        public async Task GetFilteredMoviesAsync_ShouldBeCaseInsensitive()
        {
            var upper = await this.movieService.GetFilteredMoviesAsync("SPLIT", "HORROR");
            var lower = await this.movieService.GetFilteredMoviesAsync("split", "horror");

            Assert.That(upper.Count(), Is.EqualTo(lower.Count()));
        }

        [Test]
        public async Task EditMovieAsync_ShouldSucceed_WhenOptionalFieldsAreEmpty()
        {
            var movie = this.dbCtx.Movies.First();

            var model = new EditMovieViewModel
            {
                Id = movie.Id,
                Title = movie.Title,
                Genre = movie.Genre,
                ReleaseDate = movie.ReleaseDate,
                Description = "",
                Casts = null,
                Duration = movie.Duration,
                Country = null,
                Production = null,
                ImageUrl = movie.ImageUrl
            };

            var result = await this.movieService.EditMovieAsync(model);
            Assert.That(result, Is.True);
        }



    }

}




