using APIv7_gateway.Interfaces;
using Kompas6Constants;
using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIv7_gateway.DrawingObjects
{
    public abstract record DrawingObjectBase :  IApi7Object
    {
        protected IDrawingObject drawingObject { get; init; }


        public IDrawingObject DrawingObject => drawingObject;

        public required virtual ksCurveStyleEnum Style { get; set; }

        public void Update()
        {
            drawingObject.Update();
        }


        internal DrawingObjectBase(IDrawingObject drawingObject)
        {
            this.drawingObject = drawingObject;

            Style = ksCurveStyleEnum.ksCSNormal;
        }
    }
}
