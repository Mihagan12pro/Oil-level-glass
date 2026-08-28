using Oil_level_glass.Model.Data.Operations;
using Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor;
using Shared;
using Oil_level_glass.UI.Properties;
using Oil_level_glass.Presenters.Editors.Presenters.ChamferEditor;
using Oil_level_glass.UI.Abstractions.Editors;

namespace Oil_level_glass.UI.Editors.Housing.ChamferEditor
{
    public partial class ChamferEditorForm : Form, IChamferEditorView
    {
        public event IEditorView.ViewDataChanging DataChangingHandler;
        public event IEditorView.ClearData ClearDataHandler;
        public event IEditorView.CancelDataChanges CancelDataChangesHandler;
        public event IEditorView.AcceptDataChanges AcceptDataChangesHandler;

        public bool IsValid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ChamferEditorForm()
        {
            InitializeComponent();

            rbSideAndAngle.CheckedChanged += rb_CheckedChanged;
            rbTwoSides.CheckedChanged += rb_CheckedChanged;
        }

        private void Tb_TextChanged(object? sender, EventArgs e)
        {

        }

        private void ChamferEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (DialogResult != DialogResult.OK)
            //    _chamferEditorPresenter.ResetFields();
        }

        private void btResetData_Click(object sender, EventArgs e)
        {

        }

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
                    image = (Bitmap)Resources.ResourceManager.GetObject("chamferSideAngle");
                }
                else
                {
                    tbAngle.Enabled = false;
                    image = (Bitmap)Resources.ResourceManager.GetObject("chamfer2Sides");
                }

                pbSketch.Image = image;
            }
        }
    }
}
