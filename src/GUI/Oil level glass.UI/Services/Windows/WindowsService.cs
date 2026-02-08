using Oil_level_glass.Core;
using Oil_level_glass.Core.Records;
using Oil_level_glass.ViewModels.Services.Windows;
using Oil_level_glass_UI.Windows.About;
using Oil_level_glass_UI.Windows.Wizard3D;
using System.Windows;

namespace Oil_level_glass_UI.Services.Windows
{
    internal class WindowsService
        : IWindowsService
    {
        private readonly IConnectionChecker _connectionChecker;
        private readonly Window _parent;
        public void ShowAboutWindow()
        {
            AboutWindow aboutWindow = new AboutWindow();
            
            ShowModalWindow(aboutWindow);
        }

        public void ShowWizard3dWindow()
        {
            DialogResult result = _connectionChecker.Check(KompasDocumentType.Assembly);

            if (!result.Success)
            {
                MessageBox.Show(
                    result.Message,
                    result.Caption, 
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                return;
            }

            Wizard3DWindow wizard3dWindow = new Wizard3DWindow();

            ShowModalWindow(wizard3dWindow);
        }

        private void ShowModalWindow(Window window)
        {
            window.Owner = _parent;
            window.ShowInTaskbar = false;

            window.ShowDialog();
        }


        public WindowsService(
            IConnectionChecker connectionChecker,
            Window parent)
        {
            _connectionChecker = connectionChecker;
            _parent = parent;
        }
    }
}
