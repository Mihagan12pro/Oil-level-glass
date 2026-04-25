using System.ComponentModel;

namespace Oil_level_glass.Model.Data.ScrewHoles
{
    public class ScrewHoleModel : BaseScrewHoleModel
    {
        private double _diameter;

        public double MaxDiameter { get; set; }

        [DisplayName("Diameter")]
        public double Diameter
        {
            get
            {
                return _diameter;
            }
            set
            {
                _diameter = value;

                OnPropertyChanged();
            }
        }

        protected override string CheckField(string columnName)
        {
            string error = string.Empty;

            switch (columnName)
            {
                case nameof(Diameter):
                    {
                        if (Diameter <= 0)
                            error = "Diameter must be greater than zero!";
                        else if (Diameter > MaxDiameter)
                            error = $"Diameter must be less or equal {MaxDiameter}!";

                        break;
                    }
            }

            return error;
        }
    }
}
