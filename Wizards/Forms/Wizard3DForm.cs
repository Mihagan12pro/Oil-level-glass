using Oil_level_glass.Wizards.Models.Wizard3D;
using Oil_level_glass.Wizards.ViewModels;
using KompasAPI7;
using Kompas6Constants3D;

namespace Oil_level_glass.Wizards.Forms
{
    public partial class Wizard3DForm : Form
    {
        public Wizard3DForm()
        {
            InitializeComponent();

            DataContext = new Wizard3DViewModel();

            BindHousingProperties();

            BindReadOnlyFields();

            BindEnabled();
        }


        private void BindHousingProperties()
        {
            BindHousingText();

            BindHousingBackColors();

            BindHousingCommands();
        }


        private void BindHousingText()
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

            screwHolesDiastanceTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            DataContext,

                            "HousingEntity.ScrewHolesDistance",

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            screwHolesDiameterTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            DataContext,

                            "HousingEntity.ScrewHolesDiameter",

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );
        }


        private void BindHousingCommands()
        {
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
        }

        private void BindHousingBackColors()
        {

            housingColorBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            DataContext,

                            "HousingEntity.ModelColor"
                        )
                );


            housingHeightTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            DataContext,

                            "HousingHeightColor",

                            false,

                            DataSourceUpdateMode.OnValidation
                        )
                );

            housingDiameterTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            DataContext,

                            "HousingDiameterColor",

                            false,

                            DataSourceUpdateMode.OnValidation
                        )
                );

            housingHoleTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            DataContext,

                            "HousingHoleColor",

                            false,

                            DataSourceUpdateMode.OnValidation
                        )
                );


            housingDensityTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            DataContext,

                            "HousingDensityColor",

                            false,

                            DataSourceUpdateMode.OnValidation
                        )
                );


            housingNameTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            DataContext,

                            "HousingNameColor",

                            false,

                            DataSourceUpdateMode.OnValidation
                        )
                );


            housingFolderTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            DataContext,

                            "HousingFolderColor",

                            false,

                            DataSourceUpdateMode.OnValidation
                        )
                );


            housingMaterialTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            DataContext,

                            "HousingMaterialColor",

                            false,

                            DataSourceUpdateMode.OnValidation
                        )
                );


            screwHolesDiastanceTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            DataContext,

                            "ScrewHolesDistanceColor"
                        )
                );

            screwHolesDiameterTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            DataContext,

                            "ScrewHolesDiameterColor"
                        )
                );
        }


        private void BindEnabled()
        {
            screwHolesComboBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Enabled",

                            DataContext,

                            "ScrewHolesCountEnabled",

                            true
                        )
                );

            screwHolesDiameterTextBox.DataBindings.Add
                (
                    "Enabled",

                    DataContext,

                    "ScrewHolesDiameterEnabled",

                    true
                );

            screwHolesDiastanceTextBox.DataBindings.Add
                (
                    "Enabled",

                    DataContext,

                    "ScrewHolesDistanceEnabled",

                    true
                );
        }


        private void BindReadOnlyFields()
        {
            housingDiameterInfoBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            DataContext,

                            "HousingEntity.HousingDiameter"
                        )
                );

            holeDiameterInfoBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            DataContext,

                            "HousingEntity.HousingHole"
                        )
                );
        }

        private void housingDiameterLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
