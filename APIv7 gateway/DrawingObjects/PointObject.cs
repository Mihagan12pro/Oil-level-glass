using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.DrawingObjects
{
    public record PointObject : DrawingObjectBase
    {
        public required double X
        {
            get
            {
                IPoint ?point = drawingObject as IPoint;

                if (point == null)
                    throw new InvalidDataException();


                return point.X;
            }
            set
            {
                IPoint? point = drawingObject as IPoint;

                if (point == null)
                    throw new InvalidDataException();

                point.X = value;
            }
        }


        public required double Y
        {
            get
            {
                IPoint? point = drawingObject as IPoint;

                if (point == null)
                    throw new InvalidDataException();

                return point.Y;
            }
            set
            {
                IPoint? point = drawingObject as IPoint;

                if (point == null)
                    throw new InvalidDataException();

                point.Y = value;
            }
        }


        internal PointObject(IPoint point)
        {
            drawingObject = point;
        }
    }
}
