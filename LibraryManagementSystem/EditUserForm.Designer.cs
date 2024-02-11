namespace LibraryManagementSystem
{
    partial class EditUserForm
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
            lblUserRoleError = new Label();
            lblEmailError = new Label();
            lblUserNameError = new Label();
            cbo2 = new ComboBox();
            txtEmail = new TextBox();
            txtUserName = new TextBox();
            lblUserRole = new Label();
            lblEmail = new Label();
            lblUserName = new Label();
            cbo1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(lblUserRoleError);
            panel1.Controls.Add(lblEmailError);
            panel1.Controls.Add(lblUserNameError);
            panel1.Controls.Add(cbo2);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(lblUserRole);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(cbo1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 510);
            panel1.TabIndex = 0;
            // 
            // lblUserRoleError
            // 
            lblUserRoleError.AutoSize = true;
            lblUserRoleError.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserRoleError.ForeColor = Color.Red;
            lblUserRoleError.Location = new Point(487, 397);
            lblUserRoleError.Name = "lblUserRoleError";
            lblUserRoleError.Size = new Size(140, 19);
            lblUserRoleError.TabIndex = 24;
            lblUserRoleError.Text = "Please fill this field.";
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(487, 319);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(140, 19);
            lblEmailError.TabIndex = 23;
            lblEmailError.Text = "Please fill this field.";
            // 
            // lblUserNameError
            // 
            lblUserNameError.AutoSize = true;
            lblUserNameError.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserNameError.ForeColor = Color.Red;
            lblUserNameError.Location = new Point(484, 244);
            lblUserNameError.Name = "lblUserNameError";
            lblUserNameError.Size = new Size(140, 19);
            lblUserNameError.TabIndex = 22;
            lblUserNameError.Text = "Please fill this field.";
            // 
            // cbo2
            // 
            cbo2.FormattingEnabled = true;
            cbo2.Items.AddRange(new object[] { "member", "admin" });
            cbo2.Location = new Point(487, 371);
            cbo2.Name = "cbo2";
            cbo2.Size = new Size(234, 23);
            cbo2.TabIndex = 21;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(487, 293);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 23);
            txtEmail.TabIndex = 20;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(487, 218);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(234, 23);
            txtUserName.TabIndex = 19;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserRole.Location = new Point(252, 366);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(110, 25);
            lblUserRole.TabIndex = 18;
            lblUserRole.Text = "User Role: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(252, 293);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(74, 25);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email: ";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(252, 218);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(121, 25);
            lblUserName.TabIndex = 16;
            lblUserName.Text = "User Name: ";
            // 
            // cbo1
            // 
            cbo1.FormattingEnabled = true;
            cbo1.Location = new Point(487, 147);
            cbo1.Name = "cbo1";
            cbo1.Size = new Size(234, 23);
            cbo1.TabIndex = 6;
            cbo1.SelectedIndexChanged += cbo1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(249, 145);
            label2.Name = "label2";
            label2.Size = new Size(214, 25);
            label2.TabIndex = 5;
            label2.Text = "Search by User Name: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(364, 17);
            label1.Name = "label1";
            label1.Size = new Size(300, 75);
            label1.TabIndex = 4;
            label1.Text = "Edit User";
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 525);
            Controls.Add(panel1);
            Name = "EditUserForm";
            Text = "EditUserForm";
            FormClosed += EditUserForm_FormClosed;
            Load += EditUserForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cbo1;
        private Label label2;
        private Label lblUserRoleError;
        private Label lblEmailError;
        private Label lblUserNameError;
        private ComboBox cbo2;
        private TextBox txtEmail;
        private TextBox txtUserName;
        private Label lblUserRole;
        private Label lblEmail;
        private Label lblUserName;
    }
}