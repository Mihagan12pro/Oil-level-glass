namespace Oil_level_glass.UI.Editors.Housing
{
    partial class HousingEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HousingEditorForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            pbSketch = new PictureBox();
            groupBox = new GroupBox();
            tblSizes = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            label6 = new Label();
            tbGlassSocketHeight = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label5 = new Label();
            tbHeight = new TextBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            label4 = new Label();
            tbHolesCount = new TextBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            tbScrewHolesDistance = new TextBox();
            tbHolesDiatance = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            label3 = new Label();
            tbScrewHoleDiameter = new TextBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            tbCentralHoleDiameter = new TextBox();
            label9 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            label2 = new Label();
            tbGlassSocketDiameter = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label1 = new Label();
            tbMainDiameter = new TextBox();
            tableLayoutPanel12 = new TableLayoutPanel();
            label7 = new Label();
            tbChamferLength = new TextBox();
            tableLayoutPanel13 = new TableLayoutPanel();
            label8 = new Label();
            tbChamferAngle = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btOk = new Button();
            btCancel = new Button();
            blResetData = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSketch).BeginInit();
            groupBox.SuspendLayout();
            tblSizes.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1249, 1003);
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
            tableLayoutPanel3.Size = new Size(1239, 913);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // pbSketch
            // 
            pbSketch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbSketch.BorderStyle = BorderStyle.FixedSingle;
            pbSketch.Image = (Image)resources.GetObject("pbSketch.Image");
            pbSketch.Location = new Point(624, 19);
            pbSketch.Margin = new Padding(5, 19, 20, 5);
            pbSketch.Name = "pbSketch";
            pbSketch.Size = new Size(595, 889);
            pbSketch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSketch.TabIndex = 0;
            pbSketch.TabStop = false;
            // 
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox.Controls.Add(tblSizes);
            groupBox.Location = new Point(20, 5);
            groupBox.Margin = new Padding(20, 5, 20, 5);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(5);
            groupBox.Size = new Size(579, 903);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Размеры";
            // 
            // tblSizes
            // 
            tblSizes.ColumnCount = 1;
            tblSizes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSizes.Controls.Add(tableLayoutPanel11, 0, 7);
            tblSizes.Controls.Add(tableLayoutPanel4, 0, 6);
            tblSizes.Controls.Add(tableLayoutPanel10, 0, 5);
            tblSizes.Controls.Add(tableLayoutPanel9, 0, 4);
            tblSizes.Controls.Add(tableLayoutPanel8, 0, 3);
            tblSizes.Controls.Add(tableLayoutPanel7, 0, 2);
            tblSizes.Controls.Add(tableLayoutPanel6, 0, 1);
            tblSizes.Controls.Add(tableLayoutPanel5, 0, 0);
            tblSizes.Controls.Add(tableLayoutPanel12, 0, 8);
            tblSizes.Controls.Add(tableLayoutPanel13, 0, 9);
            tblSizes.Dock = DockStyle.Fill;
            tblSizes.Location = new Point(5, 37);
            tblSizes.Margin = new Padding(5);
            tblSizes.Name = "tblSizes";
            tblSizes.RowCount = 10;
            tblSizes.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999603F));
            tblSizes.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999599F));
            tblSizes.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999599F));
            tblSizes.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999599F));
            tblSizes.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999599F));
            tblSizes.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999599F));
            tblSizes.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0015993F));
            tblSizes.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0015955F));
            tblSizes.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0000982F));
            tblSizes.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999099F));
            tblSizes.Size = new Size(569, 861);
            tblSizes.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(label6, 0, 0);
            tableLayoutPanel11.Controls.Add(tbGlassSocketHeight, 0, 1);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 605);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(563, 80);
            tableLayoutPanel11.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(49, 8);
            label6.Margin = new Padding(49, 0, 49, 0);
            label6.Name = "label6";
            label6.Size = new Size(126, 32);
            label6.TabIndex = 0;
            label6.Text = "Высота h2";
            // 
            // tbGlassSocketHeight
            // 
            tbGlassSocketHeight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbGlassSocketHeight.Location = new Point(49, 40);
            tbGlassSocketHeight.Margin = new Padding(49, 0, 49, 0);
            tbGlassSocketHeight.Name = "tbGlassSocketHeight";
            tbGlassSocketHeight.ReadOnly = true;
            tbGlassSocketHeight.Size = new Size(465, 39);
            tbGlassSocketHeight.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Controls.Add(tbHeight, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 519);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(563, 80);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(49, 8);
            label5.Margin = new Padding(49, 0, 49, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 32);
            label5.TabIndex = 0;
            label5.Text = "Высота h";
            // 
            // tbHeight
            // 
            tbHeight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbHeight.Location = new Point(49, 40);
            tbHeight.Margin = new Padding(49, 0, 49, 0);
            tbHeight.Name = "tbHeight";
            tbHeight.PlaceholderText = "8";
            tbHeight.Size = new Size(465, 39);
            tbHeight.TabIndex = 1;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(label4, 0, 0);
            tableLayoutPanel10.Controls.Add(tbHolesCount, 0, 1);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 433);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(563, 80);
            tableLayoutPanel10.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(49, 8);
            label4.Margin = new Padding(49, 0, 49, 0);
            label4.Name = "label4";
            label4.Size = new Size(223, 32);
            label4.TabIndex = 0;
            label4.Text = "Число отверстий n";
            // 
            // tbHolesCount
            // 
            tbHolesCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbHolesCount.Location = new Point(49, 40);
            tbHolesCount.Margin = new Padding(49, 0, 49, 0);
            tbHolesCount.Name = "tbHolesCount";
            tbHolesCount.PlaceholderText = "3";
            tbHolesCount.Size = new Size(465, 39);
            tbHolesCount.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(tbScrewHolesDistance, 0, 1);
            tableLayoutPanel9.Controls.Add(tbHolesDiatance, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 347);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(563, 80);
            tableLayoutPanel9.TabIndex = 4;
            // 
            // tbScrewHolesDistance
            // 
            tbScrewHolesDistance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbScrewHolesDistance.Location = new Point(49, 40);
            tbScrewHolesDistance.Margin = new Padding(49, 0, 49, 0);
            tbScrewHolesDistance.Name = "tbScrewHolesDistance";
            tbScrewHolesDistance.PlaceholderText = "36";
            tbScrewHolesDistance.Size = new Size(465, 39);
            tbScrewHolesDistance.TabIndex = 0;
            // 
            // tbHolesDiatance
            // 
            tbHolesDiatance.AutoSize = true;
            tbHolesDiatance.Location = new Point(49, 0);
            tbHolesDiatance.Margin = new Padding(49, 0, 49, 0);
            tbHolesDiatance.Name = "tbHolesDiatance";
            tbHolesDiatance.Size = new Size(175, 32);
            tbHolesDiatance.TabIndex = 1;
            tbHolesDiatance.Text = "Расстояние D3";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(label3, 0, 0);
            tableLayoutPanel8.Controls.Add(tbScrewHoleDiameter, 0, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 261);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(563, 80);
            tableLayoutPanel8.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(49, 8);
            label3.Margin = new Padding(49, 0, 49, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 0;
            label3.Text = "Диаметр d";
            // 
            // tbScrewHoleDiameter
            // 
            tbScrewHoleDiameter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbScrewHoleDiameter.Location = new Point(49, 40);
            tbScrewHoleDiameter.Margin = new Padding(49, 0, 49, 0);
            tbScrewHoleDiameter.Name = "tbScrewHoleDiameter";
            tbScrewHoleDiameter.PlaceholderText = "8";
            tbScrewHoleDiameter.Size = new Size(465, 39);
            tbScrewHoleDiameter.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(tbCentralHoleDiameter, 0, 1);
            tableLayoutPanel7.Controls.Add(label9, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 175);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(563, 80);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // tbCentralHoleDiameter
            // 
            tbCentralHoleDiameter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCentralHoleDiameter.Location = new Point(49, 40);
            tbCentralHoleDiameter.Margin = new Padding(49, 0, 49, 0);
            tbCentralHoleDiameter.Name = "tbCentralHoleDiameter";
            tbCentralHoleDiameter.ReadOnly = true;
            tbCentralHoleDiameter.Size = new Size(465, 39);
            tbCentralHoleDiameter.TabIndex = 2;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(49, 8);
            label9.Margin = new Padding(49, 0, 49, 0);
            label9.Name = "label9";
            label9.Size = new Size(148, 32);
            label9.TabIndex = 1;
            label9.Text = "Диаметр D2";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label2, 0, 0);
            tableLayoutPanel6.Controls.Add(tbGlassSocketDiameter, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 89);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(563, 80);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(49, 8);
            label2.Margin = new Padding(49, 0, 49, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 0;
            label2.Text = "Диаметр D1";
            // 
            // tbGlassSocketDiameter
            // 
            tbGlassSocketDiameter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbGlassSocketDiameter.Enabled = false;
            tbGlassSocketDiameter.Location = new Point(49, 40);
            tbGlassSocketDiameter.Margin = new Padding(49, 0, 49, 0);
            tbGlassSocketDiameter.Name = "tbGlassSocketDiameter";
            tbGlassSocketDiameter.ReadOnly = true;
            tbGlassSocketDiameter.Size = new Size(465, 39);
            tbGlassSocketDiameter.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Controls.Add(tbMainDiameter, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(563, 80);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(49, 8);
            label1.Margin = new Padding(49, 0, 49, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 0;
            label1.Text = "Диаметр D";
            // 
            // tbMainDiameter
            // 
            tbMainDiameter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbMainDiameter.Location = new Point(49, 40);
            tbMainDiameter.Margin = new Padding(49, 0, 49, 0);
            tbMainDiameter.Name = "tbMainDiameter";
            tbMainDiameter.PlaceholderText = "90";
            tbMainDiameter.Size = new Size(465, 39);
            tbMainDiameter.TabIndex = 1;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(label7, 0, 0);
            tableLayoutPanel12.Controls.Add(tbChamferLength, 0, 1);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 691);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(563, 80);
            tableLayoutPanel12.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(49, 8);
            label7.Margin = new Padding(49, 0, 49, 0);
            label7.Name = "label7";
            label7.Size = new Size(97, 32);
            label7.TabIndex = 0;
            label7.Text = "Длина l";
            // 
            // tbChamferLength
            // 
            tbChamferLength.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbChamferLength.Location = new Point(49, 40);
            tbChamferLength.Margin = new Padding(49, 0, 49, 0);
            tbChamferLength.Name = "tbChamferLength";
            tbChamferLength.PlaceholderText = "3";
            tbChamferLength.Size = new Size(465, 39);
            tbChamferLength.TabIndex = 1;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(label8, 0, 0);
            tableLayoutPanel13.Controls.Add(tbChamferAngle, 0, 1);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 777);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 2;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(563, 81);
            tableLayoutPanel13.TabIndex = 9;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(49, 8);
            label8.Margin = new Padding(49, 0, 49, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 32);
            label8.TabIndex = 0;
            label8.Text = "Угол α,°";
            // 
            // tbChamferAngle
            // 
            tbChamferAngle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbChamferAngle.Location = new Point(49, 40);
            tbChamferAngle.Margin = new Padding(49, 0, 49, 0);
            tbChamferAngle.Name = "tbChamferAngle";
            tbChamferAngle.PlaceholderText = "60";
            tbChamferAngle.Size = new Size(465, 39);
            tbChamferAngle.TabIndex = 1;
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
            tableLayoutPanel2.Location = new Point(769, 928);
            tableLayoutPanel2.Margin = new Padding(5, 5, 20, 16);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(460, 59);
            tableLayoutPanel2.TabIndex = 1;
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
            // 
            // HousingEditorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btCancel;
            ClientSize = new Size(1249, 1003);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HousingEditorForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Редактор размеров корпуса";
            Load += HousingEditorForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSketch).EndInit();
            groupBox.ResumeLayout(false);
            tblSizes.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
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
        private GroupBox groupBox;
        private TableLayoutPanel tblSizes;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private TextBox tbMainDiameter;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label4;
        private TextBox tbHolesCount;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox tbScrewHoleDiameter;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label2;
        private TextBox tbGlassSocketDiameter;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label6;
        private TextBox tbGlassSocketHeight;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label5;
        private TextBox tbHeight;
        private TableLayoutPanel tableLayoutPanel11;
        private Label label8;
        private TextBox tbChamferAngle;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label7;
        private TextBox tbChamferLength;
        private TextBox tbCentralHoleDiameter;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel12;
        private TextBox tbScrewHolesDistance;
        private Label tbHolesDiatance;
        private TableLayoutPanel tableLayoutPanel13;
    }
}