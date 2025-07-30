using System.Globalization;

namespace Oil_level_glass.Wizards.ViewModels
{
    internal class BlankTabViewModel : AssemblyTabViewModel
    {
        private string ?_blankDiameter;
        public string ?BlankDiameter
        {
            get
            {
                return _blankDiameter;
            }
            set
            {
                _blankDiameter = value;

                OnPropertyChanged();

            }
        }


        public BlankTabViewModel()
        {
            ModelColor = Color.Gold;

            MaterialTittle = "Сталь";

            Density = 7.871;

            FileName = "Корпус";
        }
    }
}
