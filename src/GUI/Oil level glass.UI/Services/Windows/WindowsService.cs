using Oil_level_glass.Core;
using Oil_level_glass.Core.Records;
using Oil_level_glass.ViewModels.Services.Windows;
using Oil_level_glass_UI.Windows.About;
using Oil_level_glass_UI.Windows.Wizard3D;
using System.Windows;

namespace Oil_level_glass_UI.Services.Windows
{
    internal class WindowsService : IWindowsService
    {
        private readonly IConnectionChecker _connectionChecker;

        public void ShowAboutWindow()
        {
            AboutWindow aboutWindow = new AboutWindow();

            aboutWindow.ShowDialog();
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

            wizard3dWindow.ShowDialog();
        }

        public WindowsService(IConnectionChecker connectionChecker)
        {
            _connectionChecker = connectionChecker;
        }
    }
}
