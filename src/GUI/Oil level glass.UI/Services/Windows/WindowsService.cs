using Oil_level_glass.ViewModels.Services.Windows;
using Oil_level_glass_UI.Windows.About;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass_UI.Services.Windows
{
    internal class WindowsService : IWindowsService
    {
        public void ShowAboutWindow()
        {
            AboutWindow aboutWindow = new AboutWindow();

            aboutWindow.ShowDialog();
        }

        public void ShowWizard3dWindow()
        {
            throw new NotImplementedException();
        }
    }
}
