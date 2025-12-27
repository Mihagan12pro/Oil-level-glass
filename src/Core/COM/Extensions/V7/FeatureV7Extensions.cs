using KompasAPI7;

namespace Oil_level_glass.COM.Extensions.V7
{
    internal static class FeatureV7Extensions
    {
        public static IVariable7[] GetVariables(
            this IFeature7 feature,
            bool externalOnly = false, 
            bool inSource = false)
        {
            var obj = feature.Variables[externalOnly, inSource];

            List<IVariable7> variables = [];

            if (obj is object[])
            {
                object[] objs = (object[])obj;

                foreach(var o in objs)
                {
                    if (o is IVariable7)
                    {
                        variables.Add((IVariable7)o);
                    }
                }
            }
            else
            {
                variables.Add((IVariable7)obj);
            }

            return variables.ToArray();
        }
    }
}
