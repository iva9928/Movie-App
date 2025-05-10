using Microsoft.AspNetCore.Mvc;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.Web.ViewModels.Quote;
using MovieApp.DataModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Controllers
{
    public class QuoteController : Controller
    {
        private readonly IQuoteService quoteService;
        private const int DefaultPageSize = 3; // ✅ Default page size for pagination

        public QuoteController(IQuoteService quoteService)
        {
            this.quoteService = quoteService;
        }

        /// <summary>
        /// Displays all quotes with search, filtering, and pagination.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> AllQuotes(string searchQuery = "", string characterFilter = "", string movieFilter = "", int page = 1, int pageSize = 3)
        {
            var allQuotes = await quoteService.GetFilteredQuotesAsync(searchQuery, characterFilter, movieFilter);

            int totalQuotes = allQuotes.Count();
            int totalPages = (int)Math.Ceiling(totalQuotes / (double)pageSize);

            var pagedQuotes = allQuotes
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var viewModel = new PaginatedQuotesViewModel
            {
                Quotes = pagedQuotes,
                CurrentPage = page,
                TotalPages = totalPages,
                PageSize = pageSize
            };

            return View(viewModel);
        }

        /// <summary>
        /// Displays details of a single quote.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var quote = await quoteService.GetQuoteDetailsAsync(id);
            if (quote == null)
            {
                return NotFound();
            }

            var viewModel = new QuoteDetailsViewModel
            {
                Id = quote.Id.ToString(),
                Description = quote.Description,
                CharacterName = quote.CharacterName,
                MovieOrShow = quote.MovieOrShow,
                CharacterImageUrl = quote.CharacterImageUrl
            };

            return View(viewModel);
        }

        /// <summary>
        /// Returns the form to add a new quote.
        /// </summary>
        [HttpGet]
        public IActionResult AddQuote()
        {
            return View(new AddQuoteViewModel());
        }

        /// <summary>
        /// Handles adding a new quote.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> AddQuote(AddQuoteViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await quoteService.AddQuoteAsync(model);
            return RedirectToAction(nameof(AllQuotes));
        }

        /// <summary>
        /// Retrieves the edit form for a quote.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("Invalid Quote ID.");
            }

            var quote = await quoteService.GetEditModelAsync(id);
            if (quote == null)
            {
                return NotFound();
            }

            var viewModel = new EditQuoteViewModel
            {
                Id = quote.Id,
                Description = quote.Description,
                CharacterName = quote.CharacterName,
                MovieOrShow = quote.MovieOrShow
            };

            return View(viewModel);
        }

        /// <summary>
        /// Saves the edited quote data.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Edit(EditQuoteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool updated = await quoteService.EditQuoteAsync(model);
            if (!updated)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(AllQuotes));
        }

        /// <summary>
        /// Retrieves the delete confirmation form.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            var quote = await quoteService.GetQuoteDetailsAsync(id);
            if (quote == null)
                return NotFound();

            var deleteModel = new DeleteQuoteViewModel
            {
                Id = quote.Id,
                Description = quote.Description
            };

            return View(deleteModel);
        }

        /// <summary>
        /// Handles deleting a quote.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Delete(DeleteQuoteViewModel model)
        {
            bool isDeleted = await quoteService.DeleteQuoteAsync(model.Id);
            if (!isDeleted)
                return NotFound();

            return RedirectToAction(nameof(AllQuotes));
        }
    }
}
