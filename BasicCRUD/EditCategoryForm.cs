using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCRUD
{
    public partial class EditCategoryForm : Form
    {
        public long _categoryID;
        public string _categoryName;
        public EditCategoryForm(long id, string categoryName)
        {
            InitializeComponent();
            _categoryID = id;
            _categoryName = categoryName;
        }

        private void EditCategoryForm_Load(object sender, EventArgs e)
        {
            txtCategoryName.Text = _categoryName;
        }

        private void EditCategoryForm_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void EditCategoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        // edit method
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
                string query = @"UPDATE Category SET CategoryName = @CategoryName WHERE CategoryId = @CategoryId";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                cmd.Parameters.AddWithValue("@CategoryId", _categoryID);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    txtCategoryName.Text = string.Empty;
                    DialogResult dialogResult = MessageBox.Show("Updating Successful.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                    return;
                }
                MessageBox.Show("Updating Fail.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                throw;
            }
        }
    }
}
