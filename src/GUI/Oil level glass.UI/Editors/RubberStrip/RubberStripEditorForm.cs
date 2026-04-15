using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;

namespace Oil_level_glass.UI.Editors.RubberStrip
{
    public partial class RubberStripEditorForm : Form, IRubberStripEditorForm
    {
        public RubberStripEditorForm()
        {
            InitializeComponent();
        }

        public RubberStripModel Model { get; set; }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void blResetData_Click(object sender, EventArgs e)
        {
            tbInternalDiameter.Text = "";
        }

        private void tbInternalDiameter_TextChanged(object sender, EventArgs e)
        {

        }

        private void RubberStripEditorForm_Load(object sender, EventArgs e)
        {
            if (Model[nameof(Model.ExternalDiameter)] == string.Empty &&
                Model[nameof(Model.Height)] == string.Empty)
            {
                tbExternalDiameter.Text = Model.ExternalDiameter.ToString();
                tbHeight.Text = Model.Height.ToString();
            }
        }
    }
}
