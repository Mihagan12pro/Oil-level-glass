using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.ScrewHoles;
using Oil_level_glass.Presenters;
using Oil_level_glass.Presenters.Editors.Data.HolesEditor;
using Oil_level_glass.UI.Abstractions.Editors.Housing.HolesEditor;

namespace Oil_level_glass.UI.Editors.Housing.HolesEditor
{
    public partial class HolesEditorForm : Form, IHolesEditorView
    {
        private IHolesEditorPresenter _holesEditorPresenter;
        private ErrorProvider _diameterError = new ErrorProvider();

        public HolesEditorForm()
        {
            InitializeComponent();
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            _holesEditorPresenter.CheckData.Invoke();
        }

        private void HolesEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                _holesEditorPresenter.ResetFields();
        }

        private void btResetData_Click(object sender, EventArgs e)
        {
            tbHoleDiameter.Text = "";
            _holesEditorPresenter.CheckData.Invoke();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
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
