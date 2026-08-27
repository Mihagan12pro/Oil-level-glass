using Oil_level_glass.UI.Abstractions.ToolEditors;

namespace Oil_level_glass.UI.Forms.ToolEditors
{
    public partial class IntegerEditor : Form, INumberEditor<int>
    {
        public IntegerEditor()
        {
            InitializeComponent();
        }

        public int Min
        {
            get
            {
                return slr.Min;
            }
            set
            {
                slr.Min = value;
            }
        }

        public int Max
        {
            get
            {
                return slr.Max;
            }
            set
            {
                slr.Max = value;
            }
        }

        public int Value
        {
            get
            {
                return slr.Value;
            }
            set
            {
                slr.Value = value;
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
            if (owner == null)
            {
                ShowDialog();
            }
            else if (owner is Form form)
            {
                ShowDialog(form);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            _result = false;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            _result = true;
        }

        private bool _result;
    }
}
