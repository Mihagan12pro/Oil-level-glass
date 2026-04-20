using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters.Editors.Housing;
using Oil_level_glass.UI.Abstractions.Editors.Housing;

namespace Oil_level_glass.UI.Editors.Housing
{
    public partial class HousingEditorForm : Form, IHousingForm
    {
        private IHousingEditorPresenter _housingEditorPresenter;
        private ErrorProvider _externalDiameterError, _holeDiameterError;
        private ErrorProvider _holeCountError;
        private ErrorProvider _heightError;
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
            Action chackData = () => 
            {

            };


            _externalDiameterError = new ErrorProvider();
            _holeDiameterError =  new ErrorProvider();
            _holeCountError = new ErrorProvider();
            _heightError = new ErrorProvider();
            _chamferLengthError = new ErrorProvider();
            _chamferAngleError = new ErrorProvider();
        }
    }
}
