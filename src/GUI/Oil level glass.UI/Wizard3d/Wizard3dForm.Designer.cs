namespace Oil_level_glass.UI.Wizard3d
{
    partial class Wizard3dForm
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
            btOk = new Button();
            btCancel = new Button();
            tbCtlrModelParams = new TabControl();
            tabSizes = new TabPage();
            tabMaterials = new TabPage();
            tlpMaterials = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            tabSaving = new TabPage();
            tabAppearance = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            textBox2 = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tbCtlrModelParams.SuspendLayout();
            tabMaterials.SuspendLayout();
            tlpMaterials.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btOk
            // 
            btOk.Location = new Point(580, 409);
            btOk.Name = "btOk";
            btOk.Size = new Size(94, 29);
            btOk.TabIndex = 0;
            btOk.Text = "Ок";
            btOk.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(694, 409);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(94, 29);
            btCancel.TabIndex = 1;
            btCancel.Text = "Отмена";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // tbCtlrModelParams
            // 
            tbCtlrModelParams.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCtlrModelParams.Controls.Add(tabSizes);
            tbCtlrModelParams.Controls.Add(tabMaterials);
            tbCtlrModelParams.Controls.Add(tabSaving);
            tbCtlrModelParams.Controls.Add(tabAppearance);
            tbCtlrModelParams.Location = new Point(12, 2);
            tbCtlrModelParams.Name = "tbCtlrModelParams";
            tbCtlrModelParams.SelectedIndex = 0;
            tbCtlrModelParams.Size = new Size(776, 401);
            tbCtlrModelParams.TabIndex = 2;
            // 
            // tabSizes
            // 
            tabSizes.Location = new Point(4, 29);
            tabSizes.Name = "tabSizes";
            tabSizes.Padding = new Padding(3);
            tabSizes.Size = new Size(768, 368);
            tabSizes.TabIndex = 0;
            tabSizes.Text = "Размеры";
            tabSizes.UseVisualStyleBackColor = true;
            // 
            // tabMaterials
            // 
            tabMaterials.Controls.Add(tlpMaterials);
            tabMaterials.Location = new Point(4, 29);
            tabMaterials.Name = "tabMaterials";
            tabMaterials.Padding = new Padding(3);
            tabMaterials.Size = new Size(768, 368);
            tabMaterials.TabIndex = 1;
            tabMaterials.Text = "Материалы";
            tabMaterials.UseVisualStyleBackColor = true;
            // 
            // tlpMaterials
            // 
            tlpMaterials.ColumnCount = 3;
            tlpMaterials.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpMaterials.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpMaterials.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpMaterials.Controls.Add(groupBox1, 0, 0);
            tlpMaterials.Controls.Add(groupBox2, 1, 0);
            tlpMaterials.Controls.Add(groupBox3, 2, 0);
            tlpMaterials.Dock = DockStyle.Fill;
            tlpMaterials.Location = new Point(3, 3);
            tlpMaterials.Name = "tlpMaterials";
            tlpMaterials.RowCount = 1;
            tlpMaterials.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMaterials.Size = new Size(762, 362);
            tlpMaterials.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 336);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Корпус";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Location = new Point(257, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 336);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Линза";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(511, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(248, 336);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Прокладка";
            // 
            // tabSaving
            // 
            tabSaving.Location = new Point(4, 29);
            tabSaving.Name = "tabSaving";
            tabSaving.Size = new Size(768, 368);
            tabSaving.TabIndex = 2;
            tabSaving.Text = "Сохранение";
            tabSaving.UseVisualStyleBackColor = true;
            // 
            // tabAppearance
            // 
            tabAppearance.Location = new Point(4, 29);
            tabAppearance.Name = "tabAppearance";
            tabAppearance.Size = new Size(768, 368);
            tabAppearance.TabIndex = 3;
            tabAppearance.Text = "Вид";
            tabAppearance.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(242, 310);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 33);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 0;
            label2.Text = "Штриховка: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 33);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 1;
            label3.Text = "Метал";
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 209);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 98);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 35);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "ρ, кг/м³";
            label1.Click += this.label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 97);
            panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(9, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 27);
            textBox2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 97);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Location = new Point(6, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(250, 125);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // Wizard3dForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(tbCtlrModelParams);
            Controls.Add(btCancel);
            Controls.Add(btOk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Wizard3dForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Мастер 3d модели";
            tbCtlrModelParams.ResumeLayout(false);
            tabMaterials.ResumeLayout(false);
            tlpMaterials.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btOk;
        private Button btCancel;
        private TabControl tbCtlrModelParams;
        private TabPage tabSizes;
        private TabPage tabMaterials;
        private TabPage tabSaving;
        private TabPage tabAppearance;
        private TableLayoutPanel tlpMaterials;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox textBox2;
        private Panel panel2;
        private TextBox textBox1;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
    }
}