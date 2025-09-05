using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass_Core.Data.Materials;
using Oil_level_glass_Core.Services;

namespace Oil_level_glass_Core.Creators.Creators3D.Builders
{
    public record RingBuilder : BaseBuilder
    {
        public double ExternalDiameter { get; set; }

        public double InternalDiameter { get; set; }

        public double RingHeight { get; set; }

        private ISketch? _profileSketch;
        private IExtrusion? _profileSketchExtrusion;


        private void AddSketch1()
        {
            _profileSketch = Properties?.GetNewSketch();

            _profileSketch.Plane = Properties?.PlaneXOY;
            _profileSketch.Update();
        }


        public override void Create()
        {
            Properties.KompasDocument = DocumentManager.GetPartDocument();

            AddSketch1();
        }


        public RingBuilder()
        {
            Properties = new Data.ModelProperties.Properties3D.ModelPartProperties() { Material = new Rubber()};
        }
    }
}
