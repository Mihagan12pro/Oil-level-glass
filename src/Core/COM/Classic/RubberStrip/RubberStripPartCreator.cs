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
        private IExtrusion? _sketch1Extrusion;

        private IVariable7? _widthVariable;
        private IVariable7? _externalDiameterVariable;
        private IVariable7? _internalDiameterVariable;

        public void AddSketch1()
        {
            _sketch1 = ModelContainer.Sketchs.Add();
            _sketch1.Plane = Part7?.GetPlaneXOY();

            IDrawingContainer sketch1DrawingContainer = _sketch1.GetDrawingContainer();

            ICircle externalCircle = sketch1DrawingContainer.AddCircle(new Point2DCrossApi(0, 0), 60 / 2);
            ICircle internalCircle = sketch1DrawingContainer.AddCircle(new Point2DCrossApi(0, 0), 50 / 2);

            ISymbols2DContainer symbols2DContainer = sketch1DrawingContainer.GetSymbols2DContainer();

            IDiametralDimension externalDimension = symbols2DContainer.AddDiametralDimension(externalCircle);
            IDiametralDimension internalDimension = symbols2DContainer.AddDiametralDimension(internalCircle, 135);

            _sketch1.AddVariableToDimension(externalDimension, "v1", _externalDiameterVariable!.Name);
            _sketch1.AddVariableToDimension(internalDimension, "v2", _internalDiameterVariable!.Name);

            _sketch1.EndEdit();
        }

        public void EditSketch1()
        {
            _internalDiameterVariable!.Expression = PartModel!.InternalDiameter.ToString();
            _externalDiameterVariable!.Expression = PartModel!.ExternalDiameter.ToString();
        }

        public void ExtrudeSketch1()
        {
            _sketch1Extrusion = ModelContainer.Extrusions.Add(Kompas6Constants3D.ksObj3dTypeEnum.o3d_bossExtrusion);

            _sketch1Extrusion.Sketch = _sketch1;
            _sketch1Extrusion.Depth[true] = 2;
            _sketch1Extrusion.Direction = Kompas6Constants3D.ksDirectionTypeEnum.dtMiddlePlane;
            _sketch1Extrusion.ExtrusionType[true] = Kompas6Constants3D.ksEndTypeEnum.etBlind;

            _sketch1Extrusion.Update();

            _sketch1Extrusion.AddVariableToObject(_widthVariable!.Name, "Расстояние 1");
        }
        public void EditSketch1Extrusion()
        {
            _widthVariable!.Expression = PartModel!.Height.ToString();
        }


        public override void Initialize()
        {
            base.Initialize();

            _internalDiameterVariable = Part7!.AddVariable("D1", PartModel.InternalDiameter, "Внутренний диаметр прокладки");
            _externalDiameterVariable = Part7!.AddVariable("D", PartModel.ExternalDiameter, "Внешний диаметр прокладки");

            _widthVariable = Part7!.AddVariable("H", PartModel.Height, "Высота прокладки");
        }
    }
}
