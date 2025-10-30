using Kompas6Constants3D;
using KompasAPI7;
using KompasData.Materials;
using Oil_level_glass.Model.Parts;

namespace Oil_level_glass_Core.Builders
{
    public class HousingBuilder : BaseBuilder
    {
        public required HousingModel Housing { get; set; }

        private ISketch _sketch1, _sketch2;

        private IExtrusion _extrusion1;

        private ICircle _mainCircle, _smallSocketCircle;

        private IDiametralDimension _mainDiameterDimension, _smallSocketDiameterDimension;

        private IVariable7 _mainDiameterVariable, _smallSocketDiameterVariable;

        private IVariable7 _mainHeightVariable;

        public override void Build()
        {
            AddSketch1();
            ExtrudeSketch1();

            base.Build();
        }


        private void AddSketch1()
        {
            _sketch1 = sketchs.Add();
            _sketch1.Plane = Part.DefaultObject[ksObj3dTypeEnum.o3d_planeXOY];
            _sketch1.Update();

            document2D = _sketch1.BeginEdit();
            InitDrawingContainer();

            _mainCircle = drawingContainer.Circles.Add();
            _mainCircle.Radius = Housing.MainDiameter * 0.5;
            _mainCircle.Xc = 0;
            _mainCircle.Yc = 0;
            _mainCircle.Update();


            _smallSocketCircle = drawingContainer.Circles.Add();
            _smallSocketCircle.Radius = Housing.SmallSocketDiameter * 0.5;
            _smallSocketCircle.Xc = 0;
            _smallSocketCircle.Yc = 0;
            _smallSocketCircle.Update();

            InitSymbolContaiber();

            _mainDiameterDimension = symbols2dContainer.DiametralDimensions.Add();
            _mainDiameterDimension.BaseObject = _mainCircle;
            _mainDiameterDimension.Angle = 45;
            _mainDiameterDimension.Update();

            _smallSocketDiameterDimension = symbols2dContainer.DiametralDimensions.Add();
            _smallSocketDiameterDimension.BaseObject = _smallSocketCircle;
            _smallSocketDiameterDimension.Angle = 135;
            _smallSocketDiameterDimension.Update();

            IFeature7 sketchFeature = (IFeature7)_sketch1;

            _mainDiameterVariable = Part.AddVariable("D", Housing.MainDiameter, "Диаметр корпуса");
            _smallSocketDiameterVariable = Part.AddVariable("D2", Housing.SmallSocketDiameter, "Диаметр центрального отверстия");

            AddVariableToDimension(_mainDiameterDimension, sketchFeature, _mainDiameterVariable.Name, "v1");
            AddVariableToDimension(_smallSocketDiameterDimension, sketchFeature, _smallSocketDiameterVariable.Name, "v2");


            _sketch1.EndEdit();
        }


        private void ExtrudeSketch1()
        {
            _extrusion1 = extrusions.Add(ksObj3dTypeEnum.o3d_baseExtrusion);
            _extrusion1.Sketch = (Sketch)_sketch1;
            _extrusion1.Depth[true] = Housing.MainHeight;
            _extrusion1.Direction = ksDirectionTypeEnum.dtMiddlePlane;
            _extrusion1.Update();

            _mainHeightVariable = Part.AddVariable("H", Housing.MainHeight, "Высота корпуса");
            AddVariableToSolidBody((IFeature7)_extrusion1, _mainHeightVariable.Name, "Расстояние 1");
        }


        public HousingBuilder(bool createNewDocument): base(createNewDocument)
        {
            
        }
    }
}
