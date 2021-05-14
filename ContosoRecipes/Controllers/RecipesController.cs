using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ContosoRecipes.Models;

namespace ContosoRecipes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        public ActionResult GetRecipes([FromQuery] int count)
        {
            Recipe[] recipes= {
                new() {Title = "Oxtail"},
                new() { Title = "Curry Chicken"},
                new() {Title =  "Dumplings"}
                };

            if(!recipes.Any())
                return NotFound();
            return Ok(recipes.Take(count));

        }
        
        [HttpPost]
        public ActionResult CreateNewRecipe([FromBody] Recipe newRecipe)
        {
            bool badThingsHappened = false;
            if (badThingsHappened)
                return BadRequest();
            return Created("", newRecipe);
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
