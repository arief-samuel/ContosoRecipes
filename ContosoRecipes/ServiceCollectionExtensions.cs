using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using ContosoRecipes.Models;

namespace CentosoRecipes
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMongoDb(this IServiceCollection services , IConfiguration config)
        {
            services.Configure<MongoDatabaseOptions>(config.GetSection("MongoDatabase"));
            services.AddSingleton<IMongoClient>(provider => new MongoClient(config["MongoDatabase"]));

            var pack = new ConventionPack();
            pack.Add(new CamelCaseElementNameConvention());

            ConventionRegistry.Register("Custom Convention", pack, t => true);
            BsonClassMap.RegisterClassMap<Recipe>(cm =>
            {
                cm.AutoMap();
                cm.SetIdMember(cm.GetMemberMap(c => c.Title));
            });
            return services;
        }
    }
}
