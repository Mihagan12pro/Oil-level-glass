namespace Oil_level_glass.UI.Editors.Housing.HolesEditor
{
    partial class HolesEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btCancel = new Button();
            btOk = new Button();
            btResetData = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label3 = new Label();
            tbScrewHolesCount = new NumericUpDown();
            tableLayoutPanel5 = new TableLayoutPanel();
            label2 = new Label();
            tbHoleDiameter = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            tbMaxDiameter = new TextBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbScrewHolesCount).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(628, 438);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btCancel, 1, 0);
            tableLayoutPanel2.Controls.Add(btOk, 2, 0);
            tableLayoutPanel2.Controls.Add(btResetData, 0, 0);
            tableLayoutPanel2.Location = new Point(148, 363);
            tableLayoutPanel2.Margin = new Padding(5, 5, 20, 16);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(460, 59);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btCancel
            // 
            btCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btCancel.Location = new Point(158, 5);
            btCancel.Margin = new Padding(5, 5, 5, 16);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(143, 46);
            btCancel.TabIndex = 1;
            btCancel.Text = "Отмена";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            btOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btOk.Location = new Point(311, 5);
            btOk.Margin = new Padding(5, 5, 0, 16);
            btOk.Name = "btOk";
            btOk.Size = new Size(144, 46);
            btOk.TabIndex = 0;
            btOk.Text = "Ок";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += btOk_Click;
            // 
            // btResetData
            // 
            btResetData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btResetData.Location = new Point(5, 5);
            btResetData.Margin = new Padding(5, 5, 5, 16);
            btResetData.Name = "btResetData";
            btResetData.Size = new Size(143, 46);
            btResetData.TabIndex = 2;
            btResetData.Text = "Очистить";
            btResetData.UseVisualStyleBackColor = true;
            btResetData.Click += btResetData_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(20, 5);
            groupBox1.Margin = new Padding(20, 5, 20, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 350);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Размеры";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 35);
            tableLayoutPanel3.Margin = new Padding(20, 3, 20, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(582, 312);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label3, 0, 0);
            tableLayoutPanel6.Controls.Add(tbScrewHolesCount, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 211);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(576, 98);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(49, 14);
            label3.Margin = new Padding(49, 3, 49, 3);
            label3.Name = "label3";
            label3.Size = new Size(202, 32);
            label3.TabIndex = 2;
            label3.Text = "Число отверстий";
            // 
            // tbScrewHolesCount
            // 
            tbScrewHolesCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbScrewHolesCount.Location = new Point(49, 52);
            tbScrewHolesCount.Margin = new Padding(49, 3, 49, 3);
            tbScrewHolesCount.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            tbScrewHolesCount.Name = "tbScrewHolesCount";
            tbScrewHolesCount.Size = new Size(478, 39);
            tbScrewHolesCount.TabIndex = 0;
            tbScrewHolesCount.Value = new decimal(new int[] { 3, 0, 0, 0 });
            tbScrewHolesCount.ValueChanged += tb_TextChanged;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Controls.Add(tbHoleDiameter, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 107);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(576, 98);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(49, 14);
            label2.Margin = new Padding(49, 3, 49, 3);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 2;
            label2.Text = "Диаметр";
            // 
            // tbHoleDiameter
            // 
            tbHoleDiameter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbHoleDiameter.Location = new Point(49, 52);
            tbHoleDiameter.Margin = new Padding(49, 3, 49, 3);
            tbHoleDiameter.Name = "tbHoleDiameter";
            tbHoleDiameter.Size = new Size(478, 39);
            tbHoleDiameter.TabIndex = 1;
            tbHoleDiameter.TextChanged += tb_TextChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tbMaxDiameter, 0, 1);
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(576, 98);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tbMaxDiameter
            // 
            tbMaxDiameter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbMaxDiameter.Enabled = false;
            tbMaxDiameter.Location = new Point(49, 52);
            tbMaxDiameter.Margin = new Padding(49, 3, 49, 3);
            tbMaxDiameter.Name = "tbMaxDiameter";
            tbMaxDiameter.Size = new Size(478, 39);
            tbMaxDiameter.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(49, 14);
            label1.Margin = new Padding(49, 3, 49, 3);
            label1.Name = "label1";
            label1.Size = new Size(284, 32);
            label1.TabIndex = 1;
            label1.Text = "Максимальный диаметр";
            // 
            // HolesEditorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btCancel;
            ClientSize = new Size(628, 438);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HolesEditorForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Редактор отверстий";
            FormClosing += HolesEditorForm_FormClosing;
            Load += HolesEditorForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbScrewHolesCount).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btCancel;
        private Button btOk;
        private Button btResetData;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label3;
        private NumericUpDown tbScrewHolesCount;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label2;
        private TextBox tbHoleDiameter;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox tbMaxDiameter;
        private Label label1;
    }
}