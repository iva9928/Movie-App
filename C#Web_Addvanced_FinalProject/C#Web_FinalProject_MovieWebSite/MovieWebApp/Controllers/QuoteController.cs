
namespace MovieWebApp.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MovieApp.Data;
    using MovieApp.DataModels;

    public class QuoteController : Controller
    {

        private readonly MovieAppDbContext dbContext;
        public QuoteController(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Authorize]
        [Route("Quote/AllQuotes")]
        public IActionResult AllQuotes()
        {
            IEnumerable<Quote> allQuote = this.dbContext
                .Quotes
                .ToList();

            return View(allQuote);
        }

        [HttpGet]
        [Route("Quote/Details/{id:guid}")]
        public async Task<IActionResult> Details(string id)
        {
            if (string.IsNullOrEmpty(id) || !Guid.TryParse(id, out Guid countryId))
            {
                return BadRequest("Invalid ID");
            }

            Quote? quote = await this.dbContext
                .Quotes
                .FindAsync(countryId);

            if (quote == null)
            {
                return NotFound();
            }

            return View(quote);
        }


    }
}
