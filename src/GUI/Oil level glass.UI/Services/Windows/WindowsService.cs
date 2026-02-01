using Oil_level_glass.ViewModels.Services.Windows;
using Oil_level_glass_UI.Windows.About;
using Oil_level_glass_UI.Windows.Wizard3D;

namespace Oil_level_glass_UI.Services.Windows
{
    internal class WindowsService : IWindowsService
    {
        public void ShowAboutWindow()
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.ShowInTaskbar = false;

            aboutWindow.ShowDialog();
        }

        public void ShowWizard3dWindow()
        {
            Wizard3DWindow wizard3dWindow = new Wizard3DWindow();
            wizard3dWindow.ShowInTaskbar = false;

            wizard3dWindow.ShowDialog();
        }
    }
}
