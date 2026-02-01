using KompasWPF.CustomControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace KompasWPF.UserControls
{
    /// <summary>
    /// Interaction logic for XpsViewer.xaml
    /// </summary>
    public partial class XpsViewer : UserControl
    {
        public IDocumentPaginatorSource Document
        {
            get
            {
                return (IDocumentPaginatorSource)GetValue(DocumentProperty);
            }
            set
            {
                SetValue(DocumentProperty, value);
            }
        }

        public static readonly DependencyProperty DocumentProperty = DependencyProperty.Register(
            nameof(Document),
            typeof(IDocumentPaginatorSource),
            typeof(XpsViewer)
            );

        public XpsViewer()
        {
            InitializeComponent();
        }

        private void XpsDocumentViewer_Zooming(object sender, RoutedEventArgs e)
        {
            XpsDocumentViewer viewer = (XpsDocumentViewer)sender;

            SlrScaler.Value = Convert.ToInt32(Math.Round(viewer.Zoom, 0));
        }

        private void SlrScaler_Scaling(object sender, RoutedEventArgs e)
        {
            ScalingSlider slider = (ScalingSlider)sender;

            Viewer.Zoom = slider.Value;
        }
    }
}
