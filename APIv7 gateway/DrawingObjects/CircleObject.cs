using Kompas6Constants;
using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.DrawingObjects
{
    public record CircleObject : DrawingObjectBase
    {
        public required double Diameter
        {
            get
            {
                return ((ICircle)drawingObject).Radius * 2;
            }
            set
            {
                ((ICircle)drawingObject).Radius = value * 0.5;
            }
        }


        public required double Xc
        {
            get
            {
                return ((ICircle)drawingObject).Xc;
            }
            set
            {
                ((ICircle)drawingObject).Xc = value;
            }
        }


        public required double Yc
        {
            get
            {
                return ((ICircle)drawingObject).Yc;
            }
            set
            {
                ((ICircle)drawingObject).Yc = value;
            }
        }

        public required override ksCurveStyleEnum Style
        {
            get => base.Style;
            set
            {
                base.Style = value;

                ((ICircle)drawingObject).Style = (int)base.Style;
            }
        }


        public CircleObject(ICircle drawingObject) : base(drawingObject)
        {
            this.drawingObject = drawingObject;
        }
    }
}
