using System.Globalization;

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
            wizard3DTabControl = new TabControl();
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
            housingDensityTextBox = new TextBox();
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
            refinePanel = new Panel();
            refineTablePanel = new TableLayoutPanel();
            blankDiametersGroupBox = new GroupBox();
            blankDiametersContainer = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            housingDiameterInfoBox = new TextBox();
            housingDiameterInfoLabel = new Label();
            panel2 = new Panel();
            housingHoleDiameterInfoLabel = new Label();
            holeDiameterInfoBox = new TextBox();
            blankDiametersPicture = new PictureBox();
            edgeMidifiersGroupBox = new GroupBox();
            edgeModifiersContainer = new SplitContainer();
            splitContainer2 = new SplitContainer();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            filletRadioButton = new RadioButton();
            noneRadioButton = new RadioButton();
            chamferRadioButton = new RadioButton();
            edgeModifierPicture = new PictureBox();
            screwHolesGroupBox = new GroupBox();
            screwHolesContainer = new SplitContainer();
            splitContainer3 = new SplitContainer();
            screwHolesParametersPanel = new TableLayoutPanel();
            panel3 = new Panel();
            screwHolesDistanceLabel = new Label();
            panel4 = new Panel();
            screwHolesDiameterLabel = new Label();
            panel5 = new Panel();
            holesCountLabel = new Label();
            screwHolesComboBox = new ComboBox();
            screwHolesDiameterTextBox = new TextBox();
            screwHolesDiastanceTextBox = new TextBox();
            holeCountCulculatorLabel = new Label();
            screwHolesPicture = new PictureBox();
            wizard3DTabControl.SuspendLayout();
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
            refinePanel.SuspendLayout();
            refineTablePanel.SuspendLayout();
            blankDiametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)blankDiametersContainer).BeginInit();
            blankDiametersContainer.Panel1.SuspendLayout();
            blankDiametersContainer.Panel2.SuspendLayout();
            blankDiametersContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)blankDiametersPicture).BeginInit();
            edgeMidifiersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edgeModifiersContainer).BeginInit();
            edgeModifiersContainer.Panel1.SuspendLayout();
            edgeModifiersContainer.Panel2.SuspendLayout();
            edgeModifiersContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edgeModifierPicture).BeginInit();
            screwHolesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)screwHolesContainer).BeginInit();
            screwHolesContainer.Panel1.SuspendLayout();
            screwHolesContainer.Panel2.SuspendLayout();
            screwHolesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            screwHolesParametersPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)screwHolesPicture).BeginInit();
            SuspendLayout();
            // 
            // wizard3DTabControl
            // 
            wizard3DTabControl.Controls.Add(housingTabPage);
            wizard3DTabControl.Controls.Add(housingRefineTabPage);
            wizard3DTabControl.Dock = DockStyle.Fill;
            wizard3DTabControl.Font = new Font("Calibri", 9F);
            wizard3DTabControl.Location = new Point(0, 0);
            wizard3DTabControl.Name = "wizard3DTabControl";
            wizard3DTabControl.SelectedIndex = 0;
            wizard3DTabControl.Size = new Size(800, 453);
            wizard3DTabControl.TabIndex = 0;
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
            housingDiameterLabel.Size = new Size(228, 18);
            housingDiameterLabel.TabIndex = 0;
            housingDiameterLabel.Text = "Диаметр всей заготовки корпуса D";
            housingDiameterLabel.Click += housingDiameterLabel_Click;
            // 
            // housingHoleLabel
            // 
            housingHoleLabel.AutoSize = true;
            housingHoleLabel.Location = new Point(3, 40);
            housingHoleLabel.Name = "housingHoleLabel";
            housingHoleLabel.Size = new Size(243, 18);
            housingHoleLabel.TabIndex = 1;
            housingHoleLabel.Text = "Диаметр центрального отверстия D1";
            // 
            // housingHeightLabel
            // 
            housingHeightLabel.AutoSize = true;
            housingHeightLabel.Location = new Point(3, 80);
            housingHeightLabel.Name = "housingHeightLabel";
            housingHeightLabel.Size = new Size(184, 18);
            housingHeightLabel.TabIndex = 2;
            housingHeightLabel.Text = "Высота заготовки корпуса H";
            // 
            // housingDiameterTextBox
            // 
            housingDiameterTextBox.Dock = DockStyle.Fill;
            housingDiameterTextBox.Location = new Point(269, 3);
            housingDiameterTextBox.Margin = new Padding(20, 3, 20, 3);
            housingDiameterTextBox.Name = "housingDiameterTextBox";
            housingDiameterTextBox.Size = new Size(80, 26);
            housingDiameterTextBox.TabIndex = 3;
            // 
            // housingHoleTextBox
            // 
            housingHoleTextBox.Dock = DockStyle.Fill;
            housingHoleTextBox.Location = new Point(269, 43);
            housingHoleTextBox.Margin = new Padding(20, 3, 20, 3);
            housingHoleTextBox.Name = "housingHoleTextBox";
            housingHoleTextBox.Size = new Size(80, 26);
            housingHoleTextBox.TabIndex = 4;
            // 
            // housingHeightTextBox
            // 
            housingHeightTextBox.Dock = DockStyle.Fill;
            housingHeightTextBox.Location = new Point(269, 83);
            housingHeightTextBox.Margin = new Padding(20, 3, 20, 3);
            housingHeightTextBox.Name = "housingHeightTextBox";
            housingHeightTextBox.Size = new Size(80, 26);
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
            housingDensityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            housingDensityTextBox.Location = new Point(149, 40);
            housingDensityTextBox.Name = "housingDensityTextBox";
            housingDensityTextBox.Size = new Size(217, 26);
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
            housingRefineTabPage.Controls.Add(refinePanel);
            housingRefineTabPage.Location = new Point(4, 27);
            housingRefineTabPage.Margin = new Padding(5);
            housingRefineTabPage.Name = "housingRefineTabPage";
            housingRefineTabPage.Size = new Size(792, 422);
            housingRefineTabPage.TabIndex = 1;
            housingRefineTabPage.Text = "Проработка корпуса";
            housingRefineTabPage.UseVisualStyleBackColor = true;
            // 
            // refinePanel
            // 
            refinePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            refinePanel.BackColor = SystemColors.ButtonFace;
            refinePanel.Controls.Add(refineTablePanel);
            refinePanel.Location = new Point(5, 5);
            refinePanel.Margin = new Padding(5, 15, 5, 5);
            refinePanel.Name = "refinePanel";
            refinePanel.Size = new Size(782, 412);
            refinePanel.TabIndex = 0;
            // 
            // refineTablePanel
            // 
            refineTablePanel.ColumnCount = 1;
            refineTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            refineTablePanel.Controls.Add(blankDiametersGroupBox, 0, 0);
            refineTablePanel.Controls.Add(edgeMidifiersGroupBox, 0, 1);
            refineTablePanel.Controls.Add(screwHolesGroupBox, 0, 2);
            refineTablePanel.Dock = DockStyle.Fill;
            refineTablePanel.Location = new Point(0, 0);
            refineTablePanel.Name = "refineTablePanel";
            refineTablePanel.RowCount = 3;
            refineTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 31.25F));
            refineTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            refineTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 31.25F));
            refineTablePanel.Size = new Size(782, 412);
            refineTablePanel.TabIndex = 0;
            // 
            // blankDiametersGroupBox
            // 
            blankDiametersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            blankDiametersGroupBox.Controls.Add(blankDiametersContainer);
            blankDiametersGroupBox.Location = new Point(10, 3);
            blankDiametersGroupBox.Margin = new Padding(10, 3, 10, 3);
            blankDiametersGroupBox.Name = "blankDiametersGroupBox";
            blankDiametersGroupBox.Size = new Size(762, 122);
            blankDiametersGroupBox.TabIndex = 0;
            blankDiametersGroupBox.TabStop = false;
            blankDiametersGroupBox.Text = "Диаметры заготовки";
            // 
            // blankDiametersContainer
            // 
            blankDiametersContainer.Dock = DockStyle.Fill;
            blankDiametersContainer.Location = new Point(3, 22);
            blankDiametersContainer.Name = "blankDiametersContainer";
            // 
            // blankDiametersContainer.Panel1
            // 
            blankDiametersContainer.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // blankDiametersContainer.Panel2
            // 
            blankDiametersContainer.Panel2.Controls.Add(blankDiametersPicture);
            blankDiametersContainer.Size = new Size(756, 97);
            blankDiametersContainer.SplitterDistance = 504;
            blankDiametersContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(504, 97);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(housingDiameterInfoBox);
            panel1.Controls.Add(housingDiameterInfoLabel);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 42);
            panel1.TabIndex = 0;
            // 
            // housingDiameterInfoBox
            // 
            housingDiameterInfoBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            housingDiameterInfoBox.Location = new Point(289, 12);
            housingDiameterInfoBox.Name = "housingDiameterInfoBox";
            housingDiameterInfoBox.ReadOnly = true;
            housingDiameterInfoBox.Size = new Size(182, 26);
            housingDiameterInfoBox.TabIndex = 1;
            // 
            // housingDiameterInfoLabel
            // 
            housingDiameterInfoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            housingDiameterInfoLabel.AutoSize = true;
            housingDiameterInfoLabel.Font = new Font("Calibri", 9F, FontStyle.Italic);
            housingDiameterInfoLabel.Location = new Point(3, 15);
            housingDiameterInfoLabel.Name = "housingDiameterInfoLabel";
            housingDiameterInfoLabel.Size = new Size(242, 18);
            housingDiameterInfoLabel.TabIndex = 0;
            housingDiameterInfoLabel.Text = "Диаметр всей заготовки корпуса D";
            // 
            // panel2
            // 
            panel2.Controls.Add(housingHoleDiameterInfoLabel);
            panel2.Controls.Add(holeDiameterInfoBox);
            panel2.Location = new Point(3, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 43);
            panel2.TabIndex = 1;
            // 
            // housingHoleDiameterInfoLabel
            // 
            housingHoleDiameterInfoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            housingHoleDiameterInfoLabel.AutoSize = true;
            housingHoleDiameterInfoLabel.Font = new Font("Calibri", 9F, FontStyle.Italic);
            housingHoleDiameterInfoLabel.Location = new Point(5, 15);
            housingHoleDiameterInfoLabel.Name = "housingHoleDiameterInfoLabel";
            housingHoleDiameterInfoLabel.Size = new Size(267, 18);
            housingHoleDiameterInfoLabel.TabIndex = 1;
            housingHoleDiameterInfoLabel.Text = "Диаметр центрального отверстия D1";
            // 
            // holeDiameterInfoBox
            // 
            holeDiameterInfoBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            holeDiameterInfoBox.Location = new Point(289, 14);
            holeDiameterInfoBox.Name = "holeDiameterInfoBox";
            holeDiameterInfoBox.ReadOnly = true;
            holeDiameterInfoBox.Size = new Size(182, 26);
            holeDiameterInfoBox.TabIndex = 0;
            // 
            // blankDiametersPicture
            // 
            blankDiametersPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            blankDiametersPicture.BorderStyle = BorderStyle.FixedSingle;
            blankDiametersPicture.Location = new Point(10, 10);
            blankDiametersPicture.Margin = new Padding(10);
            blankDiametersPicture.Name = "blankDiametersPicture";
            blankDiametersPicture.Size = new Size(228, 76);
            blankDiametersPicture.TabIndex = 0;
            blankDiametersPicture.TabStop = false;
            // 
            // edgeMidifiersGroupBox
            // 
            edgeMidifiersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            edgeMidifiersGroupBox.Controls.Add(edgeModifiersContainer);
            edgeMidifiersGroupBox.Location = new Point(10, 131);
            edgeMidifiersGroupBox.Margin = new Padding(10, 3, 10, 3);
            edgeMidifiersGroupBox.Name = "edgeMidifiersGroupBox";
            edgeMidifiersGroupBox.Size = new Size(762, 148);
            edgeMidifiersGroupBox.TabIndex = 1;
            edgeMidifiersGroupBox.TabStop = false;
            edgeMidifiersGroupBox.Text = "Обработка кромок";
            // 
            // edgeModifiersContainer
            // 
            edgeModifiersContainer.Dock = DockStyle.Fill;
            edgeModifiersContainer.Location = new Point(3, 22);
            edgeModifiersContainer.Name = "edgeModifiersContainer";
            // 
            // edgeModifiersContainer.Panel1
            // 
            edgeModifiersContainer.Panel1.Controls.Add(splitContainer2);
            // 
            // edgeModifiersContainer.Panel2
            // 
            edgeModifiersContainer.Panel2.Controls.Add(edgeModifierPicture);
            edgeModifiersContainer.Size = new Size(756, 123);
            edgeModifiersContainer.SplitterDistance = 504;
            edgeModifiersContainer.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox1);
            splitContainer2.Size = new Size(504, 123);
            splitContainer2.SplitterDistance = 252;
            splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Location = new Point(8, 0);
            groupBox1.Margin = new Padding(3, 3, 10, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 109);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вид обработки";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(filletRadioButton, 0, 1);
            tableLayoutPanel2.Controls.Add(noneRadioButton, 0, 2);
            tableLayoutPanel2.Controls.Add(chamferRadioButton, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(228, 84);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // filletRadioButton
            // 
            filletRadioButton.AutoSize = true;
            filletRadioButton.Location = new Point(10, 31);
            filletRadioButton.Margin = new Padding(10, 3, 3, 3);
            filletRadioButton.Name = "filletRadioButton";
            filletRadioButton.Size = new Size(103, 22);
            filletRadioButton.TabIndex = 1;
            filletRadioButton.TabStop = true;
            filletRadioButton.Text = "Скругление";
            filletRadioButton.UseVisualStyleBackColor = true;
            // 
            // noneRadioButton
            // 
            noneRadioButton.AutoSize = true;
            noneRadioButton.Location = new Point(10, 59);
            noneRadioButton.Margin = new Padding(10, 3, 3, 3);
            noneRadioButton.Name = "noneRadioButton";
            noneRadioButton.Size = new Size(122, 22);
            noneRadioButton.TabIndex = 2;
            noneRadioButton.TabStop = true;
            noneRadioButton.Text = "Без обработки";
            noneRadioButton.UseVisualStyleBackColor = true;
            // 
            // chamferRadioButton
            // 
            chamferRadioButton.AutoSize = true;
            chamferRadioButton.Location = new Point(10, 3);
            chamferRadioButton.Margin = new Padding(10, 3, 3, 3);
            chamferRadioButton.Name = "chamferRadioButton";
            chamferRadioButton.Size = new Size(66, 22);
            chamferRadioButton.TabIndex = 0;
            chamferRadioButton.TabStop = true;
            chamferRadioButton.Text = "Фаска";
            chamferRadioButton.UseVisualStyleBackColor = true;
            // 
            // edgeModifierPicture
            // 
            edgeModifierPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            edgeModifierPicture.BorderStyle = BorderStyle.FixedSingle;
            edgeModifierPicture.Location = new Point(10, 22);
            edgeModifierPicture.Margin = new Padding(10);
            edgeModifierPicture.Name = "edgeModifierPicture";
            edgeModifierPicture.Size = new Size(228, 75);
            edgeModifierPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            edgeModifierPicture.TabIndex = 0;
            edgeModifierPicture.TabStop = false;
            // 
            // screwHolesGroupBox
            // 
            screwHolesGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            screwHolesGroupBox.Controls.Add(screwHolesContainer);
            screwHolesGroupBox.Location = new Point(10, 285);
            screwHolesGroupBox.Margin = new Padding(10, 3, 10, 3);
            screwHolesGroupBox.Name = "screwHolesGroupBox";
            screwHolesGroupBox.Size = new Size(762, 124);
            screwHolesGroupBox.TabIndex = 2;
            screwHolesGroupBox.TabStop = false;
            screwHolesGroupBox.Text = "Отверстия под винты";
            // 
            // screwHolesContainer
            // 
            screwHolesContainer.Dock = DockStyle.Fill;
            screwHolesContainer.Location = new Point(3, 22);
            screwHolesContainer.Name = "screwHolesContainer";
            // 
            // screwHolesContainer.Panel1
            // 
            screwHolesContainer.Panel1.Controls.Add(splitContainer3);
            // 
            // screwHolesContainer.Panel2
            // 
            screwHolesContainer.Panel2.Controls.Add(screwHolesPicture);
            screwHolesContainer.Size = new Size(756, 99);
            screwHolesContainer.SplitterDistance = 504;
            screwHolesContainer.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(screwHolesParametersPanel);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(holeCountCulculatorLabel);
            splitContainer3.Size = new Size(504, 99);
            splitContainer3.SplitterDistance = 370;
            splitContainer3.TabIndex = 0;
            // 
            // screwHolesParametersPanel
            // 
            screwHolesParametersPanel.ColumnCount = 2;
            screwHolesParametersPanel.ColumnStyles.Add(new ColumnStyle());
            screwHolesParametersPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            screwHolesParametersPanel.Controls.Add(panel3, 0, 0);
            screwHolesParametersPanel.Controls.Add(panel4, 0, 1);
            screwHolesParametersPanel.Controls.Add(panel5, 0, 2);
            screwHolesParametersPanel.Controls.Add(screwHolesComboBox, 1, 2);
            screwHolesParametersPanel.Controls.Add(screwHolesDiameterTextBox, 1, 1);
            screwHolesParametersPanel.Controls.Add(screwHolesDiastanceTextBox, 1, 0);
            screwHolesParametersPanel.Dock = DockStyle.Fill;
            screwHolesParametersPanel.Location = new Point(0, 0);
            screwHolesParametersPanel.Name = "screwHolesParametersPanel";
            screwHolesParametersPanel.RowCount = 3;
            screwHolesParametersPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            screwHolesParametersPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            screwHolesParametersPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            screwHolesParametersPanel.Size = new Size(370, 99);
            screwHolesParametersPanel.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(screwHolesDistanceLabel);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 25);
            panel3.TabIndex = 0;
            // 
            // screwHolesDistanceLabel
            // 
            screwHolesDistanceLabel.AutoSize = true;
            screwHolesDistanceLabel.Location = new Point(0, 7);
            screwHolesDistanceLabel.Name = "screwHolesDistanceLabel";
            screwHolesDistanceLabel.Size = new Size(221, 18);
            screwHolesDistanceLabel.TabIndex = 0;
            screwHolesDistanceLabel.Text = "Расстояние между отверстиями S";
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(screwHolesDiameterLabel);
            panel4.Location = new Point(3, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(146, 26);
            panel4.TabIndex = 1;
            // 
            // screwHolesDiameterLabel
            // 
            screwHolesDiameterLabel.AutoSize = true;
            screwHolesDiameterLabel.Location = new Point(0, 8);
            screwHolesDiameterLabel.Name = "screwHolesDiameterLabel";
            screwHolesDiameterLabel.Size = new Size(143, 18);
            screwHolesDiameterLabel.TabIndex = 0;
            screwHolesDiameterLabel.Text = "Диаметр отверстия d";
            // 
            // panel5
            // 
            panel5.Controls.Add(holesCountLabel);
            panel5.Location = new Point(3, 67);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 29);
            panel5.TabIndex = 2;
            // 
            // holesCountLabel
            // 
            holesCountLabel.AutoSize = true;
            holesCountLabel.Location = new Point(3, 11);
            holesCountLabel.Name = "holesCountLabel";
            holesCountLabel.Size = new Size(125, 18);
            holesCountLabel.TabIndex = 0;
            holesCountLabel.Text = "Число отверстий n";
            // 
            // screwHolesComboBox
            // 
            screwHolesComboBox.Location = new Point(259, 67);
            screwHolesComboBox.Margin = new Padding(3, 3, 10, 3);
            screwHolesComboBox.Name = "screwHolesComboBox";
            screwHolesComboBox.Size = new Size(101, 26);
            screwHolesComboBox.TabIndex = 0;
            // 
            // screwHolesDiameterTextBox
            // 
            screwHolesDiameterTextBox.Location = new Point(259, 35);
            screwHolesDiameterTextBox.Margin = new Padding(3, 3, 10, 3);
            screwHolesDiameterTextBox.Name = "screwHolesDiameterTextBox";
            screwHolesDiameterTextBox.Size = new Size(101, 26);
            screwHolesDiameterTextBox.TabIndex = 3;
            // 
            // screwHolesDiastanceTextBox
            // 
            screwHolesDiastanceTextBox.Location = new Point(259, 3);
            screwHolesDiastanceTextBox.Margin = new Padding(3, 3, 10, 3);
            screwHolesDiastanceTextBox.Name = "screwHolesDiastanceTextBox";
            screwHolesDiastanceTextBox.Size = new Size(101, 26);
            screwHolesDiastanceTextBox.TabIndex = 4;
            // 
            // holeCountCulculatorLabel
            // 
            holeCountCulculatorLabel.AutoSize = true;
            holeCountCulculatorLabel.Location = new Point(11, 10);
            holeCountCulculatorLabel.Name = "holeCountCulculatorLabel";
            holeCountCulculatorLabel.Size = new Size(46, 18);
            holeCountCulculatorLabel.TabIndex = 0;
            holeCountCulculatorLabel.Text = "label6";
            // 
            // screwHolesPicture
            // 
            screwHolesPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            screwHolesPicture.BorderStyle = BorderStyle.FixedSingle;
            screwHolesPicture.Location = new Point(10, 10);
            screwHolesPicture.Margin = new Padding(10);
            screwHolesPicture.Name = "screwHolesPicture";
            screwHolesPicture.Size = new Size(228, 76);
            screwHolesPicture.TabIndex = 0;
            screwHolesPicture.TabStop = false;
            // 
            // Wizard3DForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(wizard3DTabControl);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(530, 500);
            Name = "Wizard3DForm";
            ShowInTaskbar = false;
            Text = "Мастер 3D сборки";
            wizard3DTabControl.ResumeLayout(false);
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
            refinePanel.ResumeLayout(false);
            refineTablePanel.ResumeLayout(false);
            blankDiametersGroupBox.ResumeLayout(false);
            blankDiametersContainer.Panel1.ResumeLayout(false);
            blankDiametersContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)blankDiametersContainer).EndInit();
            blankDiametersContainer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)blankDiametersPicture).EndInit();
            edgeMidifiersGroupBox.ResumeLayout(false);
            edgeModifiersContainer.Panel1.ResumeLayout(false);
            edgeModifiersContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)edgeModifiersContainer).EndInit();
            edgeModifiersContainer.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)edgeModifierPicture).EndInit();
            screwHolesGroupBox.ResumeLayout(false);
            screwHolesContainer.Panel1.ResumeLayout(false);
            screwHolesContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)screwHolesContainer).EndInit();
            screwHolesContainer.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            screwHolesParametersPanel.ResumeLayout(false);
            screwHolesParametersPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)screwHolesPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl wizard3DTabControl;
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
        private TabPage housingRefineTabPage;
        private Panel refinePanel;
        private TableLayoutPanel refineTablePanel;
        private GroupBox blankDiametersGroupBox;
        private GroupBox edgeMidifiersGroupBox;
        private GroupBox screwHolesGroupBox;
        private SplitContainer blankDiametersContainer;
        private SplitContainer edgeModifiersContainer;
        private PictureBox edgeModifierPicture;
        private SplitContainer screwHolesContainer;
        private PictureBox blankDiametersPicture;
        private PictureBox screwHolesPicture;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox housingDiameterInfoBox;
        private Label housingDiameterInfoLabel;
        private Panel panel2;
        private Label housingHoleDiameterInfoLabel;
        private TextBox holeDiameterInfoBox;
        private SplitContainer splitContainer2;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton chamferRadioButton;
        private RadioButton filletRadioButton;
        private RadioButton noneRadioButton;
        private SplitContainer splitContainer3;
        private TableLayoutPanel screwHolesParametersPanel;
        private Panel panel3;
        private Label screwHolesDistanceLabel;
        private Panel panel4;
        private Label screwHolesDiameterLabel;
        private TextBox screwHolesDiameterTextBox;
        private TextBox screwHolesDiastanceTextBox;
        private ComboBox screwHolesComboBox;
        private Label holeCountCulculatorLabel;
        private Panel panel5;
        private Label holesCountLabel;
        private TextBox housingDensityTextBox;
    }
}