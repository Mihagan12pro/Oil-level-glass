using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.Core.Housing
{
    public interface IHousingPartCreator : IHousingCreator
    {
        void AddSketch1();

        void AddSketch2();

        void AddSketch3();

        void ExtrudeSketch1();

        void ExtrudeSketch2();

        void AddScrewHoles();

        void AddRounding();
    }
}
