using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor;
using Shared;
using Oil_level_glass.UI.Properties;
using Oil_level_glass.Presenters.Editors.Presenters.ChamferEditor;
using Oil_level_glass.Presenters.Editors.Presenters.ChamferEditor.HelpStructures;
using Oil_level_glass.UI.Abstractions.Editors;

namespace Oil_level_glass.UI.Editors.Housing.ChamferEditor
{
    public partial class ChamferEditorForm : Form, IChamferEditorView
    {
        private readonly ICommand _textUpdateCommand, _resetCommand;

        private readonly ErrorProvider _errorProvider = new ErrorProvider();

        private IChamferEditorPresenter _chamferEditorPresenter;

        private ChamferType _chamferType;

        public event IEditorView.ViewDataChanging DataChangingHandler;
        public event IEditorView.ClearData ClearDataHandler;
        public event IEditorView.CancelDataChanges CancelDataChangesHandler;
        public event IEditorView.AcceptDataChanges AcceptDataChangesHandler;

        public bool IsValid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ChamferEditorForm(IChamferEditorPresenter chamferEditorPresenter)
        {
            InitializeComponent();

            _textUpdateCommand = new UICommand();
            _textUpdateCommand.SetAction(() => 
            {
                btOk.Enabled = true;
                _errorProvider.Clear();

                var result = _chamferEditorPresenter.UpdateModel(new ChamferUpdateData(
                    tbSide1.Text,
                    tbSide2.Text,
                    tbAngle.Text)
                );

                btOk.Enabled = result.NoErrors && tbAngle.Text != ""
                    && tbSide1.Text != "" && tbSide2.Text != "";

                if (!result.FirstParam.IsSuccess)
                    _errorProvider.SetError(tbSide1, result.FirstParam.ErrorMessage);

                if (_chamferType == ChamferType.TwoSides)
                {
                    if (result.SecondParam.IsSuccess)
                    {
                        tbAngle.Text = result.ThrirdParam;
                    }
                    else
                    {
                        _errorProvider.SetError(tbSide2, result.SecondParam.ErrorMessage);
                    }
                }
                else
                {
                    if (result.SecondParam.IsSuccess)
                    {
                        tbSide2.Text = result.ThrirdParam;
                    }
                    else
                    {
                        _errorProvider.SetError(tbAngle, result.SecondParam.ErrorMessage);
                    }
                }
            });

            _resetCommand = new UICommand();
            _resetCommand.SetAction(() => 
            {
                _chamferEditorPresenter.ResetFields();

                var defaultSizes = _chamferEditorPresenter.DefaultSizes;

                tbAngle.Text = defaultSizes.Angle;
                tbSide1.Text = defaultSizes.Side1;
                tbSide2.Text = defaultSizes.Side2;
            });

            rbSideAndAngle.CheckedChanged += rb_CheckedChanged;
            rbTwoSides.CheckedChanged += rb_CheckedChanged;

            tbAngle.TextChanged += Tb_TextChanged;
            tbSide1.TextChanged += Tb_TextChanged;
            tbSide2.TextChanged += Tb_TextChanged;

            _chamferEditorPresenter = chamferEditorPresenter;

            var defaultSizes = _chamferEditorPresenter.DefaultSizes;

            _chamferType = defaultSizes.ChamferType;

            if (_chamferType == ChamferType.TwoSides)
            {
                rbTwoSides.Checked = true;
                rbSideAndAngle.Checked = false;
            }
            else
            {
                rbSideAndAngle.Checked = true;
            }

            tbAngle.Text = defaultSizes.Angle;
            tbSide1.Text = defaultSizes.Side1;
            tbSide2.Text = defaultSizes.Side2;

            _textUpdateCommand.Execute();
        }

        private void Tb_TextChanged(object? sender, EventArgs e)
            => _textUpdateCommand.Execute();

        private void ChamferEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                _chamferEditorPresenter.ResetFields();
        }

        private void btResetData_Click(object sender, EventArgs e)
            => _resetCommand.Execute();

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
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

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            tbAngle.Enabled = true;
            tbSide2.Enabled = true;

            if (sender is RadioButton rb && rb.Checked)
            {
                Bitmap image;
                if (rb == rbSideAndAngle)
                {
                    tbSide2.Enabled = false;
                    _chamferType = ChamferType.SideAndAngle;
                    image = (Bitmap)Resources.ResourceManager.GetObject("chamferSideAngle");

                    if (tbSide2.Text == "" && tbSide1.Text == "")
                        _resetCommand.Execute();
                }
                else
                {
                    _chamferType = ChamferType.TwoSides;
                    tbAngle.Enabled = false;
                    image = (Bitmap)Resources.ResourceManager.GetObject("chamfer2Sides");

                    if (tbAngle.Text == "" && tbSide1.Text == "")
                        _resetCommand.Execute();
                }

                pbSketch.Image = image;
            }

            _chamferEditorPresenter.ChangeChamferType(_chamferType);
        }
    }
}
