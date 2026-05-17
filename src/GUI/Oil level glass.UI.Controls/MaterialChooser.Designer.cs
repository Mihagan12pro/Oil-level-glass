namespace Oil_level_glass.UI.Controls
{
    partial class MaterialChooser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tbMaterialTitle = new RichTextBox();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            tbDensity = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            tbHatchStyle = new TextBox();
            label3 = new Label();
            groupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(tableLayoutPanel1);
            groupBox.Dock = DockStyle.Fill;
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(433, 635);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "groupBox1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(427, 597);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tbMaterialTitle, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(421, 193);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tbMaterialTitle
            // 
            tbMaterialTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbMaterialTitle.Location = new Point(20, 99);
            tbMaterialTitle.Margin = new Padding(20, 3, 20, 3);
            tbMaterialTitle.Name = "tbMaterialTitle";
            tbMaterialTitle.ReadOnly = true;
            tbMaterialTitle.Size = new Size(381, 41);
            tbMaterialTitle.TabIndex = 0;
            tbMaterialTitle.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(20, 64);
            label1.Margin = new Padding(20, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 1;
            label1.Text = "Наименование";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(tbDensity, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 202);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(421, 193);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(20, 64);
            label2.Margin = new Padding(20, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 0;
            label2.Text = "ρ, кг/м³";
            // 
            // tbDensity
            // 
            tbDensity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDensity.Location = new Point(20, 99);
            tbDensity.Margin = new Padding(20, 3, 20, 3);
            tbDensity.Name = "tbDensity";
            tbDensity.ReadOnly = true;
            tbDensity.Size = new Size(381, 39);
            tbDensity.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tbHatchStyle, 0, 1);
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 401);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(421, 193);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tbHatchStyle
            // 
            tbHatchStyle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbHatchStyle.Location = new Point(20, 99);
            tbHatchStyle.Margin = new Padding(20, 3, 20, 3);
            tbHatchStyle.Name = "tbHatchStyle";
            tbHatchStyle.ReadOnly = true;
            tbHatchStyle.Size = new Size(381, 39);
            tbHatchStyle.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(20, 64);
            label3.Margin = new Padding(20, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 0;
            label3.Text = "Штриховка";
            // 
            // MaterialChooser
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox);
            Name = "MaterialChooser";
            Size = new Size(433, 635);
            groupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private RichTextBox tbMaterialTitle;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private TextBox tbDensity;
        private TextBox tbHatchStyle;
        private Label label3;
    }
}
