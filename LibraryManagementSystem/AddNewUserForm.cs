using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class AddNewUserForm : Form
    {
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
                    bool isUserNameDuplicate = IsUserNameDuplicate(userName);
                    bool isEmailDuplicate = IsEmailDuplicate(email);

                    if (isUserNameDuplicate)
                    {
                        MessageBox.Show("User name already exists!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (isEmailDuplicate)
                    {
                        MessageBox.Show("Email already exists!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    SqlConnection conn = new(GetConnectionString._conStr);
                    conn.Open();
                    string query = "INSERT INTO Users (UserName, Email, UserRole, IsActive) VALUES (@UserName, @Email, @UserRole, @CreateDate, @IsActive)";

                    SqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@UserRole", role);
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

        private bool IsUserNameDuplicate(string name)
        {
            try
            {
                SqlConnection conn = new(GetConnectionString._conStr);
                string query = "SELECT UserName, Email, UserRole FROM Users WHERE UserName = @UserName AND IsActive = @IsActive";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@UserName", name);
                cmd.Parameters.AddWithValue("@IsActive", 1);
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

        private bool IsEmailDuplicate(string email)
        {
            try
            {
                SqlConnection conn = new(GetConnectionString._conStr);
                string query = "SELECT UserName, Email, UserRole FROM Users WHERE Email = @Email AND IsActive = @IsActive";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@IsActive", 1);
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

        private void cbo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserManagementForm form = new();
            form.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
