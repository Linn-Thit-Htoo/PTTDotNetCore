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
            btnBack = new Button();
            txtUserId = new TextBox();
            lblUserId = new Label();
            btnUpdate = new Button();
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
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(txtUserId);
            panel1.Controls.Add(lblUserId);
            panel1.Controls.Add(btnUpdate);
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
            panel1.Location = new Point(7, 9);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1162, 721);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlDark;
            btnBack.Location = new Point(82, 33);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 59);
            btnBack.TabIndex = 28;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(553, 214);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(267, 27);
            txtUserId.TabIndex = 27;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserId.Location = new Point(288, 208);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(120, 32);
            lblUserId.TabIndex = 26;
            lblUserId.Text = "User ID:  ";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 192, 255);
            btnUpdate.Location = new Point(683, 579);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(141, 59);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblUserRoleError
            // 
            lblUserRoleError.AutoSize = true;
            lblUserRoleError.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserRoleError.ForeColor = Color.Red;
            lblUserRoleError.Location = new Point(557, 529);
            lblUserRoleError.Name = "lblUserRoleError";
            lblUserRoleError.Size = new Size(174, 23);
            lblUserRoleError.TabIndex = 24;
            lblUserRoleError.Text = "Please fill this field.";
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(557, 425);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(174, 23);
            lblEmailError.TabIndex = 23;
            lblEmailError.Text = "Please fill this field.";
            // 
            // lblUserNameError
            // 
            lblUserNameError.AutoSize = true;
            lblUserNameError.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserNameError.ForeColor = Color.Red;
            lblUserNameError.Location = new Point(553, 325);
            lblUserNameError.Name = "lblUserNameError";
            lblUserNameError.Size = new Size(174, 23);
            lblUserNameError.TabIndex = 22;
            lblUserNameError.Text = "Please fill this field.";
            // 
            // cbo2
            // 
            cbo2.FormattingEnabled = true;
            cbo2.Items.AddRange(new object[] { "member", "admin" });
            cbo2.Location = new Point(557, 495);
            cbo2.Margin = new Padding(3, 4, 3, 4);
            cbo2.Name = "cbo2";
            cbo2.Size = new Size(267, 28);
            cbo2.TabIndex = 21;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(557, 391);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(267, 27);
            txtEmail.TabIndex = 20;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(557, 291);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(267, 27);
            txtUserName.TabIndex = 19;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserRole.Location = new Point(288, 488);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(138, 32);
            lblUserRole.TabIndex = 18;
            lblUserRole.Text = "User Role: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(288, 391);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(93, 32);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email: ";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(288, 291);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(153, 32);
            lblUserName.TabIndex = 16;
            lblUserName.Text = "User Name: ";
            // 
            // cbo1
            // 
            cbo1.FormattingEnabled = true;
            cbo1.Location = new Point(553, 139);
            cbo1.Margin = new Padding(3, 4, 3, 4);
            cbo1.Name = "cbo1";
            cbo1.Size = new Size(267, 28);
            cbo1.TabIndex = 6;
            cbo1.SelectedIndexChanged += cbo1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(281, 136);
            label2.Name = "label2";
            label2.Size = new Size(271, 32);
            label2.TabIndex = 5;
            label2.Text = "Search by User Name: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(402, 14);
            label1.Name = "label1";
            label1.Size = new Size(376, 94);
            label1.TabIndex = 4;
            label1.Text = "Edit User";
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 792);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnUpdate;
        private TextBox txtUserId;
        private Label lblUserId;
        private Button btnBack;
    }
}