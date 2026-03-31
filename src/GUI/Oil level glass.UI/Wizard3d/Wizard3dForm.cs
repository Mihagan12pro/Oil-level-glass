using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oil_level_glass.UI.Wizard3d
{
    public partial class Wizard3dForm : Form
    {
        public Wizard3dForm()
        {
            InitializeComponent();

            mcHousing.MaterialTitle = "Железо";
            mcHousing.Density = 10.243;
            mcHousing.HatchStyle = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialChooser1_Load(object sender, EventArgs e)
        {

        }
    }
}
