using Microsoft.AspNetCore.Mvc;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.Web.ViewModels.Actor;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorService actorService;
        private const int DefaultPageSize = 3;

        public ActorController(IActorService actorService)
        {
            this.actorService = actorService;
        }

        [HttpGet]
        public async Task<IActionResult> AllActors(string searchQuery = "", string firstNameFilter = "", string surnameFilter = "", string descriptionFilter = "", int page = 1, int pageSize = 3)
        {
            var allActors = await actorService.GetFilteredActorsAsync(searchQuery, firstNameFilter, surnameFilter, descriptionFilter);

            int totalActors = allActors.Count();
            int totalPages = (int)Math.Ceiling(totalActors / (double)pageSize);

            var pagedActors = allActors
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var viewModel = new PaginatedActorsViewModel
            {
                Actors = pagedActors,
                CurrentPage = page,
                TotalPages = totalPages,
                PageSize = pageSize
            };

            var searchFilter = new SearchFilterActorViewModel
            {
                SearchQuery = searchQuery,
                FirstNameFilter = firstNameFilter,
                SurnameFilter = surnameFilter,
                DescriptionFilter = descriptionFilter
            };

            ViewBag.SearchFilter = searchFilter;

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult AddActor()
        {
            return View(new AddActorViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> AddActor(AddActorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await actorService.AddActorAsync(model);
            return RedirectToAction(nameof(AllActors));
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                var actor = await actorService.GetActorDetailsAsync(id);
                if (actor == null)
                {
                    return NotFound();
                }

                return View("Details", actor); // Ensure this matches the view name
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
      

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            var actor = await actorService.GetActorDetailsAsync(id);
            if (actor == null)
            {
                return NotFound();
            }

            var deleteModel = new DeleteActorViewModel
            {
                Id = actor.Id,
                FirstName = actor.FirstName,
                Surname = actor.Surname
            };

            return View(deleteModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteActorViewModel model)
        {
            bool isDeleted = await actorService.DeleteActorAsync(model.Id);
            if (!isDeleted)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(AllActors));
        }
    }
}
