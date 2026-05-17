using Oil_level_glass.UI.Abstractions;
using Oil_level_glass.UI.Wizard3d;

namespace Oil_level_glass.UI.Main
{
    public partial class MainForm : Form, IForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btShow3d_Click(object sender, EventArgs e)
        {
            Wizard3dForm wizard3DForm = new Wizard3dForm();
            wizard3DForm.Owner = this;

            wizard3DForm.ShowDialog();
        }

        private void btShowAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();

            aboutForm.Owner = this;
            aboutForm.ShowDialog();
        }

        private void pbMain_Click(object sender, EventArgs e)
        {

        }
    }
}
