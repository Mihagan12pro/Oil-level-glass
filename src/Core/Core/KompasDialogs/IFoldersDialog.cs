using Oil_level_glass.Model.Data.KompasFile;

namespace Oil_level_glass.Core.KompasDialogs
{
    /// <summary>
    /// Dialog for selecting folders
    /// </summary>
    public interface IFoldersDialog
    {
        void SelectFolder(KompasFile file);

        void SelectFolder(KompasFile file, string initialFolder);
    }
}
