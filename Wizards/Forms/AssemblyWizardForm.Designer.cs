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
            pictureBox1 = new PictureBox();
            wizardTabControl.SuspendLayout();
            housingBlandTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)housingBlankSplitContainer).BeginInit();
            housingBlankSplitContainer.Panel2.SuspendLayout();
            housingBlankSplitContainer.SuspendLayout();
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
            // housingBlankSplitContainer.Panel2
            // 
            housingBlankSplitContainer.Panel2.Controls.Add(pictureBox1);
            housingBlankSplitContainer.Size = new Size(780, 410);
            housingBlankSplitContainer.SplitterDistance = 400;
            housingBlankSplitContainer.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.housingBlank;
            pictureBox1.Location = new Point(14, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 383);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            wizardTabControl.ResumeLayout(false);
            housingBlandTab.ResumeLayout(false);
            housingBlankSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)housingBlankSplitContainer).EndInit();
            housingBlankSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl wizardTabControl;
        private TabPage housingBlandTab;
        private SplitContainer housingBlankSplitContainer;
        private PictureBox pictureBox1;
    }
}