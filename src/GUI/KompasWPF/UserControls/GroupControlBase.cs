using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace KompasWPF.UserControls
{
    /// <summary>
    /// User control with group box
    /// </summary>
    public partial class GroupControlBase
        : UserControl
    {
        public ICommand Command
        {
            get
            {
                return (ICommand)GetValue(CommandProperty);
            }
            set
            {
                SetValue(CommandProperty, value);
            }
        }

        public static DependencyProperty CommandProperty = DependencyProperty.Register(
            nameof(Command),
            typeof(ICommand),
            typeof(GroupControlBase)
            );

        public string Header
        {
            get
            {
                return (string)GetValue(HeaderProperty);
            }
            set
            {
                SetValue(HeaderProperty, value);
            }
        }

        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register(
            nameof(Header),
            typeof(string),
            typeof(GroupControlBase),
            new FrameworkPropertyMetadata(defaultValue: "Part")
            );
    }
}
