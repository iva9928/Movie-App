namespace MovieApp.Web.Controllers
{
    using Data;
    using DataModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    public class CountryController : Controller
    {
        private readonly MovieAppDbContext dbContext;

        public CountryController(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Authorize]
        [Route("Country/All")]
        public IActionResult AllCountries()
        {
            IEnumerable<Country> allCountries = this.dbContext
                .Countries
                .ToList();

            return View(allCountries);
        }

        [HttpGet]
        [Route("Country/Details/{id:guid}")]
        public async Task<IActionResult> Details(string id)
        {
            if (string.IsNullOrEmpty(id) || !Guid.TryParse(id, out Guid countryId))
            {
                return BadRequest("Invalid ID");
            }

            Country? country = await this.dbContext
                .Countries
                .FindAsync(countryId);

            if (country == null)
            {
                return NotFound();
            }

            return View(country);
        }
    }
}