using Oil_level_glass.Model.Data.KompasFile;

namespace Oil_level_glass.Model.Data.Entities.Parts.Classic
{
    /// <summary>
    /// Oil level glass assembly
    /// </summary>
    public class OilLevelGlassModel 
        : BaseAssemblyModel
    {
        public GlassModel GlassModel { get; set; } = null!;

        public HousingModel HousingModel { get; set; } = null!;

        public RubberStripModel RubberStripModel { get; set; } = null!;

        public override string Error => string.Empty;

        public OilLevelGlassModel()
        {
            File = new AssemblyFile();
        }

        protected override string CheckField(string columnName)
        {
            string error = string.Empty;
        
            return error;
        }
    }
}