using Oil_level_glass.Core.Housing;
using Oil_level_glass.Presenters.Wizards.Wizard3d;
using Oil_level_glass.UI.Abstractions.Wizards.Wizard3d;
using Oil_level_glass.UI.Utils.Extensions;
using Shared;

namespace Oil_level_glass.UI.Wizard3d
{
    public partial class Wizard3dForm : Form, IWizard3dView
    {
        private readonly IWizard3dPresenter _wizardPresenter;

        private ICommand _selectNodeCommand = new UICommand()
        {

        };

        public Wizard3dForm(IWizard3dPresenter wizardPresenter)
        {
            _wizardPresenter = wizardPresenter;
            _wizardPresenter.SetView(this);

            InitializeComponent();

            btOk.Enabled = _wizardPresenter.CanStartModeling;

            tvParts.Nodes.Add(_wizardPresenter.GetParts().ToTreeNode());

            _selectNodeCommand.SetAction(() =>
            {
                if (tvParts.SelectedNode != null)
                    _wizardPresenter.SelectPart(tvParts.SelectedNode.Text);
            });

            tvParts.AfterSelect += TvParts_AfterSelect;

            _wizardPresenter.SetDefaultFolder(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }

        private void TvParts_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            _selectNodeCommand.Execute();

            var result = _wizardPresenter.CanBeConfigured;

            btConfigPart.Enabled = result.IsSuccess;

            if (result.FailReason == Shared.Results.FailReason.TooEarlyForConfiguring)
            {
                MessageBox.Show(result.ErrorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ShowView(object owner = null)
        {
            if (owner != null && owner is Form form)
            {
                ShowDialog(form);
            }
            else
            {
                ShowDialog();
            }
        }

        private void btConfigPart_Click(object sender, EventArgs e)
        {
            _wizardPresenter.ConfigureSelectedPart();

            btOk.Enabled = _wizardPresenter.CanStartModeling;
        }

        private void btOk_Click(object sender, EventArgs e)
            => _wizardPresenter.Create();
    }
}
