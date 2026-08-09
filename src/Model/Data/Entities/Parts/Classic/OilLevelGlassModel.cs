using System.ComponentModel;
using System.Globalization;

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

        public OilLevelGlassModel()
        {
            switch (CultureInfo.CurrentCulture.Name)
            {
                case "ru-RU":
                    {
                        DisplayName = "Смотровой лючок";
                        break;
                    }
                default:
                    {
                        DisplayName = "Oil level glass";
                        break;
                    }
            }
        }

        protected override string CheckField(string columnName)
        {
            string error = string.Empty;
        
            return error;
        }
    }
}