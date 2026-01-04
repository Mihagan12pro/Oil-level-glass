using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass.COM.Extensions;
using Oil_level_glass.COM.Extensions.Containers;
using Oil_level_glass.COM.Extensions.ModelObjects;
using Oil_level_glass.COM.Extensions.V7;
using Oil_level_glass.Core.Classic.RubberStrip;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Shared.Axis;
using Shared.Points;

namespace Oil_level_glass.COM.Classic.RubberStrip
{
    internal class RubberStripPartCreator
        : ComSolidPartCreator<RubberStripModel>, IRubberStripPartCreator
    {
        private Sketch? _sketch1;
        private IRotated? _sketch1Rotation;

        private IVariable7? _widthVariable;
        private IVariable7? _externalDiameterVariable;
        private IVariable7? _internalDiameterVariable;

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
            topLine.MergeWithAnotherSegment(rightLine, rightTopPoint);


            ISymbols2DContainer symbols2DContainer = sketch1DrawingContainer.GetSymbols2DContainer();

            ILineDimension bottomDimension = symbols2DContainer.AddLineDimension(bottomLine);

            _sketch1.AddVariableToDimension(bottomDimension, "v1", _widthVariable!.Name);

            rightLine.MakeLineSegmentsEqual(leftLine);
            bottomLine.MakeLineSegmentsEqual(topLine);

            rightLine.MakeLineSegmentsPerpendicular(bottomLine);
            leftLine.MakeLineSegmentsPerpendicular(topLine);

            IPoint leftTop = sketch1DrawingContainer.AddPoint(leftTopPoint);
            IPoint rightTop = sketch1DrawingContainer.AddPoint(rightTopPoint);
            IPoint leftBottom = sketch1DrawingContainer.AddPoint(leftBottomPoint);

            IPoint center = sketch1DrawingContainer.AddPoint(new Point2DCrossApi(0, 0));
            center.MakeFixed();

            topLine.MakePointMerged(leftTop, LinePoint.Start);
            topLine.MakePointMerged(rightTop, LinePoint.End);
            bottomLine.MakePointMerged(leftBottom, LinePoint.Start);

            center.AlignPoints(leftTop, Axis2DCrossApi.OY);
            leftTop.AlignPoints(rightTop, Axis2DCrossApi.OX);

            ILineDimension internalDiameterDimension = symbols2DContainer.AddLineDimension(leftBottom, center);
            _sketch1.AddVariableToDimension(internalDiameterDimension, "v2", $"{_internalDiameterVariable!.Name} / 2");

            ILineDimension externalDiameterDimension = symbols2DContainer.AddLineDimension(center, leftTop);
            _sketch1.AddVariableToDimension(externalDiameterDimension, "v3", $"{_externalDiameterVariable!.Name} / 2");

            _sketch1.EndEdit();
        }

        public void EditSketch1()
        {
            throw new NotImplementedException();
        }

        public void RotateSketch1()
        {
            _sketch1Rotation = ModelContainer.Rotateds.Add(ksObj3dTypeEnum.o3d_bossRotated);
            
            _sketch1Rotation.Profile = _sketch1;
            _sketch1Rotation.Axis = Part7!.GetOZ();

            _sketch1Rotation.Update();
        }

        public override void SaveFile()
        {
            throw new NotImplementedException();
        }

        public override void Initialize()
        {
            base.Initialize();

            _internalDiameterVariable = Part7!.AddVariable("D1", 50, "Внутренний диаметр прокладки");
            _externalDiameterVariable = Part7!.AddVariable("D", 60, "Внешний диаметр прокладки");

            _widthVariable = Part7!.AddVariable("H", 2, "Высота прокладки");
        }
    }
}
