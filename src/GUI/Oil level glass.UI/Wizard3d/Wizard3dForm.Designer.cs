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
            mcHousing = new Oil_level_glass.UI.Controls.MaterialChooser();
            materialChooser1 = new Oil_level_glass.UI.Controls.MaterialChooser();
            materialChooser2 = new Oil_level_glass.UI.Controls.MaterialChooser();
            tabSaving = new TabPage();
            tabAppearance = new TabPage();
            tbCtlrModelParams.SuspendLayout();
            tabMaterials.SuspendLayout();
            tlpMaterials.SuspendLayout();
            SuspendLayout();
            // 
            // btOk
            // 
            btOk.Location = new Point(942, 654);
            btOk.Margin = new Padding(5);
            btOk.Name = "btOk";
            btOk.Size = new Size(153, 46);
            btOk.TabIndex = 0;
            btOk.Text = "Ок";
            btOk.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(1128, 654);
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
            tbCtlrModelParams.Size = new Size(1261, 642);
            tbCtlrModelParams.TabIndex = 2;
            // 
            // tabSizes
            // 
            tabSizes.Location = new Point(8, 46);
            tabSizes.Margin = new Padding(5);
            tabSizes.Name = "tabSizes";
            tabSizes.Padding = new Padding(5);
            tabSizes.Size = new Size(1245, 588);
            tabSizes.TabIndex = 0;
            tabSizes.Text = "Размеры";
            tabSizes.UseVisualStyleBackColor = true;
            // 
            // tabMaterials
            // 
            tabMaterials.Controls.Add(tlpMaterials);
            tabMaterials.Location = new Point(8, 46);
            tabMaterials.Margin = new Padding(5);
            tabMaterials.Name = "tabMaterials";
            tabMaterials.Padding = new Padding(5);
            tabMaterials.Size = new Size(1245, 588);
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
            tlpMaterials.Size = new Size(1235, 578);
            tlpMaterials.TabIndex = 0;
            // 
            // mcHousing
            // 
            mcHousing.Density = 0D;
            mcHousing.HatchStyle = 0;
            mcHousing.Header = "Корпус";
            mcHousing.Location = new Point(20, 3);
            mcHousing.Margin = new Padding(20, 3, 20, 3);
            mcHousing.MaterialTitle = null;
            mcHousing.Name = "mcHousing";
            mcHousing.Size = new Size(371, 572);
            mcHousing.TabIndex = 0;
            mcHousing.Load += materialChooser1_Load;
            // 
            // materialChooser1
            // 
            materialChooser1.Density = 0D;
            materialChooser1.HatchStyle = 0;
            materialChooser1.Header = "Линза";
            materialChooser1.Location = new Point(431, 3);
            materialChooser1.Margin = new Padding(20, 3, 20, 3);
            materialChooser1.MaterialTitle = null;
            materialChooser1.Name = "materialChooser1";
            materialChooser1.Size = new Size(371, 572);
            materialChooser1.TabIndex = 1;
            // 
            // materialChooser2
            // 
            materialChooser2.Density = 0D;
            materialChooser2.HatchStyle = 0;
            materialChooser2.Header = "Прокладка";
            materialChooser2.Location = new Point(842, 3);
            materialChooser2.Margin = new Padding(20, 3, 20, 3);
            materialChooser2.MaterialTitle = null;
            materialChooser2.Name = "materialChooser2";
            materialChooser2.Size = new Size(373, 572);
            materialChooser2.TabIndex = 2;
            // 
            // tabSaving
            // 
            tabSaving.Location = new Point(8, 46);
            tabSaving.Margin = new Padding(5);
            tabSaving.Name = "tabSaving";
            tabSaving.Size = new Size(1245, 588);
            tabSaving.TabIndex = 2;
            tabSaving.Text = "Сохранение";
            tabSaving.UseVisualStyleBackColor = true;
            // 
            // tabAppearance
            // 
            tabAppearance.Location = new Point(8, 46);
            tabAppearance.Margin = new Padding(5);
            tabAppearance.Name = "tabAppearance";
            tabAppearance.Size = new Size(1245, 588);
            tabAppearance.TabIndex = 3;
            tabAppearance.Text = "Вид";
            tabAppearance.UseVisualStyleBackColor = true;
            // 
            // Wizard3dForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btCancel;
            ClientSize = new Size(1300, 720);
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
            tabMaterials.ResumeLayout(false);
            tlpMaterials.ResumeLayout(false);
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
    }
}