using System.Windows;
using System.Windows.Input;

namespace Oil_level_glass_UI.Windows
{
    /// <summary>
    /// For windows with WindowStyle = None
    /// </summary>
    public abstract partial class NoneWindow : Window
    {
        protected readonly Action closeAction;

        protected void WindowHeader_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        public NoneWindow()
        {
            closeAction = () => this.Close();

            WindowStyle = WindowStyle.None;
        }
    }
}
