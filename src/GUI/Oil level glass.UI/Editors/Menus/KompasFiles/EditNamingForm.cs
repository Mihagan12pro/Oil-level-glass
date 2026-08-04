using Oil_level_glass.Model.ModelProperties.Other;
using Oil_level_glass.UI.Editors.Menus;

namespace Oil_level_glass.UI.Editors.KompasFiles
{
    public partial class EditNamingForm : BaseMenuForm<T>
    {
        public EditNamingForm()
        {
            InitializeComponent();
        }

        protected override void btApply_Click(object sender, EventArgs e)
        {
            if (tbNaming.Text != "")
            {
                base.btApply_Click(sender, e);

                return;
            }

            MessageBox.Show(
               this,
               "Поле 'Наименование' должно быть заполнено!",
               "Ошибка",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
        }

        protected override void GetControlsValues(T t)
        {
            t.Marking = tbMarking.Text;
            t.Naming = tbNaming.Text;
        }

        protected override void SetControlsValues(T t)
        {
            tbMarking.Text = t.Marking;
            tbNaming.Text = t.Naming;
        }


        protected override void MakeControlsEnabled()
        {
            base.MakeControlsEnabled();

            tbMarking.Enabled = true;
            tbNaming.Enabled = true;
        }
    }
}
