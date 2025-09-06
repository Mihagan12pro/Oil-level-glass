using KompasAPI7;
using Oil_level_glass_Core.Data.Materials;

namespace Oil_level_glass_Core.Creators.Creators3D.Builders
{
    public record RingBuilder : BaseBuilder
    {
        public double ExternalDiameter { get; set; }

        public double InternalDiameter { get; set; }

        public double RingHeight { get; set; }

        IVariable7 variable7;

        private ISketch? _sketch1;
        private IExtrusion? _sketch1Extrusion;


        private void AddSketch1()
        {
            _sketch1 = Properties?.GetNewSketch();

            _sketch1.Plane = Properties?.PlaneXOY;

            _sketch1.Update();

            Properties.KompasDocument2D = _sketch1.BeginEdit();
        }


        public override void Create()
        {
            base.Create();

            AddSketch1();
        }


        public RingBuilder()
        {
            Properties = new Data.ModelProperties.Properties3D.ModelPartProperties() { Material = new Rubber()};
        }
    }
}
