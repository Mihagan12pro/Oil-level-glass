using Oil_level_glass.Model.Data.Entities.Parts.Classic;
using Oil_level_glass.Model.Data.ScrewHoles;
using Oil_level_glass.Presenters;
using Oil_level_glass.Presenters.Editors.Data.HolesEditor;
using Oil_level_glass.UI.Abstractions.Editors.Housing.HolesEditor;

namespace Oil_level_glass.UI.Editors.Housing.HolesEditor
{
    public partial class HolesEditorForm : Form, IHolesEditorView
    {
        private IHolesEditorPresenter _holesEditorPresenter;
        private ErrorProvider _diameterError = new ErrorProvider();

        public HolesEditorForm()
        {
            InitializeComponent();
        }

        public HousingModel Model { get; set; }

        private void HolesEditorForm_Load(object sender, EventArgs e)
        {
            Action checkData = () =>
            {
                var countResult = _holesEditorPresenter.UpdateCountOfHoles(tbScrewHolesCount.Value.ToString());
                var diameterResult = _holesEditorPresenter.UpdateDiameter(tbHoleDiameter.Text);

                tbScrewHolesCount.Enabled = diameterResult.IsSuccess;
                if (diameterResult.IsSuccess)
                {
                    _diameterError.Clear();
                }
                else
                {
                    _diameterError.SetError(tbHoleDiameter, diameterResult.ErrorMessage);
                }

                tbScrewHolesCount.Maximum = Model.MaxCountOfHoles;
                btOk.Enabled = countResult.IsSuccess && diameterResult.IsSuccess;
            };

            _holesEditorPresenter = PresentersFactory.CreateHolesEditorPresenter(this, checkData);

          
            tbMaxDiameter.Text = Model.Hole.MaxDiameter.ToString();
            tbHoleDiameter.PlaceholderText = tbMaxDiameter.Text;

            var basic = (BasicScrewHoleModel)Model.Hole;

            
            if (basic.Error == string.Empty)
            {
                tbScrewHolesCount.Maximum = Model.MaxCountOfHoles;
                tbHoleDiameter.Text = ((BasicScrewHoleModel)Model.Hole).Diameter.ToString();
                tbScrewHolesCount.Value = Model.ScrewHolesCount;
            }

            tbScrewHolesCount.ValueChanged += tb_TextChanged;
            tbHoleDiameter.TextChanged += tb_TextChanged;

            checkData.Invoke();
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            _holesEditorPresenter.CheckData.Invoke();
        }

        private void HolesEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                _holesEditorPresenter.ResetFields();
        }

        private void btResetData_Click(object sender, EventArgs e)
        {
            tbHoleDiameter.Text = "";
            _holesEditorPresenter.CheckData.Invoke();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
