using Oil_level_glass.Model.Data.Other;

namespace Oil_level_glass.UI.Editors.View
{
    public partial class ModelAppereanceForm : Form
    {
        public required Model.Data.Other.Appearance HousingAppereance { get; set; }

        public required Model.Data.Other.Appearance RubberStripAppereance { get; set; }

        public required Model.Data.Other.Appearance GlassAppereance { get; set; }

        public ModelAppereanceForm()
        {
            InitializeComponent();
        }

        private void btChooseColor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    pnlColor.BackColor = colorDialog.Color;
                }
            }
        }

        private void cbChoosePart_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbChoosePart.SelectedIndex != -1)
            {
                btApply.Enabled = true;
                btChooseColor.Enabled = true;

                tbAmbient.Enabled = true;
                tbDiffuse.Enabled = true;
                tbEmission.Enabled = true;
                tbShininess.Enabled = true;
                tbSpecularity.Enabled = true;
                tbTransperency.Enabled = true;

                switch (cbChoosePart.SelectedIndex)
                {
                    case 0:
                        {
                            SetControlsValues(HousingAppereance);

                            break;
                        }

                    case 1:
                        {
                            SetControlsValues(GlassAppereance);

                            break;
                        }

                    case 2:
                        {
                            SetControlsValues(RubberStripAppereance);

                            break;
                        }
                }
            }
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            switch (cbChoosePart.SelectedIndex)
            {
                case 0:
                    {
                        GetControlsValues(HousingAppereance);
                        break;
                    }

                case 1:
                    {
                        GetControlsValues(HousingAppereance);
                        break;
                    }

                case 2:
                    {
                        GetControlsValues(HousingAppereance);
                        break;
                    }
            }

            DialogResult = DialogResult.OK;

            return;
        }

        private void SetControlsValues(Model.Data.Other.Appearance appearance)
        {
            pnlColor.BackColor = Color.FromArgb(
                appearance.Color.Red,
                appearance.Color.Green,
                appearance.Color.Blue
            );

            tbAmbient.Value = Convert.ToDecimal(appearance.Ambient);
            tbDiffuse.Value = Convert.ToDecimal(appearance.Diffuse);
            tbEmission.Value = Convert.ToDecimal(appearance.Emission);
            tbShininess.Value = Convert.ToDecimal(appearance.Shininess);
            tbSpecularity.Value = Convert.ToDecimal(appearance.Specularity);
            tbTransperency.Value = Convert.ToDecimal(appearance.Transparency);
        }

        private void GetControlsValues(Model.Data.Other.Appearance appearance)
        {
            appearance.Color.Red = pnlColor.BackColor.R;
            appearance.Color.Green = pnlColor.BackColor.G;
            appearance.Color.Blue = pnlColor.BackColor.B;

            appearance.Ambient = Convert.ToDouble(tbAmbient.Value);
            appearance.Diffuse = Convert.ToDouble(tbDiffuse.Value);
            appearance.Emission = Convert.ToDouble(tbEmission.Value);
            appearance.Shininess = Convert.ToDouble(tbShininess.Value);
            appearance.Specularity = Convert.ToDouble(tbSpecularity.Value);
            appearance.Transparency = Convert.ToDouble(tbTransperency.Value);
        }
    }
}
