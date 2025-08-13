using Oil_level_glass.Wizards.Models.Wizard3D;
using Oil_level_glass.Wizards.ViewModels;
using KompasAPI7;
using Kompas6Constants3D;
using System.Linq;
using System.ComponentModel;

namespace Oil_level_glass.Wizards.Forms
{
    public partial class Wizard3DForm : Form
    {
        private Wizard3DViewModel? _dataContext = new Wizard3DViewModel();

        public Wizard3DForm()
        {
            InitializeComponent();

            DataContext = _dataContext;

            BindHousingProperties();

            BindReadOnlyFields();

            BindEnabled();



            wizard3DTabControl.Selecting += Wizard3DTabControl_Selecting;
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

    

            

            //NotifyIcon notifyIcon = new NotifyIcon();
            //notifyIcon.Icon = SystemIcons.Information;
            //notifyIcon.Bal
            //notifyIcon.BalloonTipTitle = "Подсказка";
            //notifyIcon.BalloonTipText = $"Занесите корретные данные в поля для ввода на вкладке {wizard3DTabControl.TabPages[_dataContext.MaxTabIndex].Text}!";

            //notifyIcon.Visible = true;
            //notifyIcon.ShowBalloonTip(500);
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

        private void BindHousingBackColors()
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
        }


        private void BindEnabled()
        {
            //housingRefineTabPage.DataBindings.Add
            //    (
            //        new Binding
            //            (
            //                "Enabled",

            //                _dataContext?.HousingRefineTabPage,

            //                nameof(_dataContext.HousingRefineTabPage.Enabled)
            //            )
            //    );
            //screwHolesComboBox.DataBindings.Add
            //    (
            //        new Binding
            //            (
            //                "Enabled",

            //                _dataContext,

            //                nameof(_dataContext.ScrewHolesCountEnabled),

            //                true
            //            )
            //    );

            //screwHolesDiameterTextBox.DataBindings.Add
            //    (
            //        "Enabled",

            //        _dataContext,

            //        nameof(_dataContext.ScrewHolesDiameterEnabled),

            //        true
            //    );

            //screwHolesDiastanceTextBox.DataBindings.Add
            //    (
            //        "Enabled",

            //        _dataContext,

            //        nameof(_dataContext.ScrewHolesDistanceEnabled),

            //        true
            //    );
        }


        private void BindReadOnlyFields()
        {
            //housingDiameterInfoBox.DataBindings.Add
            //    (
            //        new Binding
            //            (
            //                "Text",

            //                _dataContext?.HousingData,

            //                nameof(_dataContext.HousingData.MainDiameter)
            //            )
            //    );

            //holeDiameterInfoBox.DataBindings.Add
            //    (
            //        new Binding
            //            (
            //                "Text",

            //                _dataContext?.HousingData,

            //                nameof(_dataContext.HousingData.CentralHole)
            //            )
            //    );
        }
    }
}
