using Oil_level_glass.Presenters.Editors.Presenters.Entities.RubberStrip;
using Oil_level_glass.UI.Abstractions.Editors;
using Oil_level_glass.UI.Abstractions.Editors.RubberStrip;

namespace Oil_level_glass.UI.Editors.RubberStrip
{
    public partial class RubberStripEditorForm : Form, IRubberStripEditorView
    {
        private ErrorProvider _errorProvider = new();

        private IRubberStripEditorPresenter _stripEditorPresenter;

        public event IEditorView.ViewDataChanging DataChangingHandler;
        public event IEditorView.ClearData ClearDataHandler;
        public event IEditorView.CancelDataChanges CancelDataChangesHandler;
        public event IEditorView.AcceptDataChanges AcceptDataChangesHandler;

        public RubberStripEditorForm()
        {
            InitializeComponent();
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

        public string RubberStripHeight
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
        public string RubberStripHeightPlaceHolder
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

        public string RubberStripInternalDiameter
        {
            get
            {
                return tbInternalDiameter.Text;
            }
            set
            {
                tbInternalDiameter.Text = value;
            }
        }
        public string RubberStripInternalDiameterPlaceHolder
        {
            get
            {
                return tbInternalDiameter.PlaceholderText;
            }
            set
            {
                tbInternalDiameter.PlaceholderText = value;
            }
        }

        public string RubberStripExternalDiameter
        {
            get
            {
                return tbExternalDiameter.Text;
            }
            set
            {
                tbExternalDiameter.Text = value;
            }
        }
        public string RubberStripExternalDiameterPlaceHolder
        {
            get
            {
                return tbExternalDiameter.PlaceholderText;
            }
            set
            {
                tbExternalDiameter.PlaceholderText = value;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (AcceptDataChangesHandler != null)
                AcceptDataChangesHandler();
        }

        private void blResetData_Click(object sender, EventArgs e)
        {
            if (ClearDataHandler != null)
                ClearDataHandler();
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (DataChangingHandler != null)
                DataChangingHandler();
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
