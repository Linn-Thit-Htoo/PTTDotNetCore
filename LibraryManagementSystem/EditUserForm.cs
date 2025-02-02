﻿using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            try
            {
                // hide all necessary fields
                lblUserId.Visible = false;
                lblUserName.Visible = false;
                lblEmail.Visible = false;
                lblUserRole.Visible = false;

                txtUserId.Visible = false;
                txtUserName.Visible = false;
                txtEmail.Visible = false;
                cbo2.Visible = false;

                lblUserNameError.Visible = false;
                lblEmailError.Visible = false;
                lblUserRoleError.Visible = false;

                btnUpdate.Visible = false;
                btnDelete.Visible = false;

                SqlConnection conn = new(GetConnectionString._conStr);
                conn.Open();
                string query = "SELECT UserName FROM Users WHERE IsActive = @IsActive";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@IsActive", 1);
                SqlDataAdapter adapter = new(cmd);
                DataTable dt = new();
                adapter.Fill(dt);
                conn.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    cbo1.Items.Add(dr["UserName"]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void EditUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void cbo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox comboBox = (ComboBox)sender;

                if (comboBox.SelectedItem != null)
                {
                    string? selectedValue = comboBox.SelectedItem.ToString(); // user name
                    selectedValue?.Trim(); // remove white spaces
                    SqlConnection conn = new(GetConnectionString._conStr);
                    conn.Open();
                    string query = "SELECT UserId, UserName, Email, UserRole FROM Users WHERE UserName = @UserName";
                    SqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@UserName", selectedValue);
                    SqlDataAdapter adapter = new(cmd);
                    DataTable dt = new();
                    adapter.Fill(dt);
                    conn.Close();

                    if (dt.Rows.Count > 0)
                    {
                        // show all necessary fields
                        lblUserName.Visible = true;
                        lblEmail.Visible = true;
                        lblUserRole.Visible = true;

                        txtUserName.Visible = true;
                        txtEmail.Visible = true;
                        cbo2.Visible = true;

                        btnUpdate.Visible = true;
                        btnDelete.Visible = true;

                        DataRow row = dt.Rows[0];
                        long id = Convert.ToInt64(row["UserId"]);
                        txtUserId.Text = id.ToString();

                        txtUserName.Text = row["UserName"].ToString();
                        txtEmail.Text = row["Email"].ToString();
                        cbo2.Text = row["UserRole"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                long id = Convert.ToInt64(txtUserId.Text);
                string userName = txtUserName.Text;
                string email = txtEmail.Text;
                string role = cbo1.Text;

                lblUserNameError.Visible = string.IsNullOrEmpty(userName);
                lblEmailError.Visible = string.IsNullOrEmpty(email);
                lblUserRoleError.Visible = string.IsNullOrEmpty(role);

                if (id != 0 && !string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(role))
                {
                    if (IsUserNameDuplicateById(id, userName))
                    {
                        MessageBox.Show("User with this name already exists.", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }

                    if (IsEmailDuplicateById(id, email))
                    {
                        MessageBox.Show("User with this email already exists.", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }

                    if (id != 0 && !string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(role))
                    {
                        SqlConnection conn = new(GetConnectionString._conStr);
                        conn.Open();
                        string query = "UPDATE Users SET UserName = @UserName, Email = @Email, UserRole = @UserRole WHERE UserId = @UserId";
                        SqlCommand cmd = new(query, conn);
                        cmd.Parameters.AddWithValue("@UserId", id);
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@UserRole", role);
                        int result = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (result > 0)
                        {
                            MessageBox.Show("Updating Successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            (new UserManagementForm()).Show();
                            this.Hide();
                            return;
                        }
                        MessageBox.Show("Updating Fail.", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Updating Fail.", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // return true if the same user name situated except the user who is editing for now
        private bool IsUserNameDuplicateById(long id, string name)
        {
            try
            {
                SqlConnection conn = new(GetConnectionString._conStr);
                conn.Open();
                string query = "SELECT UserId, UserName, Email, UserRole, CreateDate, IsActive FROM Users WHERE UserName = @UserName AND UserId != @UserId";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@UserId", id);
                cmd.Parameters.AddWithValue("@UserName", name);
                SqlDataAdapter adapter = new(cmd);
                DataTable dt = new();
                adapter.Fill(dt);
                conn.Close();

                return dt.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool IsEmailDuplicateById(long id, string email)
        {
            try
            {
                SqlConnection conn = new(GetConnectionString._conStr);
                string query = "SELECT UserName, Email, UserRole FROM Users WHERE Email = @Email AND UserId != @UserId";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@UserId", id);
                cmd.Parameters.AddWithValue("@Email", email);
                SqlDataAdapter adapter = new(cmd);
                DataTable dt = new();
                adapter.Fill(dt);
                conn.Close();

                return dt.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new UserManagementForm()).Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmMessage = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmMessage == DialogResult.Yes)
                {
                    long id = Convert.ToInt64(txtUserId.Text);

                    using SqlConnection conn = new(GetConnectionString._conStr);
                    conn.Open();
                    string query = "UPDATE Users SET IsActive = @IsActive WHERE UserId = @UserId";
                    using SqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@IsActive", 0);
                    cmd.Parameters.AddWithValue("@UserId", id);

                    int result = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (result > 0)
                    {
                        DialogResult dialog = MessageBox.Show("Deleting Successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog == DialogResult.OK)
                        {
                            (new UserManagementForm()).Show();
                            this.Hide();
                            return;
                        }
                    }
                    MessageBox.Show("Deleting Fail.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
