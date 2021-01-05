using CMS;
using CMS.Base;
using CMS.MacroEngine;
using Sample.Management.MacroMethods;

[assembly: RegisterExtension(typeof(CustomStringMacroMethods), typeof(string))]

namespace Sample.Management.MacroMethods
{
    /// <summary>
    ///     MacroContainer to display AppSettings values from the web.config
    /// </summary>
    public class CustomStringMacroMethods : MacroMethodContainer
    {
		[MacroMethod(typeof(string), "Converts the string to lower.", 1)]
		[MacroMethodParam(0, "text", typeof(string), "Text to convert.")]
		public static object CustomToLower(EvaluationContext context, params object[] parameters)
		{
			if (parameters.Length == 1)
			{
				return MacroMethodContainer.GetStringParam(parameters[0], context.Culture).ToLowerCSafe();
			}
			return "missing parameter";
		}
	}
}