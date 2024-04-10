using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class CategoryManagementForm : Form
    {
        public CategoryManagementForm()
        {
            InitializeComponent();
        }

        private void CategoryManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CategoryManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new(GetConnectionString._conStr);
                conn.Open();
                string query = "SELECT * FROM Category WHERE IsActive = @IsActive";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@IsActive", true);
                SqlDataAdapter adapter = new(cmd);
                DataTable dt = new();
                adapter.Fill(dt);
                conn.Close();

                dgv1.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
