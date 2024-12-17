using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;

namespace MovieWebApp.Controllers
{
    public class TVShowsController : Controller
    {
        private readonly ITVShowsService tvShowsService;

        public TVShowsController(ITVShowsService tvShowsService)
        {
            this.tvShowsService = tvShowsService;
        }

        // Get all TV shows
        [HttpGet]
        public async Task<IActionResult> AllTVShows()
        {
            var allTVShows = await this.tvShowsService.GetAllTVShowsAsync();
            return View(allTVShows);
        }

        // Get TV show details
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                var tvShow = await this.tvShowsService.GetTVShowDetailsAsync(id);
                if (tvShow == null)
                {
                    return NotFound();
                }

                return View(tvShow);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Add TV show (GET)
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult AddTVShow()
        {
            return View();
        }

        // Add TV show (POST)
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddTVShow(TVShows tvShow)
        {
            if (!ModelState.IsValid)
            {
                return View(tvShow);
            }

            await this.tvShowsService.AddTVShowAsync(tvShow);
            return RedirectToAction(nameof(AllTVShows));
        }

        // Delete TV show
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteTVShow(string id)
        {
            try
            {
                bool isDeleted = await this.tvShowsService.DeleteTVShowAsync(id);

                if (!isDeleted)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(AllTVShows));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
