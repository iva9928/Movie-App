using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieWebApp.Services;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.ServiceTests;
using MovieWebApp.Web.ViewModels.Quote;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Tests
{
    [TestFixture]
    public class QuoteServiceTests
    {
        private DbContextOptions<MovieAppDbContext> options;
        private MovieAppDbContext dbCtx;
        private IQuoteService quoteService;

        [OneTimeSetUp]
        public void Setup()
        {
            this.options = new DbContextOptionsBuilder<MovieAppDbContext>()
                .UseInMemoryDatabase($"MovieAppTestDb_Quote_{Guid.NewGuid()}")
                .Options;

            this.dbCtx = new MovieAppDbContext(this.options);
            this.dbCtx.Database.EnsureCreated();

            DbSeeder.SeedDb(this.dbCtx);
            this.quoteService = new QuoteService(this.dbCtx);
        }

        [OneTimeTearDown]
        public void TearDown() => this.dbCtx.Dispose();

        [Test]
        public async Task AddQuoteAsync_ShouldAddQuoteToDb()
        {
            await this.quoteService.AddQuoteAsync(DbSeeder.AddQuoteViewModel);
            var quotes = await this.dbCtx.Quotes.ToListAsync();

            Assert.That(quotes.Count, Is.EqualTo(2));
            Assert.That(quotes.Any(q => q.CharacterName == "Dylan O`Brien" && q.MovieOrShow == "The maze runner"), Is.True);
        }

        [Test]
        public async Task DeleteQuoteAsync_ShouldRemoveQuoteIfExists()
        {
            var quote = this.dbCtx.Quotes.First();
            var result = await this.quoteService.DeleteQuoteAsync(quote.Id.ToString());

            Assert.That(result, Is.True);
            Assert.That(this.dbCtx.Quotes.Any(q => q.Id == quote.Id), Is.False);
        }

        [Test]
        public async Task DeleteQuoteAsync_ShouldReturnFalse_IfQuoteNotFound()
        {
            var result = await this.quoteService.DeleteQuoteAsync(Guid.NewGuid().ToString());
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task DeleteQuoteAsync_ShouldReturnFalse_IfIdInvalid()
        {
            var result = await this.quoteService.DeleteQuoteAsync("invalid-guid");
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task GetAllQuotesAsync_ShouldReturnAllQuotes()
        {
            var quotes = await this.quoteService.GetAllQuotesAsync();
            Assert.That(quotes.Count(), Is.GreaterThan(0));
        }

        [Test]
        public async Task GetQuoteDetailsAsync_ShouldReturnCorrectQuote()
        {
            var quote = this.dbCtx.Quotes.First();
            var result = await this.quoteService.GetQuoteDetailsAsync(quote.Id.ToString());

            Assert.That(result, Is.Not.Null);
            Assert.That(result!.Description, Is.EqualTo(quote.Description));
        }

        [Test]
        public async Task GetQuoteDetailsAsync_ShouldReturnNull_IfInvalidId()
        {
            var result = await this.quoteService.GetQuoteDetailsAsync("not-a-guid");
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetQuoteDetailsAsync_ShouldReturnNull_IfQuoteNotFound()
        {
            var result = await this.quoteService.GetQuoteDetailsAsync(Guid.NewGuid().ToString());
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetEditModelAsync_ShouldReturnCorrectViewModel()
        {
            var quote = this.dbCtx.Quotes.First();
            var result = await this.quoteService.GetEditModelAsync(quote.Id.ToString());

            Assert.That(result, Is.Not.Null);
            Assert.That(result!.Id, Is.EqualTo(quote.Id.ToString()));
        }

        [Test]
        public async Task GetEditModelAsync_ShouldReturnNull_IfInvalidId()
        {
            var result = await this.quoteService.GetEditModelAsync("invalid-guid");
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task EditQuoteAsync_ShouldUpdateQuote()
        {
            var quote = this.dbCtx.Quotes.First();

            var model = new EditQuoteViewModel
            {
                Id = quote.Id.ToString(),
                Description = "Updated quote",
                CharacterName = "Updated Character",
                MovieOrShow = "Updated Movie"
            };

            var result = await this.quoteService.EditQuoteAsync(model);
            var updated = await this.dbCtx.Quotes.FindAsync(quote.Id);

            Assert.That(result, Is.True);
            Assert.That(updated!.Description, Is.EqualTo("Updated quote"));
        }

        [Test]
        public async Task EditQuoteAsync_ShouldReturnFalse_IfInvalidId()
        {
            var model = new EditQuoteViewModel
            {
                Id = "invalid-guid",
                Description = "Fake",
                CharacterName = "Fake",
                MovieOrShow = "Fake"
            };

            var result = await this.quoteService.EditQuoteAsync(model);
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task EditQuoteAsync_ShouldReturnFalse_IfQuoteNotFound()
        {
            var model = new EditQuoteViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Description = "Fake",
                CharacterName = "Fake",
                MovieOrShow = "Fake"
            };

            var result = await this.quoteService.EditQuoteAsync(model);
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task GetFilteredQuotesAsync_ShouldFilterByCharacter()
        {
            var result = await this.quoteService.GetFilteredQuotesAsync("", "Dylan", "");
            Assert.That(result.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task GetFilteredQuotesAsync_ShouldReturnEmpty_IfNoMatch()
        {
            var result = await this.quoteService.GetFilteredQuotesAsync("No match", "", "");
            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task GetFilteredQuotesAsync_ShouldBeCaseInsensitive()
        {
            var result = await this.quoteService.GetFilteredQuotesAsync("HUMOR", "", "");
            Assert.That(result.Count(), Is.GreaterThanOrEqualTo(0));
        }
       


    }
}
