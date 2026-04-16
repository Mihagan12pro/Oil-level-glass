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
            splitContainer2 = new SplitContainer();
            tabSaving = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabSizes = new TabPage();
            splitSizes = new SplitContainer();
            tvParts = new TreeView();
            pbSketch = new PictureBox();
            tbCtlrModelParams = new TabControl();
            savingParametersEditor4 = new Oil_level_glass.UI.Controls.SavingParametersEditor();
            savingParametersEditor5 = new Oil_level_glass.UI.Controls.SavingParametersEditor();
            savingParametersEditor6 = new Oil_level_glass.UI.Controls.SavingParametersEditor();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.SuspendLayout();
            tabSaving.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitSizes).BeginInit();
            splitSizes.Panel1.SuspendLayout();
            splitSizes.Panel2.SuspendLayout();
            splitSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSketch).BeginInit();
            tbCtlrModelParams.SuspendLayout();
            SuspendLayout();
            // 
            // btOk
            // 
            btOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btOk.Location = new Point(990, 885);
            btOk.Margin = new Padding(5);
            btOk.Name = "btOk";
            btOk.Size = new Size(153, 46);
            btOk.TabIndex = 0;
            btOk.Text = "Ок";
            btOk.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            btCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btCancel.Location = new Point(1188, 885);
            btCancel.Margin = new Padding(5);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(153, 46);
            btCancel.TabIndex = 1;
            btCancel.Text = "Отмена";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(2);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            splitContainer2.Size = new Size(531, 497);
            splitContainer2.SplitterDistance = 447;
            splitContainer2.SplitterWidth = 2;
            splitContainer2.TabIndex = 0;
            // 
            // tabSaving
            // 
            tabSaving.Controls.Add(tableLayoutPanel1);
            tabSaving.Location = new Point(8, 46);
            tabSaving.Margin = new Padding(5);
            tabSaving.Name = "tabSaving";
            tabSaving.Size = new Size(1305, 804);
            tabSaving.TabIndex = 2;
            tabSaving.Text = "Сохранение";
            tabSaving.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(savingParametersEditor6, 2, 0);
            tableLayoutPanel1.Controls.Add(savingParametersEditor5, 1, 0);
            tableLayoutPanel1.Controls.Add(savingParametersEditor4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1305, 804);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tabSizes
            // 
            tabSizes.Controls.Add(splitSizes);
            tabSizes.Location = new Point(8, 46);
            tabSizes.Margin = new Padding(5);
            tabSizes.Name = "tabSizes";
            tabSizes.Padding = new Padding(5);
            tabSizes.Size = new Size(1305, 804);
            tabSizes.TabIndex = 0;
            tabSizes.Text = "Размеры";
            tabSizes.UseVisualStyleBackColor = true;
            // 
            // splitSizes
            // 
            splitSizes.BorderStyle = BorderStyle.Fixed3D;
            splitSizes.Dock = DockStyle.Fill;
            splitSizes.Location = new Point(5, 5);
            splitSizes.Margin = new Padding(5);
            splitSizes.Name = "splitSizes";
            // 
            // splitSizes.Panel1
            // 
            splitSizes.Panel1.Controls.Add(tvParts);
            // 
            // splitSizes.Panel2
            // 
            splitSizes.Panel2.Controls.Add(pbSketch);
            splitSizes.Size = new Size(1295, 794);
            splitSizes.SplitterDistance = 429;
            splitSizes.SplitterWidth = 6;
            splitSizes.TabIndex = 0;
            // 
            // tvParts
            // 
            tvParts.Dock = DockStyle.Fill;
            tvParts.Location = new Point(0, 0);
            tvParts.Margin = new Padding(5);
            tvParts.Name = "tvParts";
            tvParts.Size = new Size(425, 790);
            tvParts.TabIndex = 0;
            tvParts.AfterSelect += tvParts_AfterSelect;
            tvParts.DoubleClick += tvParts_DoubleClick;
            // 
            // pbSketch
            // 
            pbSketch.Dock = DockStyle.Fill;
            pbSketch.Image = Properties.Resources.Oil_level_glass_Img;
            pbSketch.Location = new Point(0, 0);
            pbSketch.Margin = new Padding(5);
            pbSketch.Name = "pbSketch";
            pbSketch.Size = new Size(856, 790);
            pbSketch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSketch.TabIndex = 0;
            pbSketch.TabStop = false;
            // 
            // tbCtlrModelParams
            // 
            tbCtlrModelParams.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbCtlrModelParams.Controls.Add(tabSizes);
            tbCtlrModelParams.Controls.Add(tabSaving);
            tbCtlrModelParams.Location = new Point(20, 3);
            tbCtlrModelParams.Margin = new Padding(5);
            tbCtlrModelParams.Name = "tbCtlrModelParams";
            tbCtlrModelParams.SelectedIndex = 0;
            tbCtlrModelParams.Size = new Size(1321, 858);
            tbCtlrModelParams.TabIndex = 2;
            // 
            // savingParametersEditor4
            // 
            savingParametersEditor4.FolderPath = "C:\\Users\\kargi\\OneDrive\\Документы";
            savingParametersEditor4.Header = null;
            savingParametersEditor4.Location = new Point(10, 3);
            savingParametersEditor4.Margin = new Padding(10, 3, 10, 10);
            savingParametersEditor4.Marking = null;
            savingParametersEditor4.Name = "savingParametersEditor4";
            savingParametersEditor4.Namimg = null;
            savingParametersEditor4.Size = new Size(415, 791);
            savingParametersEditor4.TabIndex = 0;
            // 
            // savingParametersEditor5
            // 
            savingParametersEditor5.FolderPath = "C:\\Users\\kargi\\OneDrive\\Документы";
            savingParametersEditor5.Header = null;
            savingParametersEditor5.Location = new Point(445, 3);
            savingParametersEditor5.Margin = new Padding(10, 3, 10, 10);
            savingParametersEditor5.Marking = null;
            savingParametersEditor5.Name = "savingParametersEditor5";
            savingParametersEditor5.Namimg = null;
            savingParametersEditor5.Size = new Size(415, 791);
            savingParametersEditor5.TabIndex = 1;
            // 
            // savingParametersEditor6
            // 
            savingParametersEditor6.FolderPath = "C:\\Users\\kargi\\OneDrive\\Документы";
            savingParametersEditor6.Header = null;
            savingParametersEditor6.Location = new Point(880, 3);
            savingParametersEditor6.Margin = new Padding(10, 3, 10, 10);
            savingParametersEditor6.Marking = null;
            savingParametersEditor6.Name = "savingParametersEditor6";
            savingParametersEditor6.Namimg = null;
            savingParametersEditor6.Size = new Size(415, 791);
            savingParametersEditor6.TabIndex = 2;
            // 
            // Wizard3dForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 946);
            Controls.Add(tbCtlrModelParams);
            Controls.Add(btCancel);
            Controls.Add(btOk);
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Wizard3dForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Мастер 3d модели";
            Load += Wizard3dForm_Load;
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tabSaving.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tabSizes.ResumeLayout(false);
            splitSizes.Panel1.ResumeLayout(false);
            splitSizes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitSizes).EndInit();
            splitSizes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSketch).EndInit();
            tbCtlrModelParams.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btOk;
        private Button btCancel;
        private Controls.MaterialChooser mcHousing;
        private Controls.MaterialChooser materialChooser1;
        private Controls.MaterialChooser materialChooser2;
        private Controls.SavingParametersEditor savingParametersEditor1;
        private Controls.SavingParametersEditor savingParametersEditor2;
        private Controls.SavingParametersEditor savingParametersEditor3;
        private Controls.AppeareanceEditor appeareanceEditor1;
        private Controls.AppeareanceEditor appeareanceEditor3;
        private Controls.AppeareanceEditor appeareanceEditor2;
        private SplitContainer splitContainer2;
        private TabPage tabSaving;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabSizes;
        private SplitContainer splitSizes;
        private TreeView tvParts;
        private PictureBox pbSketch;
        private TabControl tbCtlrModelParams;
        private Controls.SavingParametersEditor savingParametersEditor6;
        private Controls.SavingParametersEditor savingParametersEditor5;
        private Controls.SavingParametersEditor savingParametersEditor4;
    }
}