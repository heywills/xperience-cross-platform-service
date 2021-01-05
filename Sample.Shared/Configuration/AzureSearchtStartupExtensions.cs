using Sample.Shared.Interfaces;
using Sample.Shared.Repositories;
using Sample.Shared.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.Shared.Configuration
{
    public static class AzureSearchtStartupExtensions
    {
        public static IServiceCollection AddAzureSearchServices(this IServiceCollection services)
        {
            services.AddSingleton<IPageRepository, PageRepository>();
            services.AddTransient<IAzureSearchFeedService, AzureSearchFeedService>();
            return services;
        }
    }
}
