using Kompas6Constants;
using KompasAPI7;
using Shared.Points;

namespace Oil_level_glass.COM.Extensions.ModelObjects
{
    internal static class LineSegmentExtensions
    {
        public static void MakePointMerged(this ILineSegment lineSegment, IPoint point, LinePoint linePoint)
        {
            int index = 0;

            if (linePoint == LinePoint.End)
                index = 1;


            IDrawingObject1 drawingObject1 = (IDrawingObject1)lineSegment;

            IParametriticConstraint parametriticConstraint = drawingObject1.NewConstraint();
            parametriticConstraint.ConstraintType = ksConstraintTypeEnum.ksCMergePoints;
            parametriticConstraint.Partner = point;
            parametriticConstraint.Index = index;
            parametriticConstraint.Create();
        }

        public static void MakePointFixed(this ILineSegment lineSegment, LinePoint linePoint)
        {
            int index = 0;

            if (linePoint == LinePoint.End)
                index = 1;


            IDrawingObject1 drawingObject1 = (IDrawingObject1)lineSegment;

            IParametriticConstraint parametriticConstraint = drawingObject1.NewConstraint();
            parametriticConstraint.ConstraintType = ksConstraintTypeEnum.ksCFixedPoint;
            parametriticConstraint.Index = index;
            parametriticConstraint.Create();
        }
    }
}
