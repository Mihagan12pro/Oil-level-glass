using Oil_level_glass.Presenters.Editors.Data.Entities.Housing;
using Oil_level_glass.Presenters.Editors.Entities.Housing.DataStructures;
using Oil_level_glass.UI.Abstractions.Editors.Housing;

namespace Oil_level_glass.UI.Editors.Housing
{
    public partial class HousingEditorForm : Form, IHousingEditorView
    {
        private readonly ErrorProvider _errorProvider = new ErrorProvider();

        private IHousingEditorPresenter _housingEditorPresenter;

        public HousingEditorForm(IHousingEditorPresenter housingEditorPresenter)
        {
            InitializeComponent();

            tbMainHeight.TextChanged += textbox_TextChanged;
            tbMainDiameter.TextChanged += textbox_TextChanged;

            _housingEditorPresenter = housingEditorPresenter;

            var defaultValues = _housingEditorPresenter.DefaultSizes;

            tbMainDiameter.Text = defaultValues.MainDiameter;
            tbMainHeight.Text = defaultValues.MainHeight;
            tbGlassSocketDiameter.Text = defaultValues.GlassSocketDiameter;
            tbGlassSocketHeight.Text = defaultValues.GlassSocketHeight;

            tbMainDiameter.PlaceholderText = (Convert.ToDouble(tbGlassSocketDiameter.Text) * 1.5).ToString();
            tbMainHeight.PlaceholderText = (Convert.ToDouble(tbGlassSocketHeight.Text) * 2).ToString();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void HousingEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void btResetData_Click(object sender, EventArgs e)
        {
            tbMainDiameter.Text = "";
            tbMainHeight.Text = "";

            _housingEditorPresenter.CheckData.Invoke();
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            _errorProvider.Clear();

            var result = _housingEditorPresenter.UpdateModel(new HousingUpdateData(
                tbMainDiameter.Text, 
                tbMainHeight.Text)
            );

            btChamfer.Enabled = _housingEditorPresenter.ChamferCanBeConfigured;
            btScrewHole.Enabled = _housingEditorPresenter.ScrewHoleCanBeConfigured;

            if (result.NoErrors && btChamfer.Enabled && btScrewHole.Enabled
                && tbMainHeight.Text != "" && tbMainDiameter.Text != "")
            {
                btOk.Enabled = true;

                return;
            }

            btOk.Enabled = false;

            if (!result.MainDiameter.IsSuccess)
                _errorProvider.SetError(tbMainDiameter, result.MainDiameter.ErrorMessage);

            if (!result.MainHeight.IsSuccess)
                _errorProvider.SetError(tbMainHeight, result.MainHeight.ErrorMessage);
        }

        private void btChamfer_Click(object sender, EventArgs e)
        {
            //ChamferEditorForm chamferEditorForm = new ChamferEditorForm()
            //{
            //    Model = Model
            //};
            //chamferEditorForm.Owner = this;
            
            //chamferEditorForm.ShowDialog();
            //_housingEditorPresenter.CheckData.Invoke();
        }

        private void btScrewHole_Click(object sender, EventArgs e)
            => _housingEditorPresenter.ConfigureHoles();

        private void HousingEditorForm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void HousingEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                _housingEditorPresenter.ResetFields();
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
