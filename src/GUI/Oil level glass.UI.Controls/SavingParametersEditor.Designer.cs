namespace Oil_level_glass.UI.Controls
{
    partial class SavingParametersEditor
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
            label1 = new Label();
            tbNaming = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            tbMarking = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            btChooseFolder = new Button();
            tbFolderPath = new RichTextBox();
            groupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.AutoSize = true;
            groupBox.Controls.Add(tableLayoutPanel1);
            groupBox.Dock = DockStyle.Fill;
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(419, 613);
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
            tableLayoutPanel1.Size = new Size(413, 575);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(tbNaming, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(400, 185);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(40, 57);
            label1.Margin = new Padding(40, 3, 40, 3);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 0;
            label1.Text = "Наименование";
            // 
            // tbNaming
            // 
            tbNaming.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbNaming.Location = new Point(40, 95);
            tbNaming.Margin = new Padding(40, 3, 40, 3);
            tbNaming.Name = "tbNaming";
            tbNaming.Size = new Size(320, 39);
            tbNaming.TabIndex = 1;
            tbNaming.TextChanged += tb_TextChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(tbMarking, 0, 1);
            tableLayoutPanel3.Location = new Point(3, 194);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(400, 185);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(40, 57);
            label2.Margin = new Padding(40, 3, 40, 3);
            label2.Name = "label2";
            label2.Size = new Size(165, 32);
            label2.TabIndex = 0;
            label2.Text = "Обозначение";
            // 
            // tbMarking
            // 
            tbMarking.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbMarking.Location = new Point(40, 95);
            tbMarking.Margin = new Padding(40, 3, 40, 3);
            tbMarking.Name = "tbMarking";
            tbMarking.Size = new Size(320, 39);
            tbMarking.TabIndex = 1;
            tbMarking.TextChanged += tb_TextChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btChooseFolder, 0, 0);
            tableLayoutPanel4.Controls.Add(tbFolderPath, 0, 1);
            tableLayoutPanel4.Location = new Point(3, 385);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(400, 187);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // btChooseFolder
            // 
            btChooseFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btChooseFolder.Location = new Point(40, 44);
            btChooseFolder.Margin = new Padding(40, 3, 40, 3);
            btChooseFolder.Name = "btChooseFolder";
            btChooseFolder.Size = new Size(150, 46);
            btChooseFolder.TabIndex = 0;
            btChooseFolder.Text = "Выбрать...";
            btChooseFolder.UseVisualStyleBackColor = true;
            btChooseFolder.Click += btChooseFolder_Click;
            // 
            // tbFolderPath
            // 
            tbFolderPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFolderPath.Location = new Point(40, 96);
            tbFolderPath.Margin = new Padding(40, 3, 40, 3);
            tbFolderPath.Multiline = false;
            tbFolderPath.Name = "tbFolderPath";
            tbFolderPath.ReadOnly = true;
            tbFolderPath.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal;
            tbFolderPath.Size = new Size(320, 47);
            tbFolderPath.TabIndex = 1;
            tbFolderPath.Text = "";
            tbFolderPath.TextChanged += tb_TextChanged;
            // 
            // SavingParametersEditor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox);
            Name = "SavingParametersEditor";
            Size = new Size(419, 613);
            groupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TextBox tbNaming;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private TextBox tbMarking;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btChooseFolder;
        private RichTextBox tbFolderPath;
    }
}
