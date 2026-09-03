namespace Oil_level_glass.UI.Forms.Controls
{
    public partial class IntegerSlider : UserControl
    {
        public int Value
        {
            get
            {
                return trBr.Value;
            }
            set
            {
                if (value < trBr.Minimum)
                    value = trBr.Minimum;

                if (value > trBr.Maximum)
                    value = trBr.Maximum;

                trBr.Value = value;
                tb.Text = value.ToString();
            }
        }

        public int Max
        {
            get
            {
                return trBr.Maximum;
            }
            set
            {
                trBr.Maximum = value;
            }
        }

        public int Min
        {
            get
            {
                return trBr.Minimum;
            }
            set
            {
                trBr.Minimum = value;
            }
        }

        public IntegerSlider()
        {
            InitializeComponent();
        }

        private void trBr_Scroll(object sender, EventArgs e)
        {
            tb.Text = trBr.Value.ToString();
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            string old = tb.Text;

            if (int.TryParse(tb.Text, out int i) && i >= Min && i <= Max)
            {
                trBr.Value = i;

                return;
            }

            tb.Text = old;
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!int.TryParse(e.KeyChar.ToString(), out int s) && e.KeyChar != '\b')
                e.Handled = true;
        }
    }
}
