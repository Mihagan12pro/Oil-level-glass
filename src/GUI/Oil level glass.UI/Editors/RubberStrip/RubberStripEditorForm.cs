using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters;
using Oil_level_glass.Presenters.Editors.RubberStrip;
using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;
using Oil_level_glass.UI.Presenters.Editors.Glass;

namespace Oil_level_glass.UI.Editors.RubberStrip
{
    public partial class RubberStripEditorForm : Form, IRubberStripEditorForm
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
            _internalDiameterError = new ErrorProvider();
            _heightError = new ErrorProvider();

            Action checkData = () =>
            {
                var internalDiameterResult = _stripEditorPresenter.UpdateInternalDiameter(tbInternalDiameter.Text);
                var heightResult = _stripEditorPresenter.UpdateHeight(tbHeight.Text);

                btOk.Enabled = internalDiameterResult.IsSuccess && heightResult.IsSuccess;
                if (internalDiameterResult.IsSuccess)
                {
                    _internalDiameterError.Clear();
                }
                else
                {
                    _internalDiameterError.SetError(tbInternalDiameter, internalDiameterResult.ErrorMessage);
                }

                if (heightResult.IsSuccess)
                {
                    _heightError.Clear();
                }
                else
                {
                    _heightError.SetError(tbHeight, heightResult.ErrorMessage);
                }
            };

            _stripEditorPresenter = PresentersFactory.CreateRubberStripPresenter(this, checkData);

            if (Model[nameof(Model.ExternalDiameter)] == string.Empty)
                tbExternalDiameter.Text = Model.ExternalDiameter.ToString();

            if (Model.Error == string.Empty)
            {
                tbInternalDiameter.Text = Model.InternalDiameter.ToString();
                tbHeight.Text = Model.Height.ToString();
            }

            _stripEditorPresenter.CheckData.Invoke();
        }

        private void RubberStripEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                _stripEditorPresenter.ResetFields();
        }
    }
}
