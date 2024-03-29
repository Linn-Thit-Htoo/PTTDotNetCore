using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BasicCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                GetData();


                // add columns to the data grid view
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                {
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                editButtonColumn.DefaultCellStyle.BackColor = Color.Green;
                dgv1.Columns.Add(editButtonColumn);


                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                deleteButtonColumn.DefaultCellStyle.BackColor = Color.Red;
                dgv1.Columns.Add(deleteButtonColumn);
            }
            catch
            {
                throw;
            }
        }

        // fetch data from db
        private void GetData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(GetConnectionString._connectionString);
                conn.Open();
                string query = @"SELECT * FROM Category";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                dgv1.DataSource = dt;
            }
            catch
            {
                throw;
            }
        }

        // go to create form
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateCategoryForm createCategoryForm = new CreateCategoryForm();
            createCategoryForm.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        // click event on data grid view
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                    return;

                long id = Convert.ToInt64(dgv1.Rows[e.RowIndex].Cells[0].Value.ToString());
                // 2 for edit
                if (e.ColumnIndex == 2)
                {
                    string categoryName = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    EditCategoryForm editCategoryForm = new EditCategoryForm(id, categoryName);
                    editCategoryForm.Show();
                    this.Hide();
                }

                if (e.ColumnIndex == 3)
                {
                    // delete case
                    DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        SqlConnection conn = new SqlConnection(GetConnectionString._connectionString);
                        conn.Open();
                        string query = @"DELETE FROM Category WHERE CategoryId = @CategoryId";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@CategoryId", id);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rowsAffected > 0)
                        {
                            DialogResult dialogResult = MessageBox.Show("Deleting Successful.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialogResult == DialogResult.OK)
                            {
                                GetData();
                                return;
                            }
                        }
                        MessageBox.Show("Deleting Fail.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
