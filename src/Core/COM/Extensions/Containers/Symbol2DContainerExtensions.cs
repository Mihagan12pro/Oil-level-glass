using Kompas6Constants;
using KompasAPI7;

namespace Oil_level_glass.COM.Extensions
{
    internal static class Symbol2DContainerExtensions
    {
        public static ILineDimension AddLineDimension(this ISymbols2DContainer container, ILineSegment lineSegment)
        {
            ILineDimension lineDimension = container.LineDimensions.Add();

            lineDimension.X1 = lineSegment.X1;
            lineDimension.Y1 = lineSegment.Y1;

            lineDimension.X2 = lineSegment.X2;
            lineDimension.Y2 = lineSegment.Y2;

            lineDimension.Update();

            IDrawingObject1 drawingObject1 = (IDrawingObject1)lineDimension;

            IParametriticConstraint parametriticConstraint1 = drawingObject1.NewConstraint();
            parametriticConstraint1.ConstraintType = ksConstraintTypeEnum.ksCMergePoints;
            parametriticConstraint1.Partner = lineSegment;
            parametriticConstraint1.Index = 0;
            parametriticConstraint1.PartnerIndex = 0;
            parametriticConstraint1.Create();

            IParametriticConstraint parametriticConstraint2 = drawingObject1.NewConstraint();
            parametriticConstraint2.ConstraintType = ksConstraintTypeEnum.ksCMergePoints;
            parametriticConstraint2.Partner = lineSegment;
            parametriticConstraint2.Index = 1;
            parametriticConstraint2.PartnerIndex = 1;
            parametriticConstraint2.Create();

            return lineDimension;
        }

        public static IDiametralDimension AddDiametralDimension(this ISymbols2DContainer container, ICircle circle, double angle = 45)
        {
            IDiametralDimension diametralDimension = container.DiametralDimensions.Add();

            diametralDimension.BaseObject = circle;
            diametralDimension.Angle = angle;

            diametralDimension.Update();

            return diametralDimension;
        }
    }
}
