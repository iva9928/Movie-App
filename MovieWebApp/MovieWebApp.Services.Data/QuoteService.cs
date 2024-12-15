using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Data
{
    public class QuoteService : IQuoteService
    {
        private readonly MovieAppDbContext dbContext;

        public QuoteService(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Quote>> GetAllQuoteAsync()
        {
            IEnumerable<Quote> allQuotes = await this.dbContext
            .Quotes
            .ToListAsync();
            return allQuotes;

        }

        public async Task<IEnumerable<Quote>> GetAllQuoteDetails(string id)
        {
            Quote? quote = await this.dbContext
           .Quotes
           .FindAsync(id);

            if (quote == null)
            {
                return Enumerable.Empty<Quote>();
            }
            return new List<Quote> { quote };

        }
    }
}
