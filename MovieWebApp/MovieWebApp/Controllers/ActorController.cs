
namespace MovieWebApp.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MovieApp.Data;
    using MovieApp.DataModels;
    using MovieWebApp.Services.Data.Interfaces;
    public class ActorController : Controller
    {
        private readonly MovieAppDbContext dbContext;

        private IActorService actorService;

        public ActorController(MovieAppDbContext dbContext, IActorService actorService)
        {
            this.dbContext = dbContext;

            this.actorService
                = actorService;
        }

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> AllActors()
        {
            IEnumerable<Actor> allActors = await this.actorService.GetAllActorsAsync();
            return View(allActors);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                var actor = await this.actorService.GetAllActorsDetails(id);
                if (actor == null)
                {
                    return NotFound();
                }

                return View(actor);
            }
            catch (ArgumentException ex)
            {
                // Handle invalid GUID error
                return BadRequest(ex.Message);
            }
        }



    }
}
