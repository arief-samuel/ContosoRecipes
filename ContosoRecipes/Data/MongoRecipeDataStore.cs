using ContosoRecipes.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoRecipes.Data
{
    public class MongoRecipeDataStore : IRecipeDataStore
    {

        public MongoRecipeDataStore(IMongoClient mongoClient, IOptions<MongoDatabaseOptions> mongodbOption, IMongoDatabase database)
        {

        }
        public async Task<IEnumerable<T>> GetRandomRecipes<T>(int count)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetRecipeById<T>(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetRecipesById<T>(string ids)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveRecipe(string recipe_id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> SearchRecipesByIngredients<T>(string[] ingredients)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> SearchRecipesByTags<T>(string[] tags)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
