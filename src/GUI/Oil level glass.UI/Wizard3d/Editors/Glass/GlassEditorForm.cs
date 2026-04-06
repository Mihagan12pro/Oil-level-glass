using Oil_level_glass.Model.Data.Entities.Parts.Classic;

namespace Oil_level_glass.UI.Wizard3d.Editors.Glass
{
    public partial class GlassEditorForm : Form, IGlassEditor
    {
        private readonly GlassEditorPresenter _glassEditorPresenter;
        private ErrorProvider _diameterError, _heightError;

        public GlassEditorForm()
        {
            InitializeComponent();

            Model = new GlassModel();

            _glassEditorPresenter = new GlassEditorPresenter(this);

            _diameterError = new ErrorProvider();
            _heightError = new ErrorProvider();
        }

        public GlassModel Model { get; set; }

        private void tbHeight_TextChanged(object sender, EventArgs e)
        {
            var result = _glassEditorPresenter.UpdateWidth((sender as TextBox)!.Text);
            if (!result.IsSuccess)
            {
                _heightError.SetError((sender as TextBox), result.ErrorMessage);
                return;
            }

            _heightError.Clear();
        }

        private void tbDiameter_TextChanged(object sender, EventArgs e)
        {
            var result = _glassEditorPresenter.UpdateDiameter((sender as TextBox)!.Text);
            if (!result.IsSuccess)
            {
                _diameterError.SetError((sender as TextBox), result.ErrorMessage);
                return;
            }

           _diameterError.Clear();
        }

        private void btOk_Click(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            _glassEditorPresenter.ResetFields();
        }
    }
}
