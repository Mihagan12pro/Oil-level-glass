using Oil_level_glass.Enums;
using Oil_level_glass.Services;

namespace Oil_level_glass.BaseClasses
{
    internal abstract class Kompas3DEntity : KompasEntity
    {
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


        private double _density;
        public double Density
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

            if (Density == 0)
                AddError(nameof(Density), "Плотность должна быть больше нуля!", InputError.TooSmall);
        }


        private void ValidateMaterial()
        {
            ClearErrors(nameof(Material));

            if (string.IsNullOrWhiteSpace(Material))
                AddError(nameof(Material), "Не задан материал!", InputError.EmptyField);
        }
    }
}
