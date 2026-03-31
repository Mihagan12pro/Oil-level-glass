namespace Oil_level_glass.UI.Main
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pbMain = new PictureBox();
            btShow3d = new Button();
            btShowAbout = new Button();
            ((System.ComponentModel.ISupportInitialize)pbMain).BeginInit();
            SuspendLayout();
            // 
            // pbMain
            // 
            pbMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbMain.BorderStyle = BorderStyle.FixedSingle;
            pbMain.Image = Properties.Resources.Oil_level_glass;
            pbMain.Location = new Point(12, 12);
            pbMain.Name = "pbMain";
            pbMain.Size = new Size(776, 373);
            pbMain.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMain.TabIndex = 0;
            pbMain.TabStop = false;
            // 
            // btShow3d
            // 
            btShow3d.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btShow3d.Location = new Point(613, 400);
            btShow3d.Name = "btShow3d";
            btShow3d.Size = new Size(175, 29);
            btShow3d.TabIndex = 1;
            btShow3d.Text = "Мастер 3d модели...";
            btShow3d.UseVisualStyleBackColor = true;
            btShow3d.Click += btShow3d_Click;
            // 
            // btShowAbout
            // 
            btShowAbout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btShowAbout.Location = new Point(403, 400);
            btShowAbout.Name = "btShowAbout";
            btShowAbout.Size = new Size(175, 29);
            btShowAbout.TabIndex = 2;
            btShowAbout.Text = "О программе...";
            btShowAbout.UseVisualStyleBackColor = true;
            btShowAbout.Click += btShowAbout_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btShowAbout);
            Controls.Add(btShow3d);
            Controls.Add(pbMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(400, 400);
            Name = "MainForm";
            ShowIcon = false;
            Text = "Мастер смотровых лючков";
            ((System.ComponentModel.ISupportInitialize)pbMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbMain;
        private Button btShow3d;
        private Button btShowAbout;
    }
}