namespace Oil_level_glass.UI.Editors.View
{
    partial class ModelAppereanceForm
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
            groupBox1 = new GroupBox();
            tblpnlNumericParams = new TableLayoutPanel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbEmission = new NumericUpDown();
            label1 = new Label();
            tbShininess = new NumericUpDown();
            tbDiffuse = new NumericUpDown();
            tbSpecularity = new NumericUpDown();
            tbTransperency = new NumericUpDown();
            tbAmbient = new NumericUpDown();
            btChooseColor = new Button();
            pnlColor = new Panel();
            label7 = new Label();
            groupBox1.SuspendLayout();
            tblpnlNumericParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbEmission).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbShininess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDiffuse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpecularity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbTransperency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAmbient).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tblpnlNumericParams);
            groupBox1.Location = new Point(25, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(512, 354);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Числовые параметры";
            // 
            // tblpnlNumericParams
            // 
            tblpnlNumericParams.ColumnCount = 2;
            tblpnlNumericParams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblpnlNumericParams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblpnlNumericParams.Controls.Add(label6, 0, 5);
            tblpnlNumericParams.Controls.Add(label5, 0, 4);
            tblpnlNumericParams.Controls.Add(label4, 0, 3);
            tblpnlNumericParams.Controls.Add(label3, 0, 2);
            tblpnlNumericParams.Controls.Add(label2, 0, 1);
            tblpnlNumericParams.Controls.Add(tbEmission, 1, 1);
            tblpnlNumericParams.Controls.Add(label1, 0, 0);
            tblpnlNumericParams.Controls.Add(tbShininess, 1, 2);
            tblpnlNumericParams.Controls.Add(tbDiffuse, 1, 3);
            tblpnlNumericParams.Controls.Add(tbSpecularity, 1, 4);
            tblpnlNumericParams.Controls.Add(tbTransperency, 1, 5);
            tblpnlNumericParams.Controls.Add(tbAmbient, 1, 0);
            tblpnlNumericParams.Dock = DockStyle.Fill;
            tblpnlNumericParams.Location = new Point(3, 35);
            tblpnlNumericParams.Name = "tblpnlNumericParams";
            tblpnlNumericParams.RowCount = 6;
            tblpnlNumericParams.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblpnlNumericParams.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblpnlNumericParams.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblpnlNumericParams.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblpnlNumericParams.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblpnlNumericParams.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblpnlNumericParams.Size = new Size(506, 316);
            tblpnlNumericParams.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 270);
            label6.Margin = new Padding(10);
            label6.Name = "label6";
            label6.Size = new Size(171, 32);
            label6.TabIndex = 16;
            label6.Text = "Прозрачность";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 218);
            label5.Margin = new Padding(10);
            label5.Name = "label5";
            label5.Size = new Size(164, 32);
            label5.TabIndex = 15;
            label5.Text = "Зеркальность";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 166);
            label4.Margin = new Padding(10);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 14;
            label4.Text = "Диффузия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 114);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Size = new Size(77, 32);
            label3.TabIndex = 13;
            label3.Text = "Блеск";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 62);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(136, 32);
            label2.TabIndex = 12;
            label2.Text = "Излучение";
            // 
            // tbEmission
            // 
            tbEmission.DecimalPlaces = 2;
            tbEmission.Enabled = false;
            tbEmission.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            tbEmission.Location = new Point(263, 62);
            tbEmission.Margin = new Padding(10);
            tbEmission.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            tbEmission.Name = "tbEmission";
            tbEmission.Size = new Size(203, 39);
            tbEmission.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 10);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 6;
            label1.Text = "Общий цвет";
            // 
            // tbShininess
            // 
            tbShininess.DecimalPlaces = 2;
            tbShininess.Enabled = false;
            tbShininess.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            tbShininess.Location = new Point(263, 114);
            tbShininess.Margin = new Padding(10);
            tbShininess.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            tbShininess.Name = "tbShininess";
            tbShininess.Size = new Size(203, 39);
            tbShininess.TabIndex = 9;
            // 
            // tbDiffuse
            // 
            tbDiffuse.DecimalPlaces = 2;
            tbDiffuse.Enabled = false;
            tbDiffuse.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            tbDiffuse.Location = new Point(263, 166);
            tbDiffuse.Margin = new Padding(10);
            tbDiffuse.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            tbDiffuse.Name = "tbDiffuse";
            tbDiffuse.Size = new Size(203, 39);
            tbDiffuse.TabIndex = 7;
            // 
            // tbSpecularity
            // 
            tbSpecularity.DecimalPlaces = 2;
            tbSpecularity.Enabled = false;
            tbSpecularity.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            tbSpecularity.Location = new Point(263, 218);
            tbSpecularity.Margin = new Padding(10);
            tbSpecularity.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            tbSpecularity.Name = "tbSpecularity";
            tbSpecularity.Size = new Size(203, 39);
            tbSpecularity.TabIndex = 10;
            // 
            // tbTransperency
            // 
            tbTransperency.DecimalPlaces = 2;
            tbTransperency.Enabled = false;
            tbTransperency.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            tbTransperency.Location = new Point(263, 270);
            tbTransperency.Margin = new Padding(10);
            tbTransperency.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            tbTransperency.Name = "tbTransperency";
            tbTransperency.Size = new Size(203, 39);
            tbTransperency.TabIndex = 11;
            // 
            // tbAmbient
            // 
            tbAmbient.DecimalPlaces = 2;
            tbAmbient.Enabled = false;
            tbAmbient.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            tbAmbient.Location = new Point(263, 10);
            tbAmbient.Margin = new Padding(10);
            tbAmbient.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            tbAmbient.Name = "tbAmbient";
            tbAmbient.Size = new Size(203, 39);
            tbAmbient.TabIndex = 0;
            // 
            // btChooseColor
            // 
            btChooseColor.Enabled = false;
            btChooseColor.Location = new Point(25, 479);
            btChooseColor.Name = "btChooseColor";
            btChooseColor.Size = new Size(150, 46);
            btChooseColor.TabIndex = 1;
            btChooseColor.Text = "Цвет...";
            btChooseColor.UseVisualStyleBackColor = true;
            btChooseColor.Click += btChooseColor_Click;
            // 
            // pnlColor
            // 
            pnlColor.BorderStyle = BorderStyle.FixedSingle;
            pnlColor.Location = new Point(249, 479);
            pnlColor.Name = "pnlColor";
            pnlColor.Size = new Size(288, 46);
            pnlColor.TabIndex = 2;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(191, 557);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(150, 46);
            btCancel.TabIndex = 9;
            btCancel.Text = "Отмена";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // btApply
            // 
            btApply.Enabled = false;
            btApply.Location = new Point(384, 557);
            btApply.Name = "btApply";
            btApply.Size = new Size(150, 46);
            btApply.TabIndex = 8;
            btApply.Text = "Применить";
            btApply.UseVisualStyleBackColor = true;
            btApply.Click += btApply_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 42);
            label7.Name = "label7";
            label7.Size = new Size(138, 32);
            label7.TabIndex = 11;
            label7.Text = "Компонент";
            // 
            // cbChoosePart
            // 
            cbChoosePart.Location = new Point(206, 42);
            cbChoosePart.Name = "cbChoosePart";
            cbChoosePart.Size = new Size(331, 40);
            cbChoosePart.TabIndex = 10;
            // 
            // ModelAppereanceForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btCancel;
            ClientSize = new Size(561, 635);
            Controls.Add(label7);
            Controls.Add(cbChoosePart);
            Controls.Add(btCancel);
            Controls.Add(btApply);
            Controls.Add(pnlColor);
            Controls.Add(btChooseColor);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModelAppereanceForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Отображение модели";
            groupBox1.ResumeLayout(false);
            tblpnlNumericParams.ResumeLayout(false);
            tblpnlNumericParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbEmission).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbShininess).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDiffuse).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpecularity).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbTransperency).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAmbient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btChooseColor;
        private Panel pnlColor;
        private TableLayoutPanel tblpnlNumericParams;
        private NumericUpDown tbAmbient;
        private NumericUpDown tbDiffuse;
        private NumericUpDown tbEmission;
        private NumericUpDown tbShininess;
        private NumericUpDown tbSpecularity;
        private NumericUpDown tbTransperency;

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
    }
}