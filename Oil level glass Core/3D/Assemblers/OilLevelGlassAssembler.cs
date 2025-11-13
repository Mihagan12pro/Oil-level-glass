using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass.Model.Entities.Parts.Classic;
using Utils.Delegates;
using Utils.Extensions;

namespace Oil_level_glass_Core.Assemblers
{
    public class OilLevelGlassAssembler : BaseAssembler
    {
        public OilLevelGlassModel OilLevelGlass => (OilLevelGlassModel)EntityModel;

        private CheckFace _checkPlanarFace = (IFace face) => 
            face.IsPlanar;
        private CheckFace _checkCylinderFace = (IFace face) =>
            face.IsCylinder;

        private IPart7 _housing, 
            _strip1, 
            _strip2,
            _glass;

        private IFace _strip1CylindricFace;
        private IEdge _strip1BottomEdge,
            _strip1TopEdge;

        private IFace _strip2CylindricFace;
        private IEdge _strip2TopEdge;

        private IFace _glassCylindricFace,
            _glassBottomFace;

        private IFace _housingCylindricFace;
        private IEdge _housingSocketBottomEdge,
            _housingSocketTopEdge;

        private IMateConstraint3D _strip1HousingConcentric,
            _strip1HousingCoincidence;

        private IMateConstraint3D _glassHousingConcentric,
         _strip1GlassCoincidence;

        private IMateConstraint3D _strip2GlassConcentric,
            _strip2GlassCoincidence;


        public override void Create()
        {
            AddHousing();

            AddStrip1();

            AddConstraintsHousingStrip1();
            
            AddGlass();

            AddConstraintsStrip1Glass();

            AddStrip2();

            AddConstraintsStrip2Housing();

            base.Create();
        }


        private void AddHousing()
        {
            AddPartByPath(
                ref _housing,
                OilLevelGlass.HousingPath
            );

            _housing.Fixed = true;

            _housingCylindricFace = _housing.GetFaces(_checkCylinderFace).ToList()[0];
            _housingSocketTopEdge = _housing.GetEdgeByPoint(OilLevelGlass.CentralHoleDiameter * 0.5, 0, OilLevelGlass.GlassSocketHeight * 0.5)!;
            _housingSocketBottomEdge = _housing.GetEdgeByPoint(OilLevelGlass.CentralHoleDiameter * 0.5, 0, -OilLevelGlass.GlassSocketHeight * 0.5)!;
        }


        private void AddStrip1()
        {
            AddPartByPath(
                ref _strip1, 
               OilLevelGlass.StripPath
            );
        
            _strip1CylindricFace = _strip1.GetFaces(_checkCylinderFace).ToList()[0];

            _strip1BottomEdge = _strip1.GetEdgeByPoint(
                OilLevelGlass.CentralHoleDiameter * 0.5, 
                0,
                -(OilLevelGlass.GlassSocketHeight - OilLevelGlass.GlassWidth) / 4
            )!;

            _strip1TopEdge = _strip1.GetEdgeByPoint(
                OilLevelGlass.CentralHoleDiameter * 0.5,
                0,
                (OilLevelGlass.GlassSocketHeight - OilLevelGlass.GlassWidth) / 4
            )!;
        }


        private void AddConstraintsHousingStrip1()
        {
            _strip1HousingConcentric = mateConstraints.Add(MateConstraintType.mc_Concentric);
            _strip1HousingConcentric.BaseObject1 = _housingCylindricFace;
            _strip1HousingConcentric.BaseObject2 = _strip1CylindricFace;
            _strip1HousingConcentric.Update();

            _strip1HousingCoincidence = mateConstraints.Add(MateConstraintType.mc_Coincidence);
            _strip1HousingCoincidence.BaseObject1 = _housingSocketBottomEdge;
            _strip1HousingCoincidence.BaseObject2 = _strip1BottomEdge;
            _strip1HousingCoincidence.Alignment = ksMateConstraintAlignmentEnum.ksMCAlignmentCooriented;
            _strip1HousingCoincidence.Update();
        }



        private void AddGlass()
        {
            AddPartByPath(ref _glass, OilLevelGlass.GlassPath);

            _glassCylindricFace = _glass.GetFaces(_checkCylinderFace).ToList()[0];

            _glassBottomFace = _glass.GetFaceByPoint(
                _glass.GetFaces(_checkPlanarFace), 
                OilLevelGlass.GlassDiameter * 0.5, 
                0, 
                OilLevelGlass.GlassWidth
            )!;
        }


        private void AddConstraintsStrip1Glass()
        {
            _glassHousingConcentric = mateConstraints.Add(MateConstraintType.mc_Concentric);
            _glassHousingConcentric.BaseObject1 = _glassCylindricFace;
            _glassHousingConcentric.BaseObject2 = _housingCylindricFace;
            _glassHousingConcentric.Alignment = ksMateConstraintAlignmentEnum.ksMCAlignmentOpposite;
            _glassHousingConcentric.Update();

            _strip1GlassCoincidence = mateConstraints.Add(MateConstraintType.mc_Coincidence);
            _strip1GlassCoincidence.BaseObject1 = _glassBottomFace;
            _strip1GlassCoincidence.BaseObject2 = _strip1TopEdge;
            _strip1GlassCoincidence.Update();
        }


        private void AddStrip2()
        {
            AddPartByPath(
                ref _strip2,
                OilLevelGlass.StripPath
            );

            _strip2CylindricFace = _strip2.GetFaces(_checkCylinderFace).ToList()[0];

            _strip2TopEdge = _strip2.GetEdgeByPoint(
                OilLevelGlass.CentralHoleDiameter * 0.5,
                0,
                (OilLevelGlass.GlassSocketHeight - OilLevelGlass.GlassWidth) / 4
            )!;
        }

        private void AddConstraintsStrip2Housing()
        {
            _strip2GlassConcentric = mateConstraints.Add(MateConstraintType.mc_Concentric);
            _strip2GlassConcentric.BaseObject1 = _strip2CylindricFace;
            _strip2GlassConcentric.BaseObject2 = _housingCylindricFace;
            _strip2GlassConcentric.Update();

            _strip2GlassCoincidence = mateConstraints.Add(MateConstraintType.mc_Coincidence);
            _strip2GlassCoincidence.BaseObject1 = _strip2TopEdge;
            _strip2GlassCoincidence.BaseObject2 = _housingSocketTopEdge;
            _strip2GlassCoincidence.Alignment = ksMateConstraintAlignmentEnum.ksMCAlignmentCooriented;
            _strip2GlassCoincidence.Update();
        }


        public OilLevelGlassAssembler(bool createNewDocument) : base(createNewDocument)
        {
        }
    }
}
