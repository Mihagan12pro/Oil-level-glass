using KompasAPI7;
using Oil_level_glass.Model.Parts;
using Oil_level_glass_Core.Builders;

namespace Oil_level_glass_Core.Assemblers
{
    public class OilLevelGlassAssembler : BaseAssembler
    {
        public required HousingModel HousingData;
        public required RubberStripModel RubberStripData;
        public required GlassModel GlassData;

        private HousingBuilder? _housingBuilder;
        private GlassBuilder? _glassBuilder;
        private RubberStripBuilder? _rubberStripBuilder;

        private IPart7 _hosuing, _topRubberStrip, _bottomRubberStrip, _glass;

        public required GlassBuilder GlassBuilder { get; set; }

        public required RubberStripBuilder RubberStripBuilder { get; set; }

        public required HousingBuilder HousingBuilder { get;set;}

        private void BuildParts()
        {
            //_housingBuilder = new HousingBuilder(false);


        }

        public override void Create()
        {
            BuildParts();
        }


        public OilLevelGlassAssembler(bool createNewDocument) : base(createNewDocument)
        {
        }
    }
}
