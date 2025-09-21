using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects
{
    public class EdgeObject : ModelObjectBase
    {
        private readonly IEdge _edge;

        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public override IModelObject? ModelObject => _edge;

        public EdgeObject(IEdge edge)
        {
            _edge = edge;

            edge.GetPoint(true, out double x, out double y, out double z);

            X = x;
            Y = y;
            Z = z;

            IFeature7 feature7;
        }
    }
}
