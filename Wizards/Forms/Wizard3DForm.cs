using Oil_level_glass.Wizards.Models.Wizard3D;
using Oil_level_glass.Wizards.ViewModels;

namespace Oil_level_glass.Wizards.Forms
{
    public partial class Wizard3DForm : Form
    {
        public Wizard3DForm()
        {
            InitializeComponent();

            DataContext = new Wizard3DViewModel();

            InitHousingBinding();
        }


        private void InitHousingBinding()
        {
            housingFolderTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            DataContext,

                            "HousingEntity.FolderPath",

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingFolderButton.DataBindings.Add
                (
                    new Binding
                        (
                            "Command",

                            DataContext,

                            "HousingEntity.InvokeFolderBrowserDialog",

                            true
                        )
                );

            housingColorBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            DataContext,

                            "HousingEntity.ModelColor"
                        )
                );

            housingColorButton.DataBindings.Add
                (
                    new Binding
                        (
                            "Command",

                            DataContext,

                            "HousingEntity.InvokeColorDialog",

                            true
                        )
                );

            housingNameTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            DataContext,

                            "HousingEntity.FileName",

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingDensityTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            DataContext,

                            "HousingEntity.Density",

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingMaterialTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            DataContext,

                            "HousingEntity.Material",

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingHeightTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            DataContext,

                            "HousingEntity.Height",

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingDiameterTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            DataContext,

                            "HousingEntity.HousingDiameter",

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingHoleTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            DataContext,

                            "HousingEntity.HousingHole",

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );
        }
    }
}
