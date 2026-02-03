using Oil_level_glass.Core;
using Oil_level_glass.ViewModels.Services.Windows;
using Oil_level_glass_UI.Windows.About;
using Oil_level_glass_UI.Windows.Wizard3D;
using System.Runtime.InteropServices;
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
            try
            {
                _connectionChecker.Check();

                Wizard3DWindow wizard3dWindow = new Wizard3DWindow();

                wizard3dWindow.ShowDialog();
            }
            catch(COMException)
            {
                MessageBox.Show("Для работы с мастером трёхмерной модели необходимо запустить КОМПАС-3D!", "ВНИМАНИЕ!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public WindowsService(IConnectionChecker connectionChecker)
        {
            _connectionChecker = connectionChecker;
        }
    }
}
