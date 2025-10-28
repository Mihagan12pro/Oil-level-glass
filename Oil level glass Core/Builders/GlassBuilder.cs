using Kompas6API5;
using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass.Model.Parts;
using System.Diagnostics;
using Utils;

namespace Oil_level_glass_Core.Builders
{
    public class GlassBuilder : BaseBuilder
    {
        private Sketch _sketch1;

        private IExtrusion _extrusion1;

        private ICircle _circleForSketch1;

        private IVariable7? _heightVariable, _externalDiameterVariable;

        private IDiametralDimension _diametralDimension;

        public required GlassModel Glass {get; set;}

        public override void Build()
        {
            AddSketch1();
            ExtrudeSketch1();

            SetAppearance();
            SetMaterial();
        }


        private void AddSketch1()
        {
            _sketch1 = sketchs!.Add();
            _sketch1.Plane = Part.DefaultObject[ksObj3dTypeEnum.o3d_planeXOY];
            _sketch1.Update();

            document2D = _sketch1.BeginEdit();
            InitDrawingContainer();

            _circleForSketch1 = drawingContainer.Circles.Add();
            _circleForSketch1.Radius = Glass.ExternalDiameter * 0.5;
            _circleForSketch1.Xc = 0;
            _circleForSketch1.Yc = 0;
            _circleForSketch1.Update();


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

            IFeature7 treeExtrusion = (IFeature7)_extrusion1;
            var variablesExtrusion = ArrayMaster.ObjectToArray(treeExtrusion.Variables[false, false]);
            foreach (IVariable7 variable in variablesExtrusion)
            {
                if (variable.ParameterNote == "Расстояние 1")
                {
                    variable.Expression = _heightVariable.Name;
                    break;
                }
            }

            Part.Update();
        }


       
        public GlassBuilder(bool createNewDocument) : base(createNewDocument)
        {
        }
    }
}
