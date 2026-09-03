using Oil_level_glass.UI.Abstractions.ToolEditors;

namespace Oil_level_glass.UI.ToolEditors
{
    public partial class DoubleEditorForm : Form, INumberEditor<double>
    {
        public DoubleEditorForm()
        {
            InitializeComponent();
        }

        public double Min { get; set; }
        public double Max { get; set; }
        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;

                if (_value >= Min && _value <= Max) 
                    tb.Text = _value.ToString();
            }
        }

        public bool Result
            => _result;

        public string Header
        {
            get
            {
                return Text;
            }
            set
            {
                Text = value;
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

        private void tb_TextChanged(object sender, EventArgs e)
        {
            btOk.Enabled = double.TryParse(tb.Text, out double d) && d >= Min && d <= Max;

            if (btOk.Enabled)
                _value = d;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            _result = true;
            DialogResult = DialogResult.OK;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            _result = false;
            DialogResult = DialogResult.Cancel;
        }

        private bool _result;
        private double _value;
    }
}
