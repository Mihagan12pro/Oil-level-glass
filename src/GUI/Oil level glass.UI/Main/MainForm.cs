using Microsoft.Extensions.DependencyInjection;
using Oil_level_glass.UI.Abstractions;
using Oil_level_glass.UI.Abstractions.Wizards.Wizard3d;

namespace Oil_level_glass.UI.Main
{
    public partial class MainForm : Form, IMainView
    {
        private readonly IServiceProvider _serviceProvider;

        public MainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
        }

        private void btShow3d_Click(object sender, EventArgs e)
        {
            using var wizard3d = _serviceProvider.GetRequiredService<IWizard3dView>();
            wizard3d.ShowView(this);
        }

        private void btShowAbout_Click(object sender, EventArgs e)
        {
           
        }

        private void pbMain_Click(object sender, EventArgs e)
        {

        }
    }
}
