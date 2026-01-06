using Kompas6Constants3D;
using KompasAPI7;
using Oil_level_glass.COM.Extensions.Containers;
using Oil_level_glass.COM.Extensions.ModelObjects;
using Oil_level_glass.COM.Extensions.V7;
using Oil_level_glass.Core.Classic.OilLevelGlass;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Shared.Points;

namespace Oil_level_glass.COM.Classic.OilLevelGlass
{
    internal class OilLevelGlassPartCreator
        : ComAssemblyPartCreator<OilLevelGlassModel>, IOilLevelGlassPartCreator
    {
        private IPart7? _housing;
        private IFace[]? _housingFaces;
        private IEdge[]? _housingEdges;

        private IPart7? _glass;
        private IFace[]? _glassFaces;
        private IEdge[]? _glassEdges;

        private IPart7? _topRubber;
        private IFace[]? _topRubberStripFaces;
        private IEdge[]? _topRubberStripEdges;

        private IPart7? _bottomRubber;
        private IFace[]? _bottomRubberStripFaces;
        private IEdge[]? _bottomRubberStripEdges;

        public void AddGlass()
        {
           _glass = AssemblyPart7.AddPartByModel(PartModel.GlassModel);

           _glassFaces =_glass.GetFaces();
           _glassEdges =_glass.GetEdges();
        }

        public void AddHousing()
        {
            _housing = AssemblyPart7.AddPartByModel(PartModel.HousingModel);
            _housing.Fixed = true;

            _housingFaces = _housing.GetFaces();
            _housingEdges = _housing.GetEdges();
        }

        public void AddTopRubberStrip()
        {
            AddRubberStrip(out _topRubber, out _topRubberStripFaces, out _topRubberStripEdges);
        }

        public void AddBottomRubberStrip()
        {
            AddRubberStrip(out _bottomRubber, out _bottomRubberStripFaces, out _bottomRubberStripEdges);
        }

        public void Assemble()
        {
            AddHousing();
            AddBottomRubberStrip();

            ConnectHousingAndBottomStrip();

            AddGlass();

            ConnectBottomStripAndGlass();

            AddTopRubberStrip();

            ConnectTopStripAndGlass();
        }

        private void ConnectHousingAndBottomStrip()
        {
            IMateConstraint3D concentric = AssemblyPart7.MateConstraints.Add(MateConstraintType.mc_Concentric);

            var housingModel = PartModel.HousingModel;
            var stripModel = PartModel.RubberStripModel;

            IEdge stripEdge = _bottomRubberStripEdges!.
                Where(e =>
                    e.ToPoint() == new Point3DCrossApi(
                        stripModel.ExternalDiameter / 2,
                        0,
                        -stripModel.Height / 2))
                .First();

            IEdge housingEdge = _housingEdges!.
                Where(e => 
                    e.ToPoint() == new Point3DCrossApi(
                        housingModel.GlassSocketDiameter / 2,
                        0,
                        -housingModel.GlassSocketHeight / 2))
                .First();

            concentric.BaseObject1 = stripEdge;
            concentric.BaseObject2 = housingEdge;

            concentric.Update();

            IMateConstraint3D coincidence = AssemblyPart7.MateConstraints.Add(MateConstraintType.mc_Coincidence);

            IFace stripFace = _bottomRubberStripFaces!
                .Where(f =>f.IsPlanar &&  
                    f.GetEdges()
                        .Where(
                            e => e.ToPoint() == new Point3DCrossApi(
                                stripModel.ExternalDiameter / 2, 
                                0, 
                                -stripModel.Height / 2)
                            ).FirstOrDefault() != null)
                .First();

            coincidence.BaseObject1 = stripFace;
            coincidence.BaseObject2 = housingEdge;
            coincidence.Update();
        }

        private void ConnectBottomStripAndGlass()
        {
            IMateConstraint3D concentric = AssemblyPart7.MateConstraints.Add(MateConstraintType.mc_Concentric);

            var glassModel = PartModel.GlassModel;
            var stripModel = PartModel.RubberStripModel;

            IEdge stripEdge = _bottomRubberStripEdges!.
                Where(e =>
                    e.ToPoint() == new Point3DCrossApi(
                        stripModel.ExternalDiameter / 2,
                        0,
                        stripModel.Height / 2))
                .First();

            IFace glassCylindricFace = _glassFaces!.
                Where(f => f.IsCylinder && f.GetEdges()
                    .Where(e =>
                        e.ToPoint() == new Point3DCrossApi(
                            glassModel.ExternalDiameter * 0.5,
                            0,
                            glassModel.Height / 2)
                        ).FirstOrDefault() != null)
                .First();

            concentric.BaseObject1 = glassCylindricFace;
            concentric.BaseObject2 = stripEdge;

            concentric.Update();


            IMateConstraint3D coincidence = AssemblyPart7.MateConstraints.Add(MateConstraintType.mc_Coincidence);

            IFace glassPlanarFace = _glassFaces!.
                Where(f => f.IsPlanar && f.GetEdges()
                    .Where(e =>
                        e.ToPoint() == new Point3DCrossApi(
                            glassModel.ExternalDiameter * 0.5,
                            0,
                            -glassModel.Height / 2)
                        ).FirstOrDefault() != null)
                .First();


            IFace stripFace = _bottomRubberStripFaces!.
                Where(f => f.IsPlanar && f.GetEdges()
                    .Where(e =>
                        e.ToPoint() == new Point3DCrossApi(
                            stripModel.ExternalDiameter * 0.5,
                            0,
                            stripModel.Height / 2)
                        ).FirstOrDefault() != null)
                .First();

            coincidence.BaseObject1 = glassPlanarFace;
            coincidence.BaseObject2 = stripFace;

            coincidence.Update();
        }

        private void ConnectTopStripAndGlass()
        {
            IMateConstraint3D concentric = AssemblyPart7.MateConstraints.Add(MateConstraintType.mc_Concentric);

            var glassModel = PartModel.GlassModel;
            var stripModel = PartModel.RubberStripModel;

            IFace stripCylindricFace = _topRubberStripFaces!.
                Where(f => f.IsCylinder && f.GetEdges()
                    .Where(e =>
                        e.ToPoint() == new Point3DCrossApi(
                            stripModel.ExternalDiameter * 0.5,
                            0,
                            stripModel.Height / 2)
                        ).FirstOrDefault() != null)
                .First();

            IFace glassCylindricFace = _glassFaces!.
                Where(f => f.IsCylinder && f.GetEdges()
                    .Where(e =>
                        e.ToPoint() == new Point3DCrossApi(
                            glassModel.ExternalDiameter * 0.5,
                            0,
                            glassModel.Height / 2)
                        ).FirstOrDefault() != null)
                .First();

            concentric.BaseObject1 = glassCylindricFace;
            concentric.BaseObject2 = stripCylindricFace;

            concentric.Update();

            IMateConstraint3D coincidence = AssemblyPart7.MateConstraints.Add(MateConstraintType.mc_Coincidence);

            IFace stripPlanarBottomFace = _topRubberStripFaces!.
                Where(f => f.IsPlanar && f.GetEdges()
                    .Where(e =>
                        e.ToPoint() == new Point3DCrossApi(
                            stripModel.ExternalDiameter * 0.5,
                            0,
                            stripModel.Height / 2)
                        ).FirstOrDefault() != null)
                .First();

            IFace glassPlanarTopFace = _glassFaces!.
                Where(f => f.IsPlanar && f.GetEdges()
                    .Where(e =>
                        e.ToPoint() == new Point3DCrossApi(
                            glassModel.ExternalDiameter * 0.5,
                            0,
                            glassModel.Height / 2)
                        ).FirstOrDefault() != null)
                .First();

            coincidence.BaseObject1 = stripPlanarBottomFace;
            coincidence.BaseObject2 = glassPlanarTopFace;

            coincidence.Update();
        }

        private void AddRubberStrip(out IPart7 part, out IFace[]? faces, out IEdge[]? edges)
        {
            part = AssemblyPart7.AddPartByModel(PartModel.RubberStripModel);

            faces = part.GetFaces();
            edges = part.GetEdges();
        }
    }
}
