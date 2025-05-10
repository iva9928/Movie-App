using Microsoft.AspNetCore.Mvc;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.Web.ViewModels.TVShows;
using MovieApp.DataModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Controllers
{
    public class TVShowsController : Controller
    {
        private readonly ITVShowsService tvShowsService;
        private const int DefaultPageSize = 3;

        public TVShowsController(ITVShowsService tvShowsService)
        {
            this.tvShowsService = tvShowsService;
        }

        [HttpGet]
        public async Task<IActionResult> AllTVShows(
            string searchQuery = "",
            string genreFilter = "",
            string countryFilter = "",
            int page = 1,
            int pageSize = DefaultPageSize)
        {
            var allTVShows = await tvShowsService.GetFilteredTVShowsAsync(searchQuery, genreFilter, countryFilter);
            int totalTVShows = allTVShows.Count();
            int totalPages = (int)Math.Ceiling(totalTVShows / (double)pageSize);

            var pagedTVShows = allTVShows
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(s => new TVShowAllViewModel
                {
                    Id = s.Id.ToString(),
                    Title = s.Title,
                    Genre = s.Genre,
                    Duration = s.Duration,
                    TVSeriesImageUrl = s.TVSeriesImageUrl
                })
                .ToList();

            var viewModel = new PaginatedTVShowsViewModel
            {
                TVShows = pagedTVShows,
                CurrentPage = page,
                TotalPages = totalPages,
                PageSize = pageSize
            };

            ViewBag.SearchFilter = new SearchFilterTVShowViewModel
            {
                SearchQuery = searchQuery,
                GenreFilter = genreFilter,
                CountryFilter = countryFilter
            };

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var tvShow = await tvShowsService.GetTVShowDetailsAsync(id);
            if (tvShow == null)
            {
                return NotFound();
            }

            var viewModel = new TVShowDetailsViewModel
            {
                Id = tvShow.Id.ToString(),
                Title = tvShow.Title,
                Genre = tvShow.Genre,
                Duration = tvShow.Duration,
                TVSeriesImageUrl = tvShow.TVSeriesImageUrl,
                ReleaseDate = tvShow.ReleaseDate,
                Casts = tvShow.Casts,
                Country = tvShow.Country,
                Production = tvShow.Production,
                Description = tvShow.Description
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult AddTVShow()
        {
            return View(new AddTVShowViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> AddTVShow(AddTVShowViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var tvShowData = new TVShows
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                Genre = model.Genre,
                ReleaseDate = model.ReleaseDate,
                Casts = model.Casts,
                Duration = model.Duration,
                Country = model.Country,
                Production = model.Production,
                TVSeriesImageUrl = model.TVSeriesImageUrl,
                Description = model.Description
            };

            await tvShowsService.AddTVShowAsync(tvShowData);
            return RedirectToAction(nameof(AllTVShows));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if (string.IsNullOrEmpty(id) || !Guid.TryParse(id, out _))
            {
                return BadRequest("Invalid TV Show ID.");
            }

            var tvShow = await tvShowsService.GetEditModelAsync(id);
            if (tvShow == null)
            {
                return NotFound();
            }

            var viewModel = new EditTVShowViewModel
            {
                Id = tvShow.Id.ToString(),
                Title = tvShow.Title,
                Genre = tvShow.Genre,
                ReleaseDate = tvShow.ReleaseDate,
                Casts = tvShow.Casts,
                Duration = tvShow.Duration,
                Country = tvShow.Country,
                Production = tvShow.Production,
                TVSeriesImageUrl = tvShow.TVSeriesImageUrl,
                Description = tvShow.Description
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditTVShowViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool updated = await tvShowsService.EditTVShowAsync(model);
            if (!updated)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(AllTVShows));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            var tvShow = await tvShowsService.GetTVShowDetailsAsync(id);
            if (tvShow == null)
            {
                return NotFound();
            }

            return View(new DeleteTVShowViewModel { Id = tvShow.Id.ToString(), Title = tvShow.Title });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteTVShowViewModel model)
        {
            bool isDeleted = await tvShowsService.DeleteTVShowAsync(model.Id);
            if (!isDeleted)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(AllTVShows));
        }
    }
}
