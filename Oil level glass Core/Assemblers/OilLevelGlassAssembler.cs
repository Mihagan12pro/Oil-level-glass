using KompasAPI7;
using Oil_level_glass.Model.Parts;
using Oil_level_glass_Core.Builders;
using System.Net.Http.Headers;

namespace Oil_level_glass_Core.Assemblers
{
    public class OilLevelGlassAssembler : BaseAssembler
    {
        public OilLevelGlassModel OilLevelGlass => (OilLevelGlassModel)EntityModel;

        private HousingBuilder? _housingBuilder;
        private GlassBuilder? _glassBuilder;
        private RubberStripBuilder? _rubberStripBuilder;

        private IPart7 _housing, _topRubberStrip, _bottomRubberStrip, _glass;

        public override void Create()
        {
            AddHousing();

            base.Create();
        }


        private void AddHousing()
        {
            _housingBuilder = new HousingBuilder(true) { EntityModel = OilLevelGlass.HousingModel };

            _housingBuilder.Create();

            AddPartByPath(
                ref _housing,
                _housingBuilder!.Housing.File!.FullName
            );

            _housing.Fixed = true;
        }


        public OilLevelGlassAssembler(bool createNewDocument) : base(createNewDocument)
        {
        }
    }
}
