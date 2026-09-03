using Oil_level_glass.UI.Abstractions.Editors.Housing.ChamferEditor;
using Oil_level_glass.UI.Properties;
using Oil_level_glass.UI.Abstractions.Editors;

namespace Oil_level_glass.UI.Editors.Housing.ChamferEditor
{
    public partial class ChamferEditorForm : Form, IChamferEditorView
    {
        public event IEditorView.ViewDataChanging DataChangingHandler;
        public event IEditorView.ClearData ClearDataHandler;
        public event IEditorView.CancelDataChanges CancelDataChangesHandler;
        public event IEditorView.AcceptDataChanges AcceptDataChangesHandler;
        public event IChamferEditorView.ChamferTypeChanged ChamferTypeChangedHandler;

        public bool IsValid
        {
            get
            {
                return btOk.Enabled;
            }
            set
            {
                btOk.Enabled = value;
            }
        }

        public string ChamferSide1
        {
            get
            {
                return tbSide1.Text;
            }
            set
            {
                tbSide1.Text = value;
            }
        }

        public string ChamferSide2
        {
            get
            {
                return tbSide2.Text;
            }
            set
            {
                tbSide2.Text = value;
            }
        }

        public string ChamferAngle
        {
            get
            {
                return tbAngle.Text;
            }
            set
            {
                tbAngle.Text = value;
            }
        }

        public bool ChamferSideAngle
        {
            get
            {
                return rbSideAndAngle.Checked;
            }
            set
            {
                rbSideAndAngle.Checked = value;

                if (!rbSideAndAngle.Checked)
                    rbTwoSides.Checked = true;
            }
        }

        public string ChamferSide1PlaceHolder
        {
            get
            {
                return tbSide1.PlaceholderText;
            }
            set
            {
                tbSide1.PlaceholderText = value;
            }
        }

        public string ChamferSide2PlaceHolder
        {
            get
            {
                return tbSide2.PlaceholderText;
            }
            set
            {
                tbSide2.PlaceholderText = value;
            }
        }

        public ChamferEditorForm()
        {
            InitializeComponent();

            rbSideAndAngle.CheckedChanged += rb_CheckedChanged;
            rbTwoSides.CheckedChanged += rb_CheckedChanged;


            tbAngle.TextChanged += Tb_TextChanged;
            tbSide1.TextChanged += Tb_TextChanged;
            tbSide2.TextChanged += Tb_TextChanged;
        }

        private void Tb_TextChanged(object? sender, EventArgs e)
        {
            if (DataChangingHandler != null)
                DataChangingHandler();
        }

        private void btResetData_Click(object sender, EventArgs e)
        {
            if (ClearDataHandler != null)
                ClearDataHandler();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (CancelDataChangesHandler != null)
                CancelDataChangesHandler();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (AcceptDataChangesHandler != null)
                AcceptDataChangesHandler();
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
                ChamferSideAngle = rbSideAndAngle.Checked;

                if (ChamferTypeChangedHandler != null)
                    ChamferTypeChangedHandler();
            }
        }
    }
}
