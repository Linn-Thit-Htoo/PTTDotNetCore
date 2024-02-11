﻿using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class AddNewUserForm : Form
    {
        string connectionString = "Data Source=(local);Initial Catalog=PTTWindowFormProject;User ID=sa;Password=sa@123";
        public AddNewUserForm()
        {
            InitializeComponent();
        }

        private void AddNewUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AddNewUserForm_Load(object sender, EventArgs e)
        {
            lblUserNameError.Visible = false;
            lblEmailError.Visible = false;
            lblUserRoleError.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text;
                string email = txtEmail.Text;
                string role = cbo1.Text;

                lblUserNameError.Visible = string.IsNullOrEmpty(userName);
                lblEmailError.Visible = string.IsNullOrEmpty(email);
                lblUserRoleError.Visible = string.IsNullOrEmpty(role);

                if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(role))
                {
                    SqlConnection conn = new(connectionString);
                    conn.Open();
                    string query = "INSERT INTO Users (UserName, Email, UserRole, CreateDate, IsActive) VALUES (@UserName, @Email, @UserRole, @CreateDate, @IsActive)";

                    SqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@UserRole", role);
                    cmd.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@IsActive", 1);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Creating Successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUserName.Text = string.Empty;
                        txtEmail.Text = string.Empty;
                        cbo1.Text = string.Empty;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Creating Fail.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void cbo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
