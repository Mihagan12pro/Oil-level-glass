using KompasAPI7;
using Oil_level_glass.Core.KompasDialogs;
using Oil_level_glass.Model.Data.KompasFile;

namespace Oil_level_glass.COM.KompasDialogs
{
    internal class FoldersDialog
        : ComDialogBase, IFoldersDialog
    {
        public void SelectFolder(KompasFile file)
        {
            SelectFolder(file, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }

        public void SelectFolder(KompasFile file, string initialFolder)
        {
            string result = applicationDialogs.ChoiceFolder(hwnd, initialFolder);

            if (result != string.Empty)
                file.Folder = result;
        }

        protected internal FoldersDialog(IApplication application) 
            : base(application)
        {
        }
    }
}
