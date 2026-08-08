using Oil_level_glass.UI.Abstractions;
using Oil_level_glass.UI.Abstractions.Wizards.Wizard3d;

namespace Oil_level_glass.UI.Main
{
    public partial class MainForm : Form, IMainView
    {
        private readonly IWizard3dView _wizard3d;

        public MainForm(IWizard3dView wizard2d)
        {
            _wizard3d = wizard2d;

            InitializeComponent();
        }

        private void btShow3d_Click(object sender, EventArgs e)
        {
            _wizard3d.ShowView(true, this);
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
