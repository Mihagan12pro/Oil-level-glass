using KompasAPI7;
using Oil_level_glass.Core.KompasDialogs;
using Oil_level_glass.Model.Data.Operations;

namespace Oil_level_glass.COM.KompasDialogs
{
    internal class ThreadDialog
        : ComDialogBase, IThreadDialog
    {
        protected internal ThreadDialog(IApplication application) : base(application)
        {
        }

        public void SelectThread(ThreadModel thread)
        {
            throw new NotImplementedException();
        }
    }
}
