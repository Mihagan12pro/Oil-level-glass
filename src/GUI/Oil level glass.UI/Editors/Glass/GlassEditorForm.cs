using Oil_level_glass.UI.Abstractions.Editors;
using Oil_level_glass.UI.Abstractions.Editors.Glass;

namespace Oil_level_glass.UI.Wizard3d.Editors.Glass
{
    public partial class GlassEditorForm : Form, IGlassEditorView
    {
        private ErrorProvider _errorProvider = new();

        public event IEditorView.ViewDataChanging DataChangingHandler;

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

        public bool IsValid { get; set; }

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

        public GlassEditorForm(/*IGlassEditorPresenter glassEditorPresenter*/)
        {
            InitializeComponent();

            //_glassEditorPresenter = glassEditorPresenter;

            tbDiameter.TextChanged += Tb_TextChanged;
            tbHeight.TextChanged += Tb_TextChanged;
        }

        private void Tb_TextChanged(object? sender, EventArgs e)
        {
            //_errorProvider.Clear();

            //var results = _glassEditorPresenter.UpdateModel(new GlassUpdateDataPending(tbHeight.Text, tbDiameter.Text));

            //if (results.NoErrors && tbDiameter.Text != "" && tbHeight.Text != "")
            //{
            //    btOk.Enabled = true;
            //    return;
            //}

            //if (!results.Height.IsSuccess)
            //    _errorProvider.SetError(tbHeight, results.Height.ErrorMessage);

            //if (!results.Diameter.IsSuccess)
            //    _errorProvider.SetError(tbDiameter, results.Diameter.ErrorMessage);

            //btOk.Enabled = false;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void GlassEditorForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbDiameter.Text = "";
            tbHeight.Text = "";

            //_glassEditorPresenter.ResetFields();
        }

        private void GlassEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (DialogResult != DialogResult.OK)
            //    _glassEditorPresenter.ResetFields();
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
