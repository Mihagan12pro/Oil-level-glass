using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass.COM.Extensions;
using Oil_level_glass.COM.Extensions.Containers;
using Oil_level_glass.COM.Extensions.ModelObjects;
using Oil_level_glass.COM.Extensions.V7;
using Oil_level_glass.Core.Classic.RubberStrip;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Shared.Points;

namespace Oil_level_glass.COM.Classic.RubberStrip
{
    internal class RubberStripPartCreator
        : ComSolidPartCreator<RubberStripModel>, IRubberStripPartCreator
    {
        private Sketch? _sketch1;

        public void AddSketch1()
        {
            _sketch1 = ModelContainer.Sketchs.Add();
            _sketch1.Plane = Part7?.GetPlaneYOZ();
            _sketch1.Update();

            Point2DCrossApi leftBottomPoint = new Point2DCrossApi(-1, 25);
            Point2DCrossApi rightBottomPoint = new Point2DCrossApi(1, 25);

            Point2DCrossApi leftTopPoint = new Point2DCrossApi(-1, 30);
            Point2DCrossApi rightTopPoint = new Point2DCrossApi(1, 30);

            IDrawingContainer sketch1DrawingContainer = _sketch1.GetDrawingContainer();

            ILineSegment bottomLine = sketch1DrawingContainer.AddLineSegment(leftBottomPoint, rightBottomPoint);
            ILineSegment rightLine = sketch1DrawingContainer.AddLineSegment(rightBottomPoint, rightTopPoint);

            ILineSegment topLine = sketch1DrawingContainer.AddLineSegment(leftTopPoint, rightTopPoint);
            ILineSegment leftLine = sketch1DrawingContainer.AddLineSegment(leftBottomPoint, leftTopPoint);

            bottomLine.MergeWithAnotherSegment(rightLine, rightBottomPoint);
            bottomLine.MergeWithAnotherSegment(leftLine, leftBottomPoint);

            topLine.MergeWithAnotherSegment(leftLine, leftTopPoint);

            ISymbols2DContainer symbols2DContainer = sketch1DrawingContainer.GetSymbols2DContainer();

            ILineDimension bottomDimension = symbols2DContainer.AddLineDimension(bottomLine);
            ILineDimension rightLineDimension = symbols2DContainer.AddLineDimension(rightLine);

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
