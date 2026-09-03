using Oil_level_glass.UI.Abstractions.Editors;
using Oil_level_glass.UI.Abstractions.Editors.Housing;

namespace Oil_level_glass.UI.Editors.Housing
{
    public partial class HousingEditorForm : Form, IHousingEditorView
    {
        public event IEditorView.ViewDataChanging DataChangingHandler;
        public event IEditorView.ClearData ClearDataHandler;
        public event IEditorView.CancelDataChanges CancelDataChangesHandler;
        public event IEditorView.AcceptDataChanges AcceptDataChangesHandler;
        public event IHousingEditorView.ConfigChamfer ConfigChamferHandler;
        public event IHousingEditorView.ConfigHoles ConfigHolesHandler;

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

        public bool ScrewHoleCanBeConfigured
        {
            get
            {
                return btScrewHole.Enabled;
            }
            set
            {
                btScrewHole.Enabled = value;
            }
        }
        public bool ChamferCanBeConfigured
        {
            get
            {
                return btChamfer.Enabled;
            }
            set
            {
                btChamfer.Enabled = value;
            }
        }


        public string HousingMainDiameter
        {
            get
            {
                return tbMainDiameter.Text;
            }
            set
            {
                tbMainDiameter.Text = value;
            }
        }

        public string HousingMainDiameterPlaceholder
        {
            get
            {
                return tbMainDiameter.PlaceholderText;
            }
            set
            {
                tbMainDiameter.PlaceholderText = value;
            }
        }


        public string HousingMainHeight
        {
            get
            {
                return tbMainHeight.Text;
            }
            set
            {
                tbMainHeight.Text = value;
            }
        }

        public string HousingMainHeightPlaceholder
        {
            get
            {
                return tbMainHeight.PlaceholderText;
            }
            set
            {
                tbMainHeight.PlaceholderText = value;
            }
        }


        public string HousingGlassSocketDiameter
        {
            get
            {
                return tbGlassSocketDiameter.Text;
            }
            set
            {
                tbGlassSocketDiameter.Text = value;
            }
        }

        public string HousingGlassSocketDiameterPlaceholder
        {
            get
            {
                return tbGlassSocketDiameter.PlaceholderText;
            }
            set
            {
                tbGlassSocketDiameter.PlaceholderText = value;
            }
        }


        public string HousingGlassSocketHeight
        {
            get
            {
                return tbGlassSocketHeight.Text;
            }
            set
            {
                tbGlassSocketHeight.Text = value;
            }
        }

        public string HousingGlassSocketHeightPlaceholder
        {
            get
            {
                return tbGlassSocketHeight.PlaceholderText;
            }
            set
            {
                tbGlassSocketHeight.PlaceholderText = value;
            }
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

        public HousingEditorForm()
        {
            InitializeComponent();

            tbMainHeight.TextChanged += textbox_TextChanged;
            tbMainDiameter.TextChanged += textbox_TextChanged;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (AcceptDataChangesHandler != null)
                AcceptDataChangesHandler();
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

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            if (DataChangingHandler != null)
                DataChangingHandler();
        }

        private void btChamfer_Click(object sender, EventArgs e)
        {
            if (ConfigChamferHandler != null)
            {
                ConfigChamferHandler();
                AcceptDataChangesHandler();
            }
        }

        private void btScrewHole_Click(object sender, EventArgs e)
        {
            if (ConfigHolesHandler != null)
            {
                ConfigHolesHandler();
                AcceptDataChangesHandler();
            }
        }
    }
}
