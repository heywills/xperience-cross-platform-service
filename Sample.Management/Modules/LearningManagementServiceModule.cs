using CMS;
using CMS.Base;
using CMS.DataEngine;
using Sample.Management.Extensions;
using Sample.Management.Modules;
using Sample.Shared.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: RegisterModule(typeof(LearningManagementServiceModule))]

namespace Sample.Management.Modules
{
    public class LearningManagementServiceModule : Module
    {
        public LearningManagementServiceModule() : base(nameof(LearningManagementServiceModule))
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
