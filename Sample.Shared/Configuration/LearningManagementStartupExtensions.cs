using Sample.Shared.Interfaces;
using Sample.Shared.Repositories;
using Sample.Shared.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.Shared.Configuration
{
    public static class LearningManagementStartupExtensions
    {
        public static IServiceCollection AddLearningManagementServices(this IServiceCollection services)
        {
            services.AddSingleton<ICourseRepository, CourseRepository>();
            services.AddSingleton<IEnrollmentRepository, EnrollmentRepository>();
            services.AddTransient<ILearningManagementService, LearningManagementService>();
            return services;
        }
    }
}
