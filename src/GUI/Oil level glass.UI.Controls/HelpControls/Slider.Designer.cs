namespace Oil_level_glass.UI.Controls.HelpControls
{
    partial class Slider
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
            groupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            trackBar = new TrackBar();
            tbValue = new TextBox();
            groupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.AutoSize = true;
            groupBox.Controls.Add(tableLayoutPanel1);
            groupBox.Dock = DockStyle.Fill;
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(614, 142);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "groupBox1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(trackBar, 0, 0);
            tableLayoutPanel1.Controls.Add(tbValue, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(608, 104);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // trackBar
            // 
            trackBar.Location = new Point(3, 3);
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(509, 90);
            trackBar.TabIndex = 0;
            trackBar.TickStyle = TickStyle.Both;
            trackBar.Scroll += trackBar_Scroll;
            // 
            // tbValue
            // 
            tbValue.Location = new Point(518, 3);
            tbValue.Margin = new Padding(3, 3, 3, 5);
            tbValue.Name = "tbValue";
            tbValue.ReadOnly = true;
            tbValue.Size = new Size(87, 39);
            tbValue.TabIndex = 1;
            // 
            // Slider
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(groupBox);
            Name = "Slider";
            Size = new Size(614, 142);
            groupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox;
        private TableLayoutPanel tableLayoutPanel1;
        internal TextBox tbValue;
        internal TrackBar trackBar;
    }
}
