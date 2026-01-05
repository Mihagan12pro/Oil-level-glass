using Kompas6Constants3D;
using KompasAPI7;
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


        public void AddAllParts()
        {
            throw new NotImplementedException();
        }

        public void AddGlass()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void AddRubberStrips()
        {
            throw new NotImplementedException();
        }

        public void AddBottomRubberStrip()
        {
            _bottomRubber = AssemblyPart7.AddPartByModel(PartModel.RubberStripModel);

            _bottomRubberStripFaces = _bottomRubber.GetFaces();
            _bottomRubberStripEdges = _bottomRubber.GetEdges();
        }

        public void Assemble()
        {
            AddHousing();

            AddBottomRubberStrip();

            MakeHousingAndBottomStripConcentric();
        }

        private void MakeHousingAndBottomStripConcentric()
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
        }
    }
}
