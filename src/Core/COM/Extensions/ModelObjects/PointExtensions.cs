using Kompas6Constants;
using KompasAPI7;
using Shared.Axis;

namespace Oil_level_glass.COM.Extensions.ModelObjects
{
    internal static class PointExtensions
    {
        public static void AlignPoints(this IPoint currentPoint, IPoint partnerPoint, Axis2DCrossApi axis)
        {
            IDrawingObject1 drawingObject1 = (IDrawingObject1)currentPoint;

            IParametriticConstraint parametriticConstraint = drawingObject1.NewConstraint();
            parametriticConstraint.Partner = partnerPoint;

            if (axis == Axis2DCrossApi.OX)
                parametriticConstraint.ConstraintType = ksConstraintTypeEnum.ksCHAlignPoints;
            else
                parametriticConstraint.ConstraintType = ksConstraintTypeEnum.ksCVAlignPoints;

            parametriticConstraint.Create();
        }

        public static void MakeFixed(this IPoint point)
        {
            IDrawingObject1 drawingObject1 = (IDrawingObject1)point;

            IParametriticConstraint parametriticConstraint = drawingObject1.NewConstraint();
            parametriticConstraint.ConstraintType = ksConstraintTypeEnum.ksCFixedPoint;
            parametriticConstraint.Create();
        }
    }
}
