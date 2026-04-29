using Oil_level_glass.Model.Data.Operations;
using System.ComponentModel;

namespace Oil_level_glass.Model.Data.ScrewHoles
{
    /// <summary>
    /// Простое отверстие
    /// </summary>
    public class BasicScrewHoleModel : BaseScrewHoleModel
    {
        private double _diameter;

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
                            error = $"Diameter can't be greater than {MaxDiameter}!";
                            break;
                    }
            }

            return error;
        }

        public override string Error
        {
            get
            {
                string error = string.Empty;

                foreach (var property in this.GetType().GetProperties())
                {
                    string propertyError = this[property.Name];

                    if (propertyError != string.Empty)
                    {
                        error += propertyError + '\n';
                    }
                }

                return error;
            }
        }
    }
}
