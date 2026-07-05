using Microsoft.Data.SqlClient;

namespace TechnologyAccessories
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {

            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";
            string query = "SELECT EmployeeRole FROM Employee WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string role = reader["EmployeeRole"].ToString();
                    reader.Close();
                    fMain fMain = new fMain(role);
                    fMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "System", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                reader.Close();
            }
        }

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }
    }
}
