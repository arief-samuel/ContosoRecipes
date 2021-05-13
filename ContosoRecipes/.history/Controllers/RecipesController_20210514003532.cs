using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ContosoRecipes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public RecipesController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult GetRecipes()
        {
            string[] recipes= {"Oxtail", "Curry Chicken", "Dumplings"};

            if(recipes.Any())
                return NotFound();
            return Ok(recipes);

        }

         [HttpDelete]
        public ActionResult DeleteRecipes()
        {
            bool badThingsHapened = false;

            if(badThingsHapened)
                return BadRequest();
            return NoContent();
        }
    }
}
