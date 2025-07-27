namespace Oil_level_glass
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainFormPictureBox = new PictureBox();
            AssembleWizardButton = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            authorsGitHubLink = new LinkLabel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)mainFormPictureBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // mainFormPictureBox
            // 
            mainFormPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mainFormPictureBox.BackColor = SystemColors.ButtonFace;
            mainFormPictureBox.BorderStyle = BorderStyle.FixedSingle;
            mainFormPictureBox.Image = Properties.Resources.mainFormImage;
            mainFormPictureBox.Location = new Point(11, 21);
            mainFormPictureBox.Name = "mainFormPictureBox";
            mainFormPictureBox.Size = new Size(390, 378);
            mainFormPictureBox.TabIndex = 0;
            mainFormPictureBox.TabStop = false;
            // 
            // AssembleWizardButton
            // 
            AssembleWizardButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AssembleWizardButton.Location = new Point(16, 22);
            AssembleWizardButton.Margin = new Padding(0);
            AssembleWizardButton.Name = "AssembleWizardButton";
            AssembleWizardButton.Size = new Size(173, 55);
            AssembleWizardButton.TabIndex = 1;
            AssembleWizardButton.Text = "Трехмерная сборка";
            AssembleWizardButton.UseVisualStyleBackColor = true;
            AssembleWizardButton.Click += AssembleWizardButton_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button4.Location = new Point(16, 87);
            button4.Name = "button4";
            button4.Size = new Size(173, 55);
            button4.TabIndex = 4;
            button4.Text = "Сборочный чертеж";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Right;
            groupBox1.Controls.Add(AssembleWizardButton);
            groupBox1.Controls.Add(button4);
            groupBox1.Location = new Point(416, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(207, 153);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Мастера проектирования";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(416, 189);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(207, 153);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Справки";
            // 
            // button3
            // 
            button3.Location = new Point(16, 89);
            button3.Name = "button3";
            button3.Size = new Size(173, 55);
            button3.TabIndex = 3;
            button3.Text = "О программе";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(16, 22);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(173, 55);
            button2.TabIndex = 2;
            button2.Text = "Руководство пользователя";
            button2.UseVisualStyleBackColor = true;
            // 
            // authorsGitHubLink
            // 
            authorsGitHubLink.AutoSize = true;
            authorsGitHubLink.LinkVisited = true;
            authorsGitHubLink.Location = new Point(533, 381);
            authorsGitHubLink.Name = "authorsGitHubLink";
            authorsGitHubLink.Size = new Size(96, 18);
            authorsGitHubLink.TabIndex = 7;
            authorsGitHubLink.TabStop = true;
            authorsGitHubLink.Text = "Mihagan12pro";
            authorsGitHubLink.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(416, 381);
            label1.Name = "label1";
            label1.Size = new Size(101, 18);
            label1.TabIndex = 8;
            label1.Text = "GitHub автора:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(635, 420);
            Controls.Add(label1);
            Controls.Add(authorsGitHubLink);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(mainFormPictureBox);
            Font = new Font("Calibri", 9F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Show;
            ((System.ComponentModel.ISupportInitialize)mainFormPictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox mainFormPictureBox;
        private Button AssembleWizardButton;
        private Button button4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private LinkLabel authorsGitHubLink;
        private Label label1;
    }
}
