using Oil_level_glass.UI.Abstractions.Editors;
using Oil_level_glass.UI.Abstractions.Editors.Glass;

namespace Oil_level_glass.UI.Wizard3d.Editors.Glass
{
    public partial class GlassEditorForm : Form, IGlassEditorView
    {
        private ErrorProvider _errorProvider = new();

        public event IEditorView.ViewDataChanging DataChangingHandler;
        public event IEditorView.ClearData ClearDataHandler;
        public event IEditorView.CancelDataChanges CancelDataChangesHandler;
        public event IEditorView.AcceptDataChanges AcceptDataChangesHandler;

        public string GlassDiameter
        {
            get
            {
                return tbDiameter.Text;
            }
            set
            {
                tbDiameter.Text = value;
            }
        }

        public string GlassHeight
        {
            get
            {
                return tbHeight.Text;
            }
            set
            {
                tbHeight.Text = value;
            }
        }

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

        public string GlassHeightPlaceHolder
        {
            get
            {
                return tbHeight.PlaceholderText;
            }
            set
            {
                tbHeight.PlaceholderText = value;
            }
        }

        public string GlassDiameterPlaceholder
        {
            get
            {
                return tbDiameter.PlaceholderText;
            }
            set
            {
                tbDiameter.PlaceholderText = value;
            }
        }

        public GlassEditorForm()
        {
            InitializeComponent();

            tbDiameter.TextChanged += Tb_TextChanged;
            tbHeight.TextChanged += Tb_TextChanged;
        }

        private void Tb_TextChanged(object? sender, EventArgs e)
        {
            if (DataChangingHandler != null)
                DataChangingHandler();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (AcceptDataChangesHandler != null)
                AcceptDataChangesHandler();
        }

        private void GlassEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (CancelDataChangesHandler != null)
                CancelDataChangesHandler();
        }

        private void btResetData_Click(object sender, EventArgs e)
        {
            if (ClearDataHandler != null)
                ClearDataHandler();
        }
    }
}
