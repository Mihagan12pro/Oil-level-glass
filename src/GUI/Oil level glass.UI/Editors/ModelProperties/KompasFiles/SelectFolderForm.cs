using Oil_level_glass.Model.ModelProperties.KompasFile;
using Oil_level_glass.UI.Editors.Menus;

namespace Oil_level_glass.UI.Editors.KompasFiles
{
    public partial class SelectFolderForm : BaseMenuForm<KompasFile>
    {
        public SelectFolderForm()
        {
            InitializeComponent();
        }

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


        protected override void btApply_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbFolder.Text))
            {
                base.btApply_Click(sender, e);

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

        protected override void GetControlsValues(KompasFile t)
        {
            t.Folder = tbFolder.Text;
        }

        protected override void SetControlsValues(KompasFile t)
        {
            tbFolder.Text = t.Folder;
        }

        protected override void MakeControlsEnabled()
        {
            base.MakeControlsEnabled();

            tbFolder.Enabled = true;
            btSelectFolder.Enabled = true;
        }
    }
}
