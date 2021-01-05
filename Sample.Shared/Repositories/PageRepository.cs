using Sample.Shared.Interfaces;
using Sample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Shared.Repositories
{
    public class PageRepository: IPageRepository
    {
        public IList<Page> GetAll()
        {
            return new List<Page>();
        }
    }
}
