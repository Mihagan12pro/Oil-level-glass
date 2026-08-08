using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Presenters;
using Oil_level_glass.Presenters.Editors.Data.ChamferEditor;
using Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor;

namespace Oil_level_glass.UI.Editors.Housing.ChamferEditor
{
    public partial class ChamferEditorForm : Form, IChamferEditorView
    {
        private IChamferEditorPresenter _chamferEditorPresenter;
        private ErrorProvider _side1Error, _side2Error;

        public ChamferEditorForm()
        {
            InitializeComponent();
        }

        public HousingModel Model { get; set; }

        private void ChamferEditorForm_Load(object sender, EventArgs e)
        {
            _side1Error = new ErrorProvider();
            _side2Error = new ErrorProvider();

            Action checkData = () =>
            {
                var angleResult = _chamferEditorPresenter.UpdateAngle(tbAngle.Value.ToString());

                var side1Result = _chamferEditorPresenter.UpdateSide1(tbSide1.Text);

                tbSide2.Text = Model.Chamfer.Side2.ToString();

                var side2Result = _chamferEditorPresenter.UpdateSide2(tbSide2.Text);

                btOk.Enabled = angleResult.IsSuccess && side1Result.IsSuccess && side2Result.IsSuccess;

                if (side1Result.IsSuccess)
                    _side1Error.Clear();
                else
                    _side1Error.SetError(tbSide1, side1Result.ErrorMessage);

                if (side2Result.IsSuccess)
                    _side2Error.Clear();
                else
                    _side2Error.SetError(tbSide2, side2Result.ErrorMessage);
            };

            _chamferEditorPresenter = PresentersFactory.CreateChamferEditorPresenter(this, checkData);

            tbAngle.Value = Convert.ToDecimal((Model.Chamfer).Angle);
            tbMaxLength.Text = Model.Chamfer.MaxSide1.ToString();
            tbSide1.PlaceholderText = tbMaxLength.Text;

            if (Model.Chamfer[nameof(Model.Chamfer.Side1)] == string.Empty)
            {
                tbSide1.Text = Model.Chamfer.Side1.ToString();
                tbSide2.Text = Model.Chamfer.Side2.ToString();
            }

            _chamferEditorPresenter.CheckData();
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            _chamferEditorPresenter.CheckData();
        }

        private void ChamferEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                _chamferEditorPresenter.ResetFields();
        }

        private void btResetData_Click(object sender, EventArgs e)
        {
            tbSide1.Text = "";
            tbSide2.Text = "";

            _chamferEditorPresenter.CheckData();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public void ShowView(object owner = null)
        {
            throw new NotImplementedException();
        }
    }
}
