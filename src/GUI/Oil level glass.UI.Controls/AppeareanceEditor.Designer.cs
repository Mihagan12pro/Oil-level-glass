namespace Oil_level_glass.UI.Controls
{
    partial class AppeareanceEditor
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
            tableLayoutPanel2 = new TableLayoutPanel();
            btSelectColor = new Button();
            pnlColor = new Panel();
            slrTransparency = new Oil_level_glass.UI.Controls.HelpControls.Slider();
            slrEmbient = new Oil_level_glass.UI.Controls.HelpControls.Slider();
            slrDiffusion = new Oil_level_glass.UI.Controls.HelpControls.Slider();
            slrSpecularity = new Oil_level_glass.UI.Controls.HelpControls.Slider();
            slrShininess = new Oil_level_glass.UI.Controls.HelpControls.Slider();
            slrEmission = new Oil_level_glass.UI.Controls.HelpControls.Slider();
            groupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(tableLayoutPanel1);
            groupBox.Dock = DockStyle.Fill;
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(540, 723);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "groupBox";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 6);
            tableLayoutPanel1.Controls.Add(slrTransparency, 0, 0);
            tableLayoutPanel1.Controls.Add(slrEmbient, 0, 1);
            tableLayoutPanel1.Controls.Add(slrDiffusion, 0, 2);
            tableLayoutPanel1.Controls.Add(slrSpecularity, 0, 3);
            tableLayoutPanel1.Controls.Add(slrShininess, 0, 4);
            tableLayoutPanel1.Controls.Add(slrEmission, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(534, 685);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btSelectColor, 0, 0);
            tableLayoutPanel2.Controls.Add(pnlColor, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 585);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(528, 97);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // btSelectColor
            // 
            btSelectColor.Location = new Point(20, 20);
            btSelectColor.Margin = new Padding(20, 20, 0, 20);
            btSelectColor.Name = "btSelectColor";
            btSelectColor.Size = new Size(150, 46);
            btSelectColor.TabIndex = 0;
            btSelectColor.Text = "Цвет...";
            btSelectColor.UseVisualStyleBackColor = true;
            btSelectColor.Click += btSelectColor_Click;
            // 
            // pnlColor
            // 
            pnlColor.BorderStyle = BorderStyle.FixedSingle;
            pnlColor.Location = new Point(190, 20);
            pnlColor.Margin = new Padding(20);
            pnlColor.Name = "pnlColor";
            pnlColor.Size = new Size(318, 46);
            pnlColor.TabIndex = 1;
            // 
            // slrTransparency
            // 
            slrTransparency.AutoSize = true;
            slrTransparency.Dock = DockStyle.Fill;
            slrTransparency.Header = "Прозрачность";
            slrTransparency.Location = new Point(20, 3);
            slrTransparency.Margin = new Padding(20, 3, 20, 3);
            slrTransparency.Max = 100;
            slrTransparency.Min = 0;
            slrTransparency.Name = "slrTransparency";
            slrTransparency.Size = new Size(494, 91);
            slrTransparency.TabIndex = 7;
            slrTransparency.Value = 0;
            // 
            // slrEmbient
            // 
            slrEmbient.AutoSize = true;
            slrEmbient.Dock = DockStyle.Fill;
            slrEmbient.Header = "Общий цвет";
            slrEmbient.Location = new Point(20, 100);
            slrEmbient.Margin = new Padding(20, 3, 20, 3);
            slrEmbient.Max = 100;
            slrEmbient.Min = 0;
            slrEmbient.Name = "slrEmbient";
            slrEmbient.Size = new Size(494, 91);
            slrEmbient.TabIndex = 8;
            slrEmbient.Value = 0;
            // 
            // slrDiffusion
            // 
            slrDiffusion.AutoSize = true;
            slrDiffusion.Dock = DockStyle.Fill;
            slrDiffusion.Header = "Диффузия";
            slrDiffusion.Location = new Point(20, 197);
            slrDiffusion.Margin = new Padding(20, 3, 20, 3);
            slrDiffusion.Max = 100;
            slrDiffusion.Min = 0;
            slrDiffusion.Name = "slrDiffusion";
            slrDiffusion.Size = new Size(494, 91);
            slrDiffusion.TabIndex = 9;
            slrDiffusion.Value = 0;
            // 
            // slrSpecularity
            // 
            slrSpecularity.AutoSize = true;
            slrSpecularity.Dock = DockStyle.Fill;
            slrSpecularity.Header = "Зеркальность";
            slrSpecularity.Location = new Point(20, 294);
            slrSpecularity.Margin = new Padding(20, 3, 20, 3);
            slrSpecularity.Max = 100;
            slrSpecularity.Min = 0;
            slrSpecularity.Name = "slrSpecularity";
            slrSpecularity.Size = new Size(494, 91);
            slrSpecularity.TabIndex = 10;
            slrSpecularity.Value = 0;
            // 
            // slrShininess
            // 
            slrShininess.AutoSize = true;
            slrShininess.Dock = DockStyle.Fill;
            slrShininess.Header = "Блеск";
            slrShininess.Location = new Point(20, 391);
            slrShininess.Margin = new Padding(20, 3, 20, 3);
            slrShininess.Max = 100;
            slrShininess.Min = 0;
            slrShininess.Name = "slrShininess";
            slrShininess.Size = new Size(494, 91);
            slrShininess.TabIndex = 11;
            slrShininess.Value = 0;
            // 
            // slrEmission
            // 
            slrEmission.AutoSize = true;
            slrEmission.Dock = DockStyle.Fill;
            slrEmission.Header = "Излучение";
            slrEmission.Location = new Point(20, 488);
            slrEmission.Margin = new Padding(20, 3, 20, 3);
            slrEmission.Max = 100;
            slrEmission.Min = 0;
            slrEmission.Name = "slrEmission";
            slrEmission.Size = new Size(494, 91);
            slrEmission.TabIndex = 12;
            slrEmission.Value = 0;
            // 
            // AppeareanceEditor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox);
            Name = "AppeareanceEditor";
            Size = new Size(540, 723);
            groupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private HelpControls.Slider slider6;
        private HelpControls.Slider slider5;
        private HelpControls.Slider slider4;
        private HelpControls.Slider slider3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btSelectColor;
        private Panel pnlColor;
        private HelpControls.Slider slrTransparency;
        private HelpControls.Slider slrEmbient;
        private HelpControls.Slider slrDiffusion;
        private HelpControls.Slider slrSpecularity;
        private HelpControls.Slider slrShininess;
        private HelpControls.Slider slrEmission;
    }
}
