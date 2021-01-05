using Sample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Shared.Interfaces
{
    public interface IPageRepository
    {
        IList<Page> GetAll();
    }
}
