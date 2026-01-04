using Kompas6Constants;
using KompasAPI7;
using Shared.Exceptions;
using Shared.Points;

namespace Oil_level_glass.COM.Extensions.ModelObjects
{
    internal static class LineSegmentExtensions
    {
        public static void MergeWithAnotherSegment(
            this ILineSegment currentLineSegment,
            ILineSegment anotherLineSegment,
            Point2DCrossApi commonPoint)
        {
            int currentIndex = currentLineSegment.GetPointIndex(commonPoint);
            int anotherIndex = anotherLineSegment.GetPointIndex(commonPoint);

            if (currentIndex == -1 || anotherIndex == -1)
                throw new NotFoundException("These line segment do not contain a common point!");

            IDrawingObject1 drawingObject = (IDrawingObject1)currentLineSegment;

            IParametriticConstraint parametriticConstraint = drawingObject.NewConstraint();
            parametriticConstraint.ConstraintType = ksConstraintTypeEnum.ksCMergePoints;
            parametriticConstraint.Partner = anotherLineSegment;
            parametriticConstraint.Index = currentIndex;
            parametriticConstraint.PartnerIndex = anotherIndex;
            parametriticConstraint.Create();
        }

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

        public static int GetPointIndex(this ILineSegment lineSegment, Point2DCrossApi point)
        {
            Point2DCrossApi start = new Point2DCrossApi(lineSegment.X1, lineSegment.Y1);

            Point2DCrossApi end = new Point2DCrossApi(lineSegment.X2, lineSegment.Y2);

            if (point == start)
                return 0;
            else if (point == end) 
                return 1;
            else 
                return 2;
        }

        public static void MakeLineEqual(this ILineSegment lineSegment, ILineSegment partnerSegment)
        {
            IDrawingObject1 drawingObject = (IDrawingObject1)lineSegment;

            IParametriticConstraint parametriticConstraint = drawingObject.NewConstraint();
            parametriticConstraint.ConstraintType = ksConstraintTypeEnum.ksCEqualLength;
            parametriticConstraint.Partner = partnerSegment;
            parametriticConstraint.Create();
        }
    }
}
