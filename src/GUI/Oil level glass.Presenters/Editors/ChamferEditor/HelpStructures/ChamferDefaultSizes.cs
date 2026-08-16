using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.Presenters.Editors.HelpStructures;

namespace Oil_level_glass.Presenters.Editors.ChamferEditor.HelpStructures
{
    public class ChamferDefaultSizes : DefaultSizes
    {
        public readonly string Side1 = "1";

        public readonly string Side2 = "1";

        public readonly string Angle = "45";

        public readonly ChamferType ChamferType;

        public ChamferDefaultSizes(
            double side1,
            double side2,
            double angle,
             ChamferType chamferType)
        {
            ChamferType = chamferType;

            if (side1 > 0)
                Side1 = side1.ToString();

            if (side2 > 0)
                Side2 = side2.ToString();

            if (angle > 0 && angle < 90)
                Angle = angle.ToString();
        }
    }
}
