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
            tableLayoutPanel4 = new TableLayoutPanel();
            tbHolesCount = new TextBox();
            label1 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            label4 = new Label();
            tbHoleDiameter = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
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
            btOk.Enabled = false;
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
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 35);
            tableLayoutPanel3.Margin = new Padding(20, 3, 20, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(582, 312);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tbHolesCount, 0, 1);
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 159);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(576, 150);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // tbHolesCount
            // 
            tbHolesCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbHolesCount.Enabled = false;
            tbHolesCount.Location = new Point(49, 78);
            tbHolesCount.Margin = new Padding(49, 3, 49, 3);
            tbHolesCount.Name = "tbHolesCount";
            tbHolesCount.Size = new Size(478, 39);
            tbHolesCount.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(49, 40);
            label1.Margin = new Padding(49, 3, 49, 3);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 2;
            label1.Text = "Число отверстий n";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(label4, 0, 0);
            tableLayoutPanel7.Controls.Add(tbHoleDiameter, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(576, 150);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(49, 40);
            label4.Margin = new Padding(49, 3, 49, 3);
            label4.Name = "label4";
            label4.Size = new Size(132, 32);
            label4.TabIndex = 2;
            label4.Text = "Диаметр d";
            // 
            // tbHoleDiameter
            // 
            tbHoleDiameter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbHoleDiameter.Location = new Point(49, 78);
            tbHoleDiameter.Margin = new Padding(49, 3, 49, 3);
            tbHoleDiameter.Name = "tbHoleDiameter";
            tbHoleDiameter.Size = new Size(478, 39);
            tbHoleDiameter.TabIndex = 1;
            // 
            // HolesEditorForm
            // 
            AcceptButton = btOk;
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label4;
        private TextBox tbHoleDiameter;
        private TextBox tbHolesCount;
    }
}