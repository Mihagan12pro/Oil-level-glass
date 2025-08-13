using Oil_level_glass.BaseClasses;

namespace Oil_level_glass.Wizards.Models.HousingRefineData
{
    internal abstract class HousingRefineData : BaseKompasData
    {
        protected static double s_mainDiameter;
        public double MainDiameter
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


        protected static double s_centralHoleDiameter;
        public double CentralHoleDiameter
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


        protected static double s_height;
        public double Height
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


        public HousingRefineData(double mainDiameter, double centralHoleDiameter, double height)
        {
            MainDiameter = mainDiameter;

            CentralHoleDiameter = centralHoleDiameter;

            Height = height;
        }
    }
}
