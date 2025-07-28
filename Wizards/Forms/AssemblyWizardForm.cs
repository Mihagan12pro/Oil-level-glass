using Oil_level_glass.Wizards.ViewModels;

namespace Oil_level_glass.Wizards.Forms
{
    public partial class AssembleWizardForm : Form
    {
        public AssembleWizardForm()
        {
            InitializeComponent();

            BlankTab.DataContext = new BlankTabViewModel(Color.AliceBlue);

            blankColorBox.DataBindings.Add
            (
                new Binding(nameof(blankColorBox.BackColor), BlankTab.DataContext, "ModelColor")
            );

            blankColorDialogButton.DataBindings.Add
            (
                new Binding("Command", BlankTab.DataContext, "ExecuteColorDialog",true)
            );
        } 

        private void AssembleWizardForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
