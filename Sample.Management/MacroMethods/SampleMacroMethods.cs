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
        [MacroMethod(typeof(string),
                     "Return the number of courses the current user is enrolled in.",
                     1)]
        [MacroMethodParam(0, "user", typeof(UserInfo), "UserInfo object.")]
        public static string GetEnrolledCourseCount(EvaluationContext context, 
                                                    params object[] parameters)
        {
            if ((parameters == null) || 
                (parameters.Length == 0) || 
                !(parameters[0] is UserInfo))
            {
                return null;
            }
            var userInfo = (UserInfo)parameters[0];
            var learningManagementService = Service.Resolve<ILearningManagementService>();
            return learningManagementService.GetCoursesByUserEnrollment(userInfo.UserID)
                                            .Count
                                            .ToString();
        }
    }
}
