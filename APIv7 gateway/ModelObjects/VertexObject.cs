using APIv7_gateway.DrawingObjects;
using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects
{
    public class VertexObject : ModelObjectBase
    {
        private readonly IVertex? _vertex;

        internal override IModelObject? ModelObject => _vertex;

        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        internal VertexObject(IVertex vertex)
        {
            _vertex = vertex;

            _vertex.GetPoint(out double x, out double y, out double z);

            X = x;
            Y = y;
            Z = z;
        }
    }
}
