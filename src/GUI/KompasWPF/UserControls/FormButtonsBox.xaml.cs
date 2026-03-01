using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace KompasWPF.UserControls
{
    /// <summary>
    /// Interaction logic for FormButtonsBox.xaml
    /// </summary>
    public partial class FormButtonsBox : UserControl
    {
        public string OkContent
        {
            get
            {
                return (string)GetValue(OkContentProperty);
            }
            set
            {
                SetValue(OkContentProperty, value);
            }
        }

        public static readonly DependencyProperty OkContentProperty = DependencyProperty.Register(
            nameof(OkContent),
            typeof(string),
            typeof(FormButtonsBox),
            new PropertyMetadata("Ок")
            );

        public string CancelContent
        {
            get
            {
                return (string)GetValue(CancelContentProperty);
            }
            set
            {
                SetValue(CancelContentProperty, value);
            }
        }

        public static readonly DependencyProperty CancelContentProperty = DependencyProperty.Register(
            nameof(CancelContent),
            typeof(string),
            typeof(FormButtonsBox),
            new PropertyMetadata("Отмена")
            );

        public ICommand OkCommand
        {
            get
            {
                return (ICommand)GetValue(OkCommandProperty);
            }
            set
            {
                SetValue(OkCommandProperty, value);
            }
        }

        public static readonly DependencyProperty OkCommandProperty = DependencyProperty.Register(
            nameof(OkCommand),
            typeof(ICommand),
            typeof(FormButtonsBox)
            );

        public ICommand CancelCommand
        {
            get
            {
                return (ICommand)GetValue(CancelCommandProperty);
            }
            set
            {
                SetValue(CancelCommandProperty, value);
            }
        }

        public static readonly DependencyProperty CancelCommandProperty = DependencyProperty.Register(
            nameof(CancelCommand),
            typeof(ICommand),
            typeof(FormButtonsBox)
            );

        public bool IsOkEnabled
        {
            get
            {
                return (bool)GetValue(IsOkEnabledProperty);
            }
            set
            {
                SetValue(IsOkEnabledProperty, value);
            }
        }

        public static readonly DependencyProperty IsOkEnabledProperty = DependencyProperty.Register(
            nameof(IsOkEnabled),
            typeof(bool),
            typeof(FormButtonsBox),
            new FrameworkPropertyMetadata(false)
            );


        public FormButtonsBox()
        {
            InitializeComponent();
        }
    }
}
