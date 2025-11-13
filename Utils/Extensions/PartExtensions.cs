using Kompas6Constants3D;
using KompasAPI7;
using Utils.Delegates;
using Utils.Exceptions;

namespace Utils.Extensions
{
    public static class PartExtensions
    {
        public static IFace? GetFaceByPoint(this IPart7 part, IEnumerable<IFace> faces, double x, double y, double z, bool start = true)
        {
            foreach(IFace face in faces)
            {
                try
                {
                    IEdge edge = GetEdgeByPoint(part, face, x, y ,z, start);

                    return face;
                }
                finally
                {

                }
            }

            return null;
        }


        public static IEnumerable<IFace> GetFaces(this IPart7 part, CheckFace? checkFace = null)
        {
            List<IFace>faces = new List<IFace>();

            IModelContainer modelContainer = (IModelContainer)part;

            object[] objs = ArrayMaster.ObjectToArray(modelContainer.Objects[ksObj3dTypeEnum.o3d_face]);

            foreach (object obj in objs)
            {
                IFace face = (IFace)obj;

                if (checkFace != null)
                {
                    if (checkFace(face))
                    {
                        faces.Add(face);
                    }
                }
                else
                {
                    faces.Add(face);
                }
            }

            return faces;
        }


        public static IEdge? GetEdgeByPoint(this IPart7 part, double x, double y, double z, bool start = true)
        {
            IModelContainer modelContainer = (IModelContainer)part;

            return GetEdgeByPoint(
                part,
                ArrayMaster.ObjectToArray(modelContainer.Objects[ksObj3dTypeEnum.o3d_edge]),
                x,
                y,
                z,
                start
            );
        }


        public static IEdge? GetEdgeByPoint(
            this IPart7 part,
            object[] edges,
            double x,
            double y,
            double z,
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
            return null;
        }


        public static IEdge? GetEdgeByPoint(
            this IPart7 part,
            IFace face,
            double x,
            double y,
            double z,
            bool start = true)
        {
            object[] edges = ArrayMaster.ObjectToArray(face.LimitingEdges);

            return GetEdgeByPoint(part, edges, x, y, z, start);
        }

  
        public static IVertex? GetVertexByPoint(
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

            return null;
        }
    }
}
