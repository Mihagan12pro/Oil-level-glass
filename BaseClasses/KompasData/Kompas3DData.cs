using Oil_level_glass.BaseClasses.ModelsBase;
using Oil_level_glass.Delegates;
using Oil_level_glass.Services;
using Oil_level_glass.Wizards.Models.CommonModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Oil_level_glass.BaseClasses.KompasData
{
    internal abstract class Kompas3DData : KompasData
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


        public override void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (prop != nameof(ModelColor))
            {
                base.OnPropertyChanged(prop);
            }
        }
    }
}
