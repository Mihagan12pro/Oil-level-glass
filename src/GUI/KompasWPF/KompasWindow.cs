using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KompasWPF
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:KompasWPF"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:KompasWPF;assembly=KompasWPF"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    public partial class KompasWindow : Window
    {
        public Button CloseButton { get; protected set; } = null!;

        public Button MinimizeButton { get; protected set; } = null!;

        public Button MaximizeButton { get; protected set; } = null!;

        public Button RestoreButton { get; protected set; } = null!;

        public Grid WindowControlsGrid { get; protected set; } = null!;

        public Grid HeaderBar { get; protected set; } = null!;

        private bool _isTemplateApplied = false;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            CloseButton = GetRequiredTemplateChild<Button>(nameof(CloseButton));
            MinimizeButton = GetRequiredTemplateChild<Button>(nameof(MinimizeButton));
            MaximizeButton = GetRequiredTemplateChild<Button>(nameof(MaximizeButton));
            RestoreButton = GetRequiredTemplateChild<Button>(nameof(RestoreButton));

            WindowControlsGrid = GetRequiredTemplateChild<Grid>(nameof(WindowControlsGrid));
            HeaderBar = GetRequiredTemplateChild<Grid>("PART_HeaderBar");

            switch(ResizeMode)
            {
                case ResizeMode.NoResize:
                    {
                        MinimizeButton.Visibility = Visibility.Collapsed;
                        MaximizeButton.Visibility = Visibility.Collapsed;
                        RestoreButton.Visibility = Visibility.Collapsed;
                        break;
                    }
                case ResizeMode.CanMinimize:
                    {
                        MaximizeButton.IsEnabled = false;

                        break;
                    }
            }

            _isTemplateApplied = true;

            if (IsLoaded)
            {
                InitializeEventHandlers();
            }
        }


        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            Loaded += KompasWindow_Loaded;
        }

        private void KompasWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (_isTemplateApplied)
            {
                InitializeEventHandlers();
            }
            else
            {
                ApplyTemplate();

                CloseButton = GetRequiredTemplateChild<Button>(nameof(CloseButton));
                MinimizeButton = GetRequiredTemplateChild<Button>(nameof(MinimizeButton));
                MaximizeButton = GetRequiredTemplateChild<Button>(nameof(MaximizeButton));
                RestoreButton = GetRequiredTemplateChild<Button>(nameof(RestoreButton));
                WindowControlsGrid = GetRequiredTemplateChild<Grid>(nameof(WindowControlsGrid));
                HeaderBar = GetRequiredTemplateChild<Grid>("PART_HeaderBar");
            
                _isTemplateApplied = true;
                InitializeEventHandlers();
            }
        }

        private void UiElement_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        

        protected void ToggleWindowState()
        {
            if (WindowState == WindowState.Maximized)
            {
                MaximizeButton.Visibility = Visibility.Visible;
                RestoreButton.Visibility = Visibility.Collapsed;

                WindowState = WindowState.Normal;
            }
            else if (WindowState == WindowState.Normal)
            {
                MaximizeButton.Visibility = Visibility.Collapsed;
                RestoreButton.Visibility = Visibility.Visible;

                WindowState = WindowState.Maximized;
            }
        }


        private void RestoreButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleWindowState();
        }

      
        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleWindowState();
        }
        
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InitializeEventHandlers()
        {
            MaximizeButton.Click += MaximizeButton_Click;
            CloseButton.Click += CloseButton_Click;
            MinimizeButton.Click += MinimizeButton_Click;
            RestoreButton.Click += RestoreButton_Click;

            foreach (UIElement uiElement in HeaderBar.Children)
            {
                if (uiElement != WindowControlsGrid)
                {
                    uiElement.PreviewMouseDown += UiElement_PreviewMouseDown;
                }
            }
        }


        public T GetRequiredTemplateChild<T>(string childName) where T : DependencyObject
        {
            return (T)base.GetTemplateChild(childName);
        }


        public KompasWindow()
        {
           
        }
    }
}