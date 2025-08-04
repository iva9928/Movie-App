using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieWebApp.Services;
using MovieWebApp.Services.Data.Interfaces;
using MovieWebApp.ServiceTests;
using MovieWebApp.Web.ViewModels.Actor;
using NUnit.Framework;
using System;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace MovieWebApp.Services.Tests
{
    [TestFixture]
    public class ActorServiceTests
    {
        private DbContextOptions<MovieAppDbContext> options;
        private MovieAppDbContext dbCtx;
        private IActorService actorService;

        [OneTimeSetUp]
        public void Setup()
        {
            this.options = new DbContextOptionsBuilder<MovieAppDbContext>()
                .UseInMemoryDatabase($"MovieAppTestDb_{Guid.NewGuid()}")
                .Options;

            this.dbCtx = new MovieAppDbContext(this.options);
            this.dbCtx.Database.EnsureCreated();

            DbSeeder.SeedDb(this.dbCtx);
            this.actorService = new ActorService(this.dbCtx);
        }

        [OneTimeTearDown]
        public void TearDown() => this.dbCtx.Dispose();

        [Test]
        public async Task AddActorAsync_ShouldAddActorToDb()
        {
            await this.actorService.AddActorAsync(DbSeeder.AddActorViewModel);
            var result = await this.dbCtx.Actors.ToListAsync();

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result.Any(a => a.FirstName == "Nina" && a.Surname == "Dobrev"), Is.True);
        }

        [Test]
        public async Task DeleteActorAsync_ShouldRemoveActorIfExists()
        {
            var actor = this.dbCtx.Actors.First();
            var result = await this.actorService.DeleteActorAsync(actor.Id.ToString());

            Assert.That(result, Is.True);
            Assert.That(this.dbCtx.Actors.Any(a => a.Id == actor.Id), Is.False);
        }

        [Test]
        public async Task DeleteActorAsync_ShouldReturnFalseIfNotExists()
        {
            var result = await this.actorService.DeleteActorAsync(Guid.NewGuid().ToString());
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task GetActorDetailsAsync_ShouldReturnCorrectData()
        {
            var actor = this.dbCtx.Actors.First();
            var result = await this.actorService.GetActorDetailsAsync(actor.Id.ToString());

            Assert.That(result, Is.Not.Null);
            Assert.That(result!.FirstName, Is.EqualTo(actor.FirstName));
        }

        [Test]
        public void GetActorDetailsAsync_ShouldThrowOnInvalidId()
        {
            Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await this.actorService.GetActorDetailsAsync("invalid-guid");
            });
        }

        [Test]
        public async Task EditActorAsync_ShouldUpdateIfExists()
        {
            var actor = this.dbCtx.Actors.First();

            var editModel = new EditActorViewModel
            {
                Id = actor.Id,
                FirstName = "Updated",
                Surname = "Name",
                Description = "Updated description",
                ActorImageUrl = actor.ActorImageUrl
            };

            var result = await this.actorService.EditActorAsync(editModel);
            var updated = await this.dbCtx.Actors.FindAsync(actor.Id);

            Assert.That(result, Is.True);
            Assert.That(updated!.FirstName, Is.EqualTo("Updated"));
            Assert.That(updated.Description, Is.EqualTo("Updated description"));
        }

        [Test]
        public async Task EditActorAsync_ShouldReturnFalseIfActorNotExists()
        {
            var model = new EditActorViewModel
            {
                Id = Guid.NewGuid(),
                FirstName = "Ghost",
                Surname = "Man",
                Description = "Not real",
                ActorImageUrl = "https://fake"
            };

            var result = await this.actorService.EditActorAsync(model);
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task GetEditModelAsync_ShouldReturnCorrectViewModel()
        {
            var actor = this.dbCtx.Actors.First();
            var model = await this.actorService.GetEditModelAsync(actor.Id.ToString());

            Assert.That(model, Is.Not.Null);
            Assert.That(model!.Id, Is.EqualTo(actor.Id));
        }

        [Test]
        public void GetEditModelAsync_ShouldThrowOnInvalidId()
        {
            Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await this.actorService.GetEditModelAsync("not-a-guid");
            });
        }

        [Test]
        public async Task GetAllActorsAsync_ShouldReturnAllActors()
        {
            var actors = await this.actorService.GetAllActorsAsync();
            Assert.That(actors.Count(), Is.GreaterThan(0));
        }
        //?
        [Test]
        public async Task GetFilteredActorsAsync_ShouldFilterBySearchQuery()
        {
            var results = await this.actorService.GetFilteredActorsAsync("Dylan", "", "", "");
            Assert.That(results.Count(), Is.EqualTo(1));
        }


        [Test]
        public async Task GetFilteredActorsAsync_ShouldFilterByFirstName()
        {
            DbSeeder.SeedDb(this.dbCtx);
            var results = await this.actorService.GetFilteredActorsAsync("", "Dylan", "", "");
            Assert.That(results.Count(), Is.EqualTo(2));
        }

        [Test]
        public async Task GetFilteredActorsAsync_ShouldReturnEmptyIfNoMatch()
        {
            var results = await this.actorService.GetFilteredActorsAsync("NoMatch", "", "", "");
            Assert.That(results, Is.Empty);
        }
        //[Test]
        //public async Task AddActorAsync_ShouldAddActorToDb()
        //{
        //    await this.actorService.AddActorAsync(DbSeeder.AddActorViewModel);
        //    var actor = this.dbCtx.Actors.FirstOrDefault(a => a.FirstName == "Nina");

        //    Assert.That(actor, Is.Not.Null);
        //    Assert.That(actor!.Surname, Is.EqualTo("Dobrev"));
        //}

        //[Test]
        //public async Task DeleteActorAsync_ShouldRemoveActorIfExists()
        //{
        //    var actor = this.dbCtx.Actors.First();
        //    var result = await this.actorService.DeleteActorAsync(actor.Id.ToString());

        //    Assert.That(result, Is.True);
        //    Assert.That(this.dbCtx.Actors.Any(a => a.Id == actor.Id), Is.False);
        //}

        [Test]
        public async Task DeleteActorAsync_ShouldReturnFalse_IfActorDoesNotExist()
        {
            var result = await this.actorService.DeleteActorAsync(Guid.NewGuid().ToString());
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task GetActorDetailsAsync_ShouldReturnCorrectActor()
        {
            var actor = this.dbCtx.Actors.First();
            var result = await this.actorService.GetActorDetailsAsync(actor.Id.ToString());

            Assert.That(result, Is.Not.Null);
            Assert.That(result!.FirstName, Is.EqualTo(actor.FirstName));
        }

        [Test]
        public void GetActorDetailsAsync_ShouldThrow_OnInvalidId()
        {
            Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await this.actorService.GetActorDetailsAsync("not-a-guid");
            });
        }

        [Test]
        public async Task EditActorAsync_ShouldUpdateActor()
        {
            var actor = this.dbCtx.Actors.First();

            var model = new EditActorViewModel
            {
                Id = actor.Id,
                FirstName = "Updated",
                Surname = actor.Surname,
                Description = "New description",
                ActorImageUrl = actor.ActorImageUrl
            };

            var result = await this.actorService.EditActorAsync(model);
            var updated = await this.dbCtx.Actors.FindAsync(actor.Id);

            Assert.That(result, Is.True);
            Assert.That(updated!.FirstName, Is.EqualTo("Updated"));
        }

        [Test]
        public async Task EditActorAsync_ShouldReturnFalse_IfActorNotFound()
        {
            var model = new EditActorViewModel
            {
                Id = Guid.NewGuid(),
                FirstName = "Ghost",
                Surname = "Man",
                Description = "None",
                ActorImageUrl = "https://image"
            };

            var result = await this.actorService.EditActorAsync(model);
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task GetEditModelAsync_ShouldReturnViewModel()
        {
            var actor = this.dbCtx.Actors.First();
            var result = await this.actorService.GetEditModelAsync(actor.Id.ToString());

            Assert.That(result, Is.Not.Null);
            Assert.That(result!.Id, Is.EqualTo(actor.Id));
        }

        [Test]
        public void GetEditModelAsync_ShouldThrow_OnInvalidGuid()
        {
            Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await this.actorService.GetEditModelAsync("invalid-guid");
            });
        }

        [Test]
        public async Task GetFilteredActorsAsync_ShouldReturnBySurname()
        {
            var result = await this.actorService.GetFilteredActorsAsync("", "", "O`Brien", "");
            Assert.That(result.Count(), Is.EqualTo(1));
        }
        [Test]
        public async Task AddActorAsync_ShouldAddNewActor()
        {
            await this.actorService.AddActorAsync(DbSeeder.AddActorViewModel);
            var actor = await this.dbCtx.Actors.FirstOrDefaultAsync(a => a.FirstName == "Nina");

            Assert.That(actor, Is.Not.Null);
            Assert.That(actor!.Surname, Is.EqualTo("Dobrev"));
        }

        [Test]
        public void GetActorDetailsAsync_InvalidId_ShouldThrowArgumentException()
        {
            Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await this.actorService.GetActorDetailsAsync("not-a-valid-guid");
            });
        }

        [Test]
        public async Task GetActorDetailsAsync_UnknownId_ShouldReturnNull()
        {
            var result = await this.actorService.GetActorDetailsAsync(Guid.NewGuid().ToString());
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task DeleteActorAsync_ShouldDeleteActorIfExists()
        {
            var actor = this.dbCtx.Actors.First();
            var result = await this.actorService.DeleteActorAsync(actor.Id.ToString());

            Assert.That(result, Is.True);
            Assert.That(await this.dbCtx.Actors.FindAsync(actor.Id), Is.Null);
        }

        [Test]
        public async Task DeleteActorAsync_NonExisting_ShouldReturnFalse()
        {
            var result = await this.actorService.DeleteActorAsync(Guid.NewGuid().ToString());
            Assert.That(result, Is.False);
        }

        [Test]
        public void DeleteActorAsync_InvalidId_ShouldThrow()
        {
            Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await this.actorService.DeleteActorAsync("not-a-guid");
            });
        }

        [Test]
        public async Task EditActorAsync_ShouldEditIfExists()
        {
            var actor = this.dbCtx.Actors.First();

            var model = new EditActorViewModel
            {
                Id = actor.Id,
                FirstName = "Changed",
                Surname = actor.Surname,
                Description = "Changed desc",
                ActorImageUrl = actor.ActorImageUrl
            };

            var result = await this.actorService.EditActorAsync(model);
            var updated = await this.dbCtx.Actors.FindAsync(actor.Id);

            Assert.That(result, Is.True);
            Assert.That(updated!.FirstName, Is.EqualTo("Changed"));
        }

        [Test]
        public async Task EditActorAsync_NonExistent_ShouldReturnFalse()
        {
            var model = new EditActorViewModel
            {
                Id = Guid.NewGuid(),
                FirstName = "Ghost",
                Surname = "Actor",
                Description = "None",
                ActorImageUrl = "https://none"
            };

            var result = await this.actorService.EditActorAsync(model);
            Assert.That(result, Is.False);
        }

        [Test]
        public async Task GetEditModelAsync_ShouldReturnCorrectData()
        {
            var actor = this.dbCtx.Actors.First();
            var result = await this.actorService.GetEditModelAsync(actor.Id.ToString());

            Assert.That(result, Is.Not.Null);
            Assert.That(result!.Id, Is.EqualTo(actor.Id));
        }

        [Test]
        public void GetEditModelAsync_InvalidId_ShouldThrow()
        {
            Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await this.actorService.GetEditModelAsync("bad-guid");
            });
        }
        //?
        [Test]
        public async Task GetFilteredActorsAsync_ShouldFilterBySurname()
        {
        
            var result = await this.actorService.GetFilteredActorsAsync("", "", "O`Brien", "");
            Assert.That(result.Count(), Is.EqualTo(1));
        }
        //?
        [Test]
        public async Task GetFilteredActorsAsync_ShouldFilterByDescription()
        {
         
            var result = await this.actorService.GetFilteredActorsAsync("", "", "", "TeenWolf");
            Assert.That(result.Count(), Is.EqualTo(1));
        }


    }
}
