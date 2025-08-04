using Oil_level_glass.Enums;
using Oil_level_glass.Services;
using System.Globalization;

namespace Oil_level_glass.BaseClasses
{
    internal abstract class Kompas3DEntity : KompasEntity
    {
        protected double maxDensity;
        protected double minDensity;


        private Color _modelColor;
        public Color ModelColor
        {
            get
            {
                return _modelColor;
            }
            protected set
            {
                _modelColor = value;

                OnPropertyChanged();
            }
        }


        private string? _density;
        public string? Density
        {
            get
            {
                return _density;
            }
            set
            {
                _density = value;

                ValidateDensity();
                OnPropertyChanged();
            }
        }


        private string? _material;
        public string? Material
        {
            get
            {
                return _material;
            }
            set
            {
                _material = value;

                ValidateMaterial();
                OnPropertyChanged();
            }
        }


        public Command InvokeColorDialog
        {
            get
            {
                return new Command
                    (
                        obj => ModelColor = Dialog.InvokeColorDialog(ModelColor)
                    );
            }
        }


        private void ValidateDensity()
        {
            ClearErrors(nameof(Density));

            double.TryParse(Density, new CultureInfo("EN-us") ,out double density);

            if (density < minDensity)
            {
                AddError(nameof(Density), $"Минимальная плотность для данного материала равна {minDensity} г/см³", InputError.TooSmall);
            }

            if (density > maxDensity)
            {
                AddError(nameof(Density), $"Максимальная плотность для данного материала равна {maxDensity} г/см³", InputError.TooBig);
            }
        }


        private void ValidateMaterial()
        {
            ClearErrors(nameof(Material));

            if (string.IsNullOrWhiteSpace(Material))
                AddError(nameof(Material), "Не задан материал!", InputError.EmptyField);
        }
    }
}
