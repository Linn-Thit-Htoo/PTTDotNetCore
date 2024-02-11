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
                lblUserName.Visible = false;
                lblEmail.Visible = false;
                lblUserRole.Visible = false;

                txtUserName.Visible = false;
                txtEmail.Visible = false;
                cbo2.Visible = false;

                lblUserNameError.Visible = false;
                lblEmailError.Visible = false;
                lblUserRoleError.Visible = false;

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
                    string? selectedValue = comboBox.SelectedItem.ToString();
                    selectedValue.Trim();
                    SqlConnection conn = new(connectionString);
                    conn.Open();
                    string query = "SELECT UserName, Email, UserRole FROM Users WHERE UserName = @UserName";
                    SqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@UserName", selectedValue);
                    SqlDataAdapter adapter = new(cmd);
                    DataTable dt = new();
                    adapter.Fill(dt);
                    conn.Close();

                    if (dt.Rows.Count > 0)
                    {
                        // hide all necessary fields
                        lblUserName.Visible = true;
                        lblEmail.Visible = true;
                        lblUserRole.Visible = true;

                        txtUserName.Visible = true;
                        txtEmail.Visible = true;
                        cbo2.Visible = true;

                        DataRow row = dt.Rows[0];

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
    }
}
