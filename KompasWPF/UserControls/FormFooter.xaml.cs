using System.Windows;
using System.Windows.Controls;

namespace KompasWPF.UserControls
{
    public partial class FormFooter : UserControl
    {
        public FormFooter()
        {
            InitializeComponent();

            CancelAction = () => { Window.GetWindow(this).DialogResult = true; };
        }

        public CancelAction? CancelAction { get; set; }

        public OkAction? OkAction { get; set; }


        private void BtCancel_Click(object sender, RoutedEventArgs e)
        {
            CancelAction?.Invoke();
        }
    }

    public delegate void CancelAction();

    public delegate void OkAction();
}
