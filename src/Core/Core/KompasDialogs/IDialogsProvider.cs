namespace Oil_level_glass.Core.KompasDialogs
{
    public interface IDialogsProvider
    {
        IColorsDialog GetColorsDialog();

        IMaterialsDialog GetMaterialsDialog();

        IThreadsDialog GetThreadsDialog();
    }
}
