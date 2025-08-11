using Oil_level_glass.Wizards.Models.Wizard3D;
using Oil_level_glass.Wizards.ViewModels;
using KompasAPI7;
using Kompas6Constants3D;

namespace Oil_level_glass.Wizards.Forms
{
    public partial class Wizard3DForm : Form
    {
        private Wizard3DViewModel _dataContext = new Wizard3DViewModel();

        public Wizard3DForm()
        {
            InitializeComponent();

            DataContext = _dataContext;

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

                            _dataContext.HousingEntity,

                            nameof(_dataContext.HousingEntity.FolderPath),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingNameTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext.HousingEntity,

                            nameof(_dataContext.HousingEntity.FileName),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingDensityTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext.HousingEntity,

                            nameof(_dataContext.HousingEntity.Density),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingMaterialTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext.HousingEntity,

                            nameof(_dataContext.HousingEntity.Material),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingHeightTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext.HousingEntity,

                            nameof(_dataContext.HousingEntity.Height),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingDiameterTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext.HousingEntity,

                            nameof(_dataContext.HousingEntity.HousingDiameter),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingHoleTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext.HousingEntity,

                            nameof(_dataContext.HousingEntity.HousingHole),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            //screwHolesDiastanceTextBox.DataBindings.Add
            //    (
            //        new Binding
            //            (
            //                "Text",

            //                _dataContext.HousingEntity,

            //                nameof(_dataContext.HousingEntity.ScrewHolesDistance),

            //                false,

            //                DataSourceUpdateMode.OnPropertyChanged
            //            )
            //    );

            //screwHolesDiameterTextBox.DataBindings.Add
            //    (
            //        new Binding
            //            (
            //                "Text",

            //                _dataContext.HousingEntity,

            //                nameof(_dataContext.HousingEntity.ScrewHolesDiameter),

            //                false,

            //                DataSourceUpdateMode.OnPropertyChanged
            //            )
            //    );
        }


        private void BindHousingCommands()
        {
            housingFolderButton.DataBindings.Add
                (
                    new Binding
                        (
                            "Command",

                           _dataContext.HousingEntity,

                            nameof(_dataContext.HousingEntity.InvokeFolderBrowserDialog),

                            true
                        )
                );



            housingColorButton.DataBindings.Add
                (
                    new Binding
                        (
                            "Command",

                            _dataContext.HousingEntity,

                            nameof(_dataContext.HousingEntity.InvokeColorDialog),

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

                            _dataContext.HousingEntity,

                            nameof(_dataContext.HousingEntity.ModelColor)
                        )
                );


            housingHeightTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext,

                            nameof(_dataContext.HousingHeightColor),

                            false,

                            DataSourceUpdateMode.OnValidation
                        )
                );

            housingDiameterTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext,

                            nameof(_dataContext.HousingDiameterColor),

                            false,

                            DataSourceUpdateMode.OnValidation
                        )
                );

            housingHoleTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext,

                            nameof(_dataContext.HousingHoleColor),

                            false,

                            DataSourceUpdateMode.OnValidation
                        )
                );


            housingDensityTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext,

                            nameof(_dataContext.HousingDensityColor),

                            false,

                            DataSourceUpdateMode.OnValidation
                        )
                );


            housingNameTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext,

                            nameof(_dataContext.HousingNameColor),

                            false,

                            DataSourceUpdateMode.OnValidation
                        )
                );


            housingFolderTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext,

                            nameof(_dataContext.HousingFolderColor),

                            false,

                            DataSourceUpdateMode.OnValidation
                        )
                );


            housingMaterialTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext,

                            nameof(_dataContext.HousingMaterialColor),

                            false,

                            DataSourceUpdateMode.OnValidation
                        )
                );


            screwHolesDiastanceTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext,

                            nameof(_dataContext.ScrewHolesDistanceColor)
                        )
                );

            screwHolesDiameterTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext,

                            nameof(_dataContext.ScrewHolesDiameterColor)
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

                            _dataContext,

                            nameof(_dataContext.ScrewHolesCountEnabled),

                            true
                        )
                );

            screwHolesDiameterTextBox.DataBindings.Add
                (
                    "Enabled",

                    _dataContext,

                    nameof(_dataContext.ScrewHolesDiameterEnabled),

                    true
                );

            screwHolesDiastanceTextBox.DataBindings.Add
                (
                    "Enabled",

                    _dataContext,

                    nameof(_dataContext.ScrewHolesDistanceEnabled),

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

                            _dataContext.HousingEntity,

                            nameof(_dataContext.HousingEntity.HousingDiameter)
                        )
                );

            holeDiameterInfoBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext.HousingEntity,

                            nameof(_dataContext.HousingEntity.HousingHole)
                        )
                );
        }

        private void housingDiameterLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
