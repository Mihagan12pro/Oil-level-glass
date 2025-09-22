using KompasAPI7;
using System.Data;
using Utils;

namespace APIv7_gateway.ModelObjects
{
    public class FaceObject : ModelObjectBase
    {
        private IFace _face;

        private Dictionary<(double X, double Y, double Z), EdgeObject> _edges;

        public Dictionary<(double X, double Y, double Z), EdgeObject> Edges => new Dictionary<(double X, double Y, double Z), EdgeObject>(_edges);

        internal override IModelObject? ModelObject => _face;

        internal FaceObject(IFace face)
        {
            _edges = new Dictionary<(double x, double y, double z), EdgeObject>();

            foreach (IEdge edge in ArrayMaster.ObjectToArray(face.LimitingEdges))
            {
                EdgeObject edgeObj = new EdgeObject(edge);

                _edges[(edgeObj.X, edgeObj.Y, edgeObj.Z)] = edgeObj;
            }

            _face = face;
        }
    }
}
