
namespace MovieApp.Web.Controllers
{
    using Data;
    using Data.Models;
    using Microsoft.AspNetCore.Mvc;
    public class MovieController : Controller
    {

        private readonly MovieDbContext dbContext;
        public MovieController(MovieDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Movie> allMovies = this.dbContext
                .Movies
                .ToList();

            return View(allMovies);
        }
    }
}
