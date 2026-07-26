namespace Oil_level_glass.UI.Editors.KompasFiles
{
    partial class EditNamingForm
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
            label1 = new Label();
            label2 = new Label();
            tbMarking = new TextBox();
            tbNaming = new TextBox();
            label3 = new Label();
            cbChoosePart = new ComboBox();
            btCancel = new Button();
            btApply = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 128);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 0;
            label1.Text = "Обозначение";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 194);
            label2.Name = "label2";
            label2.Size = new Size(181, 32);
            label2.TabIndex = 1;
            label2.Text = "Наименование";
            // 
            // tbMarking
            // 
            tbMarking.Enabled = false;
            tbMarking.Location = new Point(237, 128);
            tbMarking.Name = "tbMarking";
            tbMarking.Size = new Size(334, 39);
            tbMarking.TabIndex = 2;
            // 
            // tbNaming
            // 
            tbNaming.Enabled = false;
            tbNaming.Location = new Point(237, 194);
            tbNaming.Name = "tbNaming";
            tbNaming.Size = new Size(334, 39);
            tbNaming.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 70);
            label3.Name = "label3";
            label3.Size = new Size(138, 32);
            label3.TabIndex = 5;
            label3.Text = "Компонент";
            // 
            // cbChoosePart
            // 
            cbChoosePart.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChoosePart.FormattingEnabled = true;
            cbChoosePart.Items.AddRange(new object[] { "Корпус", "Линза", "Прокладка" });
            cbChoosePart.Location = new Point(237, 67);
            cbChoosePart.Name = "cbChoosePart";
            cbChoosePart.Size = new Size(334, 40);
            cbChoosePart.TabIndex = 4;
            cbChoosePart.SelectedValueChanged += cbChoosePart_SelectedValueChanged;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(247, 266);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(150, 46);
            btCancel.TabIndex = 7;
            btCancel.Text = "Отмена";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // btApply
            // 
            btApply.Enabled = false;
            btApply.Location = new Point(421, 266);
            btApply.Name = "btApply";
            btApply.Size = new Size(150, 46);
            btApply.TabIndex = 6;
            btApply.Text = "Применить";
            btApply.UseVisualStyleBackColor = true;
            btApply.Click += btApply_Click;
            // 
            // EditNamingForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btCancel;
            ClientSize = new Size(604, 355);
            Controls.Add(btCancel);
            Controls.Add(btApply);
            Controls.Add(label3);
            Controls.Add(cbChoosePart);
            Controls.Add(tbNaming);
            Controls.Add(tbMarking);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditNamingForm";
            Text = "Обозначение и наименование";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbMarking;
        private TextBox tbNaming;
        private Label label3;
        private ComboBox cbChoosePart;
        private Button btCancel;
        private Button btApply;
    }
}