using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieWebApp.Services;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.ServiceTests;
using MovieWebApp.Web.ViewModels.Country;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Tests
{
    [TestFixture]
    public class CountryServiceTests
    {
        private DbContextOptions<MovieAppDbContext> options;
        private MovieAppDbContext dbCtx;
        private ICountryService countryService;

        [OneTimeSetUp]
        public void Setup()
        {
            this.options = new DbContextOptionsBuilder<MovieAppDbContext>()
                .UseInMemoryDatabase($"MovieAppTestDb_Country_{Guid.NewGuid()}")
                .Options;

            this.dbCtx = new MovieAppDbContext(this.options);
            this.dbCtx.Database.EnsureCreated();

            DbSeeder.SeedDb(this.dbCtx);
            this.countryService = new CountryService(this.dbCtx);
        }

        [OneTimeTearDown]
        public void TearDown() => this.dbCtx.Dispose();

        [Test]
        public async Task AddCountryAsync_ShouldAddCountryToDb()
        {
            await this.countryService.AddCountryAsync(DbSeeder.AddCountryViewModel);
            var countries = await this.dbCtx.Countries.ToListAsync();

            Assert.That(countries.Count, Is.EqualTo(2));
            Assert.That(countries.Any(c => c.Name == "UK"), Is.True);
        }

        [Test]
        public async Task DeleteCountryAsync_ShouldDeleteExistingCountry()
        {
            var country = this.dbCtx.Countries.First();
            var result = await this.countryService.DeleteCountryAsync(country.Id.ToString());

            Assert.That(result, Is.True);
            Assert.That(this.dbCtx.Countries.Any(c => c.Id == country.Id), Is.False);
        }

        [Test]
        public async Task DeleteCountryAsync_ShouldReturnFalse_IfCountryDoesNotExist()
        {
            var result = await this.countryService.DeleteCountryAsync(Guid.NewGuid().ToString());
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task GetAllCountriesAsync_ShouldReturnAllCountries()
        {
            DbSeeder.SeedDb(this.dbCtx);
            var countries = await this.countryService.GetAllCountriesAsync();

            Assert.That(countries, Is.Not.Null);
            Assert.That(countries.Count(), Is.GreaterThan(0));
        }

        [Test]
        public async Task GetCountryDetailsAsync_ShouldReturnCorrectCountry()
        {
            var country = this.dbCtx.Countries.First();
            var result = await this.countryService.GetCountryDetailsAsync(country.Id.ToString());

            Assert.That(result, Is.Not.Null);
            Assert.That(result!.Name, Is.EqualTo(country.Name));
        }

        [Test]
        public async Task GetCountryDetailsAsync_ShouldReturnNull_IfInvalidId()
        {
            var result = await this.countryService.GetCountryDetailsAsync("invalid-guid");
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task EditCountryAsync_ShouldUpdateCountry()
        {
            var country = this.dbCtx.Countries.First();

            var model = new EditCountryViewModel
            {
                Id = country.Id.ToString(),
                Name = "UpdatedName",
                Description = "UpdatedDesc",
                CountryImageUrl = country.CountryImageUrl
            };

            var result = await this.countryService.EditCountryAsync(model);
            var updated = await this.dbCtx.Countries.FindAsync(country.Id);

            Assert.That(result, Is.True);
            Assert.That(updated!.Name, Is.EqualTo("UpdatedName"));
        }

        [Test]
        public async Task EditCountryAsync_ShouldReturnFalse_IfInvalidId()
        {
            var model = new EditCountryViewModel
            {
                Id = "invalid-guid",
                Name = "Fake",
                Description = "Fake Desc",
                CountryImageUrl = "https://fake.com/image.jpg"
            };

            var result = await this.countryService.EditCountryAsync(model);
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task EditCountryAsync_ShouldReturnFalse_IfCountryNotFound()
        {
            var model = new EditCountryViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Fake",
                Description = "Fake Desc",
                CountryImageUrl = "https://fake.com/image.jpg"
            };

            var result = await this.countryService.EditCountryAsync(model);
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task GetEditModelAsync_ShouldReturnCorrectViewModel()
        {
            var country = this.dbCtx.Countries.First();
            var result = await this.countryService.GetEditModelAsync(country.Id.ToString());

            Assert.That(result, Is.Not.Null);
            Assert.That(result!.Id, Is.EqualTo(country.Id.ToString()));
        }

        [Test]
        public async Task GetEditModelAsync_ShouldReturnNull_IfInvalidId()
        {
            var result = await this.countryService.GetEditModelAsync("invalid-guid");
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetEditModelAsync_ShouldReturnNull_IfCountryNotFound()
        {
            var result = await this.countryService.GetEditModelAsync(Guid.NewGuid().ToString());
            Assert.That(result, Is.Null);
        }
        [Test]
        public async Task DeleteCountryAsync_ShouldReturnFalse_IfIdInvalid()
        {
            var result = await this.countryService.DeleteCountryAsync("not-a-guid");
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task GetAllCountriesAsync_ShouldReturnEmpty_WhenNoCountriesExist()
        {
            this.dbCtx.Countries.RemoveRange(this.dbCtx.Countries);
            await this.dbCtx.SaveChangesAsync();

            var result = await this.countryService.GetAllCountriesAsync();
            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task GetCountryDetailsAsync_ShouldReturnNull_IfCountryNotFound()
        {
            var result = await this.countryService.GetCountryDetailsAsync(Guid.NewGuid().ToString());
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task EditCountryAsync_ShouldUpdateDescriptionOnly()
        {
            var country = this.dbCtx.Countries.First();

            var model = new EditCountryViewModel
            {
                Id = country.Id.ToString(),
                Name = country.Name,
                Description = "Just Updated Description",
                CountryImageUrl = country.CountryImageUrl
            };

            var result = await this.countryService.EditCountryAsync(model);
            var updated = await this.dbCtx.Countries.FindAsync(country.Id);

            Assert.That(result, Is.True);
            Assert.That(updated!.Description, Is.EqualTo("Just Updated Description"));
        }

    }
}
