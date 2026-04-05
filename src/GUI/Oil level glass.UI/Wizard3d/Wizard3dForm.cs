using Oil_level_glass.UI.Properties;
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialChooser1_Load(object sender, EventArgs e)
        {

        }

        private void rbSketch_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is RadioButton radioButton))
                throw new InvalidDataException("This event handler is only for radio buttons!");

            if (radioButton.Checked)
            {
                Image sketch;

                switch(radioButton.Name)
                {
                    case nameof(rbAssembly):
                        sketch = Resources.Oil_level_glass;
                        break;

                    case nameof(rbHousing):
                        sketch = Resources.Housing;
                        break;

                    case nameof(rbGlass):
                        sketch = Resources.Glass;
                        break;

                    case nameof(rbRubberStrip):
                        sketch = Resources.Rubber_strip;
                        break;

                    default:
                        sketch = Resources.Oil_level_glass;
                        break;
                }

                pbSketch.Image = sketch;
            }
        }
    }
}
