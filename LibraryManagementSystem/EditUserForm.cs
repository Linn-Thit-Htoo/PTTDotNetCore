using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class EditUserForm : Form
    {
        string connectionString = "Data Source=(local);Initial Catalog=PTTWindowFormProject;User ID=sa;Password=sa@123";
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

                SqlConnection conn = new(connectionString);
                conn.Open();
                string query = "SELECT UserName FROM Users";
                SqlCommand cmd = new(query, conn);
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
                    selectedValue.Trim(); // remove white spaces
                    SqlConnection conn = new(connectionString);
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

                    SqlConnection conn = new(connectionString);
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
                SqlConnection conn = new(connectionString);
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
                SqlConnection conn = new(connectionString);
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
    }
}
