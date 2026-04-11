using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.UI.Abstractions.Editors.Glass;
using Oil_level_glass.UI.Controls;
using Oil_level_glass.UI.Presenters.Glass;
using System.ComponentModel;

namespace Oil_level_glass.UI.Wizard3d.Editors.Glass
{
    public partial class GlassEditorForm : Form, IGlassEditorForm
    {
        private BackgroundWorker _bgWorker;
        private ThreadControl _backgroundBtOk;
        private readonly GlassEditorPresenter _glassEditorPresenter;
        private ErrorProvider _diameterErrorProvider, _heightErrorProvider;

        public GlassEditorForm()
        {
            InitializeComponent();

            Model = new GlassModel();

            _glassEditorPresenter = new GlassEditorPresenter(this);

            _diameterErrorProvider = new ErrorProvider();
            _heightErrorProvider = new ErrorProvider();
        }

        public GlassModel Model { get; set; }
        public BackgroundWorker BackgroundWorker { get; set; }

        public void CheckFormData()
        {
            var action = () => {
                btOk.Enabled = Model.Error == string.Empty;
            };

            _backgroundBtOk = new ThreadControl(btOk, action);
            _bgWorker = new BackgroundWorker();

            _bgWorker.DoWork += (obj, ea)
                => CheckFormDataBackground();

            _bgWorker.RunWorkerAsync();
        }

        private void tbHeight_TextChanged(object sender, EventArgs e)
        {
            var result = _glassEditorPresenter.UpdateWidth((sender as TextBox)!.Text);
            if (!result.IsSuccess)
            {
                _heightErrorProvider.SetError((sender as TextBox), result.ErrorMessage);
                return;
            }

            _heightErrorProvider.Clear();
        }

        private void tbDiameter_TextChanged(object sender, EventArgs e)
        {
            var result = _glassEditorPresenter.UpdateDiameter((sender as TextBox)!.Text);
            if (!result.IsSuccess)
            {
                _diameterErrorProvider.SetError((sender as TextBox), result.ErrorMessage);
                return;
            }

            _diameterErrorProvider.Clear();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void resetData_Click(object sender, EventArgs e)
        {
            _glassEditorPresenter.ResetFields();
        }

        private void CheckFormDataBackground()
        {
            while (true)
            {
                Thread.Sleep(500);

                _backgroundBtOk.Run();
            }
        }

        private void GlassEditorForm_Load(object sender, EventArgs e)
        {
            CheckFormData();
        }
    }
}
