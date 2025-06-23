using Kompas6API5;
using Oil_level_glass.Kompas_classes;
using Oil_level_glass.Services;
using System.Reflection;
namespace Oil_level_glass
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            _textBoxSavePath.Text = Directory.GetCurrentDirectory();

            nNumericUpDown.Maximum = Math.Floor(Convert.ToDecimal(Math.PI) * Convert.ToDecimal(sizeD2TextBox.Text) / Convert.ToDecimal(size_dTextBox.Text));
        }

        private string _savePath;



        private void setSaveFolderButton_Click(object sender, EventArgs e)
        {
            if (saveFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                _textBoxSavePath.Text = saveFolderBrowserDialog.SelectedPath;
            }
        }

        private void textBoxSavePath_TextChanged(object sender, EventArgs e)
        {
            _savePathError.SetError(_textBoxSavePath, "Данная папка не существует!");

            if (Directory.Exists(_textBoxSavePath.Text))
            {
                _savePath = _textBoxSavePath.Text;
                _savePathError.Clear();
            }
        }



      

        private void sizeDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationService.IsNumber(sizeDTextBox))
            {
                _DError.SetError(sizeDTextBox, "Ввод только положительных чисел!");

                return;
            }

            _DError.Clear();
        }

        private void size_dTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationService.IsNumber(size_dTextBox))
            {
                __dError.SetError(size_dTextBox, "Ввод только положительных чисел!");

                return;
            }


            try
            {
                nNumericUpDown.Maximum = Math.Floor(Convert.ToDecimal(Math.PI) * Convert.ToDecimal(sizeD2TextBox.Text) / Convert.ToDecimal(size_dTextBox.Text));

            }
            finally
            {
                if (__dError.HasErrors)
                    __dError.Clear();
            }
        }

        private void D2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationService.IsNumber(sizeD2TextBox))
            {
                _D2Error.SetError(sizeD2TextBox, "Ввод только положительных чисел!");

                return;
            }

            try
            {
                nNumericUpDown.Maximum = Math.Floor(Convert.ToDecimal(Math.PI) * Convert.ToDecimal(sizeD2TextBox.Text) / Convert.ToDecimal(size_dTextBox.Text));

            }
            finally
            {
                if (_D2Error.HasErrors)
                    _D2Error.Clear();
            }
        }

        private void size_d1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationService.IsNumber(size_d1TextBox))
            {
               __d1Error.SetError(size_d1TextBox, "Ввод только положительных чисел!");

                return;
            }

            __d1Error.Clear();
        }

        private void size_d2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationService.IsNumber(size_d2TextBox))
            {
                 __d2Error.SetError(size_d2TextBox, "Ввод только положительных чисел!");

                return;
            }

             __d2Error.Clear();
        }

        private void sizeHTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationService.IsNumber(sizeHTextBox))
            {
                _HError.SetError(sizeHTextBox, "Ввод только положительных чисел!");

                return;
            }

            _HError.Clear();
        }

        private void size_htextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationService.IsNumber(size_htextBox))
            {
               ___hError.SetError(size_htextBox, "Ввод только положительных чисел!");

                return;
            }

            ___hError.Clear();
        }


        private void chamferLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationService.IsNumber(chamferLengthTextBox))
            {
                _chamferLengthError.SetError(chamferLengthTextBox, "Ввод только положительных чисел!");

                return;
            }

            _chamferLengthError.Clear();
        }

        private void nNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (nNumericUpDown.Maximum <= nNumericUpDown.Value)
            {
                nNumericUpDown.Value = nNumericUpDown.Maximum;
            }

            if (nNumericUpDown.Value < 2)
            {
                _nError.SetError(nNumericUpDown, "Число отверстий не должно быть меньше 2!");

                return;
            }
            _nError.Clear();
        }


        private void buttonBuild_Click(object sender, EventArgs e)
        {
            if (_DError.HasErrors || _D2Error.HasErrors || _HError.HasErrors || _chamferLengthError.HasErrors || _savePathError.HasErrors || __d1Error.HasErrors || __d2Error.HasErrors || __dError.HasErrors || __hErrror.HasErrors || ___hError.HasErrors || _nError.HasErrors)
            {
                MessageBox.Show("В одно из полей для ввода введены некорректные значения!", "Невозможно начать построение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            double D = Convert.ToDouble(sizeDTextBox.Text);
            double d = Convert.ToDouble(size_dTextBox.Text);
            double D2 = Convert.ToDouble(sizeD2TextBox.Text);
            double d1 = Convert.ToDouble(size_d1TextBox.Text);
            double d2 = Convert.ToDouble(size_d2TextBox.Text);
            double H = Convert.ToDouble(sizeHTextBox.Text);
            double h = Convert.ToDouble(size_htextBox.Text);
            int n = Convert.ToInt32(nNumericUpDown.Value);
            double chamferAngle = Convert.ToDouble(angleNumericUpDown.Value);
            double chamferLength = Convert.ToDouble(chamferLengthTextBox.Text);

            double distance1 = chamferLength;
            double distance2 = Math.Tan(chamferAngle * Math.PI / 180) * distance1;

            if (distance1 >= H || distance2 >= D* 0.5 - (D2 / 2 + d/2))
            {
                MessageBox.Show("Уменьшите катет фаски или поменяйте угол!", "Невозможно начать построение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (H / h < 1.32)
            {
                MessageBox.Show("Между размерами H и h должно быть соотношение: H / h = 1,34!", "Невозможно начать построение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (d2 <= d1)
            {
                MessageBox.Show("Размер d2 должен быть больше d1!", "Невозможно начать построение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (D <= d2)
            {
                MessageBox.Show("Размер D должен быть больше d2!", "Невозможно начать построение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Housing housing = new Housing(D,d,D2,d1,d2,H,h,n,chamferAngle,chamferLength);
            housing.SavePath = _savePath;
            housing.ModelName = "Корпус";

            Glass glass = new Glass(h,d2);
            glass.SavePath = _savePath;
            glass.ModelName = "Стекло";

            Ring ring = new Ring(h,d2,d1);
            ring.SavePath = _savePath;
            ring.ModelName = "Резиновая подкладка";

            WindowAssemble windowAssemble;



            if (IKompasModel.Kompas == null)
            {
                Type? t = Type.GetTypeFromProgID("KOMPAS.Application.5");

                IKompasModel.Kompas = (KompasObject)Activator.CreateInstance(t);
            }

            try
            {
                IKompasModel.Kompas.Visible = true;
                IKompasModel.Kompas.ActivateControllerAPI();

                housing.Build();
                glass.Build();
                ring.Build();

                windowAssemble = new WindowAssemble(housing, ring, glass);
                windowAssemble.SavePath = _savePath;
                windowAssemble.ModelName = "Смотровой лючок";
                windowAssemble.CreateAssemble();
            }
            catch
            {
                try
                {
                    Type? t = Type.GetTypeFromProgID("KOMPAS.Application.5");

                    IKompasModel.Kompas = (KompasObject)Activator.CreateInstance(t);

                    IKompasModel.Kompas.Visible = true;

                    IKompasModel.Kompas.ActivateControllerAPI();

                    housing.Build();
                    glass.Build();
                    ring.Build();

                    windowAssemble = new WindowAssemble(housing, ring, glass);
                    windowAssemble.SavePath = _savePath;
                    windowAssemble.ModelName = "Смотровой лючок";
                    windowAssemble.CreateAssemble();
                }
                catch
                {
                    MessageBox.Show("Возможные причины: либо приложение КОМПАС-3D не установлено, либо приложение не поддерживает работу с данной версией.", "Не удается подключиться к КОМПАС-3D!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
