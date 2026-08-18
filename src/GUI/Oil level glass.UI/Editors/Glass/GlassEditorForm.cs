using Oil_level_glass.Presenters.Editors.Data.Entities.Glass;
using Oil_level_glass.Presenters.Editors.Entities.Glass.HelpStructures;
using Oil_level_glass.UI.Abstractions.Editors.Glass;
using Shared.Results;

namespace Oil_level_glass.UI.Wizard3d.Editors.Glass
{
    public partial class GlassEditorForm : Form, IGlassEditorView
    {
        private readonly IGlassEditorPresenter _glassEditorPresenter;
        private ErrorProvider _errorProvider = new();

        public GlassEditorForm(IGlassEditorPresenter glassEditorPresenter)
        {
            InitializeComponent();

            _glassEditorPresenter = glassEditorPresenter;

            tbDiameter.TextChanged += Tb_TextChanged;
            tbHeight.TextChanged += Tb_TextChanged;

            var defaultSizes = _glassEditorPresenter.DefaultSizes;

            tbDiameter.Text = defaultSizes.Diameter;
            tbHeight.Text = defaultSizes.Height;
        }

        private void Tb_TextChanged(object? sender, EventArgs e)
        {
            _errorProvider.Clear();

            var results = _glassEditorPresenter.UpdateModel(new GlassUpdateData(tbHeight.Text, tbDiameter.Text));

            if (results.NoErrors && tbDiameter.Text != "" && tbHeight.Text != "")
            {
                btOk.Enabled = true;
                return;
            }

            if (!results.Height.IsSuccess)
                _errorProvider.SetError(tbHeight, results.Height.ErrorMessage);

            if (!results.Diameter.IsSuccess)
                _errorProvider.SetError(tbDiameter, results.Diameter.ErrorMessage);

            btOk.Enabled = false;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void GlassEditorForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbDiameter.Text = "";
            tbHeight.Text = "";

            _glassEditorPresenter.ResetFields();
        }

        private void GlassEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                _glassEditorPresenter.ResetFields();
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
