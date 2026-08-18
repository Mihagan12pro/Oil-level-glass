using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.Presenters.Editors.HelpStructures;

namespace Oil_level_glass.Presenters.Editors.ChamferEditor.HelpStructures
{
    public class ChamferUpdateData : UpdateData
    {
        public readonly string Side1;

        public readonly string Side2;

        public readonly string Angle;

        public ChamferUpdateData(
            string side1,
            string side2, 
            string angle)
        {
            Side1 = side1;

            Side2 = side2;

            Angle = angle;
        }
    }
}
