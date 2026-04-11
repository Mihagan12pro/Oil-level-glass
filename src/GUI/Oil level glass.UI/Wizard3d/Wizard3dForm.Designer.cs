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
            tabAppearance = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            tabSaving = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabMaterials = new TabPage();
            tlpMaterials = new TableLayoutPanel();
            tabSizes = new TabPage();
            splitSizes = new SplitContainer();
            tvParts = new TreeView();
            pbSketch = new PictureBox();
            tbCtlrModelParams = new TabControl();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.SuspendLayout();
            tabAppearance.SuspendLayout();
            tabSaving.SuspendLayout();
            tabMaterials.SuspendLayout();
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
            btOk.Enabled = false;
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
            // tabAppearance
            // 
            tabAppearance.Controls.Add(tableLayoutPanel2);
            tabAppearance.Location = new Point(8, 46);
            tabAppearance.Margin = new Padding(5);
            tabAppearance.Name = "tabAppearance";
            tabAppearance.Size = new Size(1305, 804);
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
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1305, 804);
            tableLayoutPanel2.TabIndex = 0;
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
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1305, 804);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tabMaterials
            // 
            tabMaterials.Controls.Add(tlpMaterials);
            tabMaterials.Location = new Point(8, 46);
            tabMaterials.Margin = new Padding(5);
            tabMaterials.Name = "tabMaterials";
            tabMaterials.Padding = new Padding(5);
            tabMaterials.Size = new Size(1305, 804);
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
            tlpMaterials.Dock = DockStyle.Fill;
            tlpMaterials.Location = new Point(5, 5);
            tlpMaterials.Margin = new Padding(5);
            tlpMaterials.Name = "tlpMaterials";
            tlpMaterials.RowCount = 1;
            tlpMaterials.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMaterials.Size = new Size(1295, 794);
            tlpMaterials.TabIndex = 0;
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
            splitSizes.SplitterDistance = 431;
            splitSizes.SplitterWidth = 6;
            splitSizes.TabIndex = 0;
            // 
            // tvParts
            // 
            tvParts.Dock = DockStyle.Fill;
            tvParts.Location = new Point(0, 0);
            tvParts.Margin = new Padding(5);
            tvParts.Name = "tvParts";
            tvParts.Size = new Size(427, 790);
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
            pbSketch.Size = new Size(854, 790);
            pbSketch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSketch.TabIndex = 0;
            pbSketch.TabStop = false;
            // 
            // tbCtlrModelParams
            // 
            tbCtlrModelParams.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbCtlrModelParams.Controls.Add(tabSizes);
            tbCtlrModelParams.Controls.Add(tabMaterials);
            tbCtlrModelParams.Controls.Add(tabSaving);
            tbCtlrModelParams.Controls.Add(tabAppearance);
            tbCtlrModelParams.Location = new Point(20, 3);
            tbCtlrModelParams.Margin = new Padding(5);
            tbCtlrModelParams.Name = "tbCtlrModelParams";
            tbCtlrModelParams.SelectedIndex = 0;
            tbCtlrModelParams.Size = new Size(1321, 858);
            tbCtlrModelParams.TabIndex = 2;
            // 
            // Wizard3dForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btCancel;
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
            tabAppearance.ResumeLayout(false);
            tabSaving.ResumeLayout(false);
            tabMaterials.ResumeLayout(false);
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
        private TabPage tabAppearance;
        private TableLayoutPanel tableLayoutPanel2;
        private TabPage tabSaving;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabMaterials;
        private TableLayoutPanel tlpMaterials;
        private TabPage tabSizes;
        private SplitContainer splitSizes;
        private TreeView tvParts;
        private PictureBox pbSketch;
        private TabControl tbCtlrModelParams;
    }
}