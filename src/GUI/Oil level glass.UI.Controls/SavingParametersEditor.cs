using System.ComponentModel;

namespace Oil_level_glass.UI.Controls
{
    public partial class SavingParametersEditor : UserControl
    {
        private string _header, _folderPath, _naming, _marking;
        private ErrorProvider _folderPathErrors, _namingErrors;

        public event EventHandler? UpdateModel;

        public SavingParametersEditor()
        {
            InitializeComponent();

            _namingErrors = new ErrorProvider();
            _folderPathErrors = new ErrorProvider();
        }

        private void btChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FolderPath = folderBrowserDialog.SelectedPath;
            }
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                switch(textBox.Name)
                {
                    case nameof(tbNaming):
                        {
                            if (textBox.Text == "")
                                _namingErrors.SetError(textBox, "Naming is a required field!");
                            else
                                _namingErrors.Clear();
                            break;
                        }
                    case nameof(tbFolderPath):
                        {
                            if (textBox.Text == "")
                                _folderPathErrors.SetError(textBox, "Folder path is a required field!");
                            else if (!Directory.Exists(textBox.Text))
                                _folderPathErrors.SetError(textBox, "Folder with this path does not exists!");
                            else
                                _folderPathErrors.Clear();

                            break;
                        }
                }
            }

            UpdateModel?.Invoke(sender, e);
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
