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
            groupBox1 = new GroupBox();
            label1 = new Label();
            tbFolder = new TextBox();
            btChoose = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbFolder);
            groupBox1.Controls.Add(btChoose);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(636, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Папка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 40);
            label1.Name = "label1";
            label1.Size = new Size(366, 32);
            label1.TabIndex = 5;
            label1.Text = "Папка для сохранения моделей";
            // 
            // tbFolder
            // 
            tbFolder.Location = new Point(24, 120);
            tbFolder.Name = "tbFolder";
            tbFolder.Size = new Size(545, 39);
            tbFolder.TabIndex = 4;
            // 
            // btChoose
            // 
            btChoose.Location = new Point(419, 33);
            btChoose.Name = "btChoose";
            btChoose.Size = new Size(150, 46);
            btChoose.TabIndex = 3;
            btChoose.Text = "Выбрать...";
            btChoose.UseVisualStyleBackColor = true;
            // 
            // FolderChooser
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "FolderChooser";
            Size = new Size(642, 213);
            Load += FolderChooser_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbFolder;
        private Button btChoose;
    }
}
