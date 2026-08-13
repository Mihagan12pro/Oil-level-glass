using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Editors.Data.Entities.RubberStrip;
using Oil_level_glass.Presenters.Editors.Entities.RubberStrip.HelpStructures;
using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;

namespace Oil_level_glass.UI.Editors.RubberStrip
{
    public partial class RubberStripEditorForm : Form, IRubberStripEditorView
    {
        private ErrorProvider _errorProvider = new();

        private IRubberStripEditorPresenter _stripEditorPresenter;

        public RubberStripEditorForm(IRubberStripEditorPresenter stripEditorPresenter)
        {
            InitializeComponent();

            _stripEditorPresenter = stripEditorPresenter;

            var defaultSizes = _stripEditorPresenter.DefaultSizes;

            tbExternalDiameter.Text = defaultSizes.ExternalDiameter;
            tbHeight.Text = defaultSizes.Height;
            tbInternalDiameter.Text = defaultSizes.InternalDiameter;
        }

        public RubberStripModel Model { get; set; }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void blResetData_Click(object sender, EventArgs e)
        {
            tbInternalDiameter.Text = "";
            tbHeight.Text = "";
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            _errorProvider.Clear();

            var results = _stripEditorPresenter.UpdateModel(new RubberStripUpdateData(tbHeight.Text, tbInternalDiameter.Text));

            if (results.NoErrors && tbHeight.Text != "" &&  tbInternalDiameter.Text != "")
            {
                btOk.Enabled = true;

                return;
            }

            if (!results.Height.IsSuccess)
                _errorProvider.SetError(tbHeight, results.Height.ErrorMessage);

            if (!results.InternalDiameter.IsSuccess)
                _errorProvider.SetError(tbInternalDiameter, results.InternalDiameter.ErrorMessage);

            btOk.Enabled = false;
        }

        private void RubberStripEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void RubberStripEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                _stripEditorPresenter.ResetFields();
        }

        public void ShowView(object owner = null)
        {
            if (owner != null && owner is Form form)
            {
                ShowDialog(form);
            }
            else
            {
                ShowDialog();
            }
        }
    }
}
