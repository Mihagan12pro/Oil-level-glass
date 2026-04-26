using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.ScrewHoles;
using Oil_level_glass.Presenters;
using Oil_level_glass.Presenters.Editors.Housing;
using Oil_level_glass.UI.Abstractions.Editors.Housing;
using Oil_level_glass.UI.Editors.Housing.HolesEditor;
using Oil_level_glass.UI.Presenters.Editors.Glass;

namespace Oil_level_glass.UI.Editors.Housing
{
    public partial class HousingEditorForm : Form, IHousingForm
    {
        private IHousingEditorPresenter _housingEditorPresenter;

        private ErrorProvider _mainDiameterError, _mainHeightError;

        public HousingEditorForm()
        {
            InitializeComponent();
        }

        public HousingModel Model { get; set; }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void HousingEditorForm_Load(object sender, EventArgs e)
        {
            _mainDiameterError = new ErrorProvider();
            _mainHeightError = new ErrorProvider();

            Action checkData = () =>
            {
                var mainHeightResult = _housingEditorPresenter.UpdateMainHeight(tbMainHeight.Text);
                var mainDiameterResult = _housingEditorPresenter.UpdateMainDiameter(tbMainDiameter.Text);

                if (!mainHeightResult.IsSuccess)
                    _mainHeightError.SetError(tbMainHeight, mainHeightResult.ErrorMessage);
                else
                    _mainHeightError.Clear();

                if (!mainDiameterResult.IsSuccess)
                    _mainDiameterError.SetError(tbMainDiameter, mainDiameterResult.ErrorMessage);
                else
                    _mainDiameterError.Clear();

                btScrewHole.Enabled = mainHeightResult.IsSuccess && mainDiameterResult.IsSuccess;

                btChamfer.Enabled = Model.Hole.Error == string.Empty;

                btOk.Enabled = Model.Error == string.Empty;

                if (Model.GlassSocketHeight > 0)
                    tbGlassSocketHeight.Text = Model.GlassSocketHeight.ToString();

                if (Model.GlassSocketDiameter > 0)
                    tbGlassSocketDiameter.Text = Model.GlassSocketDiameter.ToString();

                Model.ScrewHolesDistance = (Model.MainDiameter / 2 + Model.GlassSocketDiameter / 2);

                ((BasicScrewHoleModel)Model.Hole).MaxDiameter = (Model.MainDiameter / 2 - Model.ScrewHolesDistance / 2) * 0.9;
            };

            _housingEditorPresenter = PresentersFactory.CreateHousingEditorPresenter(this, checkData);

            _housingEditorPresenter.CheckData.Invoke();
        }

        private void btResetData_Click(object sender, EventArgs e)
        {
            tbMainDiameter.Text = "";
            tbMainHeight.Text = "";

            _housingEditorPresenter.CheckData.Invoke();
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            _housingEditorPresenter.CheckData.Invoke();
        }

        private void btScrewHoles_Click(object sender, EventArgs e)
        {

        }

        private void btChamfer_Click(object sender, EventArgs e)
        {

        }

        private void btScrewHole_Click(object sender, EventArgs e)
        {
            HolesEditorForm holesEditorForm = new HolesEditorForm()
            {
                Model = Model
            };

            holesEditorForm.Owner = this;

            holesEditorForm.ShowDialog();
        }

        private void HousingEditorForm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void HousingEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                _housingEditorPresenter.ResetFields();
        }
    }
}
