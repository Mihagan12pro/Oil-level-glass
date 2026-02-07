using Oil_level_glass.Core.Records;
using Oil_level_glass.Model.Data.Operations;

namespace Oil_level_glass.Core.KompasDialogs
{
    /// <summary>
    /// Dialog for selecting standard thread
    /// </summary>
    public interface IThreadsDialog
    {
        DialogResult SelectThread(ThreadModel thread);

        DialogResult SelectThread(ThreadModel thread, double maximumDiameter, bool isStrictly = false);
    }
}
