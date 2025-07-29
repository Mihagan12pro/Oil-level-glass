using Oil_level_glass.BaseClasses;
using Oil_level_glass.Services;

namespace Oil_level_glass.Wizards.ViewModels
{
    internal abstract class AssemblyTabViewModel : BaseWizardViewModel
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

                OnPropertyChanged();
            }
        }


        private string? _materialTittle;

        public string? MaterialTittle
        {
            get
            {
                return _materialTittle;
            }
            set
            {
                _materialTittle = value;

                OnPropertyChanged();
            }
        }


        public Command ExecuteColorDialog
        {
            get
            {
                return new Command(
                        obj =>
                        {
                            ColorDialog colorDialog = new ColorDialog() { Color = ModelColor, FullOpen = true };

                            if (colorDialog.ShowDialog() == DialogResult.OK)
                            {
                                ModelColor = colorDialog.Color;
                            }
                        }
                    );
            }
        }


        public AssemblyTabViewModel()
        {

        }
    }
}
