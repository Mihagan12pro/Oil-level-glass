using Microsoft.Extensions.DependencyInjection;
using Oil_level_glass.UI.Abstractions;
using Oil_level_glass.UI.Abstractions.Wizards.Wizard3d;
using Oil_level_glass.UI.Editors.ModelProperties;

namespace Oil_level_glass.UI.Main
{
    public partial class MainForm : Form, IMainView
    {
        private readonly IServiceProvider _serviceProvider;

        public MainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();

            btShow3d.Click += btShow3d_Click;
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
