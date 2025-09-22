using APIv7_gateway.Enums;
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
    public abstract class DrawingObjectBase :  IApi7Object
    {
        internal abstract IDrawingObject? DrawingObject { get; }

        public virtual CurveStyles Style { get; set; } = CurveStyles.Normal;

        public void Update()
        {
            DrawingObject?.Update();
        }
    }
}
