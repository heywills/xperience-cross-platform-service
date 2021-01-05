using Sample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Shared.Interfaces
{
    public interface ICourseRepository
    {
        Course GetById(int courseId);

        IList<Course> GetAll();
    }
}
