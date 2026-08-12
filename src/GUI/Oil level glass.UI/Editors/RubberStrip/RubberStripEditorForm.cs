using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters;
using Oil_level_glass.Presenters.Editors.Data.Entities.RubberStrip;
using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;

namespace Oil_level_glass.UI.Editors.RubberStrip
{
    public partial class RubberStripEditorForm : Form, IRubberStripEditorView
    {
        private IRubberStripEditorPresenter _stripEditorPresenter;
        private ErrorProvider _internalDiameterError, _heightError;

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
            tbHeight.Text = "";
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            _stripEditorPresenter.CheckData.Invoke();
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
