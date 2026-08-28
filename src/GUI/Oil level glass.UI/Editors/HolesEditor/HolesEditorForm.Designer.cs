namespace Oil_level_glass.UI.Editors.Housing.HolesEditor
{
    partial class HolesEditorForm
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
            TreeNode treeNode1 = new TreeNode("Количество");
            TreeNode treeNode2 = new TreeNode("Размеры");
            TreeNode treeNode3 = new TreeNode("Параметры", new TreeNode[] { treeNode1, treeNode2 });
            tableLayoutPanel1 = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            tvHolesParams = new TreeView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(839, 462);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvHolesParams);
            splitContainer1.Size = new Size(833, 456);
            splitContainer1.SplitterDistance = 184;
            splitContainer1.TabIndex = 3;
            // 
            // tvHolesParams
            // 
            tvHolesParams.Dock = DockStyle.Fill;
            tvHolesParams.Location = new Point(0, 0);
            tvHolesParams.Name = "tvHolesParams";
            treeNode1.Name = "nodeCount";
            treeNode1.Text = "Количество";
            treeNode2.Name = "nodeSizes";
            treeNode2.Text = "Размеры";
            treeNode3.Name = "nodeParams";
            treeNode3.Text = "Параметры";
            tvHolesParams.Nodes.AddRange(new TreeNode[] { treeNode3 });
            tvHolesParams.Size = new Size(180, 452);
            tvHolesParams.TabIndex = 0;
            // 
            // HolesEditorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 462);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HolesEditorForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Редактор отверстий";
            tableLayoutPanel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer1;
        private TreeView tvHolesParams;
    }
}