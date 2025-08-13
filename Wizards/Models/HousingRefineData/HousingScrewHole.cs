

namespace Oil_level_glass.Wizards.Models.HousingRefineData
{
    internal class HousingScrewHole : HousingRefineData
    {
        private string _holeDistance;
        public string HoleDistance
        {
            get
            {
                return _holeDistance;
            }
            set
            {
                _holeDistance = value;

                OnPropertyChanged();
            }
        }


        private string _holeDiameter;
        public string HoleDiameter
        {
            get
            {
                return _holeDistance;
            }
            set
            {
                _holeDiameter = value;

                OnPropertyChanged();
            }
        }


        private int _holeCount;
        public int HoleCount
        {
            get
            {
                return _holeCount;
            }
            set
            {
                _holeCount = value;

                OnPropertyChanged();
            }
        }


        public HousingScrewHole(double mainDiameter, double centralHoleDiameter, double height) : base(mainDiameter, centralHoleDiameter, height)
        {

        }
    }
}
