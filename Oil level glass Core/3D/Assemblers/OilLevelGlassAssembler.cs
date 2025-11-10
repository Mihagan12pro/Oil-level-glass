using KompasAPI7;
using Oil_level_glass.Model.Entities.Parts.Classic;
using Oil_level_glass_Core.Builders;
using Utils;
using Utils.Delegates;
using Utils.Extensions;

namespace Oil_level_glass_Core.Assemblers
{
    public class OilLevelGlassAssembler : BaseAssembler
    {
        public OilLevelGlassModel OilLevelGlass => (OilLevelGlassModel)EntityModel;

        private HousingBuilder? _housingBuilder;
        private GlassBuilder? _glassBuilder;
        private RubberStripBuilder? _rubberStripBuilder;

        private IPart7 _housing, _topRubberStrip, _bottomRubberStrip, _glass;

        private IFace _topStripInternalFace, _internalStrip2Face;

        public override void Create()
        {
            AddHousing();
            AddStrips();

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

        private void AddStrips()
        {
            _rubberStripBuilder = new RubberStripBuilder(true) { EntityModel = OilLevelGlass.RubberStripModel };

            _rubberStripBuilder.Create();

            AddPartByPath(
                ref _topRubberStrip, 
                _rubberStripBuilder.RubberStrip.File!.FullName
            );

            AddPartByPath(
                ref _bottomRubberStrip,
                _rubberStripBuilder.RubberStrip.File!.FullName
            );

            CheckFace checkFace = (IFace face) =>
                    face.IsCylinder;

            _topStripInternalFace = _topRubberStrip.GetFaceByPoint(
                checkFace,   
                OilLevelGlass.RubberStripModel.InternalDiameter * 0.5,
                0,
                OilLevelGlass.RubberStripModel.Height * 0.5
            );
            //_rubberStripBuilder.GetFaceByPoint(
            //    ref _internalStripFace,

            //    (IFace face) => 
            //        face.IsCylinder,

            //    OilLevelGlass.RubberStripModel.InternalDiameter * 0.5,
            //    0,
            //    OilLevelGlass.RubberStripModel.Height * 0.5
            //);
        }


        public OilLevelGlassAssembler(bool createNewDocument) : base(createNewDocument)
        {
        }
    }
}
