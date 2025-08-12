using Oil_level_glass.Wizards.Forms;
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

        private void AssembleWizardButton_Click(object sender, EventArgs e)
        {
            Wizard3DForm form = new Wizard3DForm();

            form.ShowDialog();
        }
    }
}
