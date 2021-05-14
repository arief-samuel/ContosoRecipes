using System;
using System.Collections.Generic;

namespace ContosoRecipes.Models
{
    public record Recipe
    {
        public string Title { get; init; }
        public string Description { get; init; }
        public IEnumerable<string> Directions { get; init; }
        public IEnumerable<string> Ingredients { get; init; }
        public DateTime Update { get; init; }
    }
}
