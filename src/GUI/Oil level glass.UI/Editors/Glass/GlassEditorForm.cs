using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters;
using Oil_level_glass.UI.Abstractions.Editors.Glass;
using Oil_level_glass.UI.Presenters.Editors.Glass;

namespace Oil_level_glass.UI.Wizard3d.Editors.Glass
{
    public partial class GlassEditorForm : Form, IGlassEditorForm
    {
        private IGlassEditorPresenter _glassEditorPresenter;
        private ErrorProvider _diameterErrorProvider, _heightErrorProvider;

        public GlassEditorForm()
        {
            InitializeComponent();
        }

        public GlassModel Model { get; set; }

        private void tbHeight_TextChanged(object sender, EventArgs e)
        {
            _glassEditorPresenter.CheckData();
        }

        private void tbDiameter_TextChanged(object sender, EventArgs e)
        {
            _glassEditorPresenter.CheckData();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void GlassEditorForm_Load(object sender, EventArgs e)
        {
            Action checkData = () =>
            {
                var diameterResult = _glassEditorPresenter.UpdateDiameter(tbDiameter.Text);
                var heightResult = _glassEditorPresenter.UpdateHeight(tbHeight.Text);

                btOk.Enabled = diameterResult.IsSuccess && heightResult.IsSuccess;

                if (!diameterResult.IsSuccess)
                    _diameterErrorProvider.SetError(tbDiameter, diameterResult.ErrorMessage);
                else
                    _diameterErrorProvider.Clear();

                if (!heightResult.IsSuccess)
                    _heightErrorProvider.SetError(tbHeight, heightResult.ErrorMessage);
                else
                    _heightErrorProvider.Clear();
            };


            _glassEditorPresenter = PresentersFactory.CreateGlassEditorPresenter(this, checkData);

            _diameterErrorProvider = new ErrorProvider();
            _heightErrorProvider = new ErrorProvider();

            if (Model[nameof(Model.Diameter)] == string.Empty &&
                Model[nameof(Model.Height)] ==  string.Empty)
            {
                tbDiameter.Text = Model.Diameter.ToString();
                tbHeight.Text = Model.Height.ToString();
            }

            _glassEditorPresenter.CheckData.Invoke();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbDiameter.Text = "";
            tbHeight.Text = "";

            _glassEditorPresenter.CheckData.Invoke();
        }

        private void GlassEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                _glassEditorPresenter.ResetFields();
        }
    }
}
