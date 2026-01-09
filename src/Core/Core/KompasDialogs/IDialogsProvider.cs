namespace Oil_level_glass.Core.KompasDialogs
{
    public interface IDialogsProvider
    {
        IColorDialog GetColorDialog();

        IMaterialDialog GetMaterialDialog();

        IThreadDialog GetThreadDialog();
    }
}
