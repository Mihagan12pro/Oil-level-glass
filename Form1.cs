using Kompas6API5;
using Oil_level_glass.Kompas_classes;
namespace Oil_level_glass
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void setSaveFolderButton_Click(object sender, EventArgs e)
        {
            if (saveFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                _textBoxSavePath.Text = saveFolderBrowserDialog.SelectedPath;
            }
        }

        private void textBoxSavePath_TextChanged(object sender, EventArgs e)
        {
            _errorProvider.SetError(_textBoxSavePath, "Данная папка не существует!");

            if (Directory.Exists(_textBoxSavePath.Text))
            {
                _errorProvider.Clear();
            }
        }

        private void size_dTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void _buttonBuild_Click(object sender, EventArgs e)
        {
            if (IKompasModel.Kompas == null)
            {
                Type? t = Type.GetTypeFromProgID("KOMPAS.Application.5");

                IKompasModel.Kompas = (KompasObject)Activator.CreateInstance(t);
            }

            try
            {
                IKompasModel.Kompas.Visible = true;
                IKompasModel.Kompas.ActivateControllerAPI();
            }
            catch
            {
                try
                {
                    Type? t = Type.GetTypeFromProgID("KOMPAS.Application.5");

                    IKompasModel.Kompas = (KompasObject)Activator.CreateInstance(t);

                    IKompasModel.Kompas.Visible = true;

                    IKompasModel.Kompas.ActivateControllerAPI();
                }
                catch
                {
                    MessageBox.Show("Возможные причины: либо приложение КОМПАС-3D не установлено, либо приложение не поддерживает работу с данной версией.", "Не удается подключиться к КОМПАС-3D!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
