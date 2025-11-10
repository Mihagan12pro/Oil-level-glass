using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass.Model.Entities.Parts.Classic;
using Oil_level_glass_Core.Builders;
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

        private CheckFace _checkPlanarFace = (IFace face) => 
            face.IsPlanar;

        private IPart7 _housing, _topRubberStrip, _bottomRubberStrip, _glass;

        private IFace _topStripTopFace, _bottomStripBottomFace, _topHousingSocketFace;

        private IEdge _topStripInternalEdge, _bottomStripInternalEdge, _housingTopSocketEdge, _bottomHousingBottomSocketEdge;

        private IMateConstraint3D _stripsConcentric, _housingStripsConcentric;
        private IMateConstraint3D _topStripHousingCoincidence, _bottomStripHousingCoincidence;

        public override void Create()
        {
            AddHousing();
            AddStrips();
            MakeConcentricStripsAndHousing();
            ConnectTopStripToHousing();
            ConnectBottomStripToHousing();

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


        private void MakeConcentricStripsAndHousing()
        {
            _housingTopSocketEdge = _housing.GetEdgeByPoint(
                OilLevelGlass.BigSocketDiameter * 0.5,
                0,
                OilLevelGlass.HousingModel.SocketHeight * 0.5
            );

            _housingStripsConcentric = mateConstraints.Add(MateConstraintType.mc_Concentric);
            _housingStripsConcentric.BaseObject1 = _housingTopSocketEdge;
            _housingStripsConcentric.BaseObject2 = _topStripInternalEdge;
            _housingStripsConcentric.Update();
        }


        private void ConnectTopStripToHousing()
        {
            _topHousingSocketFace = _housing.GetFaceByPoint(
           _checkPlanarFace,
            OilLevelGlass.BigSocketDiameter * 0.5,
            0,
            OilLevelGlass.HousingModel.SocketHeight * 0.5
            );

            _topStripTopFace = _topRubberStrip.GetFaceByPoint(
            _checkPlanarFace,
            _rubberStripBuilder!.RubberStrip.ExternalDiameter * 0.5,
            0,
            _rubberStripBuilder!.RubberStrip.Height * 0.5
            );

            _topStripHousingCoincidence = mateConstraints.Add(MateConstraintType.mc_Coincidence);
            _topStripHousingCoincidence.BaseObject1 = _topStripTopFace;
            _topStripHousingCoincidence.BaseObject2 = _topHousingSocketFace;
            _topStripHousingCoincidence.Update();
        }


        private void ConnectBottomStripToHousing()
        {
            _bottomHousingBottomSocketEdge = _housing.GetEdgeByPoint(
                OilLevelGlass.BigSocketDiameter * 0.5,
                0,
                -OilLevelGlass.HousingModel.SocketHeight * 0.5
            );

            _bottomStripInternalEdge.GetPoint(true, out double x, out double y, out double z);

            _bottomStripBottomFace = _bottomRubberStrip.GetFaceByPoint(
                _checkPlanarFace,
                x, y, z
            );

            _bottomStripHousingCoincidence = mateConstraints.Add(MateConstraintType.mc_Coincidence);
            _bottomStripHousingCoincidence.BaseObject1 = _bottomStripBottomFace;
            _bottomStripHousingCoincidence.BaseObject2 = _bottomHousingBottomSocketEdge;
            _bottomStripHousingCoincidence.Update();
        }


        public OilLevelGlassAssembler(bool createNewDocument) : base(createNewDocument)
        {
        }
    }
}
