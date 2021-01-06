using CMS;
using CMS.Base;
using CMS.DataEngine;
using Sample.Management.Extensions;
using Sample.Management.Modules;
using Sample.Shared.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: RegisterModule(typeof(ServiceConfigurationModule))]

namespace Sample.Management.Modules
{
    public class ServiceConfigurationModule : Module
    {
        public ServiceConfigurationModule() 
            : base(nameof(Sample) + "." + nameof(ServiceConfigurationModule))
        {
        }

        /// <summary>
        /// Use this code-only module to add additional dependencies to the
        /// DI container used by Xperience's built-in service locator.
        /// This will allow injecting built-in components and custom components
        /// as needed.
        /// </summary>
        protected override void OnPreInit()
        {
            base.OnPreInit();
            if (SystemContext.IsCMSRunningAsMainApplication)
            {
                // Create an empty service collection, so that we can call the same
                // extension methods used when registering the shared dependencies in
                // .NET Core web application setup.
                IServiceCollection additionalServices = new ServiceCollection();
                // Call all extension methods required to setup dependencies.
                additionalServices.AddLearningManagementServices()
                                  .AddAzureSearchServices()
                                  // Call RegisterWithKenticoServiceLocator to add these
                                  // dependencies to Xperience's built-in container.
                                  .RegisterWithKenticoServiceLocator();
            }
        }
    }
}
