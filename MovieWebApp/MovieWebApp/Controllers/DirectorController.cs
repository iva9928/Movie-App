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
        //[Authorize]
        //[Route("Director/All")]
        public async Task<IActionResult> AllDirectors()
        {
           
            IEnumerable<Director> allDirectors = await this.directorService.GetAllDirectorsAsync();

            return View(allDirectors);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                var director = await this.directorService.GetAllDirectorDetails(id);
                if (director == null)
                {
                    return NotFound();
                }

                return View(director);
            }
            catch (ArgumentException ex)
            {
                // Handle invalid GUID error
                return BadRequest(ex.Message);
            }
        }


    }
}
