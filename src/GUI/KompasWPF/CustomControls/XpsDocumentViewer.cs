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

            RaiseCustomRoutedEvent();
        }

        protected override void OnDecreaseZoomCommand()
        {
            base.OnDecreaseZoomCommand();

            RaiseCustomRoutedEvent();
        }

        private void RaiseCustomRoutedEvent()
        {
            RoutedEventArgs routedEventArgs = new(routedEvent: ZoomingEvent);

            RaiseEvent(routedEventArgs);
        }
    }
}
