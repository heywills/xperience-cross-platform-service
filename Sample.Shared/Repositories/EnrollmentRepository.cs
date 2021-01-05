using Sample.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Shared.Repositories
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        public void AddEnrollment(int userId, int courseId)
        {
            return;
        }

        public IList<int> GetUserCourseEnrollment(int userId)
        {
            return new List<int>()
            {
                1
            };
        }
    }
}
