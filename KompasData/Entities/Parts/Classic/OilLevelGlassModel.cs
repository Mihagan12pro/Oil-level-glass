using Oil_level_glass.Model.Operations;

namespace Oil_level_glass.Model.Entities.Parts.Classic
{
    public class OilLevelGlassModel : BaseEntityModel
    {
        public required string GlassPath, HousingPath, StripPath;

        public double MainDiameter { get; set; }

        public double MainHeight { get; set; }

        public int ScrewHolesCount { get; set; }

        public double CentralHoleDiameter { get; set; }

        public double GlassDiameter { get; set; }

        public double GlassWidth { get; set; }

        public double GlassSocketHeight { get; set; }

        public ThreadModel ThreadModel { get; set; }

        public ChamferModel Chamfer { get; } = new ChamferModel() { Angle = 45, Length = 5 };

        public OilLevelGlassModel()
        {
            File = new KompasFile.AssemblyFile();
        }
    }
}
