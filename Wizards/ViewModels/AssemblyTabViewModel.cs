using Oil_level_glass.BaseClasses;
using Oil_level_glass.Services;
using System.Windows.Forms;

namespace Oil_level_glass.Wizards.ViewModels
{
    internal abstract class AssemblyTabViewModel : BaseWizardViewModel
    {
        protected Color modelColor;

        public Color ModelColor
        {
            get
            {
                return modelColor;
            }
            protected set
            {
                modelColor = value;

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


        public AssemblyTabViewModel(Color color)
        {
            ModelColor = color;
        }
    }
}
