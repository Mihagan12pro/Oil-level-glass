using Kompas6Constants;
using KompasAPI7;
using Shared.Results;

namespace Oil_level_glass.Core.COM.Api7.Extensions
{
    internal static class IApplicationExtensions
    {
        public static void SearchForErrors(this IApplication application, out Result result)
        {
            if (application.KompasError.Code == (int)ErrorType.etSuccess)
                result = new Result(true);
            else
                result = new Result(false, application.KompasError.Description);
        }
    }
}
