using Oil_level_glass.UI.Main;
using Oil_level_glass.UI.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Oil_level_glass.UI.Wizard3d
{
    public partial class Wizard3dForm : Form, IMainForm
    {
        private readonly MainPresenter _mainPresenter;

        public Wizard3dForm()
        {
            InitializeComponent();

            InvokeDiametersHandler();

            _mainPresenter = new MainPresenter(this);
        }

        public event EventHandler UpdateDiameterTextBox = delegate { };

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

        private void InvokeDiametersHandler()
        {
            foreach(var i in gbDiameters.Controls)
            {
                if (i is TableLayoutPanel tableLayoutPanel)
                {
                    foreach(var j in tableLayoutPanel.Controls)
                    {
                        if (j is System.Windows.Forms.TextBox textBox)
                        {
                            textBox.TextChanged += (sender, args)
                                => UpdateDiameterTextBox(sender, args);
                        }
                    }
                }
            }
        }
    }
}
