using APIv7_gateway.DrawingObjects;
using APIv7_gateway.Enums;
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
        internal IDrawingContainer DrawingContainer => _drawingContainer;


        public CircleObject AddCircle(double diameter, double xc, double yc, CurveStyles style = CurveStyles.Normal)
        {
            return new CircleObject(DrawingContainer.Circles.Add())
            {
                Diameter = diameter,
                Xc = xc,
                Yc = yc,
                Style = style
            };
        }


        public PointObject AddPoint(double x, double y, CurveStyles style = CurveStyles.Normal)
        {
            return new PointObject(DrawingContainer.Points.Add())
            {
                X = x,

                Y = y,

                Style = style
            };

        }


        public Geometry2DGateway(IKompasDocument2D? document2D) : base(document2D)
        {
            _drawingContainer = (IDrawingContainer)view;
        }
    }
}
