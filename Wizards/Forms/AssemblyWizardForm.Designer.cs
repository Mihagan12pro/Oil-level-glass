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
            housingBlandTab = new TabPage();
            housingBlankSplitContainer = new SplitContainer();
            housingBlankTablePanel = new TableLayoutPanel();
            housingSizesGroupBox = new GroupBox();
            housingMaterialsGroupBox = new GroupBox();
            otherBlankParametersGroupBox = new GroupBox();
            pictureBox1 = new PictureBox();
            housingColorDialog = new ColorDialog();
            wizardTabControl.SuspendLayout();
            housingBlandTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)housingBlankSplitContainer).BeginInit();
            housingBlankSplitContainer.Panel1.SuspendLayout();
            housingBlankSplitContainer.Panel2.SuspendLayout();
            housingBlankSplitContainer.SuspendLayout();
            housingBlankTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // wizardTabControl
            // 
            wizardTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wizardTabControl.Controls.Add(housingBlandTab);
            wizardTabControl.Location = new Point(4, 3);
            wizardTabControl.Name = "wizardTabControl";
            wizardTabControl.SelectedIndex = 0;
            wizardTabControl.Size = new Size(794, 447);
            wizardTabControl.TabIndex = 0;
            // 
            // housingBlandTab
            // 
            housingBlandTab.Controls.Add(housingBlankSplitContainer);
            housingBlandTab.Location = new Point(4, 27);
            housingBlandTab.Name = "housingBlandTab";
            housingBlandTab.Padding = new Padding(3);
            housingBlandTab.Size = new Size(786, 416);
            housingBlandTab.TabIndex = 0;
            housingBlandTab.Text = "Заготовка корпуса";
            housingBlandTab.UseVisualStyleBackColor = true;
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
            housingBlankSplitContainer.Size = new Size(780, 410);
            housingBlankSplitContainer.SplitterDistance = 400;
            housingBlankSplitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            housingBlankTablePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            housingBlankTablePanel.ColumnCount = 1;
            housingBlankTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            housingBlankTablePanel.Controls.Add(housingSizesGroupBox, 0, 0);
            housingBlankTablePanel.Controls.Add(housingMaterialsGroupBox, 0, 1);
            housingBlankTablePanel.Controls.Add(otherBlankParametersGroupBox, 0, 2);
            housingBlankTablePanel.Location = new Point(16, 13);
            housingBlankTablePanel.Name = "housingBlankTablePanel";
            housingBlankTablePanel.RowCount = 3;
            housingBlankTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            housingBlankTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            housingBlankTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            housingBlankTablePanel.Size = new Size(381, 386);
            housingBlankTablePanel.TabIndex = 0;
            // 
            // housingSizesGroupBox
            // 
            housingSizesGroupBox.Dock = DockStyle.Fill;
            housingSizesGroupBox.Location = new Point(3, 3);
            housingSizesGroupBox.Name = "housingSizesGroupBox";
            housingSizesGroupBox.Size = new Size(375, 122);
            housingSizesGroupBox.TabIndex = 0;
            housingSizesGroupBox.TabStop = false;
            housingSizesGroupBox.Text = "Размеры заготовки корпуса";
            // 
            // housingMaterialsGroupBox
            // 
            housingMaterialsGroupBox.Dock = DockStyle.Fill;
            housingMaterialsGroupBox.Location = new Point(3, 131);
            housingMaterialsGroupBox.Name = "housingMaterialsGroupBox";
            housingMaterialsGroupBox.Size = new Size(375, 122);
            housingMaterialsGroupBox.TabIndex = 1;
            housingMaterialsGroupBox.TabStop = false;
            housingMaterialsGroupBox.Text = "Материал корпуса";
            // 
            // otherBlankParametersGroupBox
            // 
            otherBlankParametersGroupBox.Dock = DockStyle.Fill;
            otherBlankParametersGroupBox.Location = new Point(3, 259);
            otherBlankParametersGroupBox.Name = "otherBlankParametersGroupBox";
            otherBlankParametersGroupBox.Size = new Size(375, 124);
            otherBlankParametersGroupBox.TabIndex = 2;
            otherBlankParametersGroupBox.TabStop = false;
            otherBlankParametersGroupBox.Text = "Прочие параметры";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.housingBlank;
            pictureBox1.Location = new Point(14, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 386);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // housingColorDialog
            // 
            housingColorDialog.AnyColor = true;
            housingColorDialog.FullOpen = true;
            // 
            // AssembleWizardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(wizardTabControl);
            Font = new Font("Calibri", 9F);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 1000);
            MinimizeBox = false;
            MinimumSize = new Size(500, 500);
            Name = "AssembleWizardForm";
            ShowInTaskbar = false;
            Text = "Мастер трёхмерной сборки";
            Load += AssembleWizardForm_Load;
            wizardTabControl.ResumeLayout(false);
            housingBlandTab.ResumeLayout(false);
            housingBlankSplitContainer.Panel1.ResumeLayout(false);
            housingBlankSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)housingBlankSplitContainer).EndInit();
            housingBlankSplitContainer.ResumeLayout(false);
            housingBlankTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl wizardTabControl;
        private TabPage housingBlandTab;
        private SplitContainer housingBlankSplitContainer;
        private PictureBox pictureBox1;
        private ColorDialog housingColorDialog;
        private TableLayoutPanel housingBlankTablePanel;
        private GroupBox housingSizesGroupBox;
        private GroupBox housingMaterialsGroupBox;
        private GroupBox otherBlankParametersGroupBox;
    }
}