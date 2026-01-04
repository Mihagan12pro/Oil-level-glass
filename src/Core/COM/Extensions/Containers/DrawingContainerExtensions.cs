using KompasAPI7;
using Shared.Points;

namespace Oil_level_glass.COM.Extensions.Containers
{
    internal static class DrawingContainerExtensions
    {
        public static ISymbols2DContainer GetSymbols2DContainer(this IDrawingContainer drawingContainer)
        {
            IView view = (IView)drawingContainer;
            ISymbols2DContainer symbols2dContainer = (ISymbols2DContainer)view;

            return symbols2dContainer;
        }

        public static ILineSegment AddLineSegment(
            this IDrawingContainer drawingContainer, 
            Point2DCrossApi start, 
            Point2DCrossApi end, 
            int style = 1)
        {
            ILineSegment lineSegment = drawingContainer.LineSegments.Add();

            lineSegment.X1 = start.X;
            lineSegment.Y1 = start.Y;

            lineSegment.X2 = end.X;
            lineSegment.Y2 = end.Y;

            lineSegment.Style = style;

            lineSegment.Update();

            return lineSegment;
        }

        public static ICircle AddCircle(
            this IDrawingContainer drawingContainer, 
            Point2DCrossApi center, 
            double radius,
            int style = 1)
        {
            ICircle circle = drawingContainer.Circles.Add();

            circle.Style = style;

            circle.Xc = center.X;
            circle.Yc = center.Y;   

            circle.Radius = radius;

            circle.Update();

            return circle;
        }

        public static IRectangle AddRectangle(
            this IDrawingContainer drawingContainer, 
            Point2DCrossApi leftBottomPoint,
            double width,
            double height,
            int style = 1)
        {
            IRectangle rectangle = drawingContainer.Rectangles.Add();

            rectangle.Width = width;
            rectangle.Height = height;

            rectangle.X = leftBottomPoint.X;
            rectangle.Y = leftBottomPoint.Y;

            rectangle.Style = style;

            rectangle.Update();

            return rectangle;
        }
    }
}
