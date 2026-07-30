namespace Oil_level_glass.UI.Editors.KompasFiles
{
    partial class SelectFolderForm
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
            cbChoosePart = new ComboBox();
            label1 = new Label();
            btSelectFolder = new Button();
            tbFolder = new TextBox();
            btApply = new Button();
            btCancel = new Button();
            SuspendLayout();
            // 
            // cbChoosePart
            // 
            cbChoosePart.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChoosePart.FormattingEnabled = true;
            cbChoosePart.Items.AddRange(new object[] { "Корпус", "Линза", "Прокладка" });
            cbChoosePart.Location = new Point(197, 27);
            cbChoosePart.Name = "cbChoosePart";
            cbChoosePart.Size = new Size(575, 40);
            cbChoosePart.TabIndex = 0;
            cbChoosePart.SelectedValueChanged += cbChoosePart_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 1;
            label1.Text = "Компонент";
            // 
            // btSelectFolder
            // 
            btSelectFolder.Enabled = false;
            btSelectFolder.Location = new Point(23, 94);
            btSelectFolder.Name = "btSelectFolder";
            btSelectFolder.Size = new Size(150, 46);
            btSelectFolder.TabIndex = 2;
            btSelectFolder.Text = "Выбрать...";
            btSelectFolder.UseVisualStyleBackColor = true;
            btSelectFolder.Click += btSelectFolder_Click;
            // 
            // tbFolder
            // 
            tbFolder.Enabled = false;
            tbFolder.Location = new Point(197, 98);
            tbFolder.Name = "tbFolder";
            tbFolder.Size = new Size(575, 39);
            tbFolder.TabIndex = 3;
            // 
            // btApply
            // 
            btApply.Enabled = false;
            btApply.Location = new Point(622, 173);
            btApply.Name = "btApply";
            btApply.Size = new Size(150, 46);
            btApply.TabIndex = 4;
            btApply.Text = "Применить";
            btApply.UseVisualStyleBackColor = true;
            btApply.Click += btApply_Click;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(448, 173);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(150, 46);
            btCancel.TabIndex = 5;
            btCancel.Text = "Отмена";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // SelectFolderForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btCancel;
            ClientSize = new Size(800, 242);
            Controls.Add(btCancel);
            Controls.Add(btApply);
            Controls.Add(tbFolder);
            Controls.Add(btSelectFolder);
            Controls.Add(label1);
            Controls.Add(cbChoosePart);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SelectFolderForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Выбор папки для сохранения";
            Load += SelectFolderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbChoosePart;
        private Label label1;
        private Button btSelectFolder;
        private TextBox tbFolder;
        private Button btApply;
        private Button btCancel;
    }
}