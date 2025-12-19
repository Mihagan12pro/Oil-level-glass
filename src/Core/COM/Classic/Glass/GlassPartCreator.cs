using KompasAPI7;
using Oil_level_glass.COM.Extensions;
using Oil_level_glass.Core.Classic.Glass;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
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
            _sketch1 = ModelContainer.Sketchs.Add();
            _sketch1.Plane = Part7?.GetPlaneXOY();
            _sketch1.Update();

            IDrawingContainer sketch1DrawingContainer = _sketch1.GetDrawingContainer();

            ILineSegment lineSegment = sketch1DrawingContainer.LineSegments.Add();
         

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
