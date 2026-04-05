namespace Oil_level_glass.UI.Wizard3d
{
    partial class Wizard3dForm
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
            btOk = new Button();
            btCancel = new Button();
            tbCtlrModelParams = new TabControl();
            tabSizes = new TabPage();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel2 = new FlowLayoutPanel();
            gbDiameters = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            tbD = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox3 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            groupBox4 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            groupBox5 = new GroupBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            label9 = new Label();
            label10 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label8 = new Label();
            numericUpDown2 = new NumericUpDown();
            splitContainer2 = new SplitContainer();
            pbSketch = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rbAssembly = new RadioButton();
            rbHousing = new RadioButton();
            rbGlass = new RadioButton();
            rbRubberStrip = new RadioButton();
            tabMaterials = new TabPage();
            tlpMaterials = new TableLayoutPanel();
            mcHousing = new Oil_level_glass.UI.Controls.MaterialChooser();
            materialChooser1 = new Oil_level_glass.UI.Controls.MaterialChooser();
            materialChooser2 = new Oil_level_glass.UI.Controls.MaterialChooser();
            tabSaving = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            savingParametersEditor1 = new Oil_level_glass.UI.Controls.SavingParametersEditor();
            savingParametersEditor2 = new Oil_level_glass.UI.Controls.SavingParametersEditor();
            savingParametersEditor3 = new Oil_level_glass.UI.Controls.SavingParametersEditor();
            tabAppearance = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            appeareanceEditor3 = new Oil_level_glass.UI.Controls.AppeareanceEditor();
            appeareanceEditor2 = new Oil_level_glass.UI.Controls.AppeareanceEditor();
            appeareanceEditor1 = new Oil_level_glass.UI.Controls.AppeareanceEditor();
            tbCtlrModelParams.SuspendLayout();
            tabSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            gbDiameters.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBox5.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSketch).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tabMaterials.SuspendLayout();
            tlpMaterials.SuspendLayout();
            tabSaving.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabAppearance.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btOk
            // 
            btOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btOk.Location = new Point(930, 885);
            btOk.Margin = new Padding(5);
            btOk.Name = "btOk";
            btOk.Size = new Size(153, 46);
            btOk.TabIndex = 0;
            btOk.Text = "Ок";
            btOk.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            btCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btCancel.Location = new Point(1128, 885);
            btCancel.Margin = new Padding(5);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(153, 46);
            btCancel.TabIndex = 1;
            btCancel.Text = "Отмена";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // tbCtlrModelParams
            // 
            tbCtlrModelParams.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCtlrModelParams.Controls.Add(tabSizes);
            tbCtlrModelParams.Controls.Add(tabMaterials);
            tbCtlrModelParams.Controls.Add(tabSaving);
            tbCtlrModelParams.Controls.Add(tabAppearance);
            tbCtlrModelParams.Location = new Point(20, 3);
            tbCtlrModelParams.Margin = new Padding(5);
            tbCtlrModelParams.Name = "tbCtlrModelParams";
            tbCtlrModelParams.SelectedIndex = 0;
            tbCtlrModelParams.Size = new Size(1261, 858);
            tbCtlrModelParams.TabIndex = 2;
            // 
            // tabSizes
            // 
            tabSizes.Controls.Add(splitContainer1);
            tabSizes.Location = new Point(8, 46);
            tabSizes.Margin = new Padding(5);
            tabSizes.Name = "tabSizes";
            tabSizes.Padding = new Padding(5);
            tabSizes.Size = new Size(1245, 804);
            tabSizes.TabIndex = 0;
            tabSizes.Text = "Размеры";
            tabSizes.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(5, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1235, 794);
            splitContainer1.SplitterDistance = 410;
            splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(gbDiameters);
            flowLayoutPanel2.Controls.Add(groupBox2);
            flowLayoutPanel2.Controls.Add(groupBox3);
            flowLayoutPanel2.Controls.Add(groupBox4);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(3, 3, 10, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(410, 794);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // gbDiameters
            // 
            gbDiameters.Controls.Add(tableLayoutPanel5);
            gbDiameters.Location = new Point(3, 3);
            gbDiameters.Name = "gbDiameters";
            gbDiameters.Size = new Size(400, 184);
            gbDiameters.TabIndex = 0;
            gbDiameters.TabStop = false;
            gbDiameters.Text = "Диаметры";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(textBox6, 1, 2);
            tableLayoutPanel5.Controls.Add(textBox5, 1, 1);
            tableLayoutPanel5.Controls.Add(tbD, 1, 0);
            tableLayoutPanel5.Controls.Add(label5, 0, 0);
            tableLayoutPanel5.Controls.Add(label6, 0, 1);
            tableLayoutPanel5.Controls.Add(label7, 0, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 35);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Size = new Size(394, 146);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Location = new Point(53, 99);
            textBox6.Margin = new Padding(3, 3, 20, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(321, 39);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(53, 51);
            textBox5.Margin = new Padding(3, 3, 20, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(321, 39);
            textBox5.TabIndex = 4;
            // 
            // tbD
            // 
            tbD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbD.Location = new Point(53, 3);
            tbD.Margin = new Padding(3, 3, 20, 3);
            tbD.Name = "tbD";
            tbD.Size = new Size(321, 39);
            tbD.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 32);
            label5.TabIndex = 0;
            label5.Text = "D";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 48);
            label6.Name = "label6";
            label6.Size = new Size(44, 32);
            label6.TabIndex = 1;
            label6.Text = "D1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 96);
            label7.Name = "label7";
            label7.Size = new Size(41, 32);
            label7.TabIndex = 2;
            label7.Text = "d2";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Location = new Point(3, 193);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 148);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Высоты";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(label4, 0, 1);
            tableLayoutPanel4.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel4.Controls.Add(textBox3, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 35);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(394, 110);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(28, 32);
            label3.TabIndex = 0;
            label3.Text = "h";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 55);
            label4.Name = "label4";
            label4.Size = new Size(41, 32);
            label4.TabIndex = 1;
            label4.Text = "h2";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(50, 3);
            textBox2.Margin = new Padding(3, 3, 20, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(324, 39);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(50, 58);
            textBox3.Margin = new Padding(3, 3, 20, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(324, 39);
            textBox3.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Location = new Point(3, 347);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(400, 154);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Параметры фаски";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(numericUpDown1, 1, 0);
            tableLayoutPanel3.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 35);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(394, 116);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 32);
            label1.TabIndex = 0;
            label1.Text = "α, °";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 58);
            label2.Name = "label2";
            label2.Size = new Size(20, 32);
            label2.TabIndex = 1;
            label2.Text = "l";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.Location = new Point(59, 3);
            numericUpDown1.Margin = new Padding(3, 3, 20, 3);
            numericUpDown1.Maximum = new decimal(new int[] { 89, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(315, 39);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 45, 0, 0, 0 });
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(59, 61);
            textBox1.Margin = new Padding(3, 3, 20, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 39);
            textBox1.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel6);
            groupBox4.Location = new Point(3, 507);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(400, 259);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Параметры отверстия";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(groupBox5, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 35);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.Size = new Size(394, 221);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox5.Controls.Add(tableLayoutPanel8);
            groupBox5.Location = new Point(5, 3);
            groupBox5.Margin = new Padding(5, 3, 5, 5);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(384, 159);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Резьба";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(label9, 0, 0);
            tableLayoutPanel8.Controls.Add(label10, 0, 1);
            tableLayoutPanel8.Controls.Add(textBox8, 1, 1);
            tableLayoutPanel8.Controls.Add(textBox7, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 35);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(378, 121);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(111, 32);
            label9.TabIndex = 0;
            label9.Text = "Диаметр";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 60);
            label10.Name = "label10";
            label10.Size = new Size(58, 32);
            label10.TabIndex = 1;
            label10.Text = "Шаг";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox8.Location = new Point(120, 63);
            textBox8.Margin = new Padding(3, 3, 20, 3);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(238, 39);
            textBox8.TabIndex = 3;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Location = new Point(120, 3);
            textBox7.Margin = new Padding(3, 3, 20, 3);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(238, 39);
            textBox7.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(label8, 0, 0);
            tableLayoutPanel7.Controls.Add(numericUpDown2, 1, 0);
            tableLayoutPanel7.Location = new Point(3, 170);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(388, 48);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(129, 32);
            label8.TabIndex = 0;
            label8.Text = "Отверстия";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(197, 3);
            numericUpDown2.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(188, 39);
            numericUpDown2.TabIndex = 0;
            numericUpDown2.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(pbSketch);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer2.Size = new Size(821, 794);
            splitContainer2.SplitterDistance = 715;
            splitContainer2.TabIndex = 0;
            // 
            // pbSketch
            // 
            pbSketch.BorderStyle = BorderStyle.FixedSingle;
            pbSketch.Dock = DockStyle.Fill;
            pbSketch.Image = Properties.Resources.Oil_level_glass;
            pbSketch.Location = new Point(0, 0);
            pbSketch.Name = "pbSketch";
            pbSketch.Size = new Size(821, 715);
            pbSketch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSketch.TabIndex = 0;
            pbSketch.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(rbAssembly);
            flowLayoutPanel1.Controls.Add(rbHousing);
            flowLayoutPanel1.Controls.Add(rbGlass);
            flowLayoutPanel1.Controls.Add(rbRubberStrip);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(821, 75);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // rbAssembly
            // 
            rbAssembly.AutoSize = true;
            rbAssembly.Checked = true;
            rbAssembly.Location = new Point(20, 10);
            rbAssembly.Margin = new Padding(20, 10, 3, 3);
            rbAssembly.Name = "rbAssembly";
            rbAssembly.Size = new Size(250, 36);
            rbAssembly.TabIndex = 0;
            rbAssembly.TabStop = true;
            rbAssembly.Text = "Смотровой лючок";
            rbAssembly.UseVisualStyleBackColor = true;
            rbAssembly.CheckedChanged += rbSketch_CheckedChanged;
            // 
            // rbHousing
            // 
            rbHousing.AutoSize = true;
            rbHousing.Location = new Point(276, 10);
            rbHousing.Margin = new Padding(3, 10, 3, 3);
            rbHousing.Name = "rbHousing";
            rbHousing.Size = new Size(124, 36);
            rbHousing.TabIndex = 1;
            rbHousing.Text = "Корпус";
            rbHousing.UseVisualStyleBackColor = true;
            rbHousing.CheckedChanged += rbSketch_CheckedChanged;
            // 
            // rbGlass
            // 
            rbGlass.AutoSize = true;
            rbGlass.Location = new Point(406, 10);
            rbGlass.Margin = new Padding(3, 10, 3, 3);
            rbGlass.Name = "rbGlass";
            rbGlass.Size = new Size(112, 36);
            rbGlass.TabIndex = 2;
            rbGlass.Text = "Линза";
            rbGlass.UseVisualStyleBackColor = true;
            rbGlass.CheckedChanged += rbSketch_CheckedChanged;
            // 
            // rbRubberStrip
            // 
            rbRubberStrip.AutoSize = true;
            rbRubberStrip.Location = new Point(524, 10);
            rbRubberStrip.Margin = new Padding(3, 10, 3, 3);
            rbRubberStrip.Name = "rbRubberStrip";
            rbRubberStrip.Size = new Size(284, 36);
            rbRubberStrip.TabIndex = 3;
            rbRubberStrip.Text = "Резиновая прокладка";
            rbRubberStrip.UseVisualStyleBackColor = true;
            rbRubberStrip.CheckedChanged += rbSketch_CheckedChanged;
            // 
            // tabMaterials
            // 
            tabMaterials.Controls.Add(tlpMaterials);
            tabMaterials.Location = new Point(8, 46);
            tabMaterials.Margin = new Padding(5);
            tabMaterials.Name = "tabMaterials";
            tabMaterials.Padding = new Padding(5);
            tabMaterials.Size = new Size(1245, 804);
            tabMaterials.TabIndex = 1;
            tabMaterials.Text = "Материалы";
            tabMaterials.UseVisualStyleBackColor = true;
            // 
            // tlpMaterials
            // 
            tlpMaterials.ColumnCount = 3;
            tlpMaterials.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpMaterials.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpMaterials.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpMaterials.Controls.Add(mcHousing, 0, 0);
            tlpMaterials.Controls.Add(materialChooser1, 1, 0);
            tlpMaterials.Controls.Add(materialChooser2, 2, 0);
            tlpMaterials.Dock = DockStyle.Fill;
            tlpMaterials.Location = new Point(5, 5);
            tlpMaterials.Margin = new Padding(5);
            tlpMaterials.Name = "tlpMaterials";
            tlpMaterials.RowCount = 1;
            tlpMaterials.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMaterials.Size = new Size(1235, 794);
            tlpMaterials.TabIndex = 0;
            // 
            // mcHousing
            // 
            mcHousing.Density = 0D;
            mcHousing.Dock = DockStyle.Fill;
            mcHousing.HatchStyle = 0;
            mcHousing.Header = "Корпус";
            mcHousing.Location = new Point(20, 3);
            mcHousing.Margin = new Padding(20, 3, 20, 3);
            mcHousing.MaterialTitle = null;
            mcHousing.Name = "mcHousing";
            mcHousing.Size = new Size(371, 788);
            mcHousing.TabIndex = 0;
            // 
            // materialChooser1
            // 
            materialChooser1.Density = 0D;
            materialChooser1.Dock = DockStyle.Fill;
            materialChooser1.HatchStyle = 0;
            materialChooser1.Header = "Линза";
            materialChooser1.Location = new Point(431, 3);
            materialChooser1.Margin = new Padding(20, 3, 20, 3);
            materialChooser1.MaterialTitle = null;
            materialChooser1.Name = "materialChooser1";
            materialChooser1.Size = new Size(371, 788);
            materialChooser1.TabIndex = 1;
            // 
            // materialChooser2
            // 
            materialChooser2.Density = 0D;
            materialChooser2.Dock = DockStyle.Fill;
            materialChooser2.HatchStyle = 0;
            materialChooser2.Header = "Прокладка";
            materialChooser2.Location = new Point(842, 3);
            materialChooser2.Margin = new Padding(20, 3, 20, 3);
            materialChooser2.MaterialTitle = null;
            materialChooser2.Name = "materialChooser2";
            materialChooser2.Size = new Size(373, 788);
            materialChooser2.TabIndex = 2;
            // 
            // tabSaving
            // 
            tabSaving.Controls.Add(tableLayoutPanel1);
            tabSaving.Location = new Point(8, 46);
            tabSaving.Margin = new Padding(5);
            tabSaving.Name = "tabSaving";
            tabSaving.Size = new Size(1245, 804);
            tabSaving.TabIndex = 2;
            tabSaving.Text = "Сохранение";
            tabSaving.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(savingParametersEditor1, 0, 0);
            tableLayoutPanel1.Controls.Add(savingParametersEditor2, 1, 0);
            tableLayoutPanel1.Controls.Add(savingParametersEditor3, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1245, 804);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // savingParametersEditor1
            // 
            savingParametersEditor1.Dock = DockStyle.Fill;
            savingParametersEditor1.FolderPath = "C:\\Users\\kargi\\OneDrive\\Документы";
            savingParametersEditor1.Header = "Корпус";
            savingParametersEditor1.Location = new Point(20, 3);
            savingParametersEditor1.Margin = new Padding(20, 3, 20, 3);
            savingParametersEditor1.Marking = null;
            savingParametersEditor1.Name = "savingParametersEditor1";
            savingParametersEditor1.Namimg = null;
            savingParametersEditor1.Size = new Size(375, 798);
            savingParametersEditor1.TabIndex = 0;
            // 
            // savingParametersEditor2
            // 
            savingParametersEditor2.Dock = DockStyle.Fill;
            savingParametersEditor2.FolderPath = "C:\\Users\\kargi\\OneDrive\\Документы";
            savingParametersEditor2.Header = "Линза";
            savingParametersEditor2.Location = new Point(435, 3);
            savingParametersEditor2.Margin = new Padding(20, 3, 20, 3);
            savingParametersEditor2.Marking = null;
            savingParametersEditor2.Name = "savingParametersEditor2";
            savingParametersEditor2.Namimg = null;
            savingParametersEditor2.Size = new Size(375, 798);
            savingParametersEditor2.TabIndex = 1;
            // 
            // savingParametersEditor3
            // 
            savingParametersEditor3.Dock = DockStyle.Fill;
            savingParametersEditor3.FolderPath = "C:\\Users\\kargi\\OneDrive\\Документы";
            savingParametersEditor3.Header = "Прокладка";
            savingParametersEditor3.Location = new Point(850, 3);
            savingParametersEditor3.Margin = new Padding(20, 3, 20, 3);
            savingParametersEditor3.Marking = null;
            savingParametersEditor3.Name = "savingParametersEditor3";
            savingParametersEditor3.Namimg = null;
            savingParametersEditor3.Size = new Size(375, 798);
            savingParametersEditor3.TabIndex = 2;
            // 
            // tabAppearance
            // 
            tabAppearance.Controls.Add(tableLayoutPanel2);
            tabAppearance.Location = new Point(8, 46);
            tabAppearance.Margin = new Padding(5);
            tabAppearance.Name = "tabAppearance";
            tabAppearance.Size = new Size(1245, 804);
            tabAppearance.TabIndex = 3;
            tabAppearance.Text = "Отображение";
            tabAppearance.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(appeareanceEditor3, 2, 0);
            tableLayoutPanel2.Controls.Add(appeareanceEditor2, 1, 0);
            tableLayoutPanel2.Controls.Add(appeareanceEditor1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1245, 804);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // appeareanceEditor3
            // 
            appeareanceEditor3.Color = Color.Transparent;
            appeareanceEditor3.Diffusion = 0;
            appeareanceEditor3.Dock = DockStyle.Fill;
            appeareanceEditor3.Embient = 0;
            appeareanceEditor3.Emission = 0;
            appeareanceEditor3.Header = "Прокладка";
            appeareanceEditor3.Location = new Point(840, 3);
            appeareanceEditor3.Margin = new Padding(10, 3, 10, 3);
            appeareanceEditor3.Name = "appeareanceEditor3";
            appeareanceEditor3.Shininess = 0;
            appeareanceEditor3.Size = new Size(395, 798);
            appeareanceEditor3.Specularity = 0;
            appeareanceEditor3.TabIndex = 2;
            appeareanceEditor3.Transparency = 0;
            // 
            // appeareanceEditor2
            // 
            appeareanceEditor2.Color = Color.Transparent;
            appeareanceEditor2.Diffusion = 0;
            appeareanceEditor2.Dock = DockStyle.Fill;
            appeareanceEditor2.Embient = 0;
            appeareanceEditor2.Emission = 0;
            appeareanceEditor2.Header = "Линза";
            appeareanceEditor2.Location = new Point(425, 3);
            appeareanceEditor2.Margin = new Padding(10, 3, 10, 3);
            appeareanceEditor2.Name = "appeareanceEditor2";
            appeareanceEditor2.Shininess = 0;
            appeareanceEditor2.Size = new Size(395, 798);
            appeareanceEditor2.Specularity = 0;
            appeareanceEditor2.TabIndex = 1;
            appeareanceEditor2.Transparency = 0;
            // 
            // appeareanceEditor1
            // 
            appeareanceEditor1.Color = Color.Transparent;
            appeareanceEditor1.Diffusion = 0;
            appeareanceEditor1.Dock = DockStyle.Fill;
            appeareanceEditor1.Embient = 0;
            appeareanceEditor1.Emission = 0;
            appeareanceEditor1.Header = "Корпус";
            appeareanceEditor1.Location = new Point(10, 3);
            appeareanceEditor1.Margin = new Padding(10, 3, 10, 3);
            appeareanceEditor1.Name = "appeareanceEditor1";
            appeareanceEditor1.Shininess = 0;
            appeareanceEditor1.Size = new Size(395, 798);
            appeareanceEditor1.Specularity = 0;
            appeareanceEditor1.TabIndex = 0;
            appeareanceEditor1.Transparency = 0;
            // 
            // Wizard3dForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btCancel;
            ClientSize = new Size(1300, 945);
            Controls.Add(tbCtlrModelParams);
            Controls.Add(btCancel);
            Controls.Add(btOk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Wizard3dForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Мастер 3d модели";
            tbCtlrModelParams.ResumeLayout(false);
            tabSizes.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            gbDiameters.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSketch).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tabMaterials.ResumeLayout(false);
            tlpMaterials.ResumeLayout(false);
            tabSaving.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tabAppearance.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btOk;
        private Button btCancel;
        private TabControl tbCtlrModelParams;
        private TabPage tabSizes;
        private TabPage tabMaterials;
        private TabPage tabSaving;
        private TabPage tabAppearance;
        private TableLayoutPanel tlpMaterials;
        private Controls.MaterialChooser mcHousing;
        private Controls.MaterialChooser materialChooser1;
        private Controls.MaterialChooser materialChooser2;
        private TableLayoutPanel tableLayoutPanel1;
        private Controls.SavingParametersEditor savingParametersEditor1;
        private Controls.SavingParametersEditor savingParametersEditor2;
        private Controls.SavingParametersEditor savingParametersEditor3;
        private TableLayoutPanel tableLayoutPanel2;
        private Controls.AppeareanceEditor appeareanceEditor1;
        private Controls.AppeareanceEditor appeareanceEditor3;
        private Controls.AppeareanceEditor appeareanceEditor2;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private PictureBox pbSketch;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton rbAssembly;
        private RadioButton rbHousing;
        private RadioButton rbGlass;
        private RadioButton rbRubberStrip;
        private FlowLayoutPanel flowLayoutPanel2;
        private GroupBox gbDiameters;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox tbD;
        private Label label5;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel6;
        private GroupBox groupBox5;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label8;
        private NumericUpDown numericUpDown2;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label9;
        private Label label10;
        private TextBox textBox8;
        private TextBox textBox7;
    }
}