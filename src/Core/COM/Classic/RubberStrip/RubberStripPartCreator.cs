using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass.COM.Extensions;
using Oil_level_glass.COM.Extensions.Containers;
using Oil_level_glass.COM.Extensions.ModelObjects;
using Oil_level_glass.COM.Extensions.V7;
using Oil_level_glass.Core.Classic.RubberStrip;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;

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
            
        }

        public void EditSketch1()
        {
            _internalDiameterVariable!.Expression = PartModel!.InternalDiameter.ToString();
            _externalDiameterVariable!.Expression = PartModel!.ExternalDiameter.ToString();
        }

        public void ExtrudeSketch1()
        {

        }
        public void EditSketch1Extrusion()
        {
            _widthVariable!.Expression = PartModel!.Height.ToString();
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
