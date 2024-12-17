using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.Web.ViewModels.Movie;

namespace MovieWebApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService movieService;

        public MovieController(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        // Get all Movies
        [HttpGet]
        public async Task<IActionResult> AllMovies()
        {
            IEnumerable<Movie> allMovies = await this.movieService.GetAllMoviesAsync();

            //AllMoviesSearchanFilterViewModel viewModel = new AllMoviesSearchanFilterViewModel()
            //{
            //    AllDurations = 
            //};


            return View(allMovies);
        }

        // Get Movie details
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                var movie = await this.movieService.GetMovieDetailsAsync(id);
                if (movie == null)
                {
                    return NotFound();
                }

                return View(movie);
            }
            catch (ArgumentException ex)
            {
                // Handle invalid GUID error
                return BadRequest(ex.Message);
            }
        }

        // Add Movie (GET)
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult AddMovie()
        {
            return View();
        }

        // Add Movie (POST)
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddMovie(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }

            await this.movieService.AddMovieAsync(movie);
            return RedirectToAction(nameof(AllMovies));
        }

        // Delete Movie
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteMovie(string id)
        {
            try
            {
                bool isDeleted = await this.movieService.DeleteMovieAsync(id);

                if (!isDeleted)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(AllMovies));
            }
            catch (ArgumentException ex)
            {
                // Handle invalid GUID error
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IActionResult AllMoviesSearch()
        {
            // Mock data for testing - Replace this with data fetched from your database or service
            var movies = new List<AllMoviesViewModel>
            {
                new AllMoviesViewModel { Id = "1", Title = "Inception", Duration = "148", ImageUrl = "img1.jpg" },
                new AllMoviesViewModel { Id = "2", Title = "Titanic", Duration = "195", ImageUrl = "img2.jpg" }
            };

            var viewModel = new AllMoviesSearchanFilterViewModel
            {
                Movies = movies,
                SearchQuery = "",
                DurationFilter = "",
                CurrentPage = 1,
                EntitiesPerPage = 5,
                TotalPages = 1
            };

            return View(viewModel);
        }
    }
}
