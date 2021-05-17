using ContosoRecipes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoRecipes.Data
{
    public interface IRecipeDataStore
    {
         Task<IEnumerable<T>> GetRandomRecipes<T>(int count);
         Task<T> GetRecipeById<T>(string id);
         Task<IEnumerable<T>> GetRecipesById<T>(string ids);
         Task<IEnumerable<T>> SearchRecipesByIngredients<T>(string[] ingredients);
         Task<IEnumerable<T>> SearchRecipesByTags<T>(string[] tags);
         Task UpdateRecipe(Recipe recipe);
         Task RemoveRecipe(string recipe_id);
    }
}
