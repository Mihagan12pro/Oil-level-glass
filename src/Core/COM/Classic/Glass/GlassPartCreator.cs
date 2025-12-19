using KompasAPI7;
using Oil_level_glass.COM.Extensions;
using Oil_level_glass.Core.Classic.Glass;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Shared.Points;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.COM.Classic.Glass
{
    internal class GlassPartCreator
        : SolidPartCreator, IGlassPartCreator
    {
        public GlassModel GlassModel { get; set; }

        private ISketch? _sketch1;

        public void AddSketch1()
        {
            Point2DCrossApi leftBottomPoint = new Point2DCrossApi(-1, 0);
            Point2DCrossApi rightBottomPoint = new Point2DCrossApi(1, 0);

            Point2DCrossApi leftTopPoint = new Point2DCrossApi(-1, 30);
            Point2DCrossApi rightTopPoint = new Point2DCrossApi(1, 30);

            _sketch1 = ModelContainer.Sketchs.Add();
            _sketch1.Plane = Part7?.GetPlaneXOY();
            _sketch1.Update();

            IDrawingContainer sketch1DrawingContainer = _sketch1.GetDrawingContainer();

            ILineSegment bottomLine = sketch1DrawingContainer.LineSegments.Add();
            bottomLine.SetPoints(leftBottomPoint, rightBottomPoint);
            bottomLine.Update();

            ILineSegment topLine = sketch1DrawingContainer.LineSegments.Add();
            topLine.SetPoints(leftTopPoint, rightTopPoint);
            topLine.Update();

            ILineSegment rightLine = sketch1DrawingContainer.LineSegments.Add();
            rightLine.SetPoints(rightBottomPoint, rightTopPoint);
            rightLine.Update();

            ILineSegment leftLine = sketch1DrawingContainer.LineSegments.Add();
            leftLine.SetPoints(leftBottomPoint, leftTopPoint);
            leftLine.Update();

            _sketch1.EndEdit();
        }

        public void EditSketch1()
        {
            throw new NotImplementedException();
        }

        public void RotateSketch1()
        {
            throw new NotImplementedException();
        }

        public override void SaveFile()
        {
            throw new NotImplementedException();
        }
    }
}
