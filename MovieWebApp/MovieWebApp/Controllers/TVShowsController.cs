
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;

namespace MovieWebApp.Controllers
{
    public class TVShowsController : Controller
    {
        private readonly MovieAppDbContext dbContext;

        private ITVShowsService TVshowsService;

        public TVShowsController(MovieAppDbContext dbContext, ITVShowsService TVshowsService)
        {
            this.dbContext = dbContext;

            this.TVshowsService
                = TVshowsService;
        }

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> AllTvShows()
        {
            IEnumerable<TVShows> allTVShows = await this.TVshowsService.GetAllTVShowsAsync();
            return View(allTVShows);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            IEnumerable<TVShows> TVshows = await this.TVshowsService.GetAllTVShowsDetails(id);
            if (!TVshows.Any())
            {
                return NotFound();
            }
            var TVshow = TVshows.First();
            return View(TVshow);
        }
        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteTVShow(string id)
        {
            bool isDeleted = await this.TVshowsService.DeleteTVShowsAsync(id);

            if (!isDeleted)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(AllTvShows));
        }
        [HttpGet]
        //[Authorize(Roles = "Admin")]
        public IActionResult AddTVShow()
        {
            return View();
        }

        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddTVShow(TVShows tvShow)
        {
            if (!ModelState.IsValid)
            {
                return View(tvShow);
            }

            await this.TVshowsService.AddTVShowsAsync(tvShow);
            return RedirectToAction(nameof(AllTvShows));
        }

    }
}
