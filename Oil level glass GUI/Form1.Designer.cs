namespace Oil_level_glass_GUI
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
            pbMain = new PictureBox();
            tlPnlButtonHolder = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbMain).BeginInit();
            tlPnlButtonHolder.SuspendLayout();
            SuspendLayout();
            // 
            // pbMain
            // 
            pbMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pbMain.BorderStyle = BorderStyle.FixedSingle;
            pbMain.Location = new Point(12, 30);
            pbMain.Name = "pbMain";
            pbMain.Size = new Size(603, 389);
            pbMain.TabIndex = 0;
            pbMain.TabStop = false;
            // 
            // tlPnlButtonHolder
            // 
            tlPnlButtonHolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlPnlButtonHolder.ColumnCount = 1;
            tlPnlButtonHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlPnlButtonHolder.Controls.Add(button3, 0, 2);
            tlPnlButtonHolder.Controls.Add(button2, 0, 1);
            tlPnlButtonHolder.Controls.Add(button1, 0, 0);
            tlPnlButtonHolder.Location = new Point(642, 30);
            tlPnlButtonHolder.Name = "tlPnlButtonHolder";
            tlPnlButtonHolder.RowCount = 3;
            tlPnlButtonHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlPnlButtonHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlPnlButtonHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlPnlButtonHolder.Size = new Size(146, 389);
            tlPnlButtonHolder.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(3, 288);
            button3.Name = "button3";
            button3.Size = new Size(140, 98);
            button3.TabIndex = 2;
            button3.Text = "Справка";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(3, 144);
            button2.Name = "button2";
            button2.Size = new Size(140, 98);
            button2.TabIndex = 1;
            button2.Text = "Запуск мастера";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(140, 98);
            button1.TabIndex = 0;
            button1.Text = "О программе";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlPnlButtonHolder);
            Controls.Add(pbMain);
            Name = "MainForm";
            Text = "Oil level glass";
            ((System.ComponentModel.ISupportInitialize)pbMain).EndInit();
            tlPnlButtonHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbMain;
        private TableLayoutPanel tlPnlButtonHolder;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
