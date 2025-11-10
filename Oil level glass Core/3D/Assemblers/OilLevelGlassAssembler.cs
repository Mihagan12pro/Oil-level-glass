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

        private IFace _topStripInternalFace, _bottomStripInternalFace;

        private IEdge _topStripInternalEdge, _bottomStripInternalEdge;

        private IMateConstraint3D _stripsConcentric;

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

            double x = OilLevelGlass.RubberStripModel.InternalDiameter * 0.5;
            double y = 0;
            double z = OilLevelGlass.RubberStripModel.Height * 0.5;

            _topStripInternalEdge = _topRubberStrip.GetEdgeByPoint(
                x,
                y,
                z
            );

            _bottomStripInternalEdge = _bottomRubberStrip.GetEdgeByPoint(
                x,
                y,
                -z
            );

            _stripsConcentric = mateConstraints.Add(Kompas6Constants3D.MateConstraintType.mc_Concentric);
            _stripsConcentric.BaseObject1 = _topStripInternalEdge;
            _stripsConcentric.BaseObject2 = _bottomStripInternalEdge;
            _stripsConcentric.Update();
        }


        public OilLevelGlassAssembler(bool createNewDocument) : base(createNewDocument)
        {
        }
    }
}
