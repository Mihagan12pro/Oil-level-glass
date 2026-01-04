using Kompas6Constants;
using KompasAPI7;
using System;

namespace Oil_level_glass.COM.Extensions.ModelObjects
{
    internal static class PointExtensions
    {
        public static void MakeFixed(this IPoint point)
        {
            IDrawingObject1 drawingObject1 = (IDrawingObject1)point;

            IParametriticConstraint parametriticConstraint = drawingObject1.NewConstraint();
            parametriticConstraint.ConstraintType = ksConstraintTypeEnum.ksCFixedPoint;
            parametriticConstraint.Create();
        }
    }
}
