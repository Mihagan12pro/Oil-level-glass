using Oil_level_glass.Presenters.Editors.Presenters.HolesEditor;
using Oil_level_glass.Presenters.Editors.Presenters.HolesEditor.HelpStructures;
using Oil_level_glass.UI.Abstractions.Editors;
using Oil_level_glass.UI.Abstractions.Editors.Housing.HolesEditor;

namespace Oil_level_glass.UI.Editors.Housing.HolesEditor
{
    public partial class HolesEditorForm : Form, IHolesEditorView
    {
        private readonly IHolesEditorPresenter _holesEditorPresenter;
        private ErrorProvider _errorsProvider = new ErrorProvider();

        public event IEditorView.ViewDataChanging DataChangingHandler;

        public bool IsValid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public HolesEditorForm(IHolesEditorPresenter holesEditorPresenter)
        {
            InitializeComponent();

            _holesEditorPresenter = holesEditorPresenter;

            tbHoleDiameter.TextChanged += tb_TextChanged;
            tbHolesCount.TextChanged += tb_TextChanged;

            var defaultValues = _holesEditorPresenter.DefaultSizes;

            tbHoleDiameter.Text = defaultValues.Diameter;
            tbHolesCount.Text = defaultValues.HolesCount;
        }

        private void tb_TextChanged(object? sender, EventArgs e)
        {
            _errorsProvider.Clear();

            var results = _holesEditorPresenter.UpdateModel(new HolesUpdateData(tbHoleDiameter.Text, tbHolesCount.Text));

            btOk.Enabled = results.NoErrors;

            if (!results.Diameter.IsSuccess)
            {
                _errorsProvider.SetError(tbHoleDiameter, results.Diameter.ErrorMessage);

                tbHolesCount.Enabled = false;

                return;
            }
            tbHolesCount.Enabled = true;

            if (!results.Count.IsSuccess)
                _errorsProvider.SetError(tbHolesCount, results.Count.ErrorMessage);
        }

        private void HolesEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                _holesEditorPresenter.ResetFields();
        }

        private void btResetData_Click(object sender, EventArgs e)
        {
            _holesEditorPresenter.ResetFields();

            tbHoleDiameter.Text = "";
            tbHolesCount.Text = "";
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

        private void tbHoleDiameter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
