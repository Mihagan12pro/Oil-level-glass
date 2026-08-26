namespace Oil_level_glass.UI.Forms.Controls
{
    partial class IntegerSlider
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
            trBr = new TrackBar();
            tb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)trBr).BeginInit();
            SuspendLayout();
            // 
            // trBr
            // 
            trBr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trBr.Location = new Point(0, 5);
            trBr.Name = "trBr";
            trBr.Size = new Size(389, 90);
            trBr.TabIndex = 0;
            trBr.TickStyle = TickStyle.Both;
            trBr.Scroll += trBr_Scroll;
            // 
            // tb
            // 
            tb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tb.Location = new Point(413, 15);
            tb.Name = "tb";
            tb.Size = new Size(92, 39);
            tb.TabIndex = 1;
            tb.TextChanged += tb_TextChanged;
            tb.KeyPress += tb_KeyPress;
            // 
            // IntegerSlider
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tb);
            Controls.Add(trBr);
            Name = "IntegerSlider";
            Size = new Size(526, 95);
            ((System.ComponentModel.ISupportInitialize)trBr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trBr;
        private TextBox tb;
    }
}
