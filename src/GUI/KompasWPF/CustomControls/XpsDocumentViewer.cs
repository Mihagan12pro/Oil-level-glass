using System.Windows.Controls;

namespace KompasWPF.CustomControls
{
    public partial class XpsDocumentViewer : DocumentViewer
    {
        public delegate void ZoomingHandler();

        public event ZoomingHandler? Zooming;

        protected override void OnIncreaseZoomCommand()
        {
            base.OnIncreaseZoomCommand();

            Zooming?.Invoke();
        }

        protected override void OnDecreaseZoomCommand()
        {
            base.OnDecreaseZoomCommand();

            Zooming?.Invoke();
        }
    }
}
