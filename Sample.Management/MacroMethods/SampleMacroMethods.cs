using CMS;
using CMS.Core;
using CMS.MacroEngine;
using CMS.Membership;
using Sample.Management.MacroMethods;
using Sample.Shared.Interfaces;

[assembly: RegisterExtension(typeof(SampleMacroMethods), typeof(UserInfo))]

namespace Sample.Management.MacroMethods
{
    public class SampleMacroMethods : MacroMethodContainer
    {
        [MacroMethod(typeof(string), "Return the number of courses the current user is enrolled in.", 0)]
        public static string GetEnrolledCourseCount(EvaluationContext context, params object[] parameters)
        {
            var learningManagementService = Service.Resolve<ILearningManagementService>();
            return learningManagementService.GetCoursesByUserEnrollment(1).Count.ToString();
        }

    }
}
