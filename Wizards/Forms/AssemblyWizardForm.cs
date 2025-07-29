using Oil_level_glass.Wizards.ViewModels;

namespace Oil_level_glass.Wizards.Forms
{
    public partial class AssembleWizardForm : Form
    {
        public AssembleWizardForm()
        {
            InitializeComponent();

            blankTab.DataContext = new BlankTabViewModel();

            blankColorBox.DataBindings.Add
            (
                new Binding(nameof(blankColorBox.BackColor), blankTab.DataContext, "ModelColor")
            );

            blankColorDialogButton.DataBindings.Add
            (
                new Binding("Command", blankTab.DataContext, "ExecuteColorDialog", true)
            );

            blankFileNameTextBox.DataBindings.Add
            (
                new Binding("Text", blankTab.DataContext, "FileName", false, DataSourceUpdateMode.OnPropertyChanged)
            );

            blankFolderBrowserButton.DataBindings.Add
            (
                new Binding("Command", blankTab.DataContext, "ExecuteFolderBrowser", true)
            );

            blankSaveFolderTextBox.DataBindings.Add
            (
                new Binding("Text", blankTab.DataContext, "SaveFolder")
            );

            blankDensityTextBox.DataBindings.Add
            (
                new Binding("Text", blankTab.DataContext, "Density", false, DataSourceUpdateMode.OnPropertyChanged)
            );

            blankMaterialTextBox.DataBindings.Add
            (
                new Binding("Text", blankTab.DataContext, "MaterialTittle", false, DataSourceUpdateMode.OnPropertyChanged)
            );
        }

        private void AssembleWizardForm_Load(object sender, EventArgs e)
        {

        }

        private void blankDensityTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
