using KompasAPI7;
using Oil_level_glass.Core.Classic.OilLevelGlass;
using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.COM.Classic.OilLevelGlass
{
    internal class OilLevelGlassPartCreator
        : ComAssemblyPartCreator<OilLevelGlassModel>, IOilLevelGlassPartCreator
    {
        private IPart7? _housing;
        private IFace[]? HousingFaces;
        private IEdge[]? HousingEdges;

        private IPart7? _glass;
        private IFace[]? GlassFaces;
        private IEdge[]? GlassEdges;

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
            throw new NotImplementedException();
        }

        public void AddTopRubberStrip()
        {
            throw new NotImplementedException();
        }

        public void AddRubberStrips()
        {
            throw new NotImplementedException();
        }

        public void Assemble()
        {
            throw new NotImplementedException();
        }

        public void AddBottomRubberStrip()
        {
            throw new NotImplementedException();
        }
    }
}
