namespace MovieApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MovieWebApp.Services.Data.Interfaces;
    using MovieApp.DataModels;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("Country")]
    public class CountryController : Controller
    {
        private readonly ICountryService countryService;

        public CountryController(ICountryService countryService)
        {
            this.countryService = countryService;
        }

        [HttpGet]
        [Authorize]
        [Route("AllCountries")]
        public async Task<IActionResult> AllCountries()
        {
            var allCountries = await this.countryService.GetAllCountriesAsync();
            return View(allCountries);
        }

        [HttpGet]
        [Route("Details/{id:guid}")]
        public async Task<IActionResult> Details(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest("Country ID cannot be null or empty.");
            }

            var country = await this.countryService.GetCountryDetailsAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            return View(country);
        }
    }
}
