using Kompas6Constants3D;
using KompasAPI7;
using Utils.Delegates;
using Utils.Exceptions;

namespace Utils.Extensions
{
    public static class PartExtensions
    {
        public static IEdge GetEdgeByPoint(
            this IPart7 part,
            object[]edges, double x = 0,
            double y = 0,
            double z = 0,
            bool start = true)
        {

            foreach (var i in edges)
            {
                IEdge edge = (IEdge)i;

                edge.GetPoint(start, out double x1, out double y1, out double z1);

                if (x1 == x && y1 == y && z1 == z)
                {
                    return edge;
                }
            }
            throw new EntityNotFoundException("The edge has not been found!");
        }


        public static IEdge GetEdgeByPoint(
            this IPart7 part,
            IFace face,
            double x = 0,
            double y = 0,
            double z = 0,
            bool start = true)
        {
            object[] edges = ArrayMaster.ObjectToArray(face.LimitingEdges);

            return GetEdgeByPoint(part, edges, x, y, z, start);
        }

        public static IEdge GetEdgeByPoint(
            this IPart7 part,
            double x = 0,
            double y = 0,
            double z = 0,
            bool start = true)
        {
            IFeature7 feature = (IFeature7)part;

            return GetEdgeByPoint(part, feature, x, y, z, start);
        }


        public static IEdge GetEdgeByPoint(
            this IPart7 part,
            IFeature7 feature,
            double x = 0,
            double y = 0,
            double z = 0,
            bool start = true)
        {
            object[] edges = ArrayMaster.ObjectToArray(feature.ModelObjects[ksObj3dTypeEnum.o3d_edge]);

            return GetEdgeByPoint(part, edges, x, y, z, start);
        }


        public static IFace GetFaceByPoint(
            this IPart7 part,
            CheckFace checkFace,
            double x = 0,
            double y = 0,
            double z = 0,
            bool start = true)
        {
            IFeature7 feature = (IFeature7)part;

            return GetFaceByPoint(part, feature, checkFace, x, y, z, start);
        }


        public static IFace GetFaceByPoint(
            this IPart7 part,
            IFeature7 feature,
            CheckFace checkFace,
            double x = 0,
            double y = 0,
            double z = 0,
            bool start = true)
        {
            object[] faces = ArrayMaster.ObjectToArray(feature.ModelObjects[ksObj3dTypeEnum.o3d_face]);

            foreach(var i in faces)
            {
                IFace face = (IFace)i;

                try
                {
                    IEdge edge = GetEdgeByPoint(part, face, x, y, z, start);

                    return face;
                }
                catch(EntityNotFoundException)
                {
                    Console.WriteLine("This face does not contains this edge!");
                }
            }
            throw new EntityNotFoundException("The face has not been found!");
        }


        public static IVertex GetVertexByPoint(
            this IPart7 part,
            IFeature7 feature,
            double x = 0,
            double y = 0,
            double z = 0)
        {
            object[] vertices = ArrayMaster.ObjectToArray(feature.ModelObjects[ksObj3dTypeEnum.o3d_vertex]);

            foreach(var i in vertices)
            {
                IVertex vertex = (IVertex)i;

                vertex.GetPoint(out double x1, out double y1, out double z1);

                if (x1 == x && y1 == y && z1 == z)
                {
                    return vertex;
                }
            }

            throw new EntityNotFoundException();
        }
    }
}
