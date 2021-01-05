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
        public ServiceConfigurationModule() : base(nameof(Sample) + "." + nameof(ServiceConfigurationModule))
        {
        }

        protected override void OnPreInit()
        {
            base.OnPreInit();
            if(SystemContext.IsCMSRunningAsMainApplication)
            {
                IServiceCollection additionalServices = new ServiceCollection();
                additionalServices.AddLearningManagementServices()
                                  .RegisterWithKenticoServiceLocator();
            }
        }
    }
}
