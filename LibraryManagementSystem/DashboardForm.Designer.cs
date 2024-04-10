namespace LibraryManagementSystem
{
    partial class DashboardForm
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
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            msUserManagement = new ToolStripMenuItem();
            msCategoryManagement = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 507);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { msUserManagement, msCategoryManagement });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(823, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // msUserManagement
            // 
            msUserManagement.Name = "msUserManagement";
            msUserManagement.Size = new Size(144, 24);
            msUserManagement.Text = "User Management";
            msUserManagement.Click += msUserManagement_Click;
            // 
            // msCategoryManagement
            // 
            msCategoryManagement.Name = "msCategoryManagement";
            msCategoryManagement.Size = new Size(175, 24);
            msCategoryManagement.Text = "Category Management";
            msCategoryManagement.Click += msCategoryManagement_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 508);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "DashboardForm";
            Text = "DashboardForm";
            FormClosed += DashboardForm_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem msUserManagement;
        private ToolStripMenuItem msCategoryManagement;
    }
}