namespace Oil_level_glass.UI.Editors.ModelProperties
{
    internal class ModelPropertiesEditorForm : Form
    {
        protected TableLayoutPanel tblMain, tblFormButtons;
        protected Panel pnlFormsButtons;

        protected Button btCancel, btOk;

        protected ComboBox cbMain;

        public ModelPropertiesEditorForm()
        {
            InitializeComponent();
        }

        protected virtual void InitializeComponent()
        {
            tblMain = new TableLayoutPanel();
            cbMain = new ComboBox();
            pnlFormsButtons = new Panel();
            btOk = new Button();
            btCancel = new Button();
            tblMain.SuspendLayout();
            pnlFormsButtons.SuspendLayout();
            SuspendLayout();



            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(cbMain, 0, 0);
            tblMain.Controls.Add(pnlFormsButtons, 0, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.AutoSize = true;
            tblMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblMain.Dock = DockStyle.Fill;
            tblMain.TabIndex = 0;



            cbMain.FormattingEnabled = false;
            cbMain.SelectedIndexChanged += cbMain_SelectedIndexChanged;
            cbMain.Dock = DockStyle.Fill;
            cbMain.Location = new Point(50, 50);
            cbMain.Margin = new Padding(50, 50, 50, 50);
            cbMain.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMain.Name = "cbMain";
            cbMain.Size = new Size(427, 40);
            cbMain.TabIndex = 0;



            pnlFormsButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlFormsButtons.Controls.Add(btCancel);
            pnlFormsButtons.Controls.Add(btOk);
            pnlFormsButtons.Location = new Point(124, 847);
            pnlFormsButtons.Name = "pnlFormsButtons";
            pnlFormsButtons.Size = new Size(400, 77);
            pnlFormsButtons.TabIndex = 1;



            btOk.Location = new Point(203, 22);
            btOk.Name = "btOk";
            btOk.Size = new Size(150, 46);
            btOk.TabIndex = 0;
            btOk.Text = "Ок";
            btOk.UseVisualStyleBackColor = true;
            btOk.Enabled = false;
            btOk.Click += btOk_Click;



            btCancel.Location = new Point(15, 22);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(150, 46);
            btCancel.TabIndex = 1;
            btCancel.Text = "Отмена";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;



            Controls.Add(tblMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            this.MinimumSize = new Size(300, 200);
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblMain.ResumeLayout(false);
            pnlFormsButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        protected virtual void btOk_Click(object? sender, EventArgs e)
            => DialogResult = DialogResult.OK;

        protected virtual void btCancel_Click(object? sender, EventArgs e)
            => DialogResult = DialogResult.Cancel;

        protected virtual void cbMain_SelectedIndexChanged(object? sender, EventArgs e)
            => btOk.Enabled = cbMain.SelectedIndex > -1;
    }
}
