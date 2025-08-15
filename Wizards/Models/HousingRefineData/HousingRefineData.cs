using Oil_level_glass.BaseClasses;
using System.ComponentModel;

namespace Oil_level_glass.Wizards.Models.HousingRefineData
{
    internal abstract class HousingRefineData : BaseKompasData
    {
        protected static string? s_mainDiameter;
        [Description("Диаметр заготовки D")]
        public string? MainDiameter
        {
            get
            {
                return s_mainDiameter;
            }
            set
            {
                s_mainDiameter = value;

                OnPropertyChanged();
            }
        }


        protected static string? s_centralHoleDiameter;
        [Description("Диаметр заготовки D1")]
        public string? CentralHoleDiameter
        {
            get
            {
                return s_centralHoleDiameter;
            }
            set
            {
                s_centralHoleDiameter = value;

                OnPropertyChanged();
            }
        }


        protected static string? s_height;
        [Description("Высота заготовски H")]
        public string? Height
        {
            get
            {
                return s_height;
            }
            set
            {
                s_height = value;

                OnPropertyChanged();
            }
        }


        public HousingRefineData()
        {

        }
    }
}
