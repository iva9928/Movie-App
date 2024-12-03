namespace MovieApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MovieApp.Data;
    using MovieApp.DataModels;
    using MovieWebApp.Services.Data.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DirectorController : Controller
    {
        private readonly MovieAppDbContext dbContext;

        private IDirectorService directorService;

        public DirectorController(MovieAppDbContext dbContext, IDirectorService directorService)
        {
            this.dbContext = dbContext;

            this.directorService
                = directorService;
        }

        [HttpGet]
        [Authorize]
        [Route("Director/All")]
        public async Task<IActionResult> AllDirectors()
        {
           
            IEnumerable<Director> allDirectors = await this.directorService.GetAllDirectorsAsync();

            return View(allDirectors);
        }

        [HttpGet]
        [Route("Director/Details/{id:guid}")]
        public async Task<IActionResult> Details(string id)
        {
            IEnumerable<Director> directors = await this.directorService.GetAllDirectorDetails(id);
            if (!directors.Any())
            {
                return NotFound();
            }
            var actor = directors.First();
            return View(directors);
        }
    }
}
