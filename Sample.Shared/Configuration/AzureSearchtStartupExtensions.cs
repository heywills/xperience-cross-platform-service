using Sample.Shared.Interfaces;
using Sample.Shared.Repositories;
using Sample.Shared.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.Shared.Configuration
{
    public static class AzureSearchtStartupExtensions
    {
        /// <summary>
        /// Register dependencies required for the AzureSearchFeedService. 
        /// This can be used by both the .NET Core web app and the CMS app.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddAzureSearchServices(this IServiceCollection services)
        {
            services.AddSingleton<IPageRepository, PageRepository>();
            services.AddTransient<IAzureSearchFeedService, AzureSearchFeedService>();
            return services;
        }
    }
}
