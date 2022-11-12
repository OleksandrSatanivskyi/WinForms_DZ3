namespace WinForms_DZ3.Task2
{
    partial class Explorer
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
            this.DiskTree = new System.Windows.Forms.ListBox();
            this.tbAddressLine = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FolderContents = new System.Windows.Forms.ListBox();
            this.lbDiskTree = new System.Windows.Forms.Label();
            this.lbFolderContents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DiskTree
            // 
            this.DiskTree.FormattingEnabled = true;
            this.DiskTree.ItemHeight = 15;
            this.DiskTree.Location = new System.Drawing.Point(53, 166);
            this.DiskTree.Name = "DiskTree";
            this.DiskTree.Size = new System.Drawing.Size(185, 229);
            this.DiskTree.TabIndex = 0;
            this.DiskTree.DoubleClick += new System.EventHandler(this.DiskTree_DoubleClick);
            // 
            // tbAddressLine
            // 
            this.tbAddressLine.Location = new System.Drawing.Point(53, 67);
            this.tbAddressLine.Name = "tbAddressLine";
            this.tbAddressLine.Size = new System.Drawing.Size(408, 23);
            this.tbAddressLine.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FolderContents
            // 
            this.FolderContents.FormattingEnabled = true;
            this.FolderContents.ItemHeight = 15;
            this.FolderContents.Location = new System.Drawing.Point(276, 166);
            this.FolderContents.Name = "FolderContents";
            this.FolderContents.Size = new System.Drawing.Size(185, 229);
            this.FolderContents.TabIndex = 4;
            // 
            // lbDiskTree
            // 
            this.lbDiskTree.AutoSize = true;
            this.lbDiskTree.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDiskTree.Location = new System.Drawing.Point(103, 131);
            this.lbDiskTree.Name = "lbDiskTree";
            this.lbDiskTree.Size = new System.Drawing.Size(67, 20);
            this.lbDiskTree.TabIndex = 5;
            this.lbDiskTree.Text = "Disk tree";
            // 
            // lbFolderContents
            // 
            this.lbFolderContents.AutoSize = true;
            this.lbFolderContents.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFolderContents.Location = new System.Drawing.Point(288, 131);
            this.lbFolderContents.Name = "lbFolderContents";
            this.lbFolderContents.Size = new System.Drawing.Size(154, 20);
            this.lbFolderContents.TabIndex = 6;
            this.lbFolderContents.Text = "Contents of the folder";
            // 
            // Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 440);
            this.Controls.Add(this.lbFolderContents);
            this.Controls.Add(this.lbDiskTree);
            this.Controls.Add(this.FolderContents);
            this.Controls.Add(this.tbAddressLine);
            this.Controls.Add(this.DiskTree);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Explorer";
            this.Text = "Explorer";
            this.Load += new System.EventHandler(this.Explorer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox DiskTree;
        private TextBox tbAddressLine;
        private MenuStrip menuStrip1;
        private ListBox FolderContents;
        private Label lbDiskTree;
        private Label lbFolderContents;
    }
}