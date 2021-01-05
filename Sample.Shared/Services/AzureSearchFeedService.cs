using CMS.Core;
using Sample.Shared.Interfaces;
using System;

namespace Sample.Shared.Services
{
    public class AzureSearchFeedService : IAzureSearchFeedService
    {
        private readonly IPageRepository _pageRepository;
        private readonly IEventLogService _eventLogService;

        public AzureSearchFeedService(IPageRepository pageRepository, IEventLogService eventLogService)
        {
            _pageRepository = pageRepository;
            _eventLogService = eventLogService;
        }

        public void PopulateAzureFeed()
        {
            throw new NotImplementedException();
        }
    }
}
