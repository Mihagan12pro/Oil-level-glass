using KompasAPI7;
using Shared.Points;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.COM.Extensions
{
    internal static class LineSegmentExtensions
    {
        public static void SetPoints(this ILineSegment line, Point2DCrossApi start, Point2DCrossApi end)
        {
            line.X1 = start.X;
            line.Y1 = start.Y;

            line.X2 = end.X;
            line.Y2 = end.Y;
        }
    }
}
