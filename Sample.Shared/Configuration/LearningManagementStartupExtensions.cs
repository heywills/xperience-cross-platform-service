using Sample.Shared.Interfaces;
using Sample.Shared.Repositories;
using Sample.Shared.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.Shared.Configuration
{
    public static class LearningManagementStartupExtensions
    {
        /// <summary>
        /// Register dependencies required for the LearningManagementService. 
        /// This can be used by both the .NET Core web app and the CMS app.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddLearningManagementServices(this IServiceCollection services)
        {
            services.AddSingleton<ICourseRepository, CourseRepository>();
            services.AddSingleton<IEnrollmentRepository, EnrollmentRepository>();
            services.AddTransient<ILearningManagementService, LearningManagementService>();
            return services;
        }
    }
}
