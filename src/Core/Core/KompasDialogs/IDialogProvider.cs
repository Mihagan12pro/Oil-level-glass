namespace Oil_level_glass.Core.KompasDialogs
{
    public interface IDialogProvider
    {
        IColorDialog GetColorDialog();

        IMaterialDialog GetMaterialDialog();

        IThreadDialog GetThreadDialog();
    }
}
