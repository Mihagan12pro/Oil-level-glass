using Oil_level_glass.Wizards.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oil_level_glass.Wizards.Forms
{
    public partial class AssembleWizardForm : Form
    {
        public AssembleWizardForm()
        {
            InitializeComponent();

            DataContext = new AssemblyViewModel();


        }

        private void AssembleWizardForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
