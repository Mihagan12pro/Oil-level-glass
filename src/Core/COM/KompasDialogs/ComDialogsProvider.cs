using Kompas6API5;
using KompasAPI7;
using NativeMethods;
using Oil_level_glass.Core.KompasDialogs;

namespace Oil_level_glass.COM.KompasDialogs
{
    public class ComDialogsProvider
        : IDialogsProvider
    {
        public IColorsDialog GetColorsDialog()
        {
            IApplication application = GetApplication();

            return new ColorsDialog(application);
        }

        public IMaterialsDialog GetMaterialsDialog()
        {
            IApplication application = GetApplication();

            return new MaterialsDialog(application);
        }

        public IThreadsDialog GetThreadsDialog()
        {
            IApplication application = GetApplication();

            return new ThreadsDialog(application);
        }

        public IFoldersDialog GetFoldersDialog()
        {
            IApplication application = GetApplication();

            return new FoldersDialog(application);
        }

        private IApplication GetApplication()
        {
            KompasObject kompasObject = (KompasObject)ComConnector.GetInstance("KOMPAS.Application.5");

            return (IApplication)kompasObject.ksGetApplication7();
        }
    }
}
