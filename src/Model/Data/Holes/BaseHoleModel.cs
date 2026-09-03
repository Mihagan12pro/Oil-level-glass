using System.ComponentModel;
using System.Reflection;

namespace Oil_level_glass.Model.Data.Holes
{
    public abstract class BaseHoleModel : BaseModel
    {
        public double MinDiameter
            => 1;

        public double MaxDiameter
        {
            get
            {
                return _maxDiameter;
            }
            set
            {
                _maxDiameter = Math.Round(value, 3);
            }
        }

        public abstract double FullHoleDiameter { get; }

        private double _diameter;
        private double _maxDiameter;

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

        public delegate void DiameterChangedHandler(double diameter);
        public event DiameterChangedHandler? NotifyDiameterChanged;
    }
}