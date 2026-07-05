using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnologyAccessories
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            if (cbbEmRo.Text.IsNullOrEmpty() || tbEmNa.Text.IsNullOrEmpty() || tbEmAdd.Text.IsNullOrEmpty() || tbEmPh.Text.IsNullOrEmpty() || tbUsername.Text.IsNullOrEmpty() || tbPass.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please fill in the blank", "System", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            string username = tbUsername.Text;
            string password = tbPass.Text;
            string employeeName = tbEmNa.Text;
            string employeeRole = cbbEmRo.Text;
            string employeeAddress = tbEmAdd.Text;
            string employeePhone = tbEmPh.Text;

            string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";
            string query = "INSERT INTO Employee (Username, Password, EmployeeName, EmployeeRole, EmployeeAddress, EmployeePhone) " + "VALUES (@Username, @Password, @EmployeeName, @EmployeeRole, @EmployeeAddress, @EmployeePhone)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@EmployeeName", employeeName);
                    command.Parameters.AddWithValue("@EmployeeRole", employeeRole);
                    command.Parameters.AddWithValue("@EmployeeAddress", employeeAddress);
                    command.Parameters.AddWithValue("@EmployeePhone", employeePhone);

                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sign up successfully!", "System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error registering: " + ex.Message);
                    }
                }
            }
        }

        private void tbEmPh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (tbEmPh.Text.Length >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
