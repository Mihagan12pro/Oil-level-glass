using Oil_level_glass.Model.Data.Holes;
using System.ComponentModel;
using System.Reflection;

namespace Oil_level_glass.Model.Data.ScrewHoles
{
    /// <summary>
    /// Простое отверстие
    /// </summary>
    public class BasicHoleModel : BaseHoleModel
    {
        public override double FullHoleDiameter
            => Diameter;
    }
}
