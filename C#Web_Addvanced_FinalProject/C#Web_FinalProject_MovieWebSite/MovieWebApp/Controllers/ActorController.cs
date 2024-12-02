
namespace MovieWebApp.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MovieApp.Data;
    using MovieApp.DataModels;

    public class ActorController : Controller
    {

        private readonly MovieAppDbContext dbContext;
        public ActorController(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Authorize]
        public IActionResult AllActors()
        {
            IEnumerable<Actor> allActors = this.dbContext
                .Actors
                .ToList();

            return View(allActors);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            Actor? actor = await this.dbContext
                .Actors
                .FindAsync(Guid.Parse(id));

            if (actor == null)
            {
                return NotFound();
            }

            return View(actor);
        }
    }
}
