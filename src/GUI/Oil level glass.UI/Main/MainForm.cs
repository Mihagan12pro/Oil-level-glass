using Oil_level_glass.UI.Wizard3d;

namespace Oil_level_glass.UI.Main
{
    public partial class MainForm : Form
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

        }
    }
}
