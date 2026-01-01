using KompasAPI7;
using Oil_level_glass.COM.Extensions.Containers;
using Shared;
using Shared.Exceptions;
using Shared.Points;

namespace Oil_level_glass.COM.Extensions.Collections
{
    internal static class ArrayExtensions
    {
        public static IFace GetFaceByAxis(this IFace[] faces, AxisCrossApi axis, double coordinate, bool start = true)
        {
            foreach(IFace face in faces)
            {
                IEdge[] edges = face.GetEdges();

                foreach(IEdge edge in edges)
                {
                    edge.GetPoint(start, out double x, out double y, out double z);

                    switch(axis)
                    {
                        case AxisCrossApi.OX:
                            {
                               if (coordinate == x)
                                    return face;

                                break;
                            }
                        case AxisCrossApi.OY:
                            {
                                if (coordinate == y)
                                    return face;

                                break;
                            }
                        case AxisCrossApi.OZ:
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
