using APIv7_gateway.Enums;
using Kompas6Constants;
using KompasAPI7;

namespace APIv7_gateway.DrawingObjects
{
    public class CircleObject : DrawingObjectBase
    {
        public required double Diameter
        {
            get
            {
                return _circle.Radius * 2;
            }
            set
            {
                _circle.Radius = value * 0.5;
            }
        }


        public required double Xc
        {
            get
            {
                return _circle.Xc;
            }
            set
            {
                _circle.Xc = value;
            }
        }


        public required double Yc
        {
            get
            {
                return _circle.Yc;
            }
            set
            {
                _circle.Yc = value;
            }
        }

        public override CurveStyles Style
        {
            get => base.Style;
            set
            {
                base.Style = value;

                _circle.Style = (int)base.Style;
            }
        }

        internal override IDrawingObject? DrawingObject => _circle;

        private readonly ICircle _circle;

        internal CircleObject(ICircle circle) 
        {
            _circle = circle;
        }
    }
}
