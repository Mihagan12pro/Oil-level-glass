using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.ModelObjects
{
    public record EdgeObject : ModelObjectBase
    {
        public double X { get; init; }
        public double Y { get; init; }
        public double Z { get; init; }


        public EdgeObject(IEdge edge)
        {
            modelObject = edge;

            edge.GetPoint(true, out double x, out double y, out double z);

            X = x;
            Y = y;
            Z = z;
        }
    }
}
