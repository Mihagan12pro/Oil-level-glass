using Oil_level_glass.Model.Data.KompasFile;

namespace Oil_level_glass.UI.Editors.KompasFiles
{
    public partial class SelectFolderForm : Form
    {
        public SelectFolderForm()
        {
            InitializeComponent();
        }

        public required KompasFile HousingFile { get; set; }

        public required KompasFile GlassFile { get; set; }

        public required KompasFile RubberStripFile { get; set; }

        private void btSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    tbFolder.Text = dialog.SelectedPath;
                }
            }
        }

        private void SelectFolderForm_Load(object sender, EventArgs e)
        {

        }

        private void cbChoosePart_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbChoosePart.SelectedIndex != -1)
            {
                btApply.Enabled = true;
                tbFolder.Enabled = true;
                btSelectFolder.Enabled = true;

                switch (cbChoosePart.SelectedIndex)
                {
                    case 0:
                        tbFolder.Text = HousingFile.Folder;
                        break;

                    case 1:
                        tbFolder.Text = GlassFile.Folder;
                        break;

                    case 2:
                        tbFolder.Text = RubberStripFile.Folder;
                        break;
                }
            }
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbFolder.Text))
            {
                switch (cbChoosePart.SelectedIndex)
                {
                    case 0:
                        HousingFile.Folder = tbFolder.Text;
                        break;

                    case 1:
                        GlassFile.Folder = tbFolder.Text;
                        break;

                    case 2:
                        RubberStripFile.Folder = tbFolder.Text;
                        break;
                }

                return;
            }

            MessageBox.Show(
                this,
                $"Папка '{tbFolder.Text}' не существует!", 
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }
}
