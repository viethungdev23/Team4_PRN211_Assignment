namespace SaleManagement.winform
{
    partial class frmMain
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.mFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.mMemberManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mProductManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mOrderManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 30);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(914, 51);
            this.tabMain.TabIndex = 2;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // mFunction
            // 
            this.mFunction.Checked = true;
            this.mFunction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMemberManagement,
            this.mProductManagement,
            this.mOrderManagement});
            this.mFunction.Name = "mFunction";
            this.mFunction.Size = new System.Drawing.Size(60, 24);
            this.mFunction.Text = "&Menu";
            // 
            // mMemberManagement
            // 
            this.mMemberManagement.Name = "mMemberManagement";
            this.mMemberManagement.Size = new System.Drawing.Size(240, 26);
            this.mMemberManagement.Text = "&Member Management";
            this.mMemberManagement.Click += new System.EventHandler(this.mMemberManagement_Click);
            // 
            // mProductManagement
            // 
            this.mProductManagement.Name = "mProductManagement";
            this.mProductManagement.Size = new System.Drawing.Size(240, 26);
            this.mProductManagement.Text = "&Product Management";
            this.mProductManagement.Click += new System.EventHandler(this.mProductManagement_Click);
            // 
            // mOrderManagement
            // 
            this.mOrderManagement.Name = "mOrderManagement";
            this.mOrderManagement.Size = new System.Drawing.Size(240, 26);
            this.mOrderManagement.Text = "&Order Management";
            this.mOrderManagement.Click += new System.EventHandler(this.mOrderManagement_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFunction,
            this.Logout});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(914, 30);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Logout
            // 
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(70, 24);
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TabControl tabMain;
        private ToolStripMenuItem mFunction;
        private ToolStripMenuItem mMemberManagement;
        private ToolStripMenuItem mProductManagement;
        private ToolStripMenuItem mOrderManagement;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem Logout;
    }
}