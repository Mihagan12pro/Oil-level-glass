using Kompas6Constants3D;
using KompasAPI7;

namespace Oil_level_glass.Core.COM.Api7.Extensions
{
    internal static class IFeature7Extensions
    {
        public static IVertex GetVertexByPoint(this IFeature7 feature, double x, double y, double z)
        {
            object verticesObj = feature.ModelObjects[Obj3dType.o3d_vertex];

            if (verticesObj is object[]  vertices)
            {
                foreach (object vertexObj in vertices)
                {
                    if (vertexObj is IVertex vertex)
                    {
                        vertex.GetPoint(out double X, out double Y, out double Z);

                        if (X == x && Y == y && Z == z)
                            return vertex;
                    }
                }
            }

            return null;
        }
    }
}
