using Oil_level_glass.Model.Data.Other;
using Oil_level_glass.UI.Editors.Menus;
using Appearance = Oil_level_glass.Model.Data.Other.Appearance;

namespace Oil_level_glass.UI.Editors.View
{
    public partial class ModelAppereanceForm : BaseMenuForm<Appearance>
    {
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

        protected override void SetControlsValues(Model.Data.Other.Appearance appearance)
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

        protected override void GetControlsValues(Model.Data.Other.Appearance appearance)
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

        protected override void MakeControlsEnabled()
        {
            base.MakeControlsEnabled();

            btApply.Enabled = true;
            btChooseColor.Enabled = true;

            tbAmbient.Enabled = true;
            tbDiffuse.Enabled = true;
            tbEmission.Enabled = true;
            tbShininess.Enabled = true;
            tbSpecularity.Enabled = true;
            tbTransperency.Enabled = true;
        }
    }
}
