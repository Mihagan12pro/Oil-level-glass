using System.ComponentModel;

namespace Oil_level_glass.UI.Controls
{
    public partial class SavingParametersEditor : UserControl
    {
        private string _header, _folderPath, _naming, _marking;

        public SavingParametersEditor()
        {
            InitializeComponent();

            FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void btChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FolderPath = folderBrowserDialog.SelectedPath;
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        public string Header
        {
            get { return _header; }
            set
            {
                _header = value;

                groupBox.Text = _header;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        public string FolderPath
        {
            get { return _folderPath; }
            set
            {
                _folderPath = value;

                tbFolderPath.Text = _folderPath;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        public string Namimg
        {
            get { return _naming; }
            set
            {
                _naming = value;

                tbNaming.Text = _naming;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        public string Marking
        {
            get { return _marking; }
            set
            {
                _marking = value;

                tbMarking.Text = _marking;
                this.Invalidate();
            }
        }
    }
}
