
using System.Diagnostics;
using System.Reflection;

namespace Oil_level_glass
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Text = Assembly.GetExecutingAssembly().GetName().Name;

            authorsGitHubLink.LinkClicked += AuthorsGitHubLink_LinkClicked;
        }

        private void AuthorsGitHubLink_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://github.com/Mihagan12pro") { UseShellExecute = true });
        }

        private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e)
        {
            //mainFormLeftPanel.Height = splitContainer1.Panel1.Height;
            //mainFormLeftPanel.Width = splitContainer1.Panel1.Width;
        }
    }
}
