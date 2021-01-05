using Sample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Shared.Interfaces
{
    public interface ILearningManagementService
    {
        IList<Course> GetCoursesByUserEnrollment(int userId);
    }
}
