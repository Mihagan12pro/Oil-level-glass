using Oil_level_glass.Delegates;
using Oil_level_glass.Services;
using System.ComponentModel;

namespace Oil_level_glass.BaseClasses
{
    internal abstract class Kompas3DData : KompasData
    {
        protected double maxDensity;
        protected double minDensity;


        private Color _modelColor;
        [Description("Цвет трехмерной модели")]
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
        [Description("Плотность")]
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
        [Description("Название материала")]
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
            ErrorAdder adder = AddError;
            ErrorClearer clearer = ClearErrors;

            if (!Validator<Kompas3DData>.CheckRequiredField(nameof(Density), Density, adder, clearer))
            {
                if (!Validator<Kompas3DData>.CheckDoubleField(nameof(Density), Density, adder, clearer, out double result))
                {
                    Validator<Kompas3DData>.CheckDensityValue(nameof(Density), Density, minDensity, maxDensity ,adder, clearer);
                }
            }
        }


        private void ValidateMaterial()
        {
            Validator<Kompas3DData>.CheckRequiredField(nameof(Material), Material, new ErrorAdder(AddError), new ErrorClearer(ClearErrors));
        }
    }
}
