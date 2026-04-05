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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            pbSketch = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rbAssembly = new RadioButton();
            rbHousing = new RadioButton();
            rbGlass = new RadioButton();
            rbRubberStrip = new RadioButton();
            tabMaterials = new TabPage();
            tlpMaterials = new TableLayoutPanel();
            mcHousing = new Oil_level_glass.UI.Controls.MaterialChooser();
            materialChooser1 = new Oil_level_glass.UI.Controls.MaterialChooser();
            materialChooser2 = new Oil_level_glass.UI.Controls.MaterialChooser();
            tabSaving = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            savingParametersEditor1 = new Oil_level_glass.UI.Controls.SavingParametersEditor();
            savingParametersEditor2 = new Oil_level_glass.UI.Controls.SavingParametersEditor();
            savingParametersEditor3 = new Oil_level_glass.UI.Controls.SavingParametersEditor();
            tabAppearance = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            appeareanceEditor3 = new Oil_level_glass.UI.Controls.AppeareanceEditor();
            appeareanceEditor2 = new Oil_level_glass.UI.Controls.AppeareanceEditor();
            appeareanceEditor1 = new Oil_level_glass.UI.Controls.AppeareanceEditor();
            tbCtlrModelParams.SuspendLayout();
            tabSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSketch).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tabMaterials.SuspendLayout();
            tlpMaterials.SuspendLayout();
            tabSaving.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabAppearance.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btOk
            // 
            btOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btOk.Location = new Point(940, 745);
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
            btCancel.Location = new Point(1128, 745);
            btCancel.Margin = new Padding(5);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(153, 46);
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
            tbCtlrModelParams.Location = new Point(20, 3);
            tbCtlrModelParams.Margin = new Padding(5);
            tbCtlrModelParams.Name = "tbCtlrModelParams";
            tbCtlrModelParams.SelectedIndex = 0;
            tbCtlrModelParams.Size = new Size(1261, 707);
            tbCtlrModelParams.TabIndex = 2;
            // 
            // tabSizes
            // 
            tabSizes.Controls.Add(splitContainer1);
            tabSizes.Location = new Point(8, 46);
            tabSizes.Margin = new Padding(5);
            tabSizes.Name = "tabSizes";
            tabSizes.Padding = new Padding(5);
            tabSizes.Size = new Size(1245, 653);
            tabSizes.TabIndex = 0;
            tabSizes.Text = "Размеры";
            tabSizes.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(5, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1235, 643);
            splitContainer1.SplitterDistance = 410;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(pbSketch);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer2.Size = new Size(821, 643);
            splitContainer2.SplitterDistance = 580;
            splitContainer2.TabIndex = 0;
            // 
            // pbSketch
            // 
            pbSketch.BorderStyle = BorderStyle.FixedSingle;
            pbSketch.Dock = DockStyle.Fill;
            pbSketch.Image = Properties.Resources.Oil_level_glass;
            pbSketch.Location = new Point(0, 0);
            pbSketch.Name = "pbSketch";
            pbSketch.Size = new Size(821, 580);
            pbSketch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSketch.TabIndex = 0;
            pbSketch.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(rbAssembly);
            flowLayoutPanel1.Controls.Add(rbHousing);
            flowLayoutPanel1.Controls.Add(rbGlass);
            flowLayoutPanel1.Controls.Add(rbRubberStrip);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(821, 59);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // rbAssembly
            // 
            rbAssembly.AutoSize = true;
            rbAssembly.Checked = true;
            rbAssembly.Location = new Point(20, 10);
            rbAssembly.Margin = new Padding(20, 10, 3, 3);
            rbAssembly.Name = "rbAssembly";
            rbAssembly.Size = new Size(250, 36);
            rbAssembly.TabIndex = 0;
            rbAssembly.TabStop = true;
            rbAssembly.Text = "Смотровой лючок";
            rbAssembly.UseVisualStyleBackColor = true;
            rbAssembly.CheckedChanged += rbSketch_CheckedChanged;
            // 
            // rbHousing
            // 
            rbHousing.AutoSize = true;
            rbHousing.Location = new Point(276, 10);
            rbHousing.Margin = new Padding(3, 10, 3, 3);
            rbHousing.Name = "rbHousing";
            rbHousing.Size = new Size(124, 36);
            rbHousing.TabIndex = 1;
            rbHousing.Text = "Корпус";
            rbHousing.UseVisualStyleBackColor = true;
            rbHousing.CheckedChanged += rbSketch_CheckedChanged;
            // 
            // rbGlass
            // 
            rbGlass.AutoSize = true;
            rbGlass.Location = new Point(406, 10);
            rbGlass.Margin = new Padding(3, 10, 3, 3);
            rbGlass.Name = "rbGlass";
            rbGlass.Size = new Size(112, 36);
            rbGlass.TabIndex = 2;
            rbGlass.Text = "Линза";
            rbGlass.UseVisualStyleBackColor = true;
            rbGlass.CheckedChanged += rbSketch_CheckedChanged;
            // 
            // rbRubberStrip
            // 
            rbRubberStrip.AutoSize = true;
            rbRubberStrip.Location = new Point(524, 10);
            rbRubberStrip.Margin = new Padding(3, 10, 3, 3);
            rbRubberStrip.Name = "rbRubberStrip";
            rbRubberStrip.Size = new Size(284, 36);
            rbRubberStrip.TabIndex = 3;
            rbRubberStrip.Text = "Резиновая прокладка";
            rbRubberStrip.UseVisualStyleBackColor = true;
            rbRubberStrip.CheckedChanged += rbSketch_CheckedChanged;
            // 
            // tabMaterials
            // 
            tabMaterials.Controls.Add(tlpMaterials);
            tabMaterials.Location = new Point(8, 46);
            tabMaterials.Margin = new Padding(5);
            tabMaterials.Name = "tabMaterials";
            tabMaterials.Padding = new Padding(5);
            tabMaterials.Size = new Size(1245, 653);
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
            tlpMaterials.Controls.Add(mcHousing, 0, 0);
            tlpMaterials.Controls.Add(materialChooser1, 1, 0);
            tlpMaterials.Controls.Add(materialChooser2, 2, 0);
            tlpMaterials.Dock = DockStyle.Fill;
            tlpMaterials.Location = new Point(5, 5);
            tlpMaterials.Margin = new Padding(5);
            tlpMaterials.Name = "tlpMaterials";
            tlpMaterials.RowCount = 1;
            tlpMaterials.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMaterials.Size = new Size(1235, 643);
            tlpMaterials.TabIndex = 0;
            // 
            // mcHousing
            // 
            mcHousing.Density = 0D;
            mcHousing.Dock = DockStyle.Fill;
            mcHousing.HatchStyle = 0;
            mcHousing.Header = "Корпус";
            mcHousing.Location = new Point(20, 3);
            mcHousing.Margin = new Padding(20, 3, 20, 3);
            mcHousing.MaterialTitle = null;
            mcHousing.Name = "mcHousing";
            mcHousing.Size = new Size(371, 637);
            mcHousing.TabIndex = 0;
            mcHousing.Load += materialChooser1_Load;
            // 
            // materialChooser1
            // 
            materialChooser1.Density = 0D;
            materialChooser1.Dock = DockStyle.Fill;
            materialChooser1.HatchStyle = 0;
            materialChooser1.Header = "Линза";
            materialChooser1.Location = new Point(431, 3);
            materialChooser1.Margin = new Padding(20, 3, 20, 3);
            materialChooser1.MaterialTitle = null;
            materialChooser1.Name = "materialChooser1";
            materialChooser1.Size = new Size(371, 637);
            materialChooser1.TabIndex = 1;
            // 
            // materialChooser2
            // 
            materialChooser2.Density = 0D;
            materialChooser2.Dock = DockStyle.Fill;
            materialChooser2.HatchStyle = 0;
            materialChooser2.Header = "Прокладка";
            materialChooser2.Location = new Point(842, 3);
            materialChooser2.Margin = new Padding(20, 3, 20, 3);
            materialChooser2.MaterialTitle = null;
            materialChooser2.Name = "materialChooser2";
            materialChooser2.Size = new Size(373, 637);
            materialChooser2.TabIndex = 2;
            // 
            // tabSaving
            // 
            tabSaving.Controls.Add(tableLayoutPanel1);
            tabSaving.Location = new Point(8, 46);
            tabSaving.Margin = new Padding(5);
            tabSaving.Name = "tabSaving";
            tabSaving.Size = new Size(1245, 653);
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
            tableLayoutPanel1.Controls.Add(savingParametersEditor1, 0, 0);
            tableLayoutPanel1.Controls.Add(savingParametersEditor2, 1, 0);
            tableLayoutPanel1.Controls.Add(savingParametersEditor3, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1245, 653);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // savingParametersEditor1
            // 
            savingParametersEditor1.Dock = DockStyle.Fill;
            savingParametersEditor1.FolderPath = "C:\\Users\\kargi\\OneDrive\\Документы";
            savingParametersEditor1.Header = "Корпус";
            savingParametersEditor1.Location = new Point(20, 3);
            savingParametersEditor1.Margin = new Padding(20, 3, 20, 3);
            savingParametersEditor1.Marking = null;
            savingParametersEditor1.Name = "savingParametersEditor1";
            savingParametersEditor1.Namimg = null;
            savingParametersEditor1.Size = new Size(375, 647);
            savingParametersEditor1.TabIndex = 0;
            // 
            // savingParametersEditor2
            // 
            savingParametersEditor2.Dock = DockStyle.Fill;
            savingParametersEditor2.FolderPath = "C:\\Users\\kargi\\OneDrive\\Документы";
            savingParametersEditor2.Header = "Линза";
            savingParametersEditor2.Location = new Point(435, 3);
            savingParametersEditor2.Margin = new Padding(20, 3, 20, 3);
            savingParametersEditor2.Marking = null;
            savingParametersEditor2.Name = "savingParametersEditor2";
            savingParametersEditor2.Namimg = null;
            savingParametersEditor2.Size = new Size(375, 647);
            savingParametersEditor2.TabIndex = 1;
            // 
            // savingParametersEditor3
            // 
            savingParametersEditor3.Dock = DockStyle.Fill;
            savingParametersEditor3.FolderPath = "C:\\Users\\kargi\\OneDrive\\Документы";
            savingParametersEditor3.Header = "Прокладка";
            savingParametersEditor3.Location = new Point(850, 3);
            savingParametersEditor3.Margin = new Padding(20, 3, 20, 3);
            savingParametersEditor3.Marking = null;
            savingParametersEditor3.Name = "savingParametersEditor3";
            savingParametersEditor3.Namimg = null;
            savingParametersEditor3.Size = new Size(375, 647);
            savingParametersEditor3.TabIndex = 2;
            // 
            // tabAppearance
            // 
            tabAppearance.Controls.Add(tableLayoutPanel2);
            tabAppearance.Location = new Point(8, 46);
            tabAppearance.Margin = new Padding(5);
            tabAppearance.Name = "tabAppearance";
            tabAppearance.Size = new Size(1245, 653);
            tabAppearance.TabIndex = 3;
            tabAppearance.Text = "Отображение";
            tabAppearance.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(appeareanceEditor3, 2, 0);
            tableLayoutPanel2.Controls.Add(appeareanceEditor2, 1, 0);
            tableLayoutPanel2.Controls.Add(appeareanceEditor1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1245, 653);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // appeareanceEditor3
            // 
            appeareanceEditor3.Color = Color.Transparent;
            appeareanceEditor3.Diffusion = 0;
            appeareanceEditor3.Dock = DockStyle.Fill;
            appeareanceEditor3.Embient = 0;
            appeareanceEditor3.Emission = 0;
            appeareanceEditor3.Header = "Прокладка";
            appeareanceEditor3.Location = new Point(840, 3);
            appeareanceEditor3.Margin = new Padding(10, 3, 10, 3);
            appeareanceEditor3.Name = "appeareanceEditor3";
            appeareanceEditor3.Shininess = 0;
            appeareanceEditor3.Size = new Size(395, 647);
            appeareanceEditor3.Specularity = 0;
            appeareanceEditor3.TabIndex = 2;
            appeareanceEditor3.Transparency = 0;
            // 
            // appeareanceEditor2
            // 
            appeareanceEditor2.Color = Color.Transparent;
            appeareanceEditor2.Diffusion = 0;
            appeareanceEditor2.Dock = DockStyle.Fill;
            appeareanceEditor2.Embient = 0;
            appeareanceEditor2.Emission = 0;
            appeareanceEditor2.Header = "Линза";
            appeareanceEditor2.Location = new Point(425, 3);
            appeareanceEditor2.Margin = new Padding(10, 3, 10, 3);
            appeareanceEditor2.Name = "appeareanceEditor2";
            appeareanceEditor2.Shininess = 0;
            appeareanceEditor2.Size = new Size(395, 647);
            appeareanceEditor2.Specularity = 0;
            appeareanceEditor2.TabIndex = 1;
            appeareanceEditor2.Transparency = 0;
            // 
            // appeareanceEditor1
            // 
            appeareanceEditor1.Color = Color.Transparent;
            appeareanceEditor1.Diffusion = 0;
            appeareanceEditor1.Dock = DockStyle.Fill;
            appeareanceEditor1.Embient = 0;
            appeareanceEditor1.Emission = 0;
            appeareanceEditor1.Header = "Корпус";
            appeareanceEditor1.Location = new Point(10, 3);
            appeareanceEditor1.Margin = new Padding(10, 3, 10, 3);
            appeareanceEditor1.Name = "appeareanceEditor1";
            appeareanceEditor1.Shininess = 0;
            appeareanceEditor1.Size = new Size(395, 647);
            appeareanceEditor1.Specularity = 0;
            appeareanceEditor1.TabIndex = 0;
            appeareanceEditor1.Transparency = 0;
            // 
            // Wizard3dForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btCancel;
            ClientSize = new Size(1300, 832);
            Controls.Add(tbCtlrModelParams);
            Controls.Add(btCancel);
            Controls.Add(btOk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Wizard3dForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Мастер 3d модели";
            tbCtlrModelParams.ResumeLayout(false);
            tabSizes.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSketch).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tabMaterials.ResumeLayout(false);
            tlpMaterials.ResumeLayout(false);
            tabSaving.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tabAppearance.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
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
        private Controls.MaterialChooser mcHousing;
        private Controls.MaterialChooser materialChooser1;
        private Controls.MaterialChooser materialChooser2;
        private TableLayoutPanel tableLayoutPanel1;
        private Controls.SavingParametersEditor savingParametersEditor1;
        private Controls.SavingParametersEditor savingParametersEditor2;
        private Controls.SavingParametersEditor savingParametersEditor3;
        private TableLayoutPanel tableLayoutPanel2;
        private Controls.AppeareanceEditor appeareanceEditor1;
        private Controls.AppeareanceEditor appeareanceEditor3;
        private Controls.AppeareanceEditor appeareanceEditor2;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private PictureBox pbSketch;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton rbAssembly;
        private RadioButton rbHousing;
        private RadioButton rbGlass;
        private RadioButton rbRubberStrip;
    }
}