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
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(housingTabPage);
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
    }
}