using Kompas6API5;
using KompasAPI7;
using NativeMethods;
using Oil_level_glass.Core.KompasDialogs;

namespace Oil_level_glass.COM.KompasDialogs
{
    public class ComDialogsProvider
        : IDialogsProvider
    {
        public IColorDialog GetColorDialog()
        {
            IApplication application = GetApplication();

            return new ColorDialog(application);
        }

        public IMaterialDialog GetMaterialDialog()
        {
            IApplication application = GetApplication();

            return new MaterialDialog(application);
        }

        public IThreadDialog GetThreadDialog()
        {
            IApplication application = GetApplication();

            return new ThreadDialog(application);
        }

        private IApplication GetApplication()
        {
            KompasObject kompasObject = (KompasObject)ComConnector.GetInstance("KOMPAS.Application.5");

            return (IApplication)kompasObject.ksGetApplication7();
        }
    }
}
