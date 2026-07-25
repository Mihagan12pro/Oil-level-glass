using System.ComponentModel;
using System.Drawing;

namespace Oil_level_glass.UI.Controls
{
    public partial class AppeareanceEditor : UserControl
    {
        public AppeareanceEditor()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Appearance")]
        public string Header
        {
            get { return groupBox.Text; }
            set {  groupBox.Text = value; }
        }

        //[Browsable(true)]
        //[Category("Appearance")]
        //public int Transparency
        //{
        //    get { return slrTransparency.Value; }
        //    set {  slrTransparency.Value = value; }
        //}

        //[Browsable(true)]
        //[Category("Appearance")]
        //public int Specularity
        //{
        //    get { return slrSpecularity.Value; }
        //    set { slrSpecularity.Value = value; }
        //}

        //[Browsable(true)]
        //[Category("Appearance")]
        //public int Embient
        //{
        //    get { return slrEmbient.Value; }
        //    set { slrEmbient.Value = value; }
        //}

        //[Browsable(true)]
        //[Category("Appearance")]
        //public int Diffusion
        //{
        //    get { return slrDiffusion.Value; }
        //    set { slrDiffusion.Value = value; }
        //}

        //[Browsable(true)]
        //[Category("Appearance")]
        //public int Shininess
        //{
        //    get { return slrShininess.Value; }
        //    set { slrShininess.Value = value; }
        //}

        //[Browsable(true)]
        //[Category("Appearance")]
        //public int Emission
        //{
        //    get { return slrEmission.Value; }
        //    set { slrEmission.Value = value; }
        //}

        [Browsable(true)]
        [Category("Appearance")]
        public Color Color
        {
            get { return pnlColor.BackColor; }
            set { pnlColor.BackColor = value; }
        }

        private void btSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pnlColor.BackColor = colorDialog.Color;
            }
        }
    }
}
