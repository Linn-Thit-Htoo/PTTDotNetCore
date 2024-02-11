namespace LibraryManagementSystem
{
    partial class Form1
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
            panel1 = new Panel();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-153, 27);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1362, 755);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Cyan;
            btnLogin.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(823, 370);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 37);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(545, 300);
            label3.Name = "label3";
            label3.Size = new Size(115, 26);
            label3.TabIndex = 10;
            label3.Text = "Password: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(545, 230);
            label2.Name = "label2";
            label2.Size = new Size(77, 26);
            label2.TabIndex = 9;
            label2.Text = "Email: ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(712, 300);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(237, 23);
            txtPassword.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(712, 230);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 23);
            txtEmail.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(648, 64);
            label1.Name = "label1";
            label1.Size = new Size(195, 75);
            label1.TabIndex = 6;
            label1.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 791);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(600, 800);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label1;
    }
}