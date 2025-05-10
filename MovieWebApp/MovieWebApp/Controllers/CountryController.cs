using Microsoft.AspNetCore.Mvc;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.Web.ViewModels.Country;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryService countryService;

        public CountryController(ICountryService countryService)
        {
            this.countryService = countryService;
        }

        /// <summary>
        /// Retrieves all countries with optional search, filtering, and pagination.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> AllCountries(string searchQuery = "", string nameFilter = "", string descriptionFilter = "", int page = 1, int pageSize = 3)
        {
            var allCountries = await countryService.GetAllCountriesAsync();

            // 🔹 Filtering Logic
            if (!string.IsNullOrEmpty(searchQuery))
            {
                allCountries = allCountries.Where(c => c.Name.Contains(searchQuery) || c.Description.Contains(searchQuery)).ToList();
            }

            if (!string.IsNullOrEmpty(nameFilter))
            {
                allCountries = allCountries.Where(c => c.Name.Contains(nameFilter)).ToList();
            }

            if (!string.IsNullOrEmpty(descriptionFilter))
            {
                allCountries = allCountries.Where(c => c.Description.Contains(descriptionFilter)).ToList();
            }

            int totalCountries = allCountries.Count();
            int totalPages = (int)Math.Ceiling(totalCountries / (double)pageSize);

            var pagedCountries = allCountries
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var viewModel = new PaginatedCountriesViewModel
            {
                Countries = pagedCountries,
                CurrentPage = page,
                TotalPages = totalPages,
                PageSize = pageSize
            };

            var searchFilter = new SearchFilterCountryViewModel
            {
                SearchQuery = searchQuery,
                NameFilter = nameFilter,
                DescriptionFilter = descriptionFilter
            };

            ViewBag.SearchFilter = searchFilter;

            return View(viewModel);
        }

        /// <summary>
        /// Retrieves details for a specific country.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var country = await countryService.GetCountryDetailsAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            return View(country);
        }

        /// <summary>
        /// Returns the form to add a new country.
        /// </summary>
        [HttpGet]
        public IActionResult AddCountry()
        {
            return View(new AddCountryViewModel());
        }

        /// <summary>
        /// Handles adding a new country.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> AddCountry(AddCountryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await countryService.AddCountryAsync(model);
            return RedirectToAction(nameof(AllCountries));
        }

        /// <summary>
        /// Retrieves the edit form for a country.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var country = await countryService.GetEditModelAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            return View(country);
        }

        /// <summary>
        /// Handles editing a country's details.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Edit(EditCountryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool updated = await countryService.EditCountryAsync(model);
            if (!updated)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(AllCountries));
        }

        /// <summary>
        /// Retrieves the delete confirmation form for a country.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            var country = await countryService.GetCountryDetailsAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            return View(new DeleteCountryViewModel { Id = country.Id, Name = country.Name });
        }

        /// <summary>
        /// Handles deleting a country.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Delete(DeleteCountryViewModel model)
        {
            bool isDeleted = await countryService.DeleteCountryAsync(model.Id);
            if (!isDeleted)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(AllCountries));
        }
    }
}
