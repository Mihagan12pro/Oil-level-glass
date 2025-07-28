namespace Oil_level_glass.Wizards.Forms
{
    partial class AssembleWizardForm
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
            wizardTabControl = new TabControl();
            MainTab = new TabPage();
            mainTabSplitContainer = new SplitContainer();
            wizardDescriptionBox = new RichTextBox();
            panel1 = new Panel();
            mainTabPicture = new PictureBox();
            BlankTab = new TabPage();
            housingBlankSplitContainer = new SplitContainer();
            housingBlankTablePanel = new TableLayoutPanel();
            housingSizesGroupBox = new GroupBox();
            housingMaterialsGroupBox = new GroupBox();
            otherBlankParametersGroupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            saveFolderBlankTextBox = new TextBox();
            blankColorDialogButton = new Button();
            folderBrowserBlankButton = new Button();
            blankColorBox = new PictureBox();
            fileNameBlankTextBox = new TextBox();
            blankNameLabel = new TextBox();
            pictureBox1 = new PictureBox();
            wizardTabControl.SuspendLayout();
            MainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainTabSplitContainer).BeginInit();
            mainTabSplitContainer.Panel1.SuspendLayout();
            mainTabSplitContainer.Panel2.SuspendLayout();
            mainTabSplitContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainTabPicture).BeginInit();
            BlankTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)housingBlankSplitContainer).BeginInit();
            housingBlankSplitContainer.Panel1.SuspendLayout();
            housingBlankSplitContainer.Panel2.SuspendLayout();
            housingBlankSplitContainer.SuspendLayout();
            housingBlankTablePanel.SuspendLayout();
            otherBlankParametersGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)blankColorBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // wizardTabControl
            // 
            wizardTabControl.Controls.Add(MainTab);
            wizardTabControl.Controls.Add(BlankTab);
            wizardTabControl.Dock = DockStyle.Fill;
            wizardTabControl.Location = new Point(0, 0);
            wizardTabControl.Name = "wizardTabControl";
            wizardTabControl.SelectedIndex = 0;
            wizardTabControl.Size = new Size(800, 553);
            wizardTabControl.TabIndex = 0;
            // 
            // MainTab
            // 
            MainTab.Controls.Add(mainTabSplitContainer);
            MainTab.Location = new Point(4, 27);
            MainTab.Name = "MainTab";
            MainTab.Padding = new Padding(3);
            MainTab.Size = new Size(792, 522);
            MainTab.TabIndex = 1;
            MainTab.Text = "Главная";
            MainTab.UseVisualStyleBackColor = true;
            // 
            // mainTabSplitContainer
            // 
            mainTabSplitContainer.BackColor = SystemColors.ButtonFace;
            mainTabSplitContainer.Dock = DockStyle.Fill;
            mainTabSplitContainer.Location = new Point(3, 3);
            mainTabSplitContainer.Name = "mainTabSplitContainer";
            // 
            // mainTabSplitContainer.Panel1
            // 
            mainTabSplitContainer.Panel1.Controls.Add(wizardDescriptionBox);
            // 
            // mainTabSplitContainer.Panel2
            // 
            mainTabSplitContainer.Panel2.Controls.Add(panel1);
            mainTabSplitContainer.Size = new Size(786, 516);
            mainTabSplitContainer.SplitterDistance = 403;
            mainTabSplitContainer.TabIndex = 0;
            // 
            // wizardDescriptionBox
            // 
            wizardDescriptionBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wizardDescriptionBox.BackColor = SystemColors.ButtonFace;
            wizardDescriptionBox.Location = new Point(15, 15);
            wizardDescriptionBox.Name = "wizardDescriptionBox";
            wizardDescriptionBox.ReadOnly = true;
            wizardDescriptionBox.Size = new Size(369, 482);
            wizardDescriptionBox.TabIndex = 0;
            wizardDescriptionBox.Text = "";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(mainTabPicture);
            panel1.Location = new Point(4, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 408);
            panel1.TabIndex = 0;
            // 
            // mainTabPicture
            // 
            mainTabPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTabPicture.BorderStyle = BorderStyle.FixedSingle;
            mainTabPicture.Image = Properties.Resources.mainFormImage;
            mainTabPicture.Location = new Point(19, 15);
            mainTabPicture.Name = "mainTabPicture";
            mainTabPicture.Size = new Size(335, 376);
            mainTabPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            mainTabPicture.TabIndex = 0;
            mainTabPicture.TabStop = false;
            // 
            // BlankTab
            // 
            BlankTab.Controls.Add(housingBlankSplitContainer);
            BlankTab.Location = new Point(4, 27);
            BlankTab.Name = "BlankTab";
            BlankTab.Padding = new Padding(3);
            BlankTab.Size = new Size(792, 522);
            BlankTab.TabIndex = 0;
            BlankTab.Text = "Заготовка корпуса";
            BlankTab.UseVisualStyleBackColor = true;
            // 
            // housingBlankSplitContainer
            // 
            housingBlankSplitContainer.BackColor = SystemColors.ButtonFace;
            housingBlankSplitContainer.Dock = DockStyle.Fill;
            housingBlankSplitContainer.Location = new Point(3, 3);
            housingBlankSplitContainer.Margin = new Padding(20, 20, 20, 0);
            housingBlankSplitContainer.Name = "housingBlankSplitContainer";
            // 
            // housingBlankSplitContainer.Panel1
            // 
            housingBlankSplitContainer.Panel1.Controls.Add(housingBlankTablePanel);
            housingBlankSplitContainer.Panel1.Margin = new Padding(0, 10, 10, 0);
            // 
            // housingBlankSplitContainer.Panel2
            // 
            housingBlankSplitContainer.Panel2.Controls.Add(pictureBox1);
            housingBlankSplitContainer.Size = new Size(786, 516);
            housingBlankSplitContainer.SplitterDistance = 403;
            housingBlankSplitContainer.TabIndex = 0;
            // 
            // housingBlankTablePanel
            // 
            housingBlankTablePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            housingBlankTablePanel.ColumnCount = 1;
            housingBlankTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            housingBlankTablePanel.Controls.Add(housingSizesGroupBox, 0, 0);
            housingBlankTablePanel.Controls.Add(housingMaterialsGroupBox, 0, 1);
            housingBlankTablePanel.Controls.Add(otherBlankParametersGroupBox, 0, 2);
            housingBlankTablePanel.Location = new Point(16, 0);
            housingBlankTablePanel.Name = "housingBlankTablePanel";
            housingBlankTablePanel.RowCount = 3;
            housingBlankTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            housingBlankTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            housingBlankTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            housingBlankTablePanel.Size = new Size(384, 495);
            housingBlankTablePanel.TabIndex = 0;
            // 
            // housingSizesGroupBox
            // 
            housingSizesGroupBox.Dock = DockStyle.Fill;
            housingSizesGroupBox.Location = new Point(3, 3);
            housingSizesGroupBox.Name = "housingSizesGroupBox";
            housingSizesGroupBox.Size = new Size(378, 159);
            housingSizesGroupBox.TabIndex = 0;
            housingSizesGroupBox.TabStop = false;
            housingSizesGroupBox.Text = "Размеры заготовки корпуса";
            // 
            // housingMaterialsGroupBox
            // 
            housingMaterialsGroupBox.Dock = DockStyle.Fill;
            housingMaterialsGroupBox.Location = new Point(3, 168);
            housingMaterialsGroupBox.Name = "housingMaterialsGroupBox";
            housingMaterialsGroupBox.Size = new Size(378, 159);
            housingMaterialsGroupBox.TabIndex = 1;
            housingMaterialsGroupBox.TabStop = false;
            housingMaterialsGroupBox.Text = "Материал корпуса";
            // 
            // otherBlankParametersGroupBox
            // 
            otherBlankParametersGroupBox.Controls.Add(tableLayoutPanel1);
            otherBlankParametersGroupBox.Dock = DockStyle.Fill;
            otherBlankParametersGroupBox.Location = new Point(3, 333);
            otherBlankParametersGroupBox.Name = "otherBlankParametersGroupBox";
            otherBlankParametersGroupBox.Size = new Size(378, 159);
            otherBlankParametersGroupBox.TabIndex = 2;
            otherBlankParametersGroupBox.TabStop = false;
            otherBlankParametersGroupBox.Text = "Прочие параметры";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(saveFolderBlankTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(blankColorDialogButton, 0, 0);
            tableLayoutPanel1.Controls.Add(folderBrowserBlankButton, 0, 2);
            tableLayoutPanel1.Controls.Add(blankColorBox, 1, 0);
            tableLayoutPanel1.Controls.Add(fileNameBlankTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(blankNameLabel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(372, 134);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // saveFolderBlankTextBox
            // 
            saveFolderBlankTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            saveFolderBlankTextBox.Location = new Point(139, 91);
            saveFolderBlankTextBox.Name = "saveFolderBlankTextBox";
            saveFolderBlankTextBox.PlaceholderText = "C:\\";
            saveFolderBlankTextBox.ReadOnly = true;
            saveFolderBlankTextBox.Size = new Size(230, 26);
            saveFolderBlankTextBox.TabIndex = 3;
            // 
            // blankColorDialogButton
            // 
            blankColorDialogButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            blankColorDialogButton.Location = new Point(3, 3);
            blankColorDialogButton.MaximumSize = new Size(170, 25);
            blankColorDialogButton.Name = "blankColorDialogButton";
            blankColorDialogButton.Size = new Size(130, 25);
            blankColorDialogButton.TabIndex = 1;
            blankColorDialogButton.Text = "Цвет корпуса...";
            blankColorDialogButton.UseVisualStyleBackColor = true;
            // 
            // folderBrowserBlankButton
            // 
            folderBrowserBlankButton.Location = new Point(3, 91);
            folderBrowserBlankButton.Name = "folderBrowserBlankButton";
            folderBrowserBlankButton.Size = new Size(130, 26);
            folderBrowserBlankButton.TabIndex = 2;
            folderBrowserBlankButton.Text = "Куда сохранить...";
            folderBrowserBlankButton.UseVisualStyleBackColor = true;
            // 
            // blankColorBox
            // 
            blankColorBox.Location = new Point(139, 3);
            blankColorBox.Name = "blankColorBox";
            blankColorBox.Size = new Size(28, 25);
            blankColorBox.TabIndex = 0;
            blankColorBox.TabStop = false;
            // 
            // fileNameBlankTextBox
            // 
            fileNameBlankTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fileNameBlankTextBox.Location = new Point(139, 47);
            fileNameBlankTextBox.Name = "fileNameBlankTextBox";
            fileNameBlankTextBox.PlaceholderText = "Корпус";
            fileNameBlankTextBox.Size = new Size(230, 26);
            fileNameBlankTextBox.TabIndex = 5;
            fileNameBlankTextBox.Text = "Корпус";
            // 
            // blankNameLabel
            // 
            blankNameLabel.BorderStyle = BorderStyle.None;
            blankNameLabel.Location = new Point(3, 47);
            blankNameLabel.Name = "blankNameLabel";
            blankNameLabel.ReadOnly = true;
            blankNameLabel.Size = new Size(125, 19);
            blankNameLabel.TabIndex = 0;
            blankNameLabel.Text = "Имя файла модели";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.housingBlank;
            pictureBox1.Location = new Point(14, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 475);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AssembleWizardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(wizardTabControl);
            Font = new Font("Calibri", 9F);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 1000);
            MinimizeBox = false;
            MinimumSize = new Size(600, 500);
            Name = "AssembleWizardForm";
            ShowInTaskbar = false;
            Text = "Мастер трёхмерной сборки";
            Load += AssembleWizardForm_Load;
            wizardTabControl.ResumeLayout(false);
            MainTab.ResumeLayout(false);
            mainTabSplitContainer.Panel1.ResumeLayout(false);
            mainTabSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainTabSplitContainer).EndInit();
            mainTabSplitContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainTabPicture).EndInit();
            BlankTab.ResumeLayout(false);
            housingBlankSplitContainer.Panel1.ResumeLayout(false);
            housingBlankSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)housingBlankSplitContainer).EndInit();
            housingBlankSplitContainer.ResumeLayout(false);
            housingBlankTablePanel.ResumeLayout(false);
            otherBlankParametersGroupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)blankColorBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl wizardTabControl;
        private TabPage BlankTab;
        private SplitContainer housingBlankSplitContainer;
        private PictureBox pictureBox1;
        private TableLayoutPanel housingBlankTablePanel;
        private GroupBox housingSizesGroupBox;
        private GroupBox housingMaterialsGroupBox;
        private GroupBox otherBlankParametersGroupBox;
        private TabPage MainTab;
        private SplitContainer mainTabSplitContainer;
        private Panel panel1;
        private PictureBox mainTabPicture;
        private RichTextBox wizardDescriptionBox;
        private Button blankColorDialogButton;
        private PictureBox blankColorBox;
        private TextBox saveFolderBlankTextBox;
        private Button folderBrowserBlankButton;
        private TextBox fileNameBlankTextBox;
        private TextBox blankNameLabel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}