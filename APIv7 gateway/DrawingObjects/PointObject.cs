using KompasAPI7;

namespace APIv7_gateway.DrawingObjects
{
    public class PointObject : DrawingObjectBase
    {
        public required double X
        {
            get
            {
                return _point.X;
            }
            set
            {
                _point.X = value;
            }
        }


        public required double Y
        {
            get
            {
                return _point.Y;
            }
            set
            {
                _point.Y = value;
            }
        }


        private readonly IPoint _point;

        public override IDrawingObject? DrawingObject => _point;

        internal PointObject(IPoint point)
        {
            _point = point;
        }
    }
}
