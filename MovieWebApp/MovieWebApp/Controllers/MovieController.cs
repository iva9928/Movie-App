using Microsoft.AspNetCore.Mvc;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.Web.ViewModels.Movie;

namespace MovieWebApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService movieService;
        private const int DefaultPageSize = 3;

        public MovieController(IMovieService movieService)
        {
            this.movieService = movieService;
        }

       
        [HttpGet]
        public async Task<IActionResult> AllMovies(string searchQuery = "", string genreFilter = "", int page = 1, int pageSize = 3)
        {
            var allMovies = await movieService.GetFilteredMoviesAsync(searchQuery, genreFilter);

            int totalMovies = allMovies.Count();
            int totalPages = (int)Math.Ceiling(totalMovies / (double)pageSize);

            var pagedMovies = allMovies
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var viewModel = new PaginatedMoviesViewModel
            {
                Movies = pagedMovies,
                CurrentPage = page,
                TotalPages = totalPages,
                PageSize = pageSize
            };

            var searchFilter = new SearchFilterMovieViewModel
            {
                SearchQuery = searchQuery,
                GenreFilter = genreFilter,
                AvailableGenres = await movieService.GetGenresAsync()
            };

            ViewBag.SearchFilter = searchFilter;

            return View(viewModel);
        }



        [HttpGet]
        public IActionResult AddMovie()
        {
            return View(new AddMovieViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> AddMovie(AddMovieViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await movieService.AddMovieAsync(model);
            return RedirectToAction(nameof(AllMovies));
        }

        // GET: Movie Details
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                var movie = await movieService.GetMovieDetailsAsync(id);
                if (movie == null)
                {
                    return RedirectToAction("Error404", "Home");
                }

                return View("Details", movie); // Ensure this matches the view name
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: Edit Movie Form
        [HttpGet]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id)
        {
            var movie = await movieService.GetEditModelAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Edit Movie
        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(EditMovieViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool updated = await movieService.EditMovieAsync(model);
            if (!updated)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(AllMovies));
        }

        // GET: Confirm Delete Movie
        [HttpGet]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string id)
        {
            var movie = await movieService.GetMovieDetailsAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            var deleteModel = new DeleteMovieViewModel
            {
                Id = movie.Id,
                Title = movie.Title,
                ReleaseDate = movie.ReleaseDate
            };

            return View(deleteModel);
        }

        // POST: Delete Movie
        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(DeleteMovieViewModel model)
        {
            bool isDeleted = await movieService.DeleteMovieAsync(model.Id);
            if (!isDeleted)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(AllMovies));
        }
    }
}
