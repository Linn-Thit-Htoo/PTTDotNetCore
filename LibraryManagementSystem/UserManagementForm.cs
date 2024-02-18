using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class UserManagementForm : Form
    {
        string connectionString = "Data Source=(local);Initial Catalog=PTTWindowFormProject;User ID=sa;Password=sa@123";
        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new(connectionString);
            string query = @"SELECT [UserId]
      ,[UserName]
      ,[Email]
      ,[Password]
      ,[UserRole]
      ,[CreateDate]
      ,[IsActive]
  FROM [PTTWindowFormProject].[dbo].[Users] WHERE IsActive = @IsActive";
            SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@IsActive", 1);
            SqlDataAdapter adapter = new(cmd);
            DataTable dt = new();
            adapter.Fill(dt);

            dgv1.DataSource = dt;
        }

        private void UserManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewUserForm addNewUserForm = new();
            addNewUserForm.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new();
            editUserForm.Show();
            this.Hide();
        }
    }
}
