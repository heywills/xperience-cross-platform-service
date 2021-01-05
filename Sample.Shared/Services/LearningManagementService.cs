using CMS.Membership;
using Sample.Shared.Interfaces;
using Sample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sample.Shared.Services
{
    public class LearningManagementService : ILearningManagementService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IUserInfoProvider _userInfoProvider;

        public LearningManagementService(ICourseRepository courseRepository, 
                                         IEnrollmentRepository enrollmentRepository, 
                                         IUserInfoProvider userInfoProvider)
        {
            _courseRepository = courseRepository;
            _enrollmentRepository = enrollmentRepository;
            _userInfoProvider = userInfoProvider;
        }

        public IList<Course> GetCoursesByUserEnrollment(int userId)
        {
            var user = _userInfoProvider.Get(userId);
            var allCourses = _courseRepository.GetAll();
            var enrolledCourseIds = _enrollmentRepository.GetUserCourseEnrollment(userId);
            return allCourses.Where(c => enrolledCourseIds.Contains(c.CourseId)).ToList();
        }
    }
}
