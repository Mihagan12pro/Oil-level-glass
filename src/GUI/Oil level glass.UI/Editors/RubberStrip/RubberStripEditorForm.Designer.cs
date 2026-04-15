namespace Oil_level_glass.UI.Editors.RubberStrip
{
    partial class RubberStripEditorForm
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
            btOk = new Button();
            btCancel = new Button();
            blResetData = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            pbSketch = new PictureBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            lblInternalDiameter = new Label();
            tbInternalDiameter = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            lblExternalDiameter = new Label();
            tbExternalDiameter = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            lblHeight = new Label();
            tbHeight = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSketch).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(925, 523);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btOk, 2, 0);
            tableLayoutPanel2.Controls.Add(btCancel, 1, 0);
            tableLayoutPanel2.Controls.Add(blResetData, 0, 0);
            tableLayoutPanel2.Location = new Point(445, 448);
            tableLayoutPanel2.Margin = new Padding(5, 5, 20, 16);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(460, 59);
            tableLayoutPanel2.TabIndex = 0;
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
            // blResetData
            // 
            blResetData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            blResetData.Location = new Point(5, 5);
            blResetData.Margin = new Padding(5, 5, 5, 16);
            blResetData.Name = "blResetData";
            blResetData.Size = new Size(143, 46);
            blResetData.TabIndex = 2;
            blResetData.Text = "Очистить";
            blResetData.UseVisualStyleBackColor = true;
            blResetData.Click += blResetData_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(pbSketch, 1, 0);
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(5, 5);
            tableLayoutPanel3.Margin = new Padding(5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(915, 433);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // pbSketch
            // 
            pbSketch.BorderStyle = BorderStyle.FixedSingle;
            pbSketch.Dock = DockStyle.Fill;
            pbSketch.Image = Properties.Resources.Rubber_strip_Img;
            pbSketch.Location = new Point(462, 19);
            pbSketch.Margin = new Padding(5, 19, 20, 5);
            pbSketch.Name = "pbSketch";
            pbSketch.Size = new Size(433, 409);
            pbSketch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSketch.TabIndex = 0;
            pbSketch.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(20, 5);
            groupBox1.Margin = new Padding(20, 5, 20, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(417, 423);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Размеры";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(5, 37);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Size = new Size(407, 381);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(lblInternalDiameter, 0, 0);
            tableLayoutPanel7.Controls.Add(tbInternalDiameter, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 257);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(401, 121);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // lblInternalDiameter
            // 
            lblInternalDiameter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblInternalDiameter.AutoSize = true;
            lblInternalDiameter.Location = new Point(49, 28);
            lblInternalDiameter.Margin = new Padding(49, 0, 49, 0);
            lblInternalDiameter.Name = "lblInternalDiameter";
            lblInternalDiameter.Size = new Size(247, 32);
            lblInternalDiameter.TabIndex = 0;
            lblInternalDiameter.Text = "Внутренний диаметр";
            // 
            // tbInternalDiameter
            // 
            tbInternalDiameter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbInternalDiameter.Location = new Point(49, 60);
            tbInternalDiameter.Margin = new Padding(49, 0, 49, 0);
            tbInternalDiameter.Name = "tbInternalDiameter";
            tbInternalDiameter.Size = new Size(303, 39);
            tbInternalDiameter.TabIndex = 1;
            tbInternalDiameter.TextChanged += tbInternalDiameter_TextChanged;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(lblExternalDiameter, 0, 0);
            tableLayoutPanel6.Controls.Add(tbExternalDiameter, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 130);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(401, 121);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // lblExternalDiameter
            // 
            lblExternalDiameter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblExternalDiameter.AutoSize = true;
            lblExternalDiameter.Location = new Point(49, 28);
            lblExternalDiameter.Margin = new Padding(49, 0, 49, 0);
            lblExternalDiameter.Name = "lblExternalDiameter";
            lblExternalDiameter.Size = new Size(216, 32);
            lblExternalDiameter.TabIndex = 0;
            lblExternalDiameter.Text = "Внешний диаметр";
            // 
            // tbExternalDiameter
            // 
            tbExternalDiameter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbExternalDiameter.Enabled = false;
            tbExternalDiameter.Location = new Point(49, 60);
            tbExternalDiameter.Margin = new Padding(49, 0, 49, 0);
            tbExternalDiameter.Name = "tbExternalDiameter";
            tbExternalDiameter.Size = new Size(303, 39);
            tbExternalDiameter.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(lblHeight, 0, 0);
            tableLayoutPanel5.Controls.Add(tbHeight, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(401, 121);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // lblHeight
            // 
            lblHeight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(49, 28);
            lblHeight.Margin = new Padding(49, 0, 49, 0);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(113, 32);
            lblHeight.TabIndex = 0;
            lblHeight.Text = "Высота h";
            // 
            // tbHeight
            // 
            tbHeight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbHeight.Enabled = false;
            tbHeight.Location = new Point(49, 60);
            tbHeight.Margin = new Padding(49, 0, 49, 0);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(303, 39);
            tbHeight.TabIndex = 1;
            // 
            // RubberStripEditorForm
            // 
            AcceptButton = btOk;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btCancel;
            ClientSize = new Size(925, 523);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RubberStripEditorForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Редактор размеров прокладки";
            Load += RubberStripEditorForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSketch).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btOk;
        private Button btCancel;
        private Button blResetData;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pbSketch;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lblHeight;
        private TextBox tbHeight;
        private TableLayoutPanel tableLayoutPanel7;
        private Label lblInternalDiameter;
        private TextBox tbInternalDiameter;
        private TableLayoutPanel tableLayoutPanel6;
        private Label lblExternalDiameter;
        private TextBox tbExternalDiameter;
    }
}
