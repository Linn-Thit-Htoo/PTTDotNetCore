using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(local);Initial Catalog=PTTWindowFormProject;User ID=sa;Password=sa@123";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill all fields...", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlConnection conn = new(connectionString);
                conn.Open();
                string query = @"SELECT UserId, UserName, Email, UserRole, IsActive FROM Users WHERE Email = @Email AND Password = @Password
AND IsActive = @IsActive AND UserRole = @UserRole";
                SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@IsActive", 1);
                cmd.Parameters.AddWithValue("@UserRole", "admin");

                SqlDataAdapter adapter = new(cmd);
                DataTable dt = new();
                adapter.Fill(dt);
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Login Fail!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}