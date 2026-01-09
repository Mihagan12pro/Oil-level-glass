using KompasAPI7;
using Oil_level_glass.COM.Extensions.Containers;
using Shared.Axis;
using Shared.Exceptions;
using Shared.Points;

namespace Oil_level_glass.COM.Extensions.Collections
{
    internal static class ArrayExtensions
    {
        public static IFace GetFaceByAxis(this IFace[] faces, Axis3DCrossApi axis, double coordinate, bool start = true)
        {
            foreach(IFace face in faces)
            {
                IEdge[] edges = face.GetEdges();

                foreach(IEdge edge in edges)
                {
                    edge.GetPoint(start, out double x, out double y, out double z);

                    switch(axis)
                    {
                        case Axis3DCrossApi.OX:
                            {
                               if (coordinate == x)
                                    return face;

                                break;
                            }
                        case Axis3DCrossApi.OY:
                            {
                                if (coordinate == y)
                                    return face;

                                break;
                            }
                        case Axis3DCrossApi.OZ:
                            {
                                if (coordinate == z)
                                    return face;

                                break;
                            }
                    }
                }
            }

            throw new NotFoundException("This face does not exists!");
        }
    }
}
