using KompasAPI7;
using Utils;

namespace APIv7_gateway.ModelObjects
{
    public record FaceObject : ModelObjectBase
    {
        public Dictionary<(double X, double Y, double Z), EdgeObject> Edges { get; private set; }

        public FaceObject(IFace face)
        {
            Edges = new Dictionary<(double x, double y, double z), EdgeObject>();

            foreach (IEdge edge in ArrayMaster.ObjectToArray(face.LimitingEdges))
            {
                EdgeObject edgeObj = new EdgeObject(edge);

                Edges[(edgeObj.X, edgeObj.Y, edgeObj.Z)] = edgeObj;
            }

            modelObject = face;
        }
    }
}
