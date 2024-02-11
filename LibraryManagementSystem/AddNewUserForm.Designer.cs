namespace LibraryManagementSystem
{
    partial class AddNewUserForm
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
            btnCreate = new Button();
            cbo1 = new ComboBox();
            txtEmail = new TextBox();
            txtUserName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBack = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(lblUserRoleError);
            panel1.Controls.Add(lblEmailError);
            panel1.Controls.Add(lblUserNameError);
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(cbo1);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 590);
            panel1.TabIndex = 0;
            // 
            // lblUserRoleError
            // 
            lblUserRoleError.AutoSize = true;
            lblUserRoleError.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserRoleError.ForeColor = Color.Red;
            lblUserRoleError.Location = new Point(416, 347);
            lblUserRoleError.Name = "lblUserRoleError";
            lblUserRoleError.Size = new Size(140, 19);
            lblUserRoleError.TabIndex = 15;
            lblUserRoleError.Text = "Please fill this field.";
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(416, 270);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(140, 19);
            lblEmailError.TabIndex = 14;
            lblEmailError.Text = "Please fill this field.";
            // 
            // lblUserNameError
            // 
            lblUserNameError.AutoSize = true;
            lblUserNameError.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserNameError.ForeColor = Color.Red;
            lblUserNameError.Location = new Point(416, 193);
            lblUserNameError.Name = "lblUserNameError";
            lblUserNameError.Size = new Size(140, 19);
            lblUserNameError.TabIndex = 13;
            lblUserNameError.Text = "Please fill this field.";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(192, 192, 255);
            btnCreate.Location = new Point(527, 415);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(123, 44);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // cbo1
            // 
            cbo1.FormattingEnabled = true;
            cbo1.Items.AddRange(new object[] { "member", "admin" });
            cbo1.Location = new Point(416, 321);
            cbo1.Name = "cbo1";
            cbo1.Size = new Size(234, 23);
            cbo1.TabIndex = 11;
            cbo1.KeyPress += cbo1_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(416, 244);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(416, 167);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(234, 23);
            txtUserName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(278, 321);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 7;
            label4.Text = "User Role: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(278, 242);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 6;
            label3.Text = "Email: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(278, 165);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 5;
            label2.Text = "User Name: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(254, 12);
            label1.Name = "label1";
            label1.Size = new Size(440, 75);
            label1.TabIndex = 4;
            label1.Text = "Add New User";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlDark;
            btnBack.Location = new Point(296, 415);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(103, 44);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // AddNewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 661);
            Controls.Add(panel1);
            MinimumSize = new Size(500, 700);
            Name = "AddNewUserForm";
            Text = "AddNewUserForm";
            FormClosed += AddNewUserForm_FormClosed;
            Load += AddNewUserForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cbo1;
        private TextBox txtEmail;
        private TextBox txtUserName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCreate;
        private Label lblUserNameError;
        private Label lblUserRoleError;
        private Label lblEmailError;
        private Button btnBack;
    }
}