using System.Windows;
using System.Windows.Controls;

namespace KompasWPF.CustomControls
{
    public partial class XpsDocumentViewer : DocumentViewer
    {
        public static readonly RoutedEvent ZoomingEvent = EventManager.RegisterRoutedEvent(
            name: "Zooming",
            routingStrategy: RoutingStrategy.Bubble,
            handlerType: typeof(RoutedEventHandler),
            ownerType: typeof(XpsDocumentViewer));

        public event RoutedEventHandler Zooming
        {
            add { AddHandler(ZoomingEvent, value); }
            remove { RemoveHandler(ZoomingEvent, value); }
        }

        protected override void OnIncreaseZoomCommand()
        {
            base.OnIncreaseZoomCommand();

            RaiseZoomingRoutedEvent();
        }

        protected override void OnDecreaseZoomCommand()
        {
            base.OnDecreaseZoomCommand();

            RaiseZoomingRoutedEvent();
        }

        private void RaiseZoomingRoutedEvent()
        {
            RoutedEventArgs routedEventArgs = new(routedEvent: ZoomingEvent);

            RaiseEvent(routedEventArgs);
        }
    }
}
