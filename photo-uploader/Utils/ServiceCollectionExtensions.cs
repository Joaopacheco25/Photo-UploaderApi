using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using photo_uploader.Options;
using photo_uploader.Repository;
using photo_uploader.Services;

namespace photo_uploader.Utils
{
    [ExcludeFromCodeCoverage]
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection serviceCollection, IConfiguration config)
        {
            var connectionDb = config.GetSection("DbOptions");
            serviceCollection.Configure<DbOptions>(connectionDb);

            serviceCollection.AddScoped<IPhotoUploaderService, PhotoUploaderService>();
            serviceCollection.AddScoped<IPhotoUploaderRepository, PhotoUploaderRepository>();

            return serviceCollection;
        }
    }
}