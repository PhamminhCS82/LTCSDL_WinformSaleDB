
namespace BTN_LTCSDL
{
    partial class FMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qlSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlDHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlKHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qlSPToolStripMenuItem,
            this.qlDHToolStripMenuItem,
            this.qlNVToolStripMenuItem,
            this.qlKHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qlSPToolStripMenuItem
            // 
            this.qlSPToolStripMenuItem.Name = "qlSPToolStripMenuItem";
            this.qlSPToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.qlSPToolStripMenuItem.Text = "Quản lý sản phẩm";
            this.qlSPToolStripMenuItem.Click += new System.EventHandler(this.qlSPToolStripMenuItem_Click);
            // 
            // qlDHToolStripMenuItem
            // 
            this.qlDHToolStripMenuItem.Name = "qlDHToolStripMenuItem";
            this.qlDHToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.qlDHToolStripMenuItem.Text = "Quản lý đơn hàng";
            this.qlDHToolStripMenuItem.Click += new System.EventHandler(this.qlDHToolStripMenuItem_Click);
            // 
            // qlNVToolStripMenuItem
            // 
            this.qlNVToolStripMenuItem.Name = "qlNVToolStripMenuItem";
            this.qlNVToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.qlNVToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // qlKHToolStripMenuItem
            // 
            this.qlKHToolStripMenuItem.Name = "qlKHToolStripMenuItem";
            this.qlKHToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.qlKHToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qlSPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qlDHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qlNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qlKHToolStripMenuItem;
    }
}

