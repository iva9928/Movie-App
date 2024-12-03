namespace MovieApp.Web.Controllers
{
    using Data;
    using DataModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MovieWebApp.Services.Data.Interfaces;

    public class MovieController : Controller
    {

        private readonly MovieAppDbContext dbContext;

        private IMovieService movieService;

        public MovieController(MovieAppDbContext dbContext, IMovieService movieService)
        {
            this.dbContext = dbContext;

            this.movieService
                = movieService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> AllMovies()
        {
            IEnumerable<Movie> allMovies = await this.movieService.GetAllMoviesAsync();
            return View(allMovies);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            IEnumerable<Movie> movies = await this.movieService.GetAllMoviesDetails(id);
            if (!movies.Any())
            {
                return NotFound();
            }
            var movie = movies.First(); 
            return View(movie);
        }
        
    }
}
