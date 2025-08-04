using Oil_level_glass.Enums;
using Oil_level_glass.Services;
using System.Globalization;

namespace Oil_level_glass.BaseClasses
{
    internal abstract class Kompas3DEntity : KompasEntity
    {
        protected double maxDensity;


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

            if (String.IsNullOrEmpty(Density))
            {
                AddError(nameof(Density), "Поле 'Плотность материала обязательно для заполнения'", InputError.InvalidType);

                return;
            }

           
            if (!double.TryParse(new String(Density).Replace(',', '.'), new CultureInfo("En-us"), out double density))
            {
                AddError(nameof(Density), "Плотность материала должна быть числом!", InputError.InvalidType);
                
                return;
            }


            if (density < 0.534)
            {
                AddError(nameof(Density), "Слишком маленькая плотность!", InputError.TooSmall);
            }


            if (density > maxDensity)
            {
                AddError(nameof(Density), "Слишком большая плотность!", InputError.TooBig);
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
