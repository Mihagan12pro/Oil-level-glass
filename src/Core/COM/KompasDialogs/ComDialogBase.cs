using KompasAPI7;

namespace Oil_level_glass.COM.KompasDialogs
{
    internal class ComDialogBase
    {
        protected readonly int hwnd;

        protected readonly IApplication application;

        protected readonly IApplicationDialogs applicationDialogs;

        public string Title { get; init; } = "";

        protected internal ComDialogBase(IApplication application)
        {
            this.application = application;

            hwnd = this.application.ActiveDocument.DocumentFrames[0].GetHWND();

            applicationDialogs = (IApplicationDialogs)this.application;
        }
    }
}
