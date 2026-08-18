using System.ComponentModel;
using System.Reflection;

namespace Oil_level_glass.Model.Data.ScrewHoles
{
    /// <summary>
    /// Простое отверстие
    /// </summary>
    public class BasicScrewHoleModel : BaseScrewHoleModel
    {
        private double _diameter;

        [DisplayName("d")]
        public double Diameter
        {
            get
            {
                return _diameter;
            }
            set
            {
                _diameter = value;

                if (NotifyDiameterChanged != null)
                    NotifyDiameterChanged(value);
            }
        }

        public delegate void DiameterChangedHandler(double diameter);
        public event DiameterChangedHandler? NotifyDiameterChanged;

        protected override string CheckField(string columnName)
        {
            string error = string.Empty;

            string? displayName = this.GetType()
                        .GetProperties()
                        .Where(p => p.Name == columnName && p.GetCustomAttribute<DisplayNameAttribute>() != null)
                        .Select(p => p.GetCustomAttribute<DisplayNameAttribute>().DisplayName)
                        .FirstOrDefault();

            if (displayName != null)
            {
                switch (columnName)
                {
                    case nameof(Diameter):
                        {
                            if (Diameter <= 0)
                            {
                                error = string.Format(messageMustBeGraterThanZero, displayName);
                            }
                            else if (Diameter > MaxDiameter)
                            {
                                error = string.Format(messageCantBeGreaterThan, displayName, MaxDiameter);
                            }

                            break;
                        }
                }
            }

            return error;
        }
    }
}
