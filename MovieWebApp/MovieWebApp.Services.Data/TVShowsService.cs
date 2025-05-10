using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.Web.ViewModels.Quote;
using MovieWebApp.Web.ViewModels.TVShows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Services
{
    public class TVShowsService : ITVShowsService
    {
        private readonly MovieAppDbContext dbContext;

        public TVShowsService(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<TVShows>> GetFilteredTVShowsAsync(string searchQuery, string genreFilter, string countryFilter)
        {
            var query = dbContext.TVShows.AsQueryable();

            if (!string.IsNullOrEmpty(searchQuery))
                query = query.Where(s => EF.Functions.Like(s.Title, $"%{searchQuery}%"));

            if (!string.IsNullOrEmpty(genreFilter))
                query = query.Where(s => EF.Functions.Like(s.Genre, $"%{genreFilter}%"));

            if (!string.IsNullOrEmpty(countryFilter))
                query = query.Where(s => EF.Functions.Like(s.Country, $"%{countryFilter}%"));

            return await query.ToListAsync();
        }

        public async Task<TVShows?> GetTVShowDetailsAsync(string id)
        {
            if (!Guid.TryParse(id, out Guid showId))
                return null;

            return await dbContext.TVShows.FindAsync(showId);
        }

        public async Task AddTVShowAsync(TVShows tvShow)
        {
            dbContext.TVShows.Add(tvShow);
            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteTVShowAsync(string id)
        {
            if (!Guid.TryParse(id, out Guid showId))
                return false;

            var tvShow = await dbContext.TVShows.FindAsync(showId);
            if (tvShow == null)
                return false;

            dbContext.TVShows.Remove(tvShow);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<TVShows?> GetEditModelAsync(string id)
        {
            return await dbContext.TVShows.FindAsync(Guid.Parse(id));
        }

        public async Task<bool> EditTVShowAsync(EditTVShowViewModel model)
        {
            var tvShow = await dbContext.TVShows.FindAsync(Guid.Parse(model.Id));
            if (tvShow == null)
                return false;

            tvShow.Title = model.Title;
            tvShow.Genre = model.Genre;
            tvShow.Description = model.Description;

            await dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<Quote?> GetQuoteByIdAsync(string id)
        {
            if (!Guid.TryParse(id, out Guid quoteId))
                return null;

            return await dbContext.Quotes.FindAsync(quoteId);
        }

        public async Task<bool> UpdateQuoteAsync(EditQuoteViewModel model)
        {
            if (!Guid.TryParse(model.Id, out Guid quoteId))
                return false;

            var existingQuote = await dbContext.Quotes.FindAsync(quoteId);
            if (existingQuote == null)
                return false;

            existingQuote.Description = model.Description;
            existingQuote.CharacterName = model.CharacterName;
            existingQuote.MovieOrShow = model.MovieOrShow;

            await dbContext.SaveChangesAsync();
            return true;
        }
    }
}
