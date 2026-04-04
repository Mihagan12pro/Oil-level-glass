using System.ComponentModel;

namespace Oil_level_glass.UI.Controls.HelpControls
{
    public partial class Slider : UserControl
    {
        public Slider()
        {
            InitializeComponent();

            tbValue.Text = Value.ToString();
        }

        [Browsable(true)]
        [Category("Appearance")]
        public string Header
        {
            get { return groupBox.Text; }
            set { groupBox.Text = value; }
        }

        [Browsable(true)]
        [Category("Appearance")]
        public int Max
        {
            get { return trackBar.Maximum; }
            set { trackBar.Maximum = value; }
        }

        [Browsable(true)]
        [Category("Appearance")]
        public int Min
        {
            get { return trackBar.Minimum; }

            set { trackBar.Minimum = value; }
        }

        [Browsable(true)]
        [Category("Appearance")]
        public int Value
        {
            get { return trackBar.Value; }

            set { trackBar.Value = value; }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            tbValue.Text = Value.ToString();
        }
    }
}
