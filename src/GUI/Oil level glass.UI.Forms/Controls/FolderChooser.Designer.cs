namespace Oil_level_glass.UI.Forms.Controls
{
    partial class FolderChooser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btChoose = new Button();
            tbFolder = new TextBox();
            SuspendLayout();
            // 
            // btChoose
            // 
            btChoose.Location = new Point(3, 26);
            btChoose.Name = "btChoose";
            btChoose.Size = new Size(150, 46);
            btChoose.TabIndex = 0;
            btChoose.Text = "Выбрать...";
            btChoose.UseVisualStyleBackColor = true;
            btChoose.Click += btChoose_Click;
            // 
            // tbFolder
            // 
            tbFolder.Location = new Point(182, 30);
            tbFolder.Name = "tbFolder";
            tbFolder.Size = new Size(423, 39);
            tbFolder.TabIndex = 1;
            tbFolder.TextChanged += tbFolder_TextChanged;
            // 
            // FolderChooser
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbFolder);
            Controls.Add(btChoose);
            Name = "FolderChooser";
            Size = new Size(608, 98);
            Load += FolderChooser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btChoose;
        private TextBox tbFolder;
    }
}
