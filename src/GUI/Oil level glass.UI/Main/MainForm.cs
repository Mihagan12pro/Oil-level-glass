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
            Wizard3d.Wizard3dForm wizard3DForm = new Wizard3d.Wizard3dForm();

            wizard3DForm.Show();
        }

        private void btShowAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
