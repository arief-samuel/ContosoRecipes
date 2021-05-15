using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ContosoRecipes.Models;
using ContosoRecipes.Data;
using Microsoft.AspNetCore.JsonPatch;

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
        private readonly IRecipeDataStore _recipeData;

        public RecipesController(IRecipeDataStore recipeData)
        {
            _recipeData = recipeData;
        }

        [HttpGet]
        public async Task<ActionResult> GetRecipes([FromQuery] int count)
        {
            if(count <= 0)
            {
                throw new ArgumentException("Invalid Count", nameof(count));
            }
            var recipes = await _recipeData.GetRandomRecipes<Recipe>(count);
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
        
        [HttpPatch("{id)")]
        public async Task<ActionResult> UpdateRecipe(string  id,  JsonPatchDocument<Recipe> recipeUpdate)
        {
            var recipe = await _recipeData.GetRecipeById<Recipe>(id);

            if (recipe == null)
                return NotFound();
            recipeUpdate.ApplyTo(recipe);
            await _recipeData.UpdateRecipe(recipe);

            return NoContent();
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
