using KompasAPI7;
using Oil_level_glass.COM.Extensions.V7;

namespace Oil_level_glass.COM.Extensions.ModelObjects
{
    internal static class ModelObjectExtensions
    {
        public static void AddVariableToObject(this IModelObject modelObject, string expression, string parameterNote)
        {
            IFeature7 feature = (IFeature7)modelObject;

            var variables = feature.GetVariables();

            foreach (IVariable7 variable in variables)
            {
                if (variable.ParameterNote == parameterNote)
                {
                    variable.Expression = expression;
                }
            }
        }
    }
}
