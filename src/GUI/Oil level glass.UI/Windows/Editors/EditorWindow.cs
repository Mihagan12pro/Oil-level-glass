using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Oil_level_glass_UI.Windows.Editors
{
    public abstract partial class EditorWindow : NoneWindow
    {
        public EditorWindow()
        {
           
        }

        protected abstract void BtCheck_Click(object sender, System.Windows.RoutedEventArgs e);
    }
}
