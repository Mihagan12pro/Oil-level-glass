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
            button1 = new Button();
            splitSizes = new SplitContainer();
            btConfigPart = new Button();
            tvParts = new TreeView();
            pbSketch = new PictureBox();
            menuStrip1 = new MenuStrip();
            tspmFile = new ToolStripMenuItem();
            tspmFolder = new ToolStripMenuItem();
            tspmNaming = new ToolStripMenuItem();
            tspmView = new ToolStripMenuItem();
            tspmModelView = new ToolStripMenuItem();
            tspmModelMaterial = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitSizes).BeginInit();
            splitSizes.Panel1.SuspendLayout();
            splitSizes.Panel2.SuspendLayout();
            splitSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSketch).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btOk
            // 
            btOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btOk.Location = new Point(1180, 928);
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
            btCancel.Location = new Point(991, 928);
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
            // button1
            // 
            button1.Location = new Point(287, 972);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // splitSizes
            // 
            splitSizes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitSizes.BorderStyle = BorderStyle.Fixed3D;
            splitSizes.Location = new Point(0, 45);
            splitSizes.Margin = new Padding(5);
            splitSizes.Name = "splitSizes";
            // 
            // splitSizes.Panel1
            // 
            splitSizes.Panel1.Controls.Add(btConfigPart);
            splitSizes.Panel1.Controls.Add(tvParts);
            // 
            // splitSizes.Panel2
            // 
            splitSizes.Panel2.Controls.Add(pbSketch);
            splitSizes.Size = new Size(1360, 862);
            splitSizes.SplitterDistance = 450;
            splitSizes.SplitterWidth = 6;
            splitSizes.TabIndex = 4;
            // 
            // btConfigPart
            // 
            btConfigPart.Dock = DockStyle.Bottom;
            btConfigPart.Enabled = false;
            btConfigPart.Location = new Point(0, 812);
            btConfigPart.Name = "btConfigPart";
            btConfigPart.Size = new Size(446, 46);
            btConfigPart.TabIndex = 1;
            btConfigPart.Text = "Конфигурировать...";
            btConfigPart.UseVisualStyleBackColor = true;
            btConfigPart.Click += btConfigPart_Click;
            // 
            // tvParts
            // 
            tvParts.Dock = DockStyle.Fill;
            tvParts.Location = new Point(0, 0);
            tvParts.Margin = new Padding(5);
            tvParts.Name = "tvParts";
            tvParts.Size = new Size(446, 858);
            tvParts.TabIndex = 0;
            // 
            // pbSketch
            // 
            pbSketch.Dock = DockStyle.Fill;
            pbSketch.Image = Properties.Resources.Oil_level_glass_Img;
            pbSketch.Location = new Point(0, 0);
            pbSketch.Margin = new Padding(5);
            pbSketch.Name = "pbSketch";
            pbSketch.Size = new Size(900, 858);
            pbSketch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSketch.TabIndex = 0;
            pbSketch.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tspmFile, tspmView });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1360, 40);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // tspmFile
            // 
            tspmFile.DropDownItems.AddRange(new ToolStripItem[] { tspmFolder, tspmNaming });
            tspmFile.Name = "tspmFile";
            tspmFile.Size = new Size(90, 36);
            tspmFile.Text = "Файл";
            // 
            // tspmFolder
            // 
            tspmFolder.Name = "tspmFolder";
            tspmFolder.Size = new Size(229, 44);
            tspmFolder.Text = "Папка...";
            // 
            // tspmNaming
            // 
            tspmNaming.Name = "tspmNaming";
            tspmNaming.Size = new Size(229, 44);
            tspmNaming.Text = "Имя...";
            // 
            // tspmView
            // 
            tspmView.DropDownItems.AddRange(new ToolStripItem[] { tspmModelView, tspmModelMaterial });
            tspmView.Name = "tspmView";
            tspmView.Size = new Size(75, 36);
            tspmView.Text = "Вид";
            // 
            // tspmModelView
            // 
            tspmModelView.Name = "tspmModelView";
            tspmModelView.Size = new Size(359, 44);
            tspmModelView.Text = "Вид модели...";
            // 
            // tspmModelMaterial
            // 
            tspmModelMaterial.Name = "tspmModelMaterial";
            tspmModelMaterial.Size = new Size(359, 44);
            tspmModelMaterial.Text = "Выбор материала...";
            // 
            // Wizard3dForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 988);
            Controls.Add(splitSizes);
            Controls.Add(button1);
            Controls.Add(btCancel);
            Controls.Add(btOk);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Wizard3dForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Мастер 3d модели";
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitSizes.Panel1.ResumeLayout(false);
            splitSizes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitSizes).EndInit();
            splitSizes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSketch).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btOk;
        private Button btCancel;
        private Controls.MaterialChooser mcHousing;
        private Controls.MaterialChooser materialChooser1;
        private Controls.MaterialChooser materialChooser2;
        private Controls.AppeareanceEditor appeareanceEditor1;
        private Controls.AppeareanceEditor appeareanceEditor3;
        private Controls.AppeareanceEditor appeareanceEditor2;
        private SplitContainer splitContainer2;
        private Controls.SavingParametersEditor savingParametersEditor4;
        private Controls.SavingParametersEditor savingParametersEditor5;
        private Controls.SavingParametersEditor savingParametersEditor6;
        private Button button1;
        private SplitContainer splitSizes;
        private Button btConfigPart;
        private TreeView tvParts;
        private PictureBox pbSketch;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem tspmFolder;
        private ToolStripMenuItem tspmNaming;
        private ToolStripMenuItem tspmView;
        private ToolStripMenuItem tspmModelView;
        private ToolStripMenuItem tspmFile;
        private ToolStripMenuItem tspmModelMaterial;
    }
}