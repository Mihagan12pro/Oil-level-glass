namespace Oil_level_glass
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBoxSketch = new PictureBox();
            label1 = new Label();
            dSizeLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nNumericUpDown = new NumericUpDown();
            label6 = new Label();
            buttonBuild = new Button();
            sizeDTextBox = new TextBox();
            size_dTextBox = new TextBox();
            size_d1TextBox = new TextBox();
            size_d2TextBox = new TextBox();
            sizeHTextBox = new TextBox();
            size_htextBox = new TextBox();
            groupBoxMainSizes = new GroupBox();
            label10 = new Label();
            sizeD2TextBox = new TextBox();
            label8 = new Label();
            saveFolderBrowserDialog = new FolderBrowserDialog();
            _textBoxSavePath = new TextBox();
            _setSaveFolderButton = new Button();
            _savePathError = new ErrorProvider(components);
            chamferGroupBox = new GroupBox();
            chamferLengthTextBox = new TextBox();
            label9 = new Label();
            angleNumericUpDown = new NumericUpDown();
            label7 = new Label();
            _DError = new ErrorProvider(components);
            _D2Error = new ErrorProvider(components);
            _HError = new ErrorProvider(components);
            _chamferLengthError = new ErrorProvider(components);
            __d1Error = new ErrorProvider(components);
            __d2Error = new ErrorProvider(components);
            __dError = new ErrorProvider(components);
            __hErrror = new ErrorProvider(components);
            ___hError = new ErrorProvider(components);
            _nError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSketch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nNumericUpDown).BeginInit();
            groupBoxMainSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_savePathError).BeginInit();
            chamferGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)angleNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_DError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_D2Error).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_HError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_chamferLengthError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)__d1Error).BeginInit();
            ((System.ComponentModel.ISupportInitialize)__d2Error).BeginInit();
            ((System.ComponentModel.ISupportInitialize)__dError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)__hErrror).BeginInit();
            ((System.ComponentModel.ISupportInitialize)___hError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_nError).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxSketch
            // 
            pictureBoxSketch.BackColor = Color.Transparent;
            pictureBoxSketch.Image = Properties.Resources.assemble;
            pictureBoxSketch.InitialImage = (Image)resources.GetObject("pictureBoxSketch.InitialImage");
            pictureBoxSketch.Location = new Point(315, 31);
            pictureBoxSketch.Name = "pictureBoxSketch";
            pictureBoxSketch.Size = new Size(171, 307);
            pictureBoxSketch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSketch.TabIndex = 0;
            pictureBoxSketch.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 27);
            label1.Name = "label1";
            label1.Size = new Size(15, 16);
            label1.TabIndex = 2;
            label1.Text = "D";
            // 
            // dSizeLabel
            // 
            dSizeLabel.AutoSize = true;
            dSizeLabel.Location = new Point(18, 57);
            dSizeLabel.Name = "dSizeLabel";
            dSizeLabel.Size = new Size(14, 16);
            dSizeLabel.TabIndex = 3;
            dSizeLabel.Text = "d";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 112);
            label2.Name = "label2";
            label2.Size = new Size(19, 16);
            label2.TabIndex = 4;
            label2.Text = "d1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 147);
            label3.Name = "label3";
            label3.Size = new Size(21, 16);
            label3.TabIndex = 10;
            label3.Text = "d2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 177);
            label4.Name = "label4";
            label4.Size = new Size(15, 16);
            label4.TabIndex = 11;
            label4.Text = "H";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 207);
            label5.Name = "label5";
            label5.Size = new Size(14, 16);
            label5.TabIndex = 12;
            label5.Text = "h";
            // 
            // nNumericUpDown
            // 
            nNumericUpDown.Location = new Point(55, 229);
            nNumericUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nNumericUpDown.Name = "nNumericUpDown";
            nNumericUpDown.Size = new Size(147, 24);
            nNumericUpDown.TabIndex = 13;
            nNumericUpDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nNumericUpDown.ValueChanged += nNumericUpDown_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 237);
            label6.Name = "label6";
            label6.Size = new Size(14, 16);
            label6.TabIndex = 14;
            label6.Text = "n";
            // 
            // buttonBuild
            // 
            buttonBuild.Location = new Point(392, 412);
            buttonBuild.Name = "buttonBuild";
            buttonBuild.Size = new Size(94, 26);
            buttonBuild.TabIndex = 15;
            buttonBuild.Text = "Построить";
            buttonBuild.UseVisualStyleBackColor = true;
            buttonBuild.Click += buttonBuild_Click;
            // 
            // sizeDTextBox
            // 
            sizeDTextBox.Location = new Point(55, 19);
            sizeDTextBox.Name = "sizeDTextBox";
            sizeDTextBox.Size = new Size(147, 24);
            sizeDTextBox.TabIndex = 16;
            sizeDTextBox.Text = "90";
            sizeDTextBox.TextChanged += sizeDTextBox_TextChanged;
            // 
            // size_dTextBox
            // 
            size_dTextBox.Location = new Point(55, 49);
            size_dTextBox.Name = "size_dTextBox";
            size_dTextBox.Size = new Size(147, 24);
            size_dTextBox.TabIndex = 17;
            size_dTextBox.Text = "6,65";
            size_dTextBox.TextChanged += size_dTextBox_TextChanged;
            // 
            // size_d1TextBox
            // 
            size_d1TextBox.Location = new Point(55, 109);
            size_d1TextBox.Name = "size_d1TextBox";
            size_d1TextBox.Size = new Size(147, 24);
            size_d1TextBox.TabIndex = 18;
            size_d1TextBox.Text = "50";
            size_d1TextBox.TextChanged += size_d1TextBox_TextChanged;
            // 
            // size_d2TextBox
            // 
            size_d2TextBox.Location = new Point(55, 139);
            size_d2TextBox.Name = "size_d2TextBox";
            size_d2TextBox.Size = new Size(147, 24);
            size_d2TextBox.TabIndex = 19;
            size_d2TextBox.Text = "60";
            size_d2TextBox.TextChanged += size_d2TextBox_TextChanged;
            // 
            // sizeHTextBox
            // 
            sizeHTextBox.Location = new Point(55, 169);
            sizeHTextBox.Name = "sizeHTextBox";
            sizeHTextBox.Size = new Size(147, 24);
            sizeHTextBox.TabIndex = 20;
            sizeHTextBox.Text = "8";
            sizeHTextBox.TextChanged += sizeHTextBox_TextChanged;
            // 
            // size_htextBox
            // 
            size_htextBox.Location = new Point(55, 199);
            size_htextBox.Name = "size_htextBox";
            size_htextBox.Size = new Size(147, 24);
            size_htextBox.TabIndex = 21;
            size_htextBox.Text = "6";
            size_htextBox.TextChanged += size_htextBox_TextChanged;
            // 
            // groupBoxMainSizes
            // 
            groupBoxMainSizes.Controls.Add(label10);
            groupBoxMainSizes.Controls.Add(sizeD2TextBox);
            groupBoxMainSizes.Controls.Add(sizeDTextBox);
            groupBoxMainSizes.Controls.Add(size_htextBox);
            groupBoxMainSizes.Controls.Add(nNumericUpDown);
            groupBoxMainSizes.Controls.Add(label6);
            groupBoxMainSizes.Controls.Add(label1);
            groupBoxMainSizes.Controls.Add(sizeHTextBox);
            groupBoxMainSizes.Controls.Add(dSizeLabel);
            groupBoxMainSizes.Controls.Add(size_d2TextBox);
            groupBoxMainSizes.Controls.Add(label5);
            groupBoxMainSizes.Controls.Add(size_dTextBox);
            groupBoxMainSizes.Controls.Add(size_d1TextBox);
            groupBoxMainSizes.Controls.Add(label2);
            groupBoxMainSizes.Controls.Add(label4);
            groupBoxMainSizes.Controls.Add(label3);
            groupBoxMainSizes.FlatStyle = FlatStyle.Flat;
            groupBoxMainSizes.Location = new Point(21, 23);
            groupBoxMainSizes.Name = "groupBoxMainSizes";
            groupBoxMainSizes.Size = new Size(241, 268);
            groupBoxMainSizes.TabIndex = 22;
            groupBoxMainSizes.TabStop = false;
            groupBoxMainSizes.Text = "Основные размеры";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 82);
            label10.Name = "label10";
            label10.Size = new Size(22, 16);
            label10.TabIndex = 23;
            label10.Text = "D2";
            // 
            // sizeD2TextBox
            // 
            sizeD2TextBox.Location = new Point(55, 79);
            sizeD2TextBox.Name = "sizeD2TextBox";
            sizeD2TextBox.Size = new Size(147, 24);
            sizeD2TextBox.TabIndex = 22;
            sizeD2TextBox.Text = "72";
            sizeD2TextBox.TextChanged += D2TextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(255, 322);
            label8.Name = "label8";
            label8.Size = new Size(0, 16);
            label8.TabIndex = 25;
            // 
            // _textBoxSavePath
            // 
            _textBoxSavePath.Location = new Point(179, 412);
            _textBoxSavePath.Name = "_textBoxSavePath";
            _textBoxSavePath.PlaceholderText = "C:\\";
            _textBoxSavePath.ScrollBars = ScrollBars.Horizontal;
            _textBoxSavePath.Size = new Size(142, 24);
            _textBoxSavePath.TabIndex = 28;
            _textBoxSavePath.Text = "C:\\";
            _textBoxSavePath.TextChanged += textBoxSavePath_TextChanged;
            // 
            // _setSaveFolderButton
            // 
            _setSaveFolderButton.Location = new Point(21, 411);
            _setSaveFolderButton.Name = "_setSaveFolderButton";
            _setSaveFolderButton.Size = new Size(136, 29);
            _setSaveFolderButton.TabIndex = 29;
            _setSaveFolderButton.Text = "Куда сохранять...";
            _setSaveFolderButton.UseVisualStyleBackColor = true;
            _setSaveFolderButton.Click += setSaveFolderButton_Click;
            // 
            // _savePathError
            // 
            _savePathError.ContainerControl = this;
            // 
            // chamferGroupBox
            // 
            chamferGroupBox.Controls.Add(chamferLengthTextBox);
            chamferGroupBox.Controls.Add(label9);
            chamferGroupBox.Controls.Add(angleNumericUpDown);
            chamferGroupBox.Controls.Add(label7);
            chamferGroupBox.Location = new Point(21, 297);
            chamferGroupBox.Name = "chamferGroupBox";
            chamferGroupBox.Size = new Size(241, 90);
            chamferGroupBox.TabIndex = 30;
            chamferGroupBox.TabStop = false;
            chamferGroupBox.Text = "Параметры фаски";
            // 
            // chamferLengthTextBox
            // 
            chamferLengthTextBox.Location = new Point(67, 50);
            chamferLengthTextBox.Name = "chamferLengthTextBox";
            chamferLengthTextBox.Size = new Size(135, 24);
            chamferLengthTextBox.TabIndex = 3;
            chamferLengthTextBox.Text = "3";
            chamferLengthTextBox.TextChanged += chamferLengthTextBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 53);
            label9.Name = "label9";
            label9.Size = new Size(44, 16);
            label9.TabIndex = 2;
            label9.Text = "Длина";
            // 
            // angleNumericUpDown
            // 
            angleNumericUpDown.Location = new Point(67, 20);
            angleNumericUpDown.Maximum = new decimal(new int[] { 89, 0, 0, 0 });
            angleNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            angleNumericUpDown.Name = "angleNumericUpDown";
            angleNumericUpDown.Size = new Size(135, 24);
            angleNumericUpDown.TabIndex = 1;
            angleNumericUpDown.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 22);
            label7.Name = "label7";
            label7.Size = new Size(36, 16);
            label7.TabIndex = 0;
            label7.Text = "Угол";
            // 
            // _DError
            // 
            _DError.ContainerControl = this;
            // 
            // _D2Error
            // 
            _D2Error.ContainerControl = this;
            // 
            // _HError
            // 
            _HError.ContainerControl = this;
            // 
            // _chamferLengthError
            // 
            _chamferLengthError.ContainerControl = this;
            // 
            // __d1Error
            // 
            __d1Error.ContainerControl = this;
            // 
            // __d2Error
            // 
            __d2Error.ContainerControl = this;
            // 
            // __dError
            // 
            __dError.ContainerControl = this;
            // 
            // __hErrror
            // 
            __hErrror.ContainerControl = this;
            // 
            // ___hError
            // 
            ___hError.ContainerControl = this;
            // 
            // _nError
            // 
            _nError.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(498, 469);
            Controls.Add(chamferGroupBox);
            Controls.Add(_setSaveFolderButton);
            Controls.Add(_textBoxSavePath);
            Controls.Add(label8);
            Controls.Add(groupBoxMainSizes);
            Controls.Add(buttonBuild);
            Controls.Add(pictureBoxSketch);
            Font = new Font("GOST type B", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)pictureBoxSketch).EndInit();
            ((System.ComponentModel.ISupportInitialize)nNumericUpDown).EndInit();
            groupBoxMainSizes.ResumeLayout(false);
            groupBoxMainSizes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_savePathError).EndInit();
            chamferGroupBox.ResumeLayout(false);
            chamferGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)angleNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)_DError).EndInit();
            ((System.ComponentModel.ISupportInitialize)_D2Error).EndInit();
            ((System.ComponentModel.ISupportInitialize)_HError).EndInit();
            ((System.ComponentModel.ISupportInitialize)_chamferLengthError).EndInit();
            ((System.ComponentModel.ISupportInitialize)__d1Error).EndInit();
            ((System.ComponentModel.ISupportInitialize)__d2Error).EndInit();
            ((System.ComponentModel.ISupportInitialize)__dError).EndInit();
            ((System.ComponentModel.ISupportInitialize)__hErrror).EndInit();
            ((System.ComponentModel.ISupportInitialize)___hError).EndInit();
            ((System.ComponentModel.ISupportInitialize)_nError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxSketch;
        private Label label1;
        private Label dSizeLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown nNumericUpDown;
        private Label label6;
        private Button buttonBuild;
        private TextBox sizeDTextBox;
        private TextBox size_dTextBox;
        private TextBox size_d1TextBox;
        private TextBox size_d2TextBox;
        private TextBox sizeHTextBox;
        private TextBox size_htextBox;
        private GroupBox groupBoxMainSizes;
        private Label label8;
        private FolderBrowserDialog saveFolderBrowserDialog;
        private TextBox _textBoxSavePath;
        private Button _setSaveFolderButton;
        private GroupBox chamferGroupBox;
        private NumericUpDown angleNumericUpDown;
        private Label label7;
        private TextBox chamferLengthTextBox;
        private Label label9;
        private Label label10;
        private TextBox sizeD2TextBox;
        private ErrorProvider _DError;
        private ErrorProvider _D2Error;
        private ErrorProvider _HError;
        private ErrorProvider _chamferLengthError;
        private ErrorProvider _savePathError;
        private ErrorProvider __d1Error;
        private ErrorProvider __d2Error;
        private ErrorProvider __dError;
        private ErrorProvider __hErrror;
        private ErrorProvider ___hError;
        private ErrorProvider _nError;
    }
}
