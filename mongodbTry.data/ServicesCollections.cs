using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mongodbTry.data
{
    public static class ServicesCollections
    {
        public static IServiceCollection AddMongoDb(this IServiceCollection services)        {
            
            services.AddSingleton<IMongoDbSettings>(serviceProvider =>
                serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);
            services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));
            return services;

        }
        public static IServiceCollection Addservices(this IServiceCollection services)
        {
            //services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));
            return services;

        }
    }
}
