namespace Oil_level_glass.UI.Editors.Housing.ChamferEditor
{
    partial class ChamferEditorForm
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
            btResetData = new Button();
            btCancel = new Button();
            btOk = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            pbSketch = new PictureBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label3 = new Label();
            tbSide2 = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            tbSide1 = new TextBox();
            label2 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            label1 = new Label();
            tbAngle = new TextBox();
            groupBox2 = new GroupBox();
            rbSideAndAngle = new RadioButton();
            rbTwoSides = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSketch).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            groupBox2.SuspendLayout();
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(937, 573);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btResetData, 0, 0);
            tableLayoutPanel2.Controls.Add(btCancel, 1, 0);
            tableLayoutPanel2.Controls.Add(btOk, 2, 0);
            tableLayoutPanel2.Location = new Point(465, 496);
            tableLayoutPanel2.Margin = new Padding(5, 5, 20, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(452, 72);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btResetData
            // 
            btResetData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btResetData.Location = new Point(5, 10);
            btResetData.Margin = new Padding(5, 5, 5, 16);
            btResetData.Name = "btResetData";
            btResetData.Size = new Size(140, 46);
            btResetData.TabIndex = 2;
            btResetData.Text = "Очистить";
            btResetData.UseVisualStyleBackColor = true;
            btResetData.Click += btResetData_Click;
            // 
            // btCancel
            // 
            btCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btCancel.Location = new Point(155, 10);
            btCancel.Margin = new Padding(5, 5, 5, 16);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(140, 46);
            btCancel.TabIndex = 0;
            btCancel.Text = "Отмена";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // btOk
            // 
            btOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btOk.Enabled = false;
            btOk.Location = new Point(306, 10);
            btOk.Margin = new Padding(5, 5, 0, 16);
            btOk.Name = "btOk";
            btOk.Size = new Size(146, 46);
            btOk.TabIndex = 1;
            btOk.Text = "Ок";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += btOk_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(pbSketch, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(931, 485);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // pbSketch
            // 
            pbSketch.BorderStyle = BorderStyle.FixedSingle;
            pbSketch.Dock = DockStyle.Fill;
            pbSketch.Location = new Point(465, 20);
            pbSketch.Margin = new Padding(0, 20, 20, 0);
            pbSketch.Name = "pbSketch";
            pbSketch.Size = new Size(446, 465);
            pbSketch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSketch.TabIndex = 0;
            pbSketch.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel4.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(459, 479);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(20, 3);
            groupBox1.Margin = new Padding(20, 3, 20, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 296);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Размеры";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 0, 2);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 35);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(413, 258);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(label3, 0, 0);
            tableLayoutPanel7.Controls.Add(tbSide2, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 174);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(407, 81);
            tableLayoutPanel7.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 0);
            label3.Margin = new Padding(49, 0, 49, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 32);
            label3.TabIndex = 0;
            label3.Text = "Катет l2";
            // 
            // tbSide2
            // 
            tbSide2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSide2.Enabled = false;
            tbSide2.Location = new Point(49, 40);
            tbSide2.Margin = new Padding(49, 0, 49, 0);
            tbSide2.Name = "tbSide2";
            tbSide2.Size = new Size(309, 39);
            tbSide2.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(tbSide1, 0, 1);
            tableLayoutPanel6.Controls.Add(label2, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 88);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(407, 80);
            tableLayoutPanel6.TabIndex = 4;
            // 
            // tbSide1
            // 
            tbSide1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSide1.Location = new Point(49, 40);
            tbSide1.Margin = new Padding(49, 0, 49, 0);
            tbSide1.Name = "tbSide1";
            tbSide1.Size = new Size(309, 39);
            tbSide1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(49, 8);
            label2.Margin = new Padding(49, 0, 49, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 0;
            label2.Text = "Катет l";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(label1, 0, 0);
            tableLayoutPanel8.Controls.Add(tbAngle, 0, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(407, 79);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(49, 7);
            label1.Margin = new Padding(49, 0, 49, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Угол α, °";
            // 
            // tbAngle
            // 
            tbAngle.Location = new Point(49, 39);
            tbAngle.Margin = new Padding(49, 0, 49, 0);
            tbAngle.Name = "tbAngle";
            tbAngle.Size = new Size(309, 39);
            tbAngle.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbSideAndAngle);
            groupBox2.Controls.Add(rbTwoSides);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(20, 305);
            groupBox2.Margin = new Padding(20, 3, 20, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 171);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Способ построения";
            // 
            // rbSideAndAngle
            // 
            rbSideAndAngle.AutoSize = true;
            rbSideAndAngle.Location = new Point(55, 116);
            rbSideAndAngle.Name = "rbSideAndAngle";
            rbSideAndAngle.Size = new Size(247, 36);
            rbSideAndAngle.TabIndex = 1;
            rbSideAndAngle.TabStop = true;
            rbSideAndAngle.Text = "По стороне и углу";
            rbSideAndAngle.UseVisualStyleBackColor = true;
            // 
            // rbTwoSides
            // 
            rbTwoSides.AutoSize = true;
            rbTwoSides.Location = new Point(55, 48);
            rbTwoSides.Name = "rbTwoSides";
            rbTwoSides.Size = new Size(251, 36);
            rbTwoSides.TabIndex = 0;
            rbTwoSides.TabStop = true;
            rbTwoSides.Text = "По двум сторонам";
            rbTwoSides.UseVisualStyleBackColor = true;
            // 
            // ChamferEditorForm
            // 
            AcceptButton = btOk;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 573);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChamferEditorForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Редактор фасок";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSketch).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btResetData;
        private Button btCancel;
        private Button btOk;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pbSketch;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label3;
        private TextBox tbSide2;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox tbSide1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rbSideAndAngle;
        private RadioButton rbTwoSides;
        private TextBox tbAngle;
    }
}