using System.Data;
using System.Data.SqlClient;

namespace PTTDotNetCore.ConsoleAppDay11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // from text fields
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // validation
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields...", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = new("Data Source=(local);Initial Catalog=PTT;User ID=sa;Password=sa@123");

                conn.Open(); // open connection

                // @ means query params. Use params due to the sql injection
                string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";

                // command
                SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                // adapter
                SqlDataAdapter adapter = new(cmd);

                // data table
                DataTable dt = new();

                // dt = adapter.Fill();
                adapter.Fill(dt);

                conn.Close(); // close connection

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Login Fail!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}