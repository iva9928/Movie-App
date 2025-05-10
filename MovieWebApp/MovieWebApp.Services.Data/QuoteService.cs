using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.Web.ViewModels.Quote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly MovieAppDbContext dbContext;

        public QuoteService(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// Retrieves all quotes.
        /// </summary>
        public async Task<IEnumerable<QuoteAllViewModel>> GetAllQuotesAsync()
        {
            return await dbContext.Quotes
                .Select(q => new QuoteAllViewModel
                {
                    Id = q.Id.ToString(),
                    Description = q.Description,
                    CharacterName = q.CharacterName,
                    MovieOrShow = q.MovieOrShow
                })
                .ToListAsync();
        }

        /// <summary>
        /// Retrieves details for a specific quote.
        /// </summary>
        public async Task<QuoteDetailsViewModel?> GetQuoteDetailsAsync(string id)
        {
            if (!Guid.TryParse(id, out var quoteId))
            {
                return null;
            }

            return await dbContext.Quotes
                .Where(q => q.Id == quoteId)
                .Select(q => new QuoteDetailsViewModel
                {
                    Id = q.Id.ToString(),
                    Description = q.Description,
                    CharacterName = q.CharacterName,
                    MovieOrShow = q.MovieOrShow,
                    CharacterImageUrl = q.CharacterImageUrl
                })
                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// Adds a new quote.
        /// </summary>
        public async Task AddQuoteAsync(AddQuoteViewModel model)
        {
            var quote = new Quote
            {
                Id = Guid.NewGuid(),
                Description = model.Description,
                CharacterName = model.CharacterName,
                MovieOrShow = model.MovieOrShow,
                CharacterImageUrl = model.CharacterImageUrl
            };

            dbContext.Quotes.Add(quote);
            await dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes a quote by ID.
        /// </summary>
        public async Task<bool> DeleteQuoteAsync(string id)
        {
            if (!Guid.TryParse(id, out var quoteId))
            {
                return false;
            }

            var quote = await dbContext.Quotes.FindAsync(quoteId);
            if (quote == null)
            {
                return false;
            }

            dbContext.Quotes.Remove(quote);
            await dbContext.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Retrieves a quote for editing.
        /// </summary>
        public async Task<EditQuoteViewModel?> GetEditModelAsync(string id)
        {
            if (!Guid.TryParse(id, out var quoteId))
            {
                return null;
            }

            return await dbContext.Quotes
                .Where(q => q.Id == quoteId)
                .Select(q => new EditQuoteViewModel
                {
                    Id = q.Id.ToString(),
                    Description = q.Description,
                    CharacterName = q.CharacterName,
                    MovieOrShow = q.MovieOrShow
                })
                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// Edits an existing quote.
        /// </summary>
        public async Task<bool> EditQuoteAsync(EditQuoteViewModel model)
        {
            if (!Guid.TryParse(model.Id, out var quoteId))
            {
                return false;
            }

            var quote = await dbContext.Quotes.FindAsync(quoteId);
            if (quote == null)
            {
                return false;
            }

            quote.Description = model.Description;
            quote.CharacterName = model.CharacterName;
            quote.MovieOrShow = model.MovieOrShow;

            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<QuoteAllViewModel>> GetFilteredQuotesAsync(string searchQuery, string characterFilter, string movieFilter)
        {
            var query = dbContext.Quotes.AsQueryable();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                query = query.Where(q => q.Description.Contains(searchQuery));
            }

            if (!string.IsNullOrEmpty(characterFilter))
            {
                query = query.Where(q => q.CharacterName.Contains(characterFilter));
            }

            if (!string.IsNullOrEmpty(movieFilter))
            {
                query = query.Where(q => q.MovieOrShow.Contains(movieFilter));
            }

            return await query.Select(q => new QuoteAllViewModel
            {
                Id = q.Id.ToString(),
                Description = q.Description,
                CharacterName = q.CharacterName,
                MovieOrShow = q.MovieOrShow
            }).ToListAsync();
        }


    }
}
