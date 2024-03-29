using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCRUD
{
    public partial class CreateCategoryForm : Form
    {
        public CreateCategoryForm()
        {
            InitializeComponent();
        }

        private void CreateCategoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        // save method
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryName = txtCategoryName.Text;

                if (string.IsNullOrEmpty(categoryName))
                {
                    MessageBox.Show("Please fill all fields...", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SqlConnection conn = new SqlConnection(GetConnectionString._connectionString);
                conn.Open();
                string query = @"INSERT INTO Category (CategoryName) VALUES (@CategoryName)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                int result = cmd.ExecuteNonQuery(); // result => 1 row affected => successful

                if (result > 0)
                {
                    txtCategoryName.Text = string.Empty;
                    DialogResult dialogResult = MessageBox.Show("Saving Successful.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(dialogResult == DialogResult.OK)
                    {
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                    return;
                }
                MessageBox.Show("Saving Fail.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                throw;
            }
        }
    }
}
