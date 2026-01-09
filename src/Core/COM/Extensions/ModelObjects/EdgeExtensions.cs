using KompasAPI7;
using Shared.Points;

namespace Oil_level_glass.COM.Extensions.ModelObjects
{
    internal static class EdgeExtensions
    {
        public static Point3DCrossApi ToPoint(this IEdge edge, bool start = true)
        {
            edge.GetPoint(start, out double x, out double y, out double z);

            Point3DCrossApi point = new Point3DCrossApi(x, y, z);

            return point;
        }
    }
}
