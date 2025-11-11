namespace Oil_level_glass.Model.Entities.Parts.Classic
{
    public class OilLevelGlassModel : BaseEntityModel
    {
        public required string GlassPath, HousingPath, StripPath;

        public OilLevelGlassModel()
        {
            File = new KompasFile.AssemblyFile();
        }
    }
}
