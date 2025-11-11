using Kompas6Constants3D;
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

        private CheckFace _checkPlanarFace = (IFace face) => 
            face.IsPlanar;

        private IPart7 _housing, 
            _topRubberStrip, 
            _bottomRubberStrip,
            _glass;

        private IFace _glassTopFace, _glassBottomFace;

        private IEdge _topStripEdge, 
            _bottomStripEdge,
            _glassTopEdge, 
            _glassBottomEdge,
            _housingEdge;

        private IMateConstraint3D _stripsConcentric,
            _housingStripsConcentric,
            _housingGlassConcentric;

        private IMateConstraint3D _topGlassStripCoincidence,
            _bottomGlassStripCoincidence;

        public override void Create()
        {
            //BuildParts();

            AddHousing();
            AddStrips();
            AddGlass();

            //GetPartsEdges();
            //GetPartsFaces();

            //MakePartsConcentric();
            //MakePartsCoincidence();

            base.Create();
        }


        //private void BuildParts()
        //{
        //    _housingBuilder = new HousingBuilder(true) { EntityModel = OilLevelGlass.HousingModel };
        //    _housingBuilder.Create();

        //    _rubberStripBuilder = new RubberStripBuilder(true) { EntityModel = OilLevelGlass.RubberStripModel };
        //    _rubberStripBuilder.Create();

        //    _glassBuilder = new GlassBuilder(true) { EntityModel = OilLevelGlass.GlassModel };
        //    _glassBuilder.Create();
        //}


        private void AddHousing()
        {
            AddPartByPath(
                ref _housing,
                OilLevelGlass.HousingPath
            );

            _housing.Fixed = true;
        }

        private void AddStrips()
        {
            AddPartByPath(
                ref _topRubberStrip, 
               OilLevelGlass.StripPath
            );

            AddPartByPath(
                ref _bottomRubberStrip,
                OilLevelGlass.StripPath
            );
        }


        private void AddGlass()
        {
            AddPartByPath(ref _glass, OilLevelGlass.GlassPath);
        }


        private void GetPartsEdges()
        {
            //_bottomStripEdge = _topRubberStrip.GetEdgeByPoint(
            //     OilLevelGlass.RubberStripModel.ExternalDiameter * 0.5,
            //     0,
            //     -OilLevelGlass.RubberStripModel.Height * 0.5
            //);

            //_topStripEdge = _bottomRubberStrip.GetEdgeByPoint(
            //    OilLevelGlass.RubberStripModel.ExternalDiameter * 0.5,
            //    0,
            //    OilLevelGlass.RubberStripModel.Height * 0.5
            //);

            //_glassTopEdge = _glass.GetEdgeByPoint(
            //    OilLevelGlass.GlassModel.ExternalDiameter * 0.5,
            //    0,
            //    OilLevelGlass.GlassModel.Height * 0.5
            //);

            //_glassBottomEdge = _glass.GetEdgeByPoint(
            //    OilLevelGlass.GlassModel.ExternalDiameter * 0.5,
            //    0,
            //    -OilLevelGlass.GlassModel.Height * 0.5
            //);

            //_housingEdge = _housing.GetEdgeByPoint(
            //    OilLevelGlass.BigSocketDiameter * 0.5,
            //    0,
            //    OilLevelGlass.HousingModel.SocketHeight * 0.5
            //);
        }


        private void GetPartsFaces()
        {
            IExtrusion extrusion = null;
            for (int i = 0; i < ((IModelContainer)_glass).Extrusions.Count; i++)
            {
                extrusion = ((IModelContainer)_glass).Extrusions.Extrusion[i];

                break;
            }

            IFeature7 feature7 = (IFeature7)extrusion!;

            //Part.GetFaceByPoint(feature7, (IFace f) => f.IsPlanar, 0, 0, OilLevelGlass.GlassModel.Height * 0.5);
        }


        private void MakePartsConcentric()
        {
            _stripsConcentric = mateConstraints.Add(MateConstraintType.mc_Concentric);
            _stripsConcentric.BaseObject1 = _topStripEdge;
            _stripsConcentric.Update();

            _housingStripsConcentric = mateConstraints.Add(MateConstraintType.mc_Concentric);
            _housingStripsConcentric.BaseObject1 = _topStripEdge;
            _housingStripsConcentric.BaseObject2 = _housingEdge;
            _housingStripsConcentric.Update();

            _housingGlassConcentric = mateConstraints.Add(MateConstraintType.mc_Concentric);
            _housingGlassConcentric.BaseObject1 = _glassTopEdge;
            _housingGlassConcentric.BaseObject2 = _housingEdge;
            _housingGlassConcentric.Update();
        }

        private void MakePartsCoincidence()
        {
            //_topGlassStripCoincidence = mateConstraints.Add(MateConstraintType.mc_Coincidence);
            //_topGlassStripCoincidence.BaseObject1 = _glassBottomEdge;
            //_topGlassStripCoincidence.BaseObject2 = _bottomStripEdge;
            //_topGlassStripCoincidence.Alignment = ksMateConstraintAlignmentEnum.ksMCAlignmentOpposite;
            //_topGlassStripCoincidence.Update();

            //_bottomGlassStripCoincidence = mateConstraints.Add(MateConstraintType.mc_Coincidence);
            //_bottomGlassStripCoincidence.BaseObject1 = _glassTopEdge;
            //_bottomGlassStripCoincidence.BaseObject2 = _topStripEdge;
            //_bottomGlassStripCoincidence.Alignment = ksMateConstraintAlignmentEnum.ksMCAlignmentOpposite;
            //_bottomGlassStripCoincidence.Update();
        }


        public OilLevelGlassAssembler(bool createNewDocument) : base(createNewDocument)
        {
        }
    }
}
