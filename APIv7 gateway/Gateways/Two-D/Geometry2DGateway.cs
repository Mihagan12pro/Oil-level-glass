using APIv7_gateway.DrawingObjects;
using Kompas6Constants;
using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.Gateways.Two_D
{
    public class Geometry2DGateway : Kompas2DGateway
    {
        private readonly IDrawingContainer _drawingContainer;
        public IDrawingContainer DrawingContainer => _drawingContainer;


        public CircleObject AddCircle(double diameter, double xc, double yc, ksCurveStyleEnum style = ksCurveStyleEnum.ksCSNormal)
        {
            return new CircleObject(DrawingContainer.Circles.Add())
            {
                Diameter = diameter,
                Xc = xc,
                Yc = yc,
                Style = style
            };
        }


        public Geometry2DGateway(IKompasDocument2D? document2D) : base(document2D)
        {
            _drawingContainer = (IDrawingContainer)view;
        }
    }
}
