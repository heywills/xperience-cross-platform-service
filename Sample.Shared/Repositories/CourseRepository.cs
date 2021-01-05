using Sample.Shared.Interfaces;
using Sample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Shared.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        public IList<Course> GetAll()
        {
            return new List<Course>()
            {
                GetById(1)
            };
        }

        public Course GetById(int courseId)
        {
            return new Course()
            {
                CourseId = 1,
                CourseName = "Building Xperience cross-platform components",
                CourseDescription = "Lorem Ipsum..."
            };
        }
    }
}
