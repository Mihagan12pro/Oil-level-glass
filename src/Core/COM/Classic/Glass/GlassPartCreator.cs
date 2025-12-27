using Kompas6API5;
using KompasAPI7;
using Oil_level_glass.COM.Extensions;
using Oil_level_glass.COM.Extensions.Containers;
using Oil_level_glass.COM.Extensions.ModelObjects;
using Oil_level_glass.COM.Extensions.V7;
using Oil_level_glass.Core.Classic.Glass;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.Other;
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
        public GlassModel GlassModel { get; set; } = null!;

        private IVariable7? _diameterVariable;
        private IVariable7? _extrusionHeight;

        private Sketch? _sketch1;
        private IExtrusion? _extrusion1;


        public void AddSketch1()
        {
            _sketch1 = ModelContainer.Sketchs.Add();
            _sketch1.Plane = Part7?.GetPlaneXOY();
            _sketch1.Update();

            IDrawingContainer sketch1DrawingContainer = _sketch1.GetDrawingContainer();

            ICircle circle = sketch1DrawingContainer.AddCircle(new Point2DCrossApi(0, 0), 30);

            ISymbols2DContainer symbols2DContainer = sketch1DrawingContainer.GetSymbols2DContainer();

            IDiametralDimension diametralDimension = symbols2DContainer.AddDiametralDimension(circle);

            _sketch1.AddVariableToDimension(diametralDimension, "v1", _diameterVariable!.Name);

            _sketch1.EndEdit();
        }

        public void EditSketch1()
        {
            _diameterVariable!.Expression = GlassModel.ExternalDiameter.ToString();
        }

        public override void SaveFile()
        {
            throw new NotImplementedException();
        }

  
        public void ExtrudeSketch1()
        {
            _extrusion1 = ModelContainer.Extrusions.Add(Kompas6Constants3D.ksObj3dTypeEnum.o3d_bossExtrusion);

            _extrusion1.Sketch = _sketch1;
            _extrusion1.Depth[true] = 2;
            _extrusion1.Direction = Kompas6Constants3D.ksDirectionTypeEnum.dtMiddlePlane;

            _extrusion1.AddVariableToObject(_extrusionHeight!.Name, "Расстояние 1");

            _extrusion1.Update();
        }

        public void EditSketch1Extrusion()
        {
            throw new NotImplementedException();
        }

        public override void Initialize()
        {
            base.Initialize();

            _diameterVariable = Part7!.AddVariable("D", 60, "Диаметр линзы");
            _extrusionHeight = Part7!.AddVariable("h", 2, "Высота линзы");
        }
    }
}
