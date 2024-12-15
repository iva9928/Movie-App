using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Models;
using System.Diagnostics;

namespace MovieWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MovieAppDbContext dbContext;

        public HomeController(ILogger<HomeController> logger, MovieAppDbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Movie> allMovies = this.dbContext
                .Movies
                .ToList();

            return View(allMovies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
