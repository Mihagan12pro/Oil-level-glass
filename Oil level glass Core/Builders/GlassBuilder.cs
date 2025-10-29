using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass.Model.Parts;
using Utils;

namespace Oil_level_glass_Core.Builders
{
    public class GlassBuilder : BaseBuilder
    {
        private Sketch _sketch1;

        private IExtrusion _extrusion1;

        private ICircle _circle;

        private IVariable7? _heightVariable, _externalDiameterVariable;

        private IDiametralDimension _diametralDimension;

        public required GlassModel Glass {get; set;}

        public override void Build()
        {
            AddSketch1();
            ExtrudeSketch1();

            base.Build();
        }


        private void AddSketch1()
        {
            _sketch1 = sketchs!.Add();
            _sketch1.Plane = Part.DefaultObject[ksObj3dTypeEnum.o3d_planeXOY];
            _sketch1.Update();

            document2D = _sketch1.BeginEdit();
            InitDrawingContainer();

            _circle = drawingContainer.Circles.Add();
            _circle.Radius = Glass.ExternalDiameter * 0.5;
            _circle.Xc = 0;
            _circle.Yc = 0;
            _circle.Update();

            InitSymbolContaiber();
             
            _diametralDimension = symbols2dContainer.DiametralDimensions.Add();
            _diametralDimension.BaseObject = _circle;
            _diametralDimension.DimensionType = false;
            _diametralDimension.Angle = 45;
            _diametralDimension.Update();

            _sketch1.EndEdit();
        }


        private void ExtrudeSketch1()
        {
            _extrusion1 = extrusions.Add(ksObj3dTypeEnum.o3d_bossExtrusion);
            _extrusion1.Sketch = _sketch1;
            _extrusion1.Depth[true] = Glass.Height;
            _extrusion1.Direction = ksDirectionTypeEnum.dtMiddlePlane;

            _extrusion1.Update();

            _heightVariable = Part.AddVariable("H", Glass.Height, "Высота линзы");


            IVariable7 variable = GetVariableByParameterNote((_extrusion1 as IFeature7)!, "Расстояние 1");
            variable.Expression = _heightVariable.Name;
        }


       
        public GlassBuilder(bool createNewDocument) : base(createNewDocument)
        {
        }
    }
}
