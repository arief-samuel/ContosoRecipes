using ContosoRecipes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoRecipes.Data
{
    public interface IRecipeDataStore
    {
        public Task<IEnumerable<T>> GetRandomRecipes<T>(int count);
        public Task<T> GetRecipeById<T>(string id);
        public Task<IEnumerable<T>> GetRecipesById<T>(string ids);
        public Task<IEnumerable<T>> SearchRecipesByIngredients<T>(string[] ingredients);
        public Task<IEnumerable<T>> SearchRecipesByTags<T>(string[] tags);
        public Task UpdateRecipe(Recipe recipe);
        public Task RemoveRecipe(string recipe_id);
    }
}
