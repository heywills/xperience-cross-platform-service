using System;
using CMS;
using CMS.Core;
using CMS.Scheduler;
using Sample.Shared.Interfaces;

namespace Sample.Management.ScheduledTasks
{
    public class AzureSearchFeedTask: ITask
    {
        private readonly IAzureSearchFeedService _azureSearchFeedService;

        /// <summary>
        /// Kentico creates Schedule tasks using the default constructor. However,
        /// we only have to use Kentico's built-in service locator at the top
        /// of the dependency chain. The rest of the dependencies will be
        /// injected into the service.
        /// </summary>
        public AzureSearchFeedTask()
        {
            _azureSearchFeedService = Service.Resolve<IAzureSearchFeedService>();
        }
        public string Execute(TaskInfo task)
        {
            throw new NotImplementedException();
        }
    }
}
