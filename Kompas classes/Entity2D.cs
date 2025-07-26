
namespace Oil_level_glass.Kompas_classes
{
    internal abstract class Entity2D
    {
        public static readonly int MainLine = 1;
        public static readonly int AxesLine = 3;
        public int LineType { get; protected set; }

        public Entity2D(int lineType)
        {
            LineType = lineType;
        }
    }


    class Circle : Entity2D
    {
        public Point Center { get; private set; } 

        public double Radius { get; private set; }

        public Circle(Point center, double diameter, int lineType) : base(lineType)  
        {
            Center = center; 
            Radius = diameter / 2;
        }
    }


    class LineSegment : Entity2D
    {
        public Point2D StartPoint { get; private set; }
        public Point2D EndPoint { get; private set; }

        public LineSegment(Point2D startPoint,Point2D endPoint,int lineType) : base(lineType)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }
    }
}
