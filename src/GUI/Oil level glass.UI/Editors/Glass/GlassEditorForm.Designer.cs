namespace Oil_level_glass.UI.Wizard3d.Editors.Glass
{
    partial class GlassEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlassEditorForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            pbSketch = new PictureBox();
            groupBox = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label1 = new Label();
            tbHeight = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            tbDiameter = new TextBox();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btResetData = new Button();
            btCancel = new Button();
            btOk = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSketch).BeginInit();
            groupBox.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(921, 515);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(pbSketch, 1, 0);
            tableLayoutPanel3.Controls.Add(groupBox, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(5, 5);
            tableLayoutPanel3.Margin = new Padding(5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(911, 423);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // pbSketch
            // 
            pbSketch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbSketch.BorderStyle = BorderStyle.FixedSingle;
            pbSketch.Image = (Image)resources.GetObject("pbSketch.Image");
            pbSketch.Location = new Point(460, 19);
            pbSketch.Margin = new Padding(5, 19, 20, 5);
            pbSketch.Name = "pbSketch";
            pbSketch.Size = new Size(431, 399);
            pbSketch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSketch.TabIndex = 0;
            pbSketch.TabStop = false;
            // 
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox.Controls.Add(tableLayoutPanel4);
            groupBox.Location = new Point(20, 5);
            groupBox.Margin = new Padding(20, 5, 20, 5);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(5);
            groupBox.Size = new Size(415, 413);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Размеры";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(5, 37);
            tableLayoutPanel4.Margin = new Padding(5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(405, 371);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Controls.Add(tbHeight, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(10, 5);
            tableLayoutPanel5.Margin = new Padding(10, 5, 5, 5);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(390, 175);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(49, 55);
            label1.Margin = new Padding(49, 0, 49, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 0;
            label1.Text = "Высота h";
            // 
            // tbHeight
            // 
            tbHeight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbHeight.Location = new Point(49, 87);
            tbHeight.Margin = new Padding(49, 0, 49, 0);
            tbHeight.Name = "tbHeight";
            tbHeight.PlaceholderText = "2";
            tbHeight.Size = new Size(292, 39);
            tbHeight.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(tbDiameter, 0, 1);
            tableLayoutPanel6.Controls.Add(label2, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(5, 190);
            tableLayoutPanel6.Margin = new Padding(5);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(395, 176);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // tbDiameter
            // 
            tbDiameter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDiameter.Location = new Point(49, 88);
            tbDiameter.Margin = new Padding(49, 0, 49, 0);
            tbDiameter.Name = "tbDiameter";
            tbDiameter.PlaceholderText = "60";
            tbDiameter.Size = new Size(297, 39);
            tbDiameter.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(49, 56);
            label2.Margin = new Padding(49, 0, 49, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 1;
            label2.Text = "Диаметр D";
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
            tableLayoutPanel2.Location = new Point(449, 438);
            tableLayoutPanel2.Margin = new Padding(5, 5, 20, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(452, 72);
            tableLayoutPanel2.TabIndex = 0;
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
            btResetData.Click += btClear_Click;
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
            // GlassEditorForm
            // 
            AcceptButton = btOk;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btCancel;
            ClientSize = new Size(921, 515);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GlassEditorForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Редактор размеров линзы";
            FormClosing += GlassEditorForm_FormClosing;
            Load += GlassEditorForm_Load;
            Click += btOk_Click;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSketch).EndInit();
            groupBox.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btCancel;
        private Button btOk;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pbSketch;
        private GroupBox groupBox;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label1;
        private TextBox tbHeight;
        private TextBox tbDiameter;
        private Label label2;
        private Button btResetData;
    }
}