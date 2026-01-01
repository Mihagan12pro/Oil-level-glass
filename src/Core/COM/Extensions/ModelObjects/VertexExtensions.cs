using KompasAPI7;
using Shared.Points;

namespace Oil_level_glass.COM.Extensions.ModelObjects
{
    internal static class VertexExtensions
    {
        public static Point3DCrossApi ToPoint(this IVertex vertex)
        {
            vertex.GetPoint(out double x, out double y, out double z);

            return new Point3DCrossApi(x, y, z);
        }
    }
}
