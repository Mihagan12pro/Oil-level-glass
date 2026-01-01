using Kompas6Constants3D;
using KompasAPI7;

namespace Oil_level_glass.COM.Extensions.Containers
{
    internal static class FaceExtensions
    {
        public static IEdge[] GetEdges(this IFace face)
        {
            object obj = face.LimitingEdges;

            List<IEdge> edges = [];

            if (obj is object[])
            {
                object[] objs = (object[])obj;

                foreach (var o in objs)
                {
                    if (o is IEdge)
                    {
                        edges.Add((IEdge)o);
                    }
                }
            }
            else
            {
               edges.Add((IEdge)obj);
            }

            return edges.ToArray();
        }
    }
}
