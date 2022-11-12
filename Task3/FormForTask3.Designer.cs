namespace WinForms_DZ3.Task3
{
    partial class FormForTask3
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
            this.SubItem = new System.Windows.Forms.TextBox();
            this.TopLevelMenu = new System.Windows.Forms.TextBox();
            this.btAddMenuItem = new System.Windows.Forms.Button();
            this.btAddSubmenu = new System.Windows.Forms.Button();
            this.gbAddMenu = new System.Windows.Forms.GroupBox();
            this.gbAddSubMenu = new System.Windows.Forms.GroupBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.gbAddMenu.SuspendLayout();
            this.gbAddSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubItem
            // 
            this.SubItem.Location = new System.Drawing.Point(22, 35);
            this.SubItem.Name = "SubItem";
            this.SubItem.Size = new System.Drawing.Size(147, 23);
            this.SubItem.TabIndex = 0;
            // 
            // TopLevelMenu
            // 
            this.TopLevelMenu.Location = new System.Drawing.Point(25, 35);
            this.TopLevelMenu.Name = "TopLevelMenu";
            this.TopLevelMenu.Size = new System.Drawing.Size(150, 23);
            this.TopLevelMenu.TabIndex = 1;
            // 
            // btAddMenuItem
            // 
            this.btAddMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAddMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddMenuItem.Location = new System.Drawing.Point(63, 88);
            this.btAddMenuItem.Name = "btAddMenuItem";
            this.btAddMenuItem.Size = new System.Drawing.Size(75, 51);
            this.btAddMenuItem.TabIndex = 2;
            this.btAddMenuItem.Text = "Add menu item";
            this.btAddMenuItem.UseVisualStyleBackColor = false;
            this.btAddMenuItem.Click += new System.EventHandler(this.btAddMenuItem_Click);
            // 
            // btAddSubmenu
            // 
            this.btAddSubmenu.BackColor = System.Drawing.Color.IndianRed;
            this.btAddSubmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddSubmenu.Location = new System.Drawing.Point(62, 88);
            this.btAddSubmenu.Name = "btAddSubmenu";
            this.btAddSubmenu.Size = new System.Drawing.Size(75, 51);
            this.btAddSubmenu.TabIndex = 3;
            this.btAddSubmenu.Text = "Add submenu";
            this.btAddSubmenu.UseVisualStyleBackColor = false;
            this.btAddSubmenu.Click += new System.EventHandler(this.btAddSubmenu_Click);
            // 
            // gbAddMenu
            // 
            this.gbAddMenu.Controls.Add(this.SubItem);
            this.gbAddMenu.Controls.Add(this.btAddSubmenu);
            this.gbAddMenu.Location = new System.Drawing.Point(237, 106);
            this.gbAddMenu.Name = "gbAddMenu";
            this.gbAddMenu.Size = new System.Drawing.Size(200, 191);
            this.gbAddMenu.TabIndex = 4;
            this.gbAddMenu.TabStop = false;
            this.gbAddMenu.Text = "Add submenu:";
            // 
            // gbAddSubMenu
            // 
            this.gbAddSubMenu.Controls.Add(this.TopLevelMenu);
            this.gbAddSubMenu.Controls.Add(this.btAddMenuItem);
            this.gbAddSubMenu.Location = new System.Drawing.Point(12, 106);
            this.gbAddSubMenu.Name = "gbAddSubMenu";
            this.gbAddSubMenu.Size = new System.Drawing.Size(200, 191);
            this.gbAddSubMenu.TabIndex = 5;
            this.gbAddSubMenu.TabStop = false;
            this.gbAddSubMenu.Text = "Add menu item:";
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(450, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(450, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // FormForTask3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 324);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbAddSubMenu);
            this.Controls.Add(this.gbAddMenu);
            this.Controls.Add(this.menuStrip);
            this.Name = "FormForTask3";
            this.Text = "FormForTask3";
            this.gbAddMenu.ResumeLayout(false);
            this.gbAddMenu.PerformLayout();
            this.gbAddSubMenu.ResumeLayout(false);
            this.gbAddSubMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SubItem;
        private TextBox TopLevelMenu;
        private Button btAddMenuItem;
        private Button btAddSubmenu;
        private GroupBox gbAddMenu;
        private GroupBox gbAddSubMenu;
        private MenuStrip menuStrip;
        private ToolStrip toolStrip1;
    }
}