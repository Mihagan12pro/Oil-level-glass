using Kompas6API5;
using KompasAPI7;
using KompasData.Materials;
using Oil_level_glass.Model.Parts;
using Utils;

namespace Oil_level_glass_Core.Builders
{
    public class RubberStripBuilder : BaseBuilder
    {
        public required RubberStripModel RubberStrip { get; set; }

        private ICircle _internalCircle, _externalCircle;

        private IVariable7 _internalDiameterVariable, _externalDiameterVariable, _heightVariable;

        private IDiametralDimension _internalDiametralDimension, _externalDiametralDimension;

        private ISketch _sketch1;

        private IExtrusion _extrusion1;

        public override void Build()
        {
            AddSketch1();

            AddExtrusion1();

            base.Build();
        }

        private void AddSketch1()
        {
            _sketch1 = sketchs.Add();

            _sketch1.Plane = Part.DefaultObject[Kompas6Constants3D.ksObj3dTypeEnum.o3d_planeXOY];
            _sketch1.Update();

            document2D = _sketch1.BeginEdit();

            InitDrawingContainer();

            _internalCircle = drawingContainer.Circles.Add();
            _internalCircle.Xc = 0;
            _internalCircle.Yc = 0;
            _internalCircle.Radius = RubberStrip.InternalDiameter * 0.5;
            _internalCircle.Update();


            _externalCircle = drawingContainer.Circles.Add();
            _externalCircle.Xc = 0;
            _externalCircle.Yc = 0;
            _externalCircle.Radius = RubberStrip.ExternalDiameter * 0.5;
            _externalCircle.Update();


            InitSymbolContaiber();


            _externalDiametralDimension = symbols2dContainer.DiametralDimensions.Add();
            _externalDiametralDimension.Angle = 45;
            _externalDiametralDimension.BaseObject = _externalCircle;
            _externalDiametralDimension.Update();

            _internalDiametralDimension = symbols2dContainer.DiametralDimensions.Add();
            _internalDiametralDimension.Angle = 135;
            _internalDiametralDimension.BaseObject = _internalCircle;
            _internalDiametralDimension.Update();

            IFeature7 featureSketch = (IFeature7)_sketch1;


            AddVariableToDimension(_externalDiametralDimension, featureSketch, _externalDiameterVariable, "D1", "v1");
            AddVariableToDimension(_internalDiametralDimension, featureSketch, _internalDiameterVariable, "D2", "v2");

            _sketch1.EndEdit();
        }


        private void AddExtrusion1()
        {
            _extrusion1 = extrusions.Add(Kompas6Constants3D.ksObj3dTypeEnum.o3d_baseExtrusion);
            _extrusion1.Direction = Kompas6Constants3D.ksDirectionTypeEnum.dtMiddlePlane;
            _extrusion1.Sketch = _sketch1 as Sketch;
            _extrusion1.Depth[true] = RubberStrip.Height;

            _extrusion1.Update();
        }


        public RubberStripBuilder(bool createNewDocument) : base(createNewDocument)
        {
            
        }
    }
}
