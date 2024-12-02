namespace MovieApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MovieApp.Data;
    using MovieApp.DataModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DirectorController : Controller
    {
        private readonly MovieAppDbContext dbContext;

        public DirectorController(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Authorize]
        [Route("Director/All")]
        public IActionResult AllDirectors()
        {
            var allDirectors = dbContext.Directors.ToList();
            return View(allDirectors);
        }

        [HttpGet]
        [Route("Director/Details/{id:guid}")]
        public async Task<IActionResult> Details(string id)
        {
            if (string.IsNullOrEmpty(id) || !Guid.TryParse(id, out Guid directorId))
            {
                return BadRequest("Invalid Director ID.");
            }

            var director = await dbContext.Directors.FindAsync(directorId);

            if (director == null)
            {
                return NotFound("Director not found.");
            }

            return View(director);
        }
    }
}
