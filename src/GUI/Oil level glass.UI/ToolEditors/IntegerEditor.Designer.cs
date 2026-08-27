namespace Oil_level_glass.UI.Forms.ToolEditors
{
    partial class IntegerEditor
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
            slr = new Oil_level_glass.UI.Forms.Controls.IntegerSlider();
            tableLayoutPanel1 = new TableLayoutPanel();
            btOk = new Button();
            btCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // slr
            // 
            slr.Location = new Point(12, 28);
            slr.Max = 10;
            slr.Min = 0;
            slr.Name = "slr";
            slr.Size = new Size(737, 101);
            slr.TabIndex = 0;
            slr.Value = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btOk, 1, 0);
            tableLayoutPanel1.Controls.Add(btCancel, 0, 0);
            tableLayoutPanel1.Location = new Point(395, 162);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(344, 57);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btOk
            // 
            btOk.Dock = DockStyle.Right;
            btOk.Location = new Point(191, 3);
            btOk.Name = "btOk";
            btOk.Size = new Size(150, 51);
            btOk.TabIndex = 0;
            btOk.Text = "Ок";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += btOk_Click;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(3, 3);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(150, 46);
            btCancel.TabIndex = 1;
            btCancel.Text = "Отмена";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // IntegerEditor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 231);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(slr);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IntegerEditor";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Controls.IntegerSlider slr;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btOk;
        private Button btCancel;
    }
}