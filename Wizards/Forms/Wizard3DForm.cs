using Oil_level_glass.Wizards.ViewModels;

namespace Oil_level_glass.Wizards.Forms
{
    public partial class Wizard3DForm : Form
    {
        private Wizard3DViewModel? _dataContext = new Wizard3DViewModel();

        private TextBox _chamferSideAngle;
        private TextBox _chamferTwoSides;

        public Wizard3DForm()
        {
            InitializeComponent();

            DataContext = _dataContext;

            BindText();

            BindBackColors();

            BindCommands();

            BindBoolProperties();

            sideAngleChamferRadio.CheckedChanged += SideAngleChamferRadio_CheckedChanged;
        }

        private void SideAngleChamferRadio_CheckedChanged(object? sender, EventArgs e)
        {
            if (sideAngleChamferRadio.Checked)
            {


                return;
            }
        }

        private void BindText()
        {
            housingFolderTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext?.HousingData,

                            nameof(_dataContext.HousingData.FolderPath),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingNameTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext?.HousingData,

                            nameof(_dataContext.HousingData.FileName),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingDensityTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext?.HousingData,

                            nameof(_dataContext.HousingData.Density),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingMaterialTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext?.HousingData,

                            nameof(_dataContext.HousingData.Material),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingHeightTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext?.HousingData,

                            nameof(_dataContext.HousingData.Height),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingDiameterTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext?.HousingData,

                            nameof(_dataContext.HousingData.MainDiameter),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            housingHoleTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext?.HousingData,

                            nameof(_dataContext.HousingData.CentralHole),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            mainDiameterRefineInfo.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext?.HousingData.ScrewHoleData,

                            nameof(_dataContext.HousingData.ScrewHoleData.MainDiameter),

                            false
                        )
                );

            centralDiameterRefineInfo.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext?.HousingData.ScrewHoleData,

                            nameof(_dataContext.HousingData.ScrewHoleData.CentralHoleDiameter),

                            false
                        )
                );

            heightRefineInfo.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext?.HousingData.ScrewHoleData,

                            nameof(_dataContext.HousingData.ScrewHoleData.Height),

                            false
                        )
                );

            holesDistanceTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext?.HousingData.ScrewHoleData,

                            nameof(_dataContext.HousingData.ScrewHoleData.HoleDistance),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            holesCountTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            nameof(holesCountTextBox.Minimum),

                            _dataContext?.HousingData.ScrewHoleData,

                            nameof(_dataContext.HousingData.ScrewHoleData.MinHolesCount),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            holesCountTextBox.DataBindings.Add
               (
                   new Binding
                       (
                           nameof(holesCountTextBox.Maximum),

                           _dataContext?.HousingData.ScrewHoleData,

                           nameof(_dataContext.HousingData.ScrewHoleData.MaxHoleCount),

                           false,

                           DataSourceUpdateMode.OnPropertyChanged
                       )
               );

            holesDiameterTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "Text",

                            _dataContext?.HousingData.ScrewHoleData,

                            nameof(_dataContext.HousingData.ScrewHoleData.HoleDiameter),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );

            holesCountTextBox.DataBindings.Add
                (
                new Binding
                        (
                            "Text",

                            _dataContext?.HousingData.ScrewHoleData,

                            nameof(_dataContext.HousingData.ScrewHoleData.HoleCount),

                            false,

                            DataSourceUpdateMode.OnPropertyChanged
                        )
                );
        }


        private void BindCommands()
        {
            housingFolderButton.DataBindings.Add
                (
                    new Binding
                        (
                            "Command",

                           _dataContext?.HousingData,

                            nameof(_dataContext.HousingData.InvokeFolderBrowserDialog),

                            true
                        )
                );



            housingColorButton.DataBindings.Add
                (
                    new Binding
                        (
                            "Command",

                            _dataContext?.HousingData,

                            nameof(_dataContext.HousingData.InvokeColorDialog),

                            true
                        )
                );
        }

        private void BindBackColors()
        {

            housingColorBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext?.HousingData,

                            nameof(_dataContext.HousingData.ModelColor)
                        )
                );


            housingHeightTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext?.HousingHeightTextBox,

                            nameof(_dataContext.HousingHeightTextBox.BackColor)
                        )
                );

            housingDiameterTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext?.HousingDiameterTextBox,

                            nameof(_dataContext.HousingDiameterTextBox.BackColor)
                        )
                );

            housingHoleTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext?.HousingHoleTextBox,

                            nameof(_dataContext.HousingHoleTextBox.BackColor)
                        )
                );


            housingDensityTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext?.HousingDensityTextBox,

                            nameof(_dataContext.HousingDensityTextBox.BackColor)
                        )
                );


            housingNameTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext?.HousingFileNameTextBox,

                            nameof(_dataContext.HousingFileNameTextBox.BackColor)
                        )
                );


            housingFolderTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext?.HousingFolderTextBox,

                            nameof(_dataContext.HousingFolderTextBox.BackColor)
                        )
                );


            housingMaterialTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext?.HousingMaterialTextBox,

                            nameof(_dataContext.HousingMaterialTextBox.BackColor)
                        )
                );

            holesDistanceTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext?.ScrewDistanceTextBox,

                            nameof(_dataContext.ScrewDistanceTextBox.BackColor)
                        )
                );

            holesDiameterTextBox.DataBindings.Add
                (
                    new Binding
                        (
                            "BackColor",

                            _dataContext?.ScrewDiameterTextBox,

                            nameof(_dataContext.ScrewDiameterTextBox.BackColor)
                        )
                );
        }


        private void BindBoolProperties()
        {
            holesCountTextBox.DataBindings.Add
                (
                    "Enabled",

                    _dataContext?.ScrewCountTextBox,

                    nameof(_dataContext.ScrewDistanceTextBox.Enabled)
                );


            holesDiameterTextBox.DataBindings.Add
               (
                   "Enabled",

                   _dataContext?.ScrewDiameterTextBox,

                   nameof(_dataContext.ScrewDiameterTextBox.Enabled)
               );
        }


        private void Wizard3DTabControl_Selecting(object? sender, TabControlCancelEventArgs e)
        {
            TabPage? tab = e.TabPage;
            int tabIndex = wizard3DTabControl.TabPages.IndexOf(tab);

            if (tabIndex > _dataContext?.MaxTabIndex)
            {
                NotifyIcon notifyIcon = new NotifyIcon();
                notifyIcon.Icon = SystemIcons.Information;
                notifyIcon.BalloonTipTitle = "Подсказка";
                notifyIcon.BalloonTipText = $"Заполните корректными данными поля для ввода на вкладке «{wizard3DTabControl.TabPages[_dataContext.MaxTabIndex].Text}»";
                notifyIcon.Visible = true;

                notifyIcon.ShowBalloonTip(2000);

                e.Cancel = true;
            }
        }
    }
}
