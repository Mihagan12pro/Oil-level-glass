namespace Oil_level_glass.UI.Editors.Menus.View
{
    partial class ModelMaterialForm
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
            tvMaterials = new TreeView();
            SuspendLayout();
            // 
            // tvMaterials
            // 
            tvMaterials.Location = new Point(12, 21);
            tvMaterials.Name = "tvMaterials";
            tvMaterials.Size = new Size(1173, 565);
            tvMaterials.TabIndex = 0;
            // 
            // ModelMaterialForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 695);
            Controls.Add(tvMaterials);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModelMaterialForm";
            Text = "ModelMaterialForm";
            Load += ModelMaterialForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView tvMaterials;
    }
}