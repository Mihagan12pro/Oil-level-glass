using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters;
using Oil_level_glass.Presenters.Editors.Housing;
using Oil_level_glass.UI.Abstractions.Editors.Housing;

namespace Oil_level_glass.UI.Editors.Housing
{
    public partial class HousingEditorForm : Form, IHousingForm
    {
        private IHousingEditorPresenter _housingEditorPresenter;

        private ErrorProvider _mainDiameterError, _mainHeightError;
        private ErrorProvider _screwHolesCountError, _screwHoleDiameterError, _screwHolePitchError, _screwHoleDistanceError;
        private ErrorProvider _chamferLengthError, _chamferAngleError;

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
            Action checkData = () =>
            {
                var mainDiameterResult = _housingEditorPresenter.UpdateMainDiameter(tbMainDiameter.Text);
                var mainHeightResult = _housingEditorPresenter.UpdateMainHeight(tbHeight.Text);
                var distanceResult = _housingEditorPresenter.UpdateScrewHolesDictance(tbScrewHolesDistance.Text);


                btScrewHoles.Enabled = mainDiameterResult.IsSuccess && mainHeightResult.IsSuccess &&
                               distanceResult.IsSuccess;

                btChamfer.Enabled = Model.Hole.Error == string.Empty;


                if (!mainDiameterResult.IsSuccess)
                    _mainDiameterError.SetError(tbMainDiameter, mainDiameterResult.ErrorMessage);
                else
                    _mainDiameterError.Clear();

                if (!mainHeightResult.IsSuccess)
                    _mainHeightError.SetError(tbHeight, mainHeightResult.ErrorMessage);
                else
                    _mainHeightError.Clear();

                if (!distanceResult.IsSuccess)
                    _screwHoleDistanceError.SetError(tbScrewHolesDistance, distanceResult.ErrorMessage);
                else
                    _screwHoleDistanceError.Clear();


                btOk.Enabled = Model.Error == string.Empty;
            };

            _housingEditorPresenter = PresentersFactory.CreateHousingEditorPresenter(this, checkData);

            _mainDiameterError = new ErrorProvider();
            _mainHeightError = new ErrorProvider();
            _screwHoleDiameterError = new ErrorProvider();
            _screwHolesCountError = new ErrorProvider();
            _screwHolePitchError = new ErrorProvider();
            _screwHoleDistanceError = new ErrorProvider();
            _chamferLengthError = new ErrorProvider();
            _chamferAngleError = new ErrorProvider();


            tbGlassSocketDiameter.Text = Model.GlassSocketDiameter.ToString();
            tbCentralHoleDiameter.Text = Model.CentralHoleDiameter.ToString();
            tbGlassSocketHeight.Text = Model.GlassSocketHeight.ToString();

            if (Model.Error == string.Empty)
            {
                tbMainDiameter.Text = Model.MainDiameter.ToString();
                tbHeight.Text = Model.MainHeight.ToString();
            }

            _housingEditorPresenter.CheckData.Invoke();
        }

        private void blResetData_Click(object sender, EventArgs e)
        {
            tbMainDiameter.Text = "";
            tbHeight.Text = "";
            tbScrewHolesDistance.Text = "";
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
    }
}
