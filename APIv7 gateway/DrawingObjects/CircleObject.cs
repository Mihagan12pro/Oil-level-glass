using Kompas6Constants;
using KompasAPI7;

namespace APIv7_gateway.DrawingObjects
{
    public record CircleObject : DrawingObjectBase
    {
        public required double Diameter
        {
            get
            {
                ICircle? circle = drawingObject as ICircle;

                if (circle == null)
                    throw new InvalidDataException();

                return circle.Radius * 2;
            }
            set
            {
                ICircle? circle = drawingObject as ICircle;

                if (circle == null)
                    throw new InvalidDataException();

                circle.Radius = value * 0.5;
            }
        }


        public required double Xc
        {
            get
            {
                ICircle? circle = drawingObject as ICircle;

                if (circle == null)
                    throw new InvalidDataException();

                return circle.Xc;
            }
            set
            {
                ICircle? circle = drawingObject as ICircle;

                if (circle == null)
                    throw new InvalidDataException();

                circle.Xc = value;
            }
        }


        public required double Yc
        {
            get
            {
                ICircle? circle = drawingObject as ICircle;

                if (circle == null)
                    throw new InvalidDataException();

                return circle.Yc;
            }
            set
            {
                ICircle? circle = drawingObject as ICircle;

                if (circle == null)
                    throw new InvalidDataException();

                circle.Yc = value;
            }
        }

        public override ksCurveStyleEnum Style
        {
            get => base.Style;
            set
            {
                ICircle ?circle = drawingObject as ICircle;

                if (circle == null)
                    throw new InvalidDataException();


                base.Style = value;

                circle.Style = (int)base.Style;
            }
        }


        internal CircleObject(ICircle drawingObject) 
        {
            this.drawingObject = drawingObject;
        }
    }
}
