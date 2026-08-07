namespace Oil_level_glass.UI.Editors.Menus
{
    public abstract class BaseMenuForm : Form
    {
        protected Button btApply = new Button()
        {
            Text = "Применить",

            Enabled = false
        };

        protected Button btCancel = new Button()
        {
            Text = "Отмена"
        };

        protected ComboBox cbChoosePart = new ComboBox()
        {
            DropDownStyle = ComboBoxStyle.DropDownList,

            FormattingEnabled = true
        };
    }
}
