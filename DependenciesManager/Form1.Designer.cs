namespace DependenciesManager
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
            ListViewItem listViewItem1 = new ListViewItem("Нахождение библиотек для работы с API");
            ListViewItem listViewItem2 = new ListViewItem("Наличие списка доступных материалов");
            ListViewItem listViewItem3 = new ListViewItem("Соответствие системным требованиям*");
            tbKompasFolder = new TextBox();
            groupBox1 = new GroupBox();
            btInstallFolder = new Button();
            label2 = new Label();
            tbInstallFolder = new TextBox();
            btSearchKompasFolder = new Button();
            label1 = new Label();
            listView1 = new ListView();
            chApplicationComponent = new ColumnHeader();
            chResult = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tbKompasFolder
            // 
            tbKompasFolder.Location = new Point(242, 31);
            tbKompasFolder.Name = "tbKompasFolder";
            tbKompasFolder.ReadOnly = true;
            tbKompasFolder.Size = new Size(402, 27);
            tbKompasFolder.TabIndex = 0;
            tbKompasFolder.Text = "C:\\Program Files\\ASCON\\KOMPAS-3D v23 Study";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btInstallFolder);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbInstallFolder);
            groupBox1.Controls.Add(btSearchKompasFolder);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbKompasFolder);
            groupBox1.Location = new Point(27, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры установки";
            // 
            // btInstallFolder
            // 
            btInstallFolder.Enabled = false;
            btInstallFolder.Location = new Point(650, 80);
            btInstallFolder.Name = "btInstallFolder";
            btInstallFolder.Size = new Size(131, 29);
            btInstallFolder.TabIndex = 5;
            btInstallFolder.Text = "Выбрать папку...";
            btInstallFolder.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 83);
            label2.Name = "label2";
            label2.Size = new Size(196, 20);
            label2.TabIndex = 4;
            label2.Text = "Выберите папку установки";
            // 
            // tbInstallFolder
            // 
            tbInstallFolder.Location = new Point(242, 80);
            tbInstallFolder.Name = "tbInstallFolder";
            tbInstallFolder.ReadOnly = true;
            tbInstallFolder.Size = new Size(402, 27);
            tbInstallFolder.TabIndex = 3;
            tbInstallFolder.Text = "C:\\Program Files";
            // 
            // btSearchKompasFolder
            // 
            btSearchKompasFolder.Location = new Point(650, 31);
            btSearchKompasFolder.Name = "btSearchKompasFolder";
            btSearchKompasFolder.Size = new Size(131, 29);
            btSearchKompasFolder.TabIndex = 2;
            btSearchKompasFolder.Text = "Выбрать папку...";
            btSearchKompasFolder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 34);
            label1.Name = "label1";
            label1.Size = new Size(228, 20);
            label1.TabIndex = 1;
            label1.Text = "Куда установлен \"КОМПАС-3D\"";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { chApplicationComponent, chResult });
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.Location = new Point(27, 152);
            listView1.Name = "listView1";
            listView1.Size = new Size(798, 112);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // chApplicationComponent
            // 
            chApplicationComponent.Tag = "";
            chApplicationComponent.Text = "Компонент";
            chApplicationComponent.Width = 500;
            // 
            // chResult
            // 
            chResult.Text = "Результат";
            chResult.Width = 198;
            // 
            // button1
            // 
            button1.Location = new Point(731, 471);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(631, 471);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Ок";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(27, 270);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(798, 150);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Лицензионное соглашение";
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(6, 26);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(786, 88);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(6, 120);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(324, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Не принимаю лицензионное соглашение";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(489, 120);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(303, 24);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "Принимаю лицензионное соглашение";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 434);
            label3.Name = "label3";
            label3.Size = new Size(803, 20);
            label3.TabIndex = 7;
            label3.Text = "*Минимальная версия программы \"КОМПАС-3D\", с которой может взаимодействовать Oil level glass - 22 версия";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 512);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Установщик";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbKompasFolder;
        private GroupBox groupBox1;
        private Label label1;
        private Button btSearchKompasFolder;
        private ListView listView1;
        private ColumnHeader chApplicationComponent;
        private ColumnHeader chResult;
        private Button button1;
        private Button button2;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RichTextBox richTextBox1;
        private Button btInstallFolder;
        private Label label2;
        private TextBox tbInstallFolder;
        private Label label3;
    }
}
