namespace Oil_level_glass.UI.Forms.Controls
{
    public partial class NamingPropertiesChooser : ModelProperties
    {
        public string Namimg
        {
            get
            {
                return tbNaming.Text;
            }
            set
            {
                tbNaming.Text = value;
            }
        }

        public string Marking
        {
            get
            {
                return tbMarking.Text;
            }
            set
            {
                tbMarking.Text = value;
            }
        }

        public NamingPropertiesChooser()
        {
            InitializeComponent();

            tbNaming.TextChanged += TbNaming_TextChanged;
        }

        private void TbNaming_TextChanged(object? sender, EventArgs e)
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(tbNaming.Text))
            {
                errorProvider.SetError(tbNaming, "Поле обязательно к заполнению!");
            }

            OnDataChanging(nameof(sender));
        }
    }
}
