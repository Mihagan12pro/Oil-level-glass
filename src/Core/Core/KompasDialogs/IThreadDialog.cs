using Oil_level_glass.Model.Data.Operations;

namespace Oil_level_glass.Core.KompasDialogs
{
    /// <summary>
    /// Dialog for selecting standard thread
    /// </summary>
    public interface IThreadDialog
    {
        void SelectThread(ThreadModel thread);

        void SelectThread(ThreadModel thread, double maximumDiameter, bool isStrictly = false);
    }
}
