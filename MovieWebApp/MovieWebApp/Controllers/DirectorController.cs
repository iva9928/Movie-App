using Microsoft.AspNetCore.Mvc;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.Web.ViewModels.Director;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Controllers
{
    public class DirectorController : Controller
    {
        private readonly IDirectorService directorService;
        private const int DefaultPageSize = 3;

        public DirectorController(IDirectorService directorService)
        {
            this.directorService = directorService;
        }

        /// <summary>
        /// Shows all directors with pagination and filtering.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> AllDirectors(string searchQuery = "", string firstNameFilter = "", string surnameFilter = "", int page = 1, int pageSize = DefaultPageSize)
        {
            var allDirectors = await directorService.GetFilteredDirectorsAsync(searchQuery, firstNameFilter, surnameFilter);

            int totalDirectors = allDirectors.Count();
            int totalPages = (int)Math.Ceiling(totalDirectors / (double)pageSize);

            var pagedDirectors = allDirectors
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var viewModel = new PaginatedDirectorsViewModel
            {
                Directors = pagedDirectors,
                CurrentPage = page,
                TotalPages = totalPages,
                PageSize = pageSize
            };

            var searchFilter = new SearchFilterDirectorViewModel
            {
                SearchQuery = searchQuery,
                FirstNameFilter = firstNameFilter,
                SurnameFilter = surnameFilter
            };

            ViewBag.SearchFilter = searchFilter;

            return View(viewModel);
        }

        /// <summary>
        /// Displays form to add a new director.
        /// </summary>
        [HttpGet]
        public IActionResult AddDirector()
        {
            return View(new AddDirectorViewModel());
        }

        /// <summary>
        /// Handles form submission for adding a new director.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> AddDirector(AddDirectorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await directorService.AddDirectorAsync(model);
            return RedirectToAction(nameof(AllDirectors));
        }

        /// <summary>
        /// Displays director details.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                var director = await directorService.GetDirectorDetailsAsync(id);
                if (director == null)
                {
                    return NotFound();
                }

                return View(director); // Ensure this matches the expected ViewModel type
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Displays form to edit an existing director.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var director = await directorService.GetEditModelAsync(id);
            if (director == null)
            {
                return NotFound();
            }

            return View(director);
        }

        /// <summary>
        /// Handles form submission for editing a director.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Edit(EditDirectorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool updated = await directorService.EditDirectorAsync(model);
            if (!updated)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(AllDirectors));
        }

        /// <summary>
        /// Displays delete confirmation for a director.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            var director = await directorService.GetDirectorDetailsAsync(id);
            if (director == null)
            {
                return NotFound();
            }

            var deleteModel = new DeleteDirectorViewModel
            {
                Id = director.Id,
                FirstName = director.FirstName,
                Surname = director.Surname
            };

            return View(deleteModel);
        }

        /// <summary>
        /// Handles delete confirmation.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Delete(DeleteDirectorViewModel model)
        {
            bool isDeleted = await directorService.DeleteDirectorAsync(model.Id);
            if (!isDeleted)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(AllDirectors));
        }
    }
}
