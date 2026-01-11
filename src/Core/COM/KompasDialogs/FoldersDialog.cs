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
            throw new NotImplementedException();
        }

        public void SelectFolder(KompasFile file, string initialFolder)
        {
            throw new NotImplementedException();
        }

        protected internal FoldersDialog(IApplication application) 
            : base(application)
        {
        }
    }
}
