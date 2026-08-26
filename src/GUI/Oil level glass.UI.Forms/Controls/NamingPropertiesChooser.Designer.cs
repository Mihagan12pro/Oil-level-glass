namespace Oil_level_glass.UI.Forms.Controls
{
    partial class NamingPropertiesChooser
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            tbNaming = new TextBox();
            tbMarking = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 0;
            label1.Text = "Наименование";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 96);
            label2.Name = "label2";
            label2.Size = new Size(165, 32);
            label2.TabIndex = 1;
            label2.Text = "Обозначение";
            // 
            // tbNaming
            // 
            tbNaming.Location = new Point(229, 34);
            tbNaming.Name = "tbNaming";
            tbNaming.Size = new Size(284, 39);
            tbNaming.TabIndex = 2;
            // 
            // tbMarking
            // 
            tbMarking.Location = new Point(229, 96);
            tbMarking.Name = "tbMarking";
            tbMarking.Size = new Size(284, 39);
            tbMarking.TabIndex = 3;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // NamingEditor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbMarking);
            Controls.Add(tbNaming);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NamingEditor";
            Size = new Size(553, 150);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbNaming;
        private TextBox tbMarking;
        private ErrorProvider errorProvider;
    }
}
