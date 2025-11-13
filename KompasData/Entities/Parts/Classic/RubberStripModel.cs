
using Model.Materials;

namespace Oil_level_glass.Model.Entities.Parts.Classic
{
    public class RubberStripModel : BaseDetailModel
    {
        public double InternalDiameter { get; set; }

        public double ExternalDiameter { get; set; }

        public double Height { get; set; }

        public RubberStripModel()
        {
            Material = new Rubber();

            Appereance.Blue = 0;
            Appereance.Red = 0;
            Appereance.Green = 0;
        }
    }
}
