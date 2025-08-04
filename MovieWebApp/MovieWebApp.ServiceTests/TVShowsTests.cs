
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.DataModels;
using MovieWebApp.Services;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.ServiceTests;
using MovieWebApp.Web.ViewModels.Quote;
using MovieWebApp.Web.ViewModels.TVShows;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Tests
{
    [TestFixture]
    public class TVShowsServiceTests
    {
        private DbContextOptions<MovieAppDbContext> options;
        private MovieAppDbContext dbCtx;
        private ITVShowsService service;

        [OneTimeSetUp]
        public void Setup()
        {
            options = new DbContextOptionsBuilder<MovieAppDbContext>()
                .UseInMemoryDatabase($"MovieAppTestDb_TVShows_{Guid.NewGuid()}")
                .Options;

            dbCtx = new MovieAppDbContext(options);
            dbCtx.Database.EnsureCreated();
            DbSeeder.SeedDb(dbCtx);
            dbCtx.TVShows.Add(DbSeeder.TVShows);
            dbCtx.SaveChanges();
            service = new TVShowsService(dbCtx);
        }

        [OneTimeTearDown]
        public void TearDown() => dbCtx.Dispose();

        [Test]
        public async Task GetFilteredTVShowsAsync_ShouldReturnMatchingByTitle()
        {
            var result = await service.GetFilteredTVShowsAsync("Teen Wolf", "", "");
            Assert.That(result.Count(), Is.EqualTo(2));
        }

        [Test]
        public async Task GetFilteredTVShowsAsync_ShouldReturnMatchingByGenre()
        {
            var result = await service.GetFilteredTVShowsAsync("", "Action", "");
            Assert.That(result.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task GetFilteredTVShowsAsync_ShouldReturnMatchingByCountry()
        {
            var result = await service.GetFilteredTVShowsAsync("", "", "United States");
            Assert.That(result.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task GetFilteredTVShowsAsync_ShouldReturnEmptyIfNoMatch()
        {
            var result = await service.GetFilteredTVShowsAsync("NotFound", "None", "Nowhere");
            Assert.That(result, Is.Empty);
        }

        //[Test]
        //public async Task GetTVShowDetailsAsync_ShouldReturnCorrectTVShow()
        //{
        //    var id = dbCtx.TVShows.First().Id.ToString();
        //    var result = await service.GetTVShowDetailsAsync(id);

        //    Assert.That(result, Is.Not.Null);
        //    Assert.That(result!.Title, Is.EqualTo("Updated Show"));
        //}

        [Test]
        public async Task GetTVShowDetailsAsync_ShouldReturnNull_IfInvalidGuid()
        {
            var result = await service.GetTVShowDetailsAsync("not-a-guid");
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task AddTVShowAsync_ShouldAddTVShow()
        {
            var tvShow = new TVShows
            {
                Title = "New Show",
                Genre = "Drama",
                ReleaseDate = DateTime.Now,
                Casts = "Some Actor",
                Duration = 50,
                Country = "France",
                Production = "France TV",
                TVSeriesImageUrl = "https://image.com/show.jpg",
                Description = "A dramatic show"
            };

            await service.AddTVShowAsync(tvShow);
            Assert.That(dbCtx.TVShows.Any(t => t.Title == "New Show"), Is.True);
        }

        [Test]
        public async Task DeleteTVShowAsync_ShouldRemoveTVShow()
        {
            var show = new TVShows
            {
                Id = Guid.NewGuid(),
                Title = "Temp Show",
                Genre = "Thriller",
                ReleaseDate = DateTime.Now,
                Casts = "X Y",
                Duration = 40,
                Country = "Germany",
                Production = "Z Prod",
                TVSeriesImageUrl = "https://img.com/temp.jpg",
                Description = "Temp description"
            };
            dbCtx.TVShows.Add(show);
            await dbCtx.SaveChangesAsync();

            var result = await service.DeleteTVShowAsync(show.Id.ToString());
            Assert.That(result, Is.True);
            Assert.That(dbCtx.TVShows.Any(s => s.Id == show.Id), Is.False);
        }

        [Test]
        public async Task DeleteTVShowAsync_ShouldReturnFalse_IfInvalidId()
        {
            var result = await service.DeleteTVShowAsync("invalid-guid");
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task DeleteTVShowAsync_ShouldReturnFalse_IfNotFound()
        {
            var result = await service.DeleteTVShowAsync(Guid.NewGuid().ToString());
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task EditTVShowAsync_ShouldUpdateShow()
        {
            var tvShow = dbCtx.TVShows.First();
            var model = new EditTVShowViewModel
            {
                Id = tvShow.Id.ToString(),
                Title = "Updated Show",
                Genre = tvShow.Genre,
                Description = "Updated description"
            };

            var result = await service.EditTVShowAsync(model);
            var updated = await dbCtx.TVShows.FindAsync(tvShow.Id);

            Assert.That(result, Is.True);
            Assert.That(updated!.Title, Is.EqualTo("Updated Show"));
            Assert.That(updated.Description, Is.EqualTo("Updated description"));
        }

        [Test]
        public async Task EditTVShowAsync_ShouldReturnFalse_IfShowNotExists()
        {
            var model = new EditTVShowViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Non-Existent",
                Genre = "None",
                Description = "None"
            };

            var result = await service.EditTVShowAsync(model);
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task GetEditModelAsync_ShouldReturnTVShowModel()
        {
            var tvShow = dbCtx.TVShows.First();
            var result = await service.GetEditModelAsync(tvShow.Id.ToString());

            Assert.That(result, Is.Not.Null);
            Assert.That(result!.Id, Is.EqualTo(tvShow.Id));
        }


    }
}
