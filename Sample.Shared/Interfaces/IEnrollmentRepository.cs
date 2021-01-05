using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Shared.Interfaces
{
    public interface IEnrollmentRepository
    {
        void AddEnrollment(int userId, int courseId);

        IList<int> GetUserCourseEnrollment(int userId);
    }
}
