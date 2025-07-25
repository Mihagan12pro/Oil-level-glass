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
            TreeNode treeNode1 = new TreeNode("Корпус");
            TreeNode treeNode2 = new TreeNode("Стекло");
            TreeNode treeNode3 = new TreeNode("Кольцо");
            TreeNode treeNode4 = new TreeNode("Смотровой лючок", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            splitContainer1 = new SplitContainer();
            mainFormLeftPanel = new Panel();
            leftPanelTreeView = new TreeView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            mainFormLeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(mainFormLeftPanel);
            splitContainer1.Panel1.SizeChanged += splitContainer1_Panel1_SizeChanged;
            splitContainer1.Size = new Size(579, 528);
            splitContainer1.SplitterDistance = 193;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // mainFormLeftPanel
            // 
            mainFormLeftPanel.Controls.Add(leftPanelTreeView);
            mainFormLeftPanel.Location = new Point(3, 2);
            mainFormLeftPanel.Name = "mainFormLeftPanel";
            mainFormLeftPanel.Size = new Size(186, 525);
            mainFormLeftPanel.TabIndex = 0;
            // 
            // leftPanelTreeView
            // 
            leftPanelTreeView.BackColor = SystemColors.ButtonFace;
            leftPanelTreeView.BorderStyle = BorderStyle.None;
            leftPanelTreeView.Indent = 30;
            leftPanelTreeView.ItemHeight = 20;
            leftPanelTreeView.Location = new Point(5, 10);
            leftPanelTreeView.Margin = new Padding(3, 30, 3, 30);
            leftPanelTreeView.Name = "leftPanelTreeView";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Корпус";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Стекло";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Кольцо";
            treeNode4.Name = "oilGlassNode";
            treeNode4.Text = "Смотровой лючок";
            leftPanelTreeView.Nodes.AddRange(new TreeNode[] { treeNode4 });
            leftPanelTreeView.Size = new Size(163, 504);
            leftPanelTreeView.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(579, 528);
            Controls.Add(splitContainer1);
            Font = new Font("Calibri", 9F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Смотровой лючок";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            mainFormLeftPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel mainFormLeftPanel;
        private TreeView leftPanelTreeView;
    }
}
