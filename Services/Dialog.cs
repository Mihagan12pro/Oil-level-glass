using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.Services
{
    internal static class Dialog
    {
        public static Color InvokeColorDialog(Color color, bool fullOpen = true)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = color;
            dialog.FullOpen = fullOpen;

            if (dialog.ShowDialog() == DialogResult.OK)
                color = dialog.Color;

            return color;
        }
        

        public static void InvokeFolderBrowser(string? path, Environment.SpecialFolder rootFolder = Environment.SpecialFolder.MyDocuments)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
  
            dialog.RootFolder = rootFolder;

    

            if (dialog.ShowDialog() == DialogResult.OK)
                path = dialog.SelectedPath;
        }
    }
}
