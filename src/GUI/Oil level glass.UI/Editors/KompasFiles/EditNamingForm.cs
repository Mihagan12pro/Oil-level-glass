using Oil_level_glass.Model.Data.Other;

namespace Oil_level_glass.UI.Editors.KompasFiles
{
    public partial class EditNamingForm : Form
    {
        public EditNamingForm()
        {
            InitializeComponent();
        }

        public required Name HousingName { get; set; }

        public required Name GlassName { get; set; }

        public required Name RubberStripName { get; set; }

        private void btApply_Click(object sender, EventArgs e)
        {
            if (tbNaming.Text != "")
            {
                switch (cbChoosePart.SelectedIndex)
                {
                    case 0:
                        {
                            RubberStripName.Marking = tbMarking.Text;
                            RubberStripName.Naming = tbNaming.Text;
                            break;
                        }

                    case 1:
                        {
                            GlassName.Marking = tbMarking.Text;
                            GlassName.Naming = tbNaming.Text;
                            break;
                        }

                    case 2:
                        {
                            HousingName.Marking = tbMarking.Text;
                            HousingName.Naming = tbNaming.Text;
                            break;
                        }
                }

                DialogResult = DialogResult.OK;

                return;
            }

            MessageBox.Show(
               this,
               "Поле 'Наименование' должно быть заполнено!",
               "Ошибка",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
        }

        private void cbChoosePart_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbChoosePart.SelectedIndex != -1)
            {
                btApply.Enabled = true;
                tbMarking.Enabled = true;
                tbNaming.Enabled = true;

                switch (cbChoosePart.SelectedIndex)
                {
                    case 0:
                        {
                            tbMarking.Text = RubberStripName.Marking;
                            tbNaming.Text = RubberStripName.Naming;
                            break;
                        }

                    case 1:
                        {
                            tbMarking.Text = GlassName.Marking;
                            tbNaming.Text = GlassName.Naming;
                            break;
                        }

                    case 2:
                        {
                            tbMarking.Text = HousingName.Marking;
                            tbNaming.Text = HousingName.Naming;
                            break;
                        }
                }
            }
        }
    }
}
