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
            housingRefineTab = new TabPage();
            housingRefinePanel = new TableLayoutPanel();
            housingRefinePictureBox = new PictureBox();
            screwHolesPictureBox = new PictureBox();
            chamferPictureBox = new PictureBox();
            refineSizesGroupBox = new GroupBox();
            angleLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            mainDiameterRefineInfo = new TextBox();
            centralDiameterRefineInfo = new TextBox();
            heightRefineInfo = new TextBox();
            screwHolesGroupBox = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            holesDistanceTextBox = new TextBox();
            holesDiameterTextBox = new TextBox();
            holesCountTextBox = new NumericUpDown();
            chamferGroupBox = new GroupBox();
            splitContainer2 = new SplitContainer();
            chamferTyoeGroupBox = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            twoSidesRadioButton = new RadioButton();
            sideAngleChamferRadio = new RadioButton();
            chamferSizesGroupBox = new GroupBox();
            chamferSizesPanel = new TableLayoutPanel();
            side1Label = new Label();
            textBox1 = new TextBox();
            secondChamferSizeLabel = new Label();
            secondChamferSizeTextBox = new TextBox();
            glassTab = new TabPage();
            ringTab = new TabPage();
            assembleTab = new TabPage();
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
            housingRefineTab.SuspendLayout();
            housingRefinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)housingRefinePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)screwHolesPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chamferPictureBox).BeginInit();
            refineSizesGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            screwHolesGroupBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)holesCountTextBox).BeginInit();
            chamferGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            chamferTyoeGroupBox.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            chamferSizesGroupBox.SuspendLayout();
            chamferSizesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // wizard3DTabControl
            // 
            wizard3DTabControl.Controls.Add(housingTabPage);
            wizard3DTabControl.Controls.Add(housingRefineTab);
            wizard3DTabControl.Controls.Add(glassTab);
            wizard3DTabControl.Controls.Add(ringTab);
            wizard3DTabControl.Controls.Add(assembleTab);
            wizard3DTabControl.Dock = DockStyle.Fill;
            wizard3DTabControl.Font = new Font("Calibri", 9F);
            wizard3DTabControl.Location = new Point(0, 0);
            wizard3DTabControl.Name = "wizard3DTabControl";
            wizard3DTabControl.SelectedIndex = 0;
            wizard3DTabControl.Size = new Size(802, 453);
            wizard3DTabControl.TabIndex = 0;
            wizard3DTabControl.Selecting += Wizard3DTabControl_Selecting;
            // 
            // housingTabPage
            // 
            housingTabPage.Controls.Add(splitContainer1);
            housingTabPage.Location = new Point(4, 27);
            housingTabPage.Name = "housingTabPage";
            housingTabPage.Padding = new Padding(3);
            housingTabPage.Size = new Size(794, 422);
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
            splitContainer1.Size = new Size(788, 416);
            splitContainer1.SplitterDistance = 401;
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
            housingLeftPanel.Size = new Size(382, 393);
            housingLeftPanel.TabIndex = 0;
            // 
            // housingSizesGroupBox
            // 
            housingSizesGroupBox.Controls.Add(housingSizesPanel);
            housingSizesGroupBox.Dock = DockStyle.Fill;
            housingSizesGroupBox.Location = new Point(3, 3);
            housingSizesGroupBox.Name = "housingSizesGroupBox";
            housingSizesGroupBox.Size = new Size(376, 146);
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
            housingSizesPanel.Size = new Size(370, 121);
            housingSizesPanel.TabIndex = 0;
            // 
            // housingDiameterLabel
            // 
            housingDiameterLabel.AutoSize = true;
            housingDiameterLabel.Location = new Point(3, 10);
            housingDiameterLabel.Margin = new Padding(3, 10, 3, 0);
            housingDiameterLabel.Name = "housingDiameterLabel";
            housingDiameterLabel.Size = new Size(145, 18);
            housingDiameterLabel.TabIndex = 0;
            housingDiameterLabel.Text = "Диаметр  заготовки D";
            // 
            // housingHoleLabel
            // 
            housingHoleLabel.AutoSize = true;
            housingHoleLabel.Location = new Point(3, 50);
            housingHoleLabel.Margin = new Padding(3, 10, 3, 0);
            housingHoleLabel.Name = "housingHoleLabel";
            housingHoleLabel.Size = new Size(152, 18);
            housingHoleLabel.TabIndex = 1;
            housingHoleLabel.Text = "Диаметр  заготовки D1";
            // 
            // housingHeightLabel
            // 
            housingHeightLabel.AutoSize = true;
            housingHeightLabel.Location = new Point(3, 90);
            housingHeightLabel.Margin = new Padding(3, 10, 3, 0);
            housingHeightLabel.Name = "housingHeightLabel";
            housingHeightLabel.Size = new Size(130, 18);
            housingHeightLabel.TabIndex = 2;
            housingHeightLabel.Text = "Высота заготовки H";
            // 
            // housingDiameterTextBox
            // 
            housingDiameterTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            housingDiameterTextBox.Location = new Point(184, 3);
            housingDiameterTextBox.Margin = new Padding(26, 3, 25, 3);
            housingDiameterTextBox.Name = "housingDiameterTextBox";
            housingDiameterTextBox.Size = new Size(161, 26);
            housingDiameterTextBox.TabIndex = 3;
            // 
            // housingHoleTextBox
            // 
            housingHoleTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            housingHoleTextBox.Location = new Point(184, 43);
            housingHoleTextBox.Margin = new Padding(26, 3, 26, 3);
            housingHoleTextBox.Name = "housingHoleTextBox";
            housingHoleTextBox.Size = new Size(160, 26);
            housingHoleTextBox.TabIndex = 4;
            // 
            // housingHeightTextBox
            // 
            housingHeightTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            housingHeightTextBox.Location = new Point(184, 83);
            housingHeightTextBox.Margin = new Padding(26, 3, 26, 3);
            housingHeightTextBox.Name = "housingHeightTextBox";
            housingHeightTextBox.Size = new Size(160, 26);
            housingHeightTextBox.TabIndex = 5;
            // 
            // housingMaterialGroupBox
            // 
            housingMaterialGroupBox.Controls.Add(housingMaterialPanel);
            housingMaterialGroupBox.Dock = DockStyle.Fill;
            housingMaterialGroupBox.Location = new Point(3, 155);
            housingMaterialGroupBox.Name = "housingMaterialGroupBox";
            housingMaterialGroupBox.Size = new Size(376, 99);
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
            housingMaterialPanel.Size = new Size(370, 74);
            housingMaterialPanel.TabIndex = 0;
            // 
            // housingMaterialLabel
            // 
            housingMaterialLabel.AutoSize = true;
            housingMaterialLabel.Dock = DockStyle.Bottom;
            housingMaterialLabel.Location = new Point(3, 4);
            housingMaterialLabel.Margin = new Padding(3, 0, 3, 15);
            housingMaterialLabel.Name = "housingMaterialLabel";
            housingMaterialLabel.Size = new Size(140, 18);
            housingMaterialLabel.TabIndex = 0;
            housingMaterialLabel.Text = "Название материала";
            // 
            // housingDensityLabel
            // 
            housingDensityLabel.AutoSize = true;
            housingDensityLabel.Location = new Point(3, 42);
            housingDensityLabel.Margin = new Padding(3, 5, 3, 0);
            housingDensityLabel.Name = "housingDensityLabel";
            housingDensityLabel.Size = new Size(113, 18);
            housingDensityLabel.TabIndex = 1;
            housingDensityLabel.Text = "Плотность, г/см³";
            // 
            // housingMaterialTextBox
            // 
            housingMaterialTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            housingMaterialTextBox.Location = new Point(186, 3);
            housingMaterialTextBox.Margin = new Padding(40, 3, 25, 3);
            housingMaterialTextBox.Name = "housingMaterialTextBox";
            housingMaterialTextBox.Size = new Size(159, 26);
            housingMaterialTextBox.TabIndex = 2;
            // 
            // housingDensityTextBox
            // 
            housingDensityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            housingDensityTextBox.Location = new Point(186, 40);
            housingDensityTextBox.Margin = new Padding(40, 3, 25, 3);
            housingDensityTextBox.Name = "housingDensityTextBox";
            housingDensityTextBox.Size = new Size(159, 26);
            housingDensityTextBox.TabIndex = 3;
            // 
            // hoisungOtherParametersGroupBox
            // 
            hoisungOtherParametersGroupBox.Controls.Add(housingOtherParametersPanel);
            hoisungOtherParametersGroupBox.Dock = DockStyle.Fill;
            hoisungOtherParametersGroupBox.Location = new Point(3, 260);
            hoisungOtherParametersGroupBox.Name = "hoisungOtherParametersGroupBox";
            hoisungOtherParametersGroupBox.Size = new Size(376, 130);
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
            housingOtherParametersPanel.Size = new Size(370, 105);
            housingOtherParametersPanel.TabIndex = 0;
            // 
            // housingNameLabel
            // 
            housingNameLabel.AutoSize = true;
            housingNameLabel.Location = new Point(3, 8);
            housingNameLabel.Margin = new Padding(3, 8, 3, 0);
            housingNameLabel.Name = "housingNameLabel";
            housingNameLabel.Size = new Size(140, 18);
            housingNameLabel.TabIndex = 0;
            housingNameLabel.Text = "Название 3D модели";
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
            housingNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            housingNameTextBox.Location = new Point(186, 3);
            housingNameTextBox.Margin = new Padding(40, 3, 25, 3);
            housingNameTextBox.Name = "housingNameTextBox";
            housingNameTextBox.Size = new Size(159, 26);
            housingNameTextBox.TabIndex = 3;
            // 
            // housingFolderTextBox
            // 
            housingFolderTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            housingFolderTextBox.Location = new Point(186, 37);
            housingFolderTextBox.Margin = new Padding(40, 3, 25, 3);
            housingFolderTextBox.Name = "housingFolderTextBox";
            housingFolderTextBox.Size = new Size(159, 26);
            housingFolderTextBox.TabIndex = 4;
            // 
            // housingColorBox
            // 
            housingColorBox.BorderStyle = BorderStyle.FixedSingle;
            housingColorBox.Location = new Point(186, 71);
            housingColorBox.Margin = new Padding(40, 3, 3, 3);
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
            housingPicture.Size = new Size(362, 377);
            housingPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            housingPicture.TabIndex = 0;
            housingPicture.TabStop = false;
            // 
            // housingRefineTab
            // 
            housingRefineTab.Controls.Add(housingRefinePanel);
            housingRefineTab.Location = new Point(4, 27);
            housingRefineTab.Name = "housingRefineTab";
            housingRefineTab.Size = new Size(794, 422);
            housingRefineTab.TabIndex = 2;
            housingRefineTab.Text = "Проработка корпуса";
            housingRefineTab.UseVisualStyleBackColor = true;
            // 
            // housingRefinePanel
            // 
            housingRefinePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            housingRefinePanel.BackColor = SystemColors.ButtonFace;
            housingRefinePanel.ColumnCount = 2;
            housingRefinePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            housingRefinePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            housingRefinePanel.Controls.Add(housingRefinePictureBox, 1, 0);
            housingRefinePanel.Controls.Add(screwHolesPictureBox, 1, 1);
            housingRefinePanel.Controls.Add(chamferPictureBox, 1, 2);
            housingRefinePanel.Controls.Add(refineSizesGroupBox, 0, 0);
            housingRefinePanel.Controls.Add(screwHolesGroupBox, 0, 1);
            housingRefinePanel.Controls.Add(chamferGroupBox, 0, 2);
            housingRefinePanel.Location = new Point(3, 3);
            housingRefinePanel.Name = "housingRefinePanel";
            housingRefinePanel.RowCount = 3;
            housingRefinePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            housingRefinePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            housingRefinePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            housingRefinePanel.Size = new Size(786, 416);
            housingRefinePanel.TabIndex = 0;
            // 
            // housingRefinePictureBox
            // 
            housingRefinePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            housingRefinePictureBox.BorderStyle = BorderStyle.FixedSingle;
            housingRefinePictureBox.Location = new Point(403, 10);
            housingRefinePictureBox.Margin = new Padding(10);
            housingRefinePictureBox.Name = "housingRefinePictureBox";
            housingRefinePictureBox.Size = new Size(373, 118);
            housingRefinePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            housingRefinePictureBox.TabIndex = 0;
            housingRefinePictureBox.TabStop = false;
            // 
            // screwHolesPictureBox
            // 
            screwHolesPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            screwHolesPictureBox.BorderStyle = BorderStyle.FixedSingle;
            screwHolesPictureBox.Location = new Point(403, 148);
            screwHolesPictureBox.Margin = new Padding(10);
            screwHolesPictureBox.Name = "screwHolesPictureBox";
            screwHolesPictureBox.Size = new Size(373, 118);
            screwHolesPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            screwHolesPictureBox.TabIndex = 1;
            screwHolesPictureBox.TabStop = false;
            // 
            // chamferPictureBox
            // 
            chamferPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chamferPictureBox.BorderStyle = BorderStyle.FixedSingle;
            chamferPictureBox.Location = new Point(403, 286);
            chamferPictureBox.Margin = new Padding(10);
            chamferPictureBox.Name = "chamferPictureBox";
            chamferPictureBox.Size = new Size(373, 120);
            chamferPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            chamferPictureBox.TabIndex = 2;
            chamferPictureBox.TabStop = false;
            // 
            // refineSizesGroupBox
            // 
            refineSizesGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            refineSizesGroupBox.Controls.Add(angleLabel);
            refineSizesGroupBox.Controls.Add(tableLayoutPanel1);
            refineSizesGroupBox.Location = new Point(10, 3);
            refineSizesGroupBox.Margin = new Padding(10, 3, 10, 10);
            refineSizesGroupBox.Name = "refineSizesGroupBox";
            refineSizesGroupBox.Size = new Size(373, 125);
            refineSizesGroupBox.TabIndex = 3;
            refineSizesGroupBox.TabStop = false;
            refineSizesGroupBox.Text = "Размеры заготовки";
            // 
            // angleLabel
            // 
            angleLabel.AutoSize = true;
            angleLabel.Location = new Point(249, 0);
            angleLabel.Name = "angleLabel";
            angleLabel.Size = new Size(48, 18);
            angleLabel.TabIndex = 1;
            angleLabel.Text = "Угол α";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(mainDiameterRefineInfo, 1, 0);
            tableLayoutPanel1.Controls.Add(centralDiameterRefineInfo, 1, 1);
            tableLayoutPanel1.Controls.Add(heightRefineInfo, 1, 2);
            tableLayoutPanel1.Font = new Font("Calibri", 9F, FontStyle.Italic);
            tableLayoutPanel1.Location = new Point(3, 22);
            tableLayoutPanel1.Margin = new Padding(3, 0, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 0, 25, 0);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(364, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 5);
            label1.Margin = new Padding(3, 5, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 18);
            label1.TabIndex = 0;
            label1.Text = "Диаметр заготовки D";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 38);
            label2.Margin = new Padding(3, 5, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 18);
            label2.TabIndex = 1;
            label2.Text = "Диаметр заготовки D1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 71);
            label3.Margin = new Padding(3, 5, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 18);
            label3.TabIndex = 2;
            label3.Text = "Высота заготовки H";
            // 
            // mainDiameterRefineInfo
            // 
            mainDiameterRefineInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainDiameterRefineInfo.Location = new Point(184, 3);
            mainDiameterRefineInfo.Margin = new Padding(15, 3, 0, 3);
            mainDiameterRefineInfo.Name = "mainDiameterRefineInfo";
            mainDiameterRefineInfo.ReadOnly = true;
            mainDiameterRefineInfo.Size = new Size(155, 26);
            mainDiameterRefineInfo.TabIndex = 3;
            // 
            // centralDiameterRefineInfo
            // 
            centralDiameterRefineInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            centralDiameterRefineInfo.Location = new Point(184, 36);
            centralDiameterRefineInfo.Margin = new Padding(15, 3, 0, 3);
            centralDiameterRefineInfo.Name = "centralDiameterRefineInfo";
            centralDiameterRefineInfo.ReadOnly = true;
            centralDiameterRefineInfo.Size = new Size(155, 26);
            centralDiameterRefineInfo.TabIndex = 4;
            // 
            // heightRefineInfo
            // 
            heightRefineInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            heightRefineInfo.Location = new Point(184, 69);
            heightRefineInfo.Margin = new Padding(15, 3, 0, 0);
            heightRefineInfo.Name = "heightRefineInfo";
            heightRefineInfo.ReadOnly = true;
            heightRefineInfo.Size = new Size(155, 26);
            heightRefineInfo.TabIndex = 5;
            // 
            // screwHolesGroupBox
            // 
            screwHolesGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            screwHolesGroupBox.Controls.Add(tableLayoutPanel2);
            screwHolesGroupBox.Location = new Point(10, 138);
            screwHolesGroupBox.Margin = new Padding(10, 0, 10, 0);
            screwHolesGroupBox.Name = "screwHolesGroupBox";
            screwHolesGroupBox.Size = new Size(373, 138);
            screwHolesGroupBox.TabIndex = 4;
            screwHolesGroupBox.TabStop = false;
            screwHolesGroupBox.Text = "Отверстия под винты";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(holesDistanceTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(holesDiameterTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(holesCountTextBox, 1, 2);
            tableLayoutPanel2.Location = new Point(6, 25);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(361, 110);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 5);
            label4.Margin = new Padding(3, 5, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(154, 18);
            label4.TabIndex = 0;
            label4.Text = "Диаметр окружности S";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 41);
            label5.Margin = new Padding(3, 5, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(143, 18);
            label5.TabIndex = 1;
            label5.Text = "Диаметр отверстия d";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 77);
            label6.Margin = new Padding(3, 5, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(161, 33);
            label6.TabIndex = 2;
            label6.Text = "Количество отверстий n";
            // 
            // holesDistanceTextBox
            // 
            holesDistanceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            holesDistanceTextBox.Location = new Point(177, 3);
            holesDistanceTextBox.Margin = new Padding(10, 3, 20, 3);
            holesDistanceTextBox.Name = "holesDistanceTextBox";
            holesDistanceTextBox.Size = new Size(164, 26);
            holesDistanceTextBox.TabIndex = 3;
            // 
            // holesDiameterTextBox
            // 
            holesDiameterTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            holesDiameterTextBox.Location = new Point(177, 39);
            holesDiameterTextBox.Margin = new Padding(10, 3, 20, 3);
            holesDiameterTextBox.Name = "holesDiameterTextBox";
            holesDiameterTextBox.Size = new Size(164, 26);
            holesDiameterTextBox.TabIndex = 4;
            // 
            // holesCountTextBox
            // 
            holesCountTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            holesCountTextBox.Location = new Point(177, 75);
            holesCountTextBox.Margin = new Padding(10, 3, 20, 3);
            holesCountTextBox.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            holesCountTextBox.Name = "holesCountTextBox";
            holesCountTextBox.Size = new Size(164, 26);
            holesCountTextBox.TabIndex = 5;
            holesCountTextBox.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // chamferGroupBox
            // 
            chamferGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chamferGroupBox.Controls.Add(splitContainer2);
            chamferGroupBox.Location = new Point(10, 279);
            chamferGroupBox.Margin = new Padding(10, 3, 10, 10);
            chamferGroupBox.Name = "chamferGroupBox";
            chamferGroupBox.Padding = new Padding(3, 0, 3, 3);
            chamferGroupBox.Size = new Size(373, 127);
            chamferGroupBox.TabIndex = 5;
            chamferGroupBox.TabStop = false;
            chamferGroupBox.Text = "Фаска";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 19);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(chamferTyoeGroupBox);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(chamferSizesGroupBox);
            splitContainer2.Size = new Size(367, 105);
            splitContainer2.SplitterDistance = 183;
            splitContainer2.TabIndex = 0;
            // 
            // chamferTyoeGroupBox
            // 
            chamferTyoeGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chamferTyoeGroupBox.Controls.Add(tableLayoutPanel3);
            chamferTyoeGroupBox.Location = new Point(10, 0);
            chamferTyoeGroupBox.Margin = new Padding(10);
            chamferTyoeGroupBox.Name = "chamferTyoeGroupBox";
            chamferTyoeGroupBox.Size = new Size(163, 95);
            chamferTyoeGroupBox.TabIndex = 2;
            chamferTyoeGroupBox.TabStop = false;
            chamferTyoeGroupBox.Text = "Тип";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(twoSidesRadioButton, 0, 1);
            tableLayoutPanel3.Controls.Add(sideAngleChamferRadio, 0, 0);
            tableLayoutPanel3.Location = new Point(6, 20);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(150, 69);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // twoSidesRadioButton
            // 
            twoSidesRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            twoSidesRadioButton.AutoSize = true;
            twoSidesRadioButton.Location = new Point(3, 37);
            twoSidesRadioButton.Name = "twoSidesRadioButton";
            twoSidesRadioButton.Size = new Size(144, 29);
            twoSidesRadioButton.TabIndex = 1;
            twoSidesRadioButton.Text = "Две стороны";
            twoSidesRadioButton.UseVisualStyleBackColor = true;
            // 
            // sideAngleChamferRadio
            // 
            sideAngleChamferRadio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sideAngleChamferRadio.AutoSize = true;
            sideAngleChamferRadio.Location = new Point(3, 3);
            sideAngleChamferRadio.Name = "sideAngleChamferRadio";
            sideAngleChamferRadio.Size = new Size(144, 28);
            sideAngleChamferRadio.TabIndex = 0;
            sideAngleChamferRadio.Text = "Угол и фаска";
            sideAngleChamferRadio.UseVisualStyleBackColor = true;
            // 
            // chamferSizesGroupBox
            // 
            chamferSizesGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chamferSizesGroupBox.Controls.Add(chamferSizesPanel);
            chamferSizesGroupBox.Location = new Point(6, 0);
            chamferSizesGroupBox.Margin = new Padding(10);
            chamferSizesGroupBox.Name = "chamferSizesGroupBox";
            chamferSizesGroupBox.Size = new Size(164, 95);
            chamferSizesGroupBox.TabIndex = 1;
            chamferSizesGroupBox.TabStop = false;
            chamferSizesGroupBox.Text = "Размеры";
            // 
            // chamferSizesPanel
            // 
            chamferSizesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chamferSizesPanel.ColumnCount = 2;
            chamferSizesPanel.ColumnStyles.Add(new ColumnStyle());
            chamferSizesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            chamferSizesPanel.Controls.Add(side1Label, 0, 0);
            chamferSizesPanel.Controls.Add(textBox1, 1, 0);
            chamferSizesPanel.Controls.Add(secondChamferSizeLabel, 0, 1);
            chamferSizesPanel.Controls.Add(secondChamferSizeTextBox, 1, 1);
            chamferSizesPanel.Location = new Point(6, 23);
            chamferSizesPanel.Name = "chamferSizesPanel";
            chamferSizesPanel.RowCount = 2;
            chamferSizesPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            chamferSizesPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            chamferSizesPanel.Size = new Size(152, 66);
            chamferSizesPanel.TabIndex = 0;
            // 
            // side1Label
            // 
            side1Label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            side1Label.AutoSize = true;
            side1Label.Location = new Point(3, 5);
            side1Label.Margin = new Padding(3, 5, 3, 0);
            side1Label.Name = "side1Label";
            side1Label.Size = new Size(80, 28);
            side1Label.TabIndex = 0;
            side1Label.Text = "Длина l1";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(89, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(60, 26);
            textBox1.TabIndex = 1;
            // 
            // secondChamferSizeLabel
            // 
            secondChamferSizeLabel.AutoSize = true;
            secondChamferSizeLabel.Location = new Point(3, 38);
            secondChamferSizeLabel.Margin = new Padding(3, 5, 3, 0);
            secondChamferSizeLabel.Name = "secondChamferSizeLabel";
            secondChamferSizeLabel.Size = new Size(80, 18);
            secondChamferSizeLabel.TabIndex = 2;
            secondChamferSizeLabel.Text = "Hello world";
            // 
            // secondChamferSizeTextBox
            // 
            secondChamferSizeTextBox.Location = new Point(89, 36);
            secondChamferSizeTextBox.Name = "secondChamferSizeTextBox";
            secondChamferSizeTextBox.Size = new Size(60, 26);
            secondChamferSizeTextBox.TabIndex = 3;
            // 
            // glassTab
            // 
            glassTab.Location = new Point(4, 27);
            glassTab.Name = "glassTab";
            glassTab.Size = new Size(794, 422);
            glassTab.TabIndex = 3;
            glassTab.Text = "Линза";
            glassTab.UseVisualStyleBackColor = true;
            // 
            // ringTab
            // 
            ringTab.Location = new Point(4, 27);
            ringTab.Name = "ringTab";
            ringTab.Size = new Size(794, 422);
            ringTab.TabIndex = 4;
            ringTab.Text = "Кольцо";
            ringTab.UseVisualStyleBackColor = true;
            // 
            // assembleTab
            // 
            assembleTab.Location = new Point(4, 27);
            assembleTab.Name = "assembleTab";
            assembleTab.Size = new Size(794, 422);
            assembleTab.TabIndex = 5;
            assembleTab.Text = "Сборка";
            assembleTab.UseVisualStyleBackColor = true;
            // 
            // Wizard3DForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 453);
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
            housingRefineTab.ResumeLayout(false);
            housingRefinePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)housingRefinePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)screwHolesPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)chamferPictureBox).EndInit();
            refineSizesGroupBox.ResumeLayout(false);
            refineSizesGroupBox.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            screwHolesGroupBox.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)holesCountTextBox).EndInit();
            chamferGroupBox.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            chamferTyoeGroupBox.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            chamferSizesGroupBox.ResumeLayout(false);
            chamferSizesPanel.ResumeLayout(false);
            chamferSizesPanel.PerformLayout();
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
        private TextBox housingDensityTextBox;
        private TabPage housingRefineTab;
        private TabPage glassTab;
        private TabPage ringTab;
        private TabPage assembleTab;
        private TableLayoutPanel housingRefinePanel;
        private PictureBox housingRefinePictureBox;
        private PictureBox screwHolesPictureBox;
        private PictureBox chamferPictureBox;
        private GroupBox refineSizesGroupBox;
        private GroupBox screwHolesGroupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox mainDiameterRefineInfo;
        private TextBox centralDiameterRefineInfo;
        private TextBox heightRefineInfo;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox holesDistanceTextBox;
        private TextBox holesDiameterTextBox;
        private NumericUpDown holesCountTextBox;
        private GroupBox chamferGroupBox;
        private SplitContainer splitContainer2;
        private GroupBox chamferSizesGroupBox;
        private GroupBox chamferTyoeGroupBox;
        private RadioButton twoSidesRadioButton;
        private RadioButton sideAngleChamferRadio;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel chamferSizesPanel;
        private Label side1Label;
        private TextBox textBox1;
        private Label secondChamferSizeLabel;
        private Label angleLabel;
        private TextBox secondChamferSizeTextBox;
    }
}