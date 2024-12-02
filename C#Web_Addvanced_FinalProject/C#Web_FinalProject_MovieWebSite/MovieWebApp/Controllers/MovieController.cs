namespace MovieApp.Web.Controllers
{
    using Data;
    using DataModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    public class MovieController : Controller
    {

        private readonly MovieAppDbContext dbContext;
        public MovieController(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Authorize]
        public IActionResult AllMovies()
        {
            IEnumerable<Movie> allMovies = this.dbContext
                .Movies
                .ToList();

            return View(allMovies);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            Movie? movie = await this.dbContext
                .Movies
                .FindAsync(Guid.Parse(id));

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
        
    }
}
