using Microsoft.AspNetCore.Mvc;
using Moq;
using MovieApp.DataModels;
using MovieWebApp.Controllers;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.Web.ViewModels.Movie;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieWebApp.Tests.Controllers
{
    [TestFixture]
    public class MovieControllerTests
    {
        private Mock<IMovieService> mockMovieService;
        private MovieController movieController;

        [SetUp]
        public void Setup()
        {
            mockMovieService = new Mock<IMovieService>();
            movieController = new MovieController(mockMovieService.Object);
        }

        [Test]
        public async Task AllMovies_ShouldReturnViewResult_WithListOfMovies()
        {
            // Arrange
            var movies = new List<Movie>
            {
                new Movie { Id = "1", Title = "Inception", Duration = "148" },
                new Movie { Id = "2", Title = "Titanic", Duration = "195" }
            };
            mockMovieService.Setup(service => service.GetAllMoviesAsync()).ReturnsAsync(movies);

            // Act
            var result = await movieController.AllMovies();

            // Assert
            var viewResult = result as ViewResult;
            Assert.IsNotNull(viewResult);
            Assert.IsInstanceOf<IEnumerable<Movie>>(viewResult.Model);
            var model = viewResult.Model as IEnumerable<Movie>;
            Assert.AreEqual(2, model.Count());
        }

        [Test]
        public async Task Details_ValidId_ShouldReturnViewResult_WithMovie()
        {
            // Arrange
            var movie = new Movie { Id = "1", Title = "Inception", Duration = "148" };
            mockMovieService.Setup(service => service.GetMovieDetailsAsync("1")).ReturnsAsync(movie);

            // Act
            var result = await movieController.Details("1");

            // Assert
            var viewResult = result as ViewResult;
            Assert.IsNotNull(viewResult);
            Assert.IsInstanceOf<Movie>(viewResult.Model);
            Assert.AreEqual("Inception", (viewResult.Model as Movie)?.Title);
        }

        [Test]
        public async Task Details_InvalidId_ShouldReturnNotFound()
        {
            // Arrange
            mockMovieService.Setup(service => service.GetMovieDetailsAsync("999")).ReturnsAsync((Movie)null);

            // Act
            var result = await movieController.Details("999");

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result);
        }

        [Test]
        public async Task AddMovie_ValidMovie_ShouldRedirectToAllMovies()
        {
            // Arrange
            var newMovie = new Movie { Id = "1", Title = "Inception", Duration = "148" };
            mockMovieService.Setup(service => service.AddMovieAsync(newMovie)).Returns(Task.CompletedTask);

            // Act
            var result = await movieController.AddMovie(newMovie);

            // Assert
            var redirectResult = result as RedirectToActionResult;
            Assert.IsNotNull(redirectResult);
            Assert.AreEqual("AllMovies", redirectResult.ActionName);
        }

        [Test]
        public async Task AddMovie_InvalidModelState_ShouldReturnViewWithModel()
        {
            // Arrange
            var invalidMovie = new Movie();
            movieController.ModelState.AddModelError("Title", "Title is required");

            // Act
            var result = await movieController.AddMovie(invalidMovie);

            // Assert
            var viewResult = result as ViewResult;
            Assert.IsNotNull(viewResult);
            Assert.AreEqual(invalidMovie, viewResult.Model);
        }

        [Test]
        public async Task DeleteMovie_ValidId_ShouldRedirectToAllMovies()
        {
            // Arrange
            mockMovieService.Setup(service => service.DeleteMovieAsync("1")).ReturnsAsync(true);

            // Act
            var result = await movieController.DeleteMovie("1");

            // Assert
            var redirectResult = result as RedirectToActionResult;
            Assert.IsNotNull(redirectResult);
            Assert.AreEqual("AllMovies", redirectResult.ActionName);
        }

        [Test]
        public async Task DeleteMovie_InvalidId_ShouldReturnNotFound()
        {
            // Arrange
            mockMovieService.Setup(service => service.DeleteMovieAsync("999")).ReturnsAsync(false);

            // Act
            var result = await movieController.DeleteMovie("999");

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result);
        }

        [Test]
        public void AllMoviesSearch_ShouldReturnViewResult_WithMockData()
        {
            // Arrange
            var mockMovies = new List<AllMoviesViewModel>
            {
                new AllMoviesViewModel { Id = "1", Title = "Inception", Duration = "148", ImageUrl = "img1.jpg" },
                new AllMoviesViewModel { Id = "2", Title = "Titanic", Duration = "195", ImageUrl = "img2.jpg" }
            };
            var viewModel = new AllMoviesSearchanFilterViewModel
            {
                Movies = mockMovies,
                CurrentPage = 1,
                EntitiesPerPage = 5,
                TotalPages = 1
            };

            // Act
            var result = movieController.AllMoviesSearch();

            // Assert
            var viewResult = result as ViewResult;
            Assert.IsNotNull(viewResult);
            var model = viewResult.Model as AllMoviesSearchanFilterViewModel;
            Assert.IsNotNull(model);
            Assert.AreEqual(2, model.Movies.Count());
        }
    }
}
