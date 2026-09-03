namespace Oil_level_glass.UI.Forms.Controls
{
    public partial class FolderChooser : ModelProperties
    {
        public delegate void ValueChangedHandler();

        public event ValueChangedHandler ValueChanged;

        public bool IsValid
        {
            get
            {
                bool exists = Directory.Exists(tbFolder.Text);

                return exists;
            }
        }

        public string Folder
        {
            get
            {
                return tbFolder.Text;
            }
            set
            {
                tbFolder.Text = value; 
            }
        }

        public FolderChooser()
        {
            InitializeComponent();

            btChoose.Click += btChoose_Click;
        }

        private void FolderChooser_Load(object sender, EventArgs e)
        {
            tbFolder.PlaceholderText = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void tbFolder_TextChanged(object sender, EventArgs e)
        {
            if (!IsValid && Enabled)
            {
                var toolTip = new ToolTip();
                toolTip.IsBalloon = true;
                toolTip.ToolTipIcon = ToolTipIcon.Error;
                toolTip.Show("Данная папка не сушествует!", tbFolder, 0, -75, 1000);
            }

            if (ValueChanged != null)
                ValueChanged.Invoke();

            OnDataChanging(nameof(sender));
        }

        private void btChoose_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    tbFolder.Text = dialog.SelectedPath;
                }
            }
        }
    }
}
