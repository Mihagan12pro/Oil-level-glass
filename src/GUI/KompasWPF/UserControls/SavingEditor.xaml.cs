using System.Windows;

namespace KompasWPF.UserControls
{
    /// <summary>
    /// Interaction logic for SavingEditor.xaml
    /// </summary>
    public partial class SavingEditor 
        : GroupControlBase
    {
        public string Directory
        {
            get
            {
                return (string)GetValue(DirectoryProperty);
            }
            set
            {
                SetValue(DirectoryProperty, value);
            }
        }


        public static readonly DependencyProperty DirectoryProperty = DependencyProperty.Register(
            nameof(Directory),
            typeof(string),
            typeof(SavingEditor));

        public string Naming
        {
            get
            {
                return (string)GetValue(NamingProperty);
            }
            set
            {
                SetValue(NamingProperty, value);
            }
        }

        public static readonly DependencyProperty NamingProperty = DependencyProperty.Register(
            nameof(Naming),
            typeof(string),
            typeof(SavingEditor));

        public string Marking
        {
            get
            {
                return (string)GetValue(MarkingProperty);
            }
            set
            {
                SetValue(MarkingProperty, value);
            }
        }

        public static readonly DependencyProperty MarkingProperty = DependencyProperty.Register(
            nameof(Marking),
            typeof(string),
            typeof(SavingEditor));

        public SavingEditor()
        {
            InitializeComponent();
        }
    }
}
