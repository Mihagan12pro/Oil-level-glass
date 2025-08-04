namespace Oil_level_glass.Wizards.Forms
{
    partial class Wizard3DForm
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
            tabControl1 = new TabControl();
            housingTabPage = new TabPage();
            splitContainer1 = new SplitContainer();
            housingLeftPanel = new TableLayoutPanel();
            housingSizesGroupBox = new GroupBox();
            housingSizesPanel = new TableLayoutPanel();
            housingDiameterLabel = new Label();
            housingHoleLabel = new Label();
            housingHeightLabel = new Label();
            housingDiameterTextBox = new TextBox();
            housingHoleTextBox = new TextBox();
            housingHeightTextBox = new TextBox();
            housingMaterialGroupBox = new GroupBox();
            housingMaterialPanel = new TableLayoutPanel();
            housingMaterialLabel = new Label();
            housingDensityLabel = new Label();
            housingMaterialTextBox = new TextBox();
            housingDensityTextBox = new MaskedTextBox();
            hoisungOtherParametersGroupBox = new GroupBox();
            housingOtherParametersPanel = new TableLayoutPanel();
            housingNameLabel = new Label();
            housingFolderButton = new Button();
            housingColorButton = new Button();
            housingNameTextBox = new TextBox();
            housingFolderTextBox = new TextBox();
            housingColorBox = new PictureBox();
            housingPicture = new PictureBox();
            housingRefineTabPage = new TabPage();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            blankDiametersGroupBox = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            modifyEdgeGroupBox = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            chamferRadioButton = new RadioButton();
            roundingRadioButton = new RadioButton();
            noneRadioButton = new RadioButton();
            chamferGroupBox = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox3 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            housingTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            housingLeftPanel.SuspendLayout();
            housingSizesGroupBox.SuspendLayout();
            housingSizesPanel.SuspendLayout();
            housingMaterialGroupBox.SuspendLayout();
            housingMaterialPanel.SuspendLayout();
            hoisungOtherParametersGroupBox.SuspendLayout();
            housingOtherParametersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)housingColorBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)housingPicture).BeginInit();
            housingRefineTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            blankDiametersGroupBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            modifyEdgeGroupBox.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            chamferGroupBox.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(housingTabPage);
            tabControl1.Controls.Add(housingRefineTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Calibri", 9F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 453);
            tabControl1.TabIndex = 0;
            // 
            // housingTabPage
            // 
            housingTabPage.Controls.Add(splitContainer1);
            housingTabPage.Location = new Point(4, 27);
            housingTabPage.Name = "housingTabPage";
            housingTabPage.Padding = new Padding(3);
            housingTabPage.Size = new Size(792, 422);
            housingTabPage.TabIndex = 0;
            housingTabPage.Text = "Корпус";
            housingTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.ButtonFace;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(housingLeftPanel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(housingPicture);
            splitContainer1.Size = new Size(786, 416);
            splitContainer1.SplitterDistance = 400;
            splitContainer1.TabIndex = 0;
            // 
            // housingLeftPanel
            // 
            housingLeftPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            housingLeftPanel.ColumnCount = 1;
            housingLeftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            housingLeftPanel.Controls.Add(housingSizesGroupBox, 0, 0);
            housingLeftPanel.Controls.Add(housingMaterialGroupBox, 0, 1);
            housingLeftPanel.Controls.Add(hoisungOtherParametersGroupBox, 0, 2);
            housingLeftPanel.Location = new Point(16, 3);
            housingLeftPanel.Name = "housingLeftPanel";
            housingLeftPanel.RowCount = 3;
            housingLeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 38.70968F));
            housingLeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 26.8817234F));
            housingLeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 34.4086037F));
            housingLeftPanel.Size = new Size(381, 393);
            housingLeftPanel.TabIndex = 0;
            // 
            // housingSizesGroupBox
            // 
            housingSizesGroupBox.Controls.Add(housingSizesPanel);
            housingSizesGroupBox.Dock = DockStyle.Fill;
            housingSizesGroupBox.Location = new Point(3, 3);
            housingSizesGroupBox.Name = "housingSizesGroupBox";
            housingSizesGroupBox.Size = new Size(375, 146);
            housingSizesGroupBox.TabIndex = 0;
            housingSizesGroupBox.TabStop = false;
            housingSizesGroupBox.Text = "Размеры заготовки";
            // 
            // housingSizesPanel
            // 
            housingSizesPanel.ColumnCount = 2;
            housingSizesPanel.ColumnStyles.Add(new ColumnStyle());
            housingSizesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            housingSizesPanel.Controls.Add(housingDiameterLabel, 0, 0);
            housingSizesPanel.Controls.Add(housingHoleLabel, 0, 1);
            housingSizesPanel.Controls.Add(housingHeightLabel, 0, 2);
            housingSizesPanel.Controls.Add(housingDiameterTextBox, 1, 0);
            housingSizesPanel.Controls.Add(housingHoleTextBox, 1, 1);
            housingSizesPanel.Controls.Add(housingHeightTextBox, 1, 2);
            housingSizesPanel.Dock = DockStyle.Fill;
            housingSizesPanel.Location = new Point(3, 22);
            housingSizesPanel.Name = "housingSizesPanel";
            housingSizesPanel.RowCount = 3;
            housingSizesPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            housingSizesPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            housingSizesPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            housingSizesPanel.Size = new Size(369, 121);
            housingSizesPanel.TabIndex = 0;
            // 
            // housingDiameterLabel
            // 
            housingDiameterLabel.AutoSize = true;
            housingDiameterLabel.Location = new Point(3, 0);
            housingDiameterLabel.Name = "housingDiameterLabel";
            housingDiameterLabel.Size = new Size(17, 18);
            housingDiameterLabel.TabIndex = 0;
            housingDiameterLabel.Text = "D";
            // 
            // housingHoleLabel
            // 
            housingHoleLabel.AutoSize = true;
            housingHoleLabel.Location = new Point(3, 40);
            housingHoleLabel.Name = "housingHoleLabel";
            housingHoleLabel.Size = new Size(24, 18);
            housingHoleLabel.TabIndex = 1;
            housingHoleLabel.Text = "D1";
            // 
            // housingHeightLabel
            // 
            housingHeightLabel.AutoSize = true;
            housingHeightLabel.Location = new Point(3, 80);
            housingHeightLabel.Name = "housingHeightLabel";
            housingHeightLabel.Size = new Size(17, 18);
            housingHeightLabel.TabIndex = 2;
            housingHeightLabel.Text = "H";
            // 
            // housingDiameterTextBox
            // 
            housingDiameterTextBox.Dock = DockStyle.Fill;
            housingDiameterTextBox.Location = new Point(35, 3);
            housingDiameterTextBox.Margin = new Padding(5, 3, 30, 3);
            housingDiameterTextBox.Name = "housingDiameterTextBox";
            housingDiameterTextBox.Size = new Size(304, 26);
            housingDiameterTextBox.TabIndex = 3;
            // 
            // housingHoleTextBox
            // 
            housingHoleTextBox.Dock = DockStyle.Fill;
            housingHoleTextBox.Location = new Point(35, 43);
            housingHoleTextBox.Margin = new Padding(5, 3, 30, 3);
            housingHoleTextBox.Name = "housingHoleTextBox";
            housingHoleTextBox.Size = new Size(304, 26);
            housingHoleTextBox.TabIndex = 4;
            // 
            // housingHeightTextBox
            // 
            housingHeightTextBox.Dock = DockStyle.Fill;
            housingHeightTextBox.Location = new Point(35, 83);
            housingHeightTextBox.Margin = new Padding(5, 3, 30, 3);
            housingHeightTextBox.Name = "housingHeightTextBox";
            housingHeightTextBox.Size = new Size(304, 26);
            housingHeightTextBox.TabIndex = 5;
            // 
            // housingMaterialGroupBox
            // 
            housingMaterialGroupBox.Controls.Add(housingMaterialPanel);
            housingMaterialGroupBox.Dock = DockStyle.Fill;
            housingMaterialGroupBox.Location = new Point(3, 155);
            housingMaterialGroupBox.Name = "housingMaterialGroupBox";
            housingMaterialGroupBox.Size = new Size(375, 99);
            housingMaterialGroupBox.TabIndex = 1;
            housingMaterialGroupBox.TabStop = false;
            housingMaterialGroupBox.Text = "Материал заготовки";
            // 
            // housingMaterialPanel
            // 
            housingMaterialPanel.ColumnCount = 2;
            housingMaterialPanel.ColumnStyles.Add(new ColumnStyle());
            housingMaterialPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            housingMaterialPanel.Controls.Add(housingMaterialLabel, 0, 0);
            housingMaterialPanel.Controls.Add(housingDensityLabel, 0, 1);
            housingMaterialPanel.Controls.Add(housingMaterialTextBox, 1, 0);
            housingMaterialPanel.Controls.Add(housingDensityTextBox, 1, 1);
            housingMaterialPanel.Dock = DockStyle.Fill;
            housingMaterialPanel.Location = new Point(3, 22);
            housingMaterialPanel.Name = "housingMaterialPanel";
            housingMaterialPanel.RowCount = 2;
            housingMaterialPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            housingMaterialPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            housingMaterialPanel.Size = new Size(369, 74);
            housingMaterialPanel.TabIndex = 0;
            // 
            // housingMaterialLabel
            // 
            housingMaterialLabel.AutoSize = true;
            housingMaterialLabel.Location = new Point(3, 0);
            housingMaterialLabel.Name = "housingMaterialLabel";
            housingMaterialLabel.Size = new Size(140, 18);
            housingMaterialLabel.TabIndex = 0;
            housingMaterialLabel.Text = "Название материала";
            // 
            // housingDensityLabel
            // 
            housingDensityLabel.AutoSize = true;
            housingDensityLabel.Location = new Point(3, 37);
            housingDensityLabel.Name = "housingDensityLabel";
            housingDensityLabel.Size = new Size(113, 18);
            housingDensityLabel.TabIndex = 1;
            housingDensityLabel.Text = "Плотность, г/см³";
            // 
            // housingMaterialTextBox
            // 
            housingMaterialTextBox.Dock = DockStyle.Fill;
            housingMaterialTextBox.Location = new Point(149, 3);
            housingMaterialTextBox.Margin = new Padding(3, 3, 30, 3);
            housingMaterialTextBox.Name = "housingMaterialTextBox";
            housingMaterialTextBox.Size = new Size(190, 26);
            housingMaterialTextBox.TabIndex = 2;
            // 
            // housingDensityTextBox
            // 
            housingDensityTextBox.Culture = new System.Globalization.CultureInfo("en-US");
            housingDensityTextBox.Dock = DockStyle.Fill;
            housingDensityTextBox.Location = new Point(149, 40);
            housingDensityTextBox.Margin = new Padding(3, 3, 30, 3);
            housingDensityTextBox.Mask = "0.000";
            housingDensityTextBox.Name = "housingDensityTextBox";
            housingDensityTextBox.PromptChar = '0';
            housingDensityTextBox.Size = new Size(190, 26);
            housingDensityTextBox.TabIndex = 3;
            // 
            // hoisungOtherParametersGroupBox
            // 
            hoisungOtherParametersGroupBox.Controls.Add(housingOtherParametersPanel);
            hoisungOtherParametersGroupBox.Dock = DockStyle.Fill;
            hoisungOtherParametersGroupBox.Location = new Point(3, 260);
            hoisungOtherParametersGroupBox.Name = "hoisungOtherParametersGroupBox";
            hoisungOtherParametersGroupBox.Size = new Size(375, 130);
            hoisungOtherParametersGroupBox.TabIndex = 2;
            hoisungOtherParametersGroupBox.TabStop = false;
            hoisungOtherParametersGroupBox.Text = "Прочее";
            // 
            // housingOtherParametersPanel
            // 
            housingOtherParametersPanel.ColumnCount = 2;
            housingOtherParametersPanel.ColumnStyles.Add(new ColumnStyle());
            housingOtherParametersPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            housingOtherParametersPanel.Controls.Add(housingNameLabel, 0, 0);
            housingOtherParametersPanel.Controls.Add(housingFolderButton, 0, 1);
            housingOtherParametersPanel.Controls.Add(housingColorButton, 0, 2);
            housingOtherParametersPanel.Controls.Add(housingNameTextBox, 1, 0);
            housingOtherParametersPanel.Controls.Add(housingFolderTextBox, 1, 1);
            housingOtherParametersPanel.Controls.Add(housingColorBox, 1, 2);
            housingOtherParametersPanel.Dock = DockStyle.Fill;
            housingOtherParametersPanel.Location = new Point(3, 22);
            housingOtherParametersPanel.Name = "housingOtherParametersPanel";
            housingOtherParametersPanel.RowCount = 3;
            housingOtherParametersPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            housingOtherParametersPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            housingOtherParametersPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            housingOtherParametersPanel.Size = new Size(369, 105);
            housingOtherParametersPanel.TabIndex = 0;
            // 
            // housingNameLabel
            // 
            housingNameLabel.AutoSize = true;
            housingNameLabel.Location = new Point(3, 0);
            housingNameLabel.Name = "housingNameLabel";
            housingNameLabel.Size = new Size(121, 18);
            housingNameLabel.TabIndex = 0;
            housingNameLabel.Text = "Название модели";
            // 
            // housingFolderButton
            // 
            housingFolderButton.Location = new Point(3, 37);
            housingFolderButton.Name = "housingFolderButton";
            housingFolderButton.Size = new Size(128, 24);
            housingFolderButton.TabIndex = 1;
            housingFolderButton.Text = "Куда сохранить...";
            housingFolderButton.UseVisualStyleBackColor = true;
            // 
            // housingColorButton
            // 
            housingColorButton.Location = new Point(3, 71);
            housingColorButton.Name = "housingColorButton";
            housingColorButton.Size = new Size(128, 24);
            housingColorButton.TabIndex = 2;
            housingColorButton.Text = "Цвет модели...";
            housingColorButton.UseVisualStyleBackColor = true;
            // 
            // housingNameTextBox
            // 
            housingNameTextBox.Dock = DockStyle.Fill;
            housingNameTextBox.Location = new Point(144, 3);
            housingNameTextBox.Margin = new Padding(10, 3, 30, 3);
            housingNameTextBox.Name = "housingNameTextBox";
            housingNameTextBox.Size = new Size(195, 26);
            housingNameTextBox.TabIndex = 3;
            // 
            // housingFolderTextBox
            // 
            housingFolderTextBox.Dock = DockStyle.Fill;
            housingFolderTextBox.Location = new Point(144, 37);
            housingFolderTextBox.Margin = new Padding(10, 3, 30, 3);
            housingFolderTextBox.Name = "housingFolderTextBox";
            housingFolderTextBox.Size = new Size(195, 26);
            housingFolderTextBox.TabIndex = 4;
            // 
            // housingColorBox
            // 
            housingColorBox.BorderStyle = BorderStyle.FixedSingle;
            housingColorBox.Location = new Point(144, 71);
            housingColorBox.Margin = new Padding(10, 3, 3, 3);
            housingColorBox.MaximumSize = new Size(26, 26);
            housingColorBox.MinimumSize = new Size(26, 26);
            housingColorBox.Name = "housingColorBox";
            housingColorBox.Size = new Size(26, 26);
            housingColorBox.TabIndex = 5;
            housingColorBox.TabStop = false;
            // 
            // housingPicture
            // 
            housingPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            housingPicture.BorderStyle = BorderStyle.FixedSingle;
            housingPicture.Image = Properties.Resources.housingBlank;
            housingPicture.Location = new Point(13, 16);
            housingPicture.Name = "housingPicture";
            housingPicture.Size = new Size(361, 377);
            housingPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            housingPicture.TabIndex = 0;
            housingPicture.TabStop = false;
            // 
            // housingRefineTabPage
            // 
            housingRefineTabPage.Controls.Add(splitContainer2);
            housingRefineTabPage.Location = new Point(4, 27);
            housingRefineTabPage.Margin = new Padding(5);
            housingRefineTabPage.Name = "housingRefineTabPage";
            housingRefineTabPage.Size = new Size(792, 422);
            housingRefineTabPage.TabIndex = 1;
            housingRefineTabPage.Text = "Проработка корпуса";
            housingRefineTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = SystemColors.ButtonFace;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(pictureBox1);
            splitContainer2.Size = new Size(792, 422);
            splitContainer2.SplitterDistance = 460;
            splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(blankDiametersGroupBox, 0, 0);
            tableLayoutPanel1.Controls.Add(modifyEdgeGroupBox, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(300, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.97096F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.4508972F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.5781479F));
            tableLayoutPanel1.Size = new Size(460, 422);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // blankDiametersGroupBox
            // 
            blankDiametersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            blankDiametersGroupBox.Controls.Add(tableLayoutPanel2);
            blankDiametersGroupBox.Location = new Point(20, 10);
            blankDiametersGroupBox.Margin = new Padding(20, 10, 10, 3);
            blankDiametersGroupBox.Name = "blankDiametersGroupBox";
            blankDiametersGroupBox.Size = new Size(430, 100);
            blankDiametersGroupBox.TabIndex = 0;
            blankDiametersGroupBox.TabStop = false;
            blankDiametersGroupBox.Text = "Диаметры заготовки";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 22);
            tableLayoutPanel2.Margin = new Padding(3, 3, 10, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(424, 75);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9F, FontStyle.Italic);
            label1.Location = new Point(10, 0);
            label1.Margin = new Padding(10, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 18);
            label1.TabIndex = 0;
            label1.Text = "Размер D";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Italic);
            label2.Location = new Point(10, 37);
            label2.Margin = new Padding(10, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 18);
            label2.TabIndex = 1;
            label2.Text = "Размер D1";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Calibri", 9F, FontStyle.Italic);
            textBox1.Location = new Point(97, 3);
            textBox1.Margin = new Padding(10, 3, 10, 3);
            textBox1.MinimumSize = new Size(40, 0);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(317, 26);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Calibri", 9F, FontStyle.Italic);
            textBox2.Location = new Point(97, 40);
            textBox2.Margin = new Padding(10, 3, 10, 3);
            textBox2.MinimumSize = new Size(40, 0);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(317, 26);
            textBox2.TabIndex = 3;
            // 
            // modifyEdgeGroupBox
            // 
            modifyEdgeGroupBox.Controls.Add(tableLayoutPanel3);
            modifyEdgeGroupBox.Dock = DockStyle.Fill;
            modifyEdgeGroupBox.Location = new Point(20, 118);
            modifyEdgeGroupBox.Margin = new Padding(20, 5, 10, 3);
            modifyEdgeGroupBox.Name = "modifyEdgeGroupBox";
            modifyEdgeGroupBox.Size = new Size(430, 154);
            modifyEdgeGroupBox.TabIndex = 1;
            modifyEdgeGroupBox.TabStop = false;
            modifyEdgeGroupBox.Text = "Обработка кромок";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel3.Controls.Add(chamferGroupBox, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 22);
            tableLayoutPanel3.Margin = new Padding(3, 0, 3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(424, 129);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Location = new Point(10, 3);
            groupBox2.Margin = new Padding(10, 3, 10, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(192, 116);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вид обработки";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(chamferRadioButton, 0, 0);
            tableLayoutPanel4.Controls.Add(roundingRadioButton, 0, 1);
            tableLayoutPanel4.Controls.Add(noneRadioButton, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 22);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Size = new Size(186, 91);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // chamferRadioButton
            // 
            chamferRadioButton.AutoSize = true;
            chamferRadioButton.Checked = true;
            chamferRadioButton.Location = new Point(10, 3);
            chamferRadioButton.Margin = new Padding(10, 3, 3, 3);
            chamferRadioButton.Name = "chamferRadioButton";
            chamferRadioButton.Size = new Size(66, 22);
            chamferRadioButton.TabIndex = 0;
            chamferRadioButton.TabStop = true;
            chamferRadioButton.Text = "Фаска";
            chamferRadioButton.UseVisualStyleBackColor = true;
            // 
            // roundingRadioButton
            // 
            roundingRadioButton.AutoSize = true;
            roundingRadioButton.Location = new Point(10, 33);
            roundingRadioButton.Margin = new Padding(10, 3, 3, 3);
            roundingRadioButton.Name = "roundingRadioButton";
            roundingRadioButton.Size = new Size(103, 22);
            roundingRadioButton.TabIndex = 1;
            roundingRadioButton.Text = "Скругление";
            roundingRadioButton.UseVisualStyleBackColor = true;
            // 
            // noneRadioButton
            // 
            noneRadioButton.AutoSize = true;
            noneRadioButton.Location = new Point(10, 63);
            noneRadioButton.Margin = new Padding(10, 3, 3, 3);
            noneRadioButton.Name = "noneRadioButton";
            noneRadioButton.Size = new Size(122, 22);
            noneRadioButton.TabIndex = 2;
            noneRadioButton.Text = "Без обработки";
            noneRadioButton.UseVisualStyleBackColor = true;
            // 
            // chamferGroupBox
            // 
            chamferGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chamferGroupBox.Controls.Add(tableLayoutPanel5);
            chamferGroupBox.Location = new Point(215, 3);
            chamferGroupBox.Margin = new Padding(3, 3, 10, 10);
            chamferGroupBox.Name = "chamferGroupBox";
            chamferGroupBox.Size = new Size(199, 116);
            chamferGroupBox.TabIndex = 1;
            chamferGroupBox.TabStop = false;
            chamferGroupBox.Text = "Параметры фаски";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(label4, 0, 1);
            tableLayoutPanel5.Controls.Add(textBox3, 1, 0);
            tableLayoutPanel5.Controls.Add(textBox4, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 22);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(193, 91);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 18);
            label3.TabIndex = 0;
            label3.Text = "Длина";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 45);
            label4.Name = "label4";
            label4.Size = new Size(36, 18);
            label4.TabIndex = 1;
            label4.Text = "Угол";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(58, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 26);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(58, 48);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(132, 26);
            textBox4.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(tableLayoutPanel6);
            groupBox3.Location = new Point(20, 278);
            groupBox3.Margin = new Padding(20, 3, 10, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(430, 129);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Отверстия под винты";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label5, 0, 0);
            tableLayoutPanel6.Controls.Add(label6, 0, 1);
            tableLayoutPanel6.Controls.Add(textBox5, 1, 0);
            tableLayoutPanel6.Controls.Add(textBox6, 1, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 22);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(424, 104);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 18);
            label5.TabIndex = 0;
            label5.Text = "Диаметр";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 52);
            label6.Name = "label6";
            label6.Size = new Size(82, 18);
            label6.TabIndex = 1;
            label6.Text = "Количество";
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Fill;
            textBox5.Location = new Point(98, 3);
            textBox5.Margin = new Padding(10, 3, 10, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(316, 26);
            textBox5.TabIndex = 2;
            // 
            // textBox6
            // 
            textBox6.Dock = DockStyle.Fill;
            textBox6.Location = new Point(98, 55);
            textBox6.Margin = new Padding(10, 3, 10, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(316, 26);
            textBox6.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.chamferEdge;
            pictureBox1.Location = new Point(18, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 382);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Wizard3DForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(530, 500);
            Name = "Wizard3DForm";
            ShowInTaskbar = false;
            Text = "Мастер 3D сборки";
            tabControl1.ResumeLayout(false);
            housingTabPage.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            housingLeftPanel.ResumeLayout(false);
            housingSizesGroupBox.ResumeLayout(false);
            housingSizesPanel.ResumeLayout(false);
            housingSizesPanel.PerformLayout();
            housingMaterialGroupBox.ResumeLayout(false);
            housingMaterialPanel.ResumeLayout(false);
            housingMaterialPanel.PerformLayout();
            hoisungOtherParametersGroupBox.ResumeLayout(false);
            housingOtherParametersPanel.ResumeLayout(false);
            housingOtherParametersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)housingColorBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)housingPicture).EndInit();
            housingRefineTabPage.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            blankDiametersGroupBox.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            modifyEdgeGroupBox.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            chamferGroupBox.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage housingTabPage;
        private SplitContainer splitContainer1;
        private TableLayoutPanel housingLeftPanel;
        private PictureBox housingPicture;
        private GroupBox housingSizesGroupBox;
        private GroupBox housingMaterialGroupBox;
        private GroupBox hoisungOtherParametersGroupBox;
        private TableLayoutPanel housingSizesPanel;
        private Label housingDiameterLabel;
        private Label housingHoleLabel;
        private Label housingHeightLabel;
        private TextBox housingDiameterTextBox;
        private TextBox housingHoleTextBox;
        private TextBox housingHeightTextBox;
        private TableLayoutPanel housingMaterialPanel;
        private Label housingMaterialLabel;
        private Label housingDensityLabel;
        private TextBox housingMaterialTextBox;
        private TableLayoutPanel housingOtherParametersPanel;
        private Label housingNameLabel;
        private Button housingFolderButton;
        private Button housingColorButton;
        private TextBox housingNameTextBox;
        private TextBox housingFolderTextBox;
        private PictureBox housingColorBox;
        private MaskedTextBox housingDensityTextBox;
        private TabPage housingRefineTabPage;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox blankDiametersGroupBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox modifyEdgeGroupBox;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private RadioButton chamferRadioButton;
        private RadioButton roundingRadioButton;
        private RadioButton noneRadioButton;
        private GroupBox chamferGroupBox;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}