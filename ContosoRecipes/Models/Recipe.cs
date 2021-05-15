using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoRecipes.Models
{
    public record Recipe
    {
        [JsonProperty("recipe_id")]
        public string RecipeId { get; init; }

        [Required]
        public string Title { get; init; }
        public string Description { get; init; }
        public IEnumerable<string> Directions { get; init; }
        public IEnumerable<string> Tags { get; init; }

        [Required]
        public IEnumerable<Ingredient> Ingredients { get; init; }
        public DateTime Update { get; init; }
    }

    public record Ingredient
    {
        public string Name { get; init; }
        public string Amount { get; init; }
        public string Unit { get; init; }
    }
}
