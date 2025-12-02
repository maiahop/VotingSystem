using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace OnlineVotingDraft
{
    public partial class AdminLog : Form
    {
        // Connection string to your ElectionDB2 database
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-7N9A002P\SQLEXPRESS02;Initial Catalog=ElectionDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        public AdminLog()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAdminPass.UseSystemPasswordChar = true; // Hide password characters
        }

        // Login Button
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox3.Text.Trim();
            string password = txtAdminPass.Text.Trim();

            // Validate input fields
            if (string.IsNullOrEmpty(username) || username == "Username" ||
                string.IsNullOrEmpty(password) || password == "Password")
            {
                MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connection.Open();

                // ✅ Updated table name to "Admins"
                string query = "SELECT * FROM Admins WHERE Username = @Username AND PasswordHash = @Password";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string fullName = reader["FullName"].ToString();

                    MessageBox.Show($"Welcome, {fullName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    reader.Close();
                    connection.Close();

                    Dashboard dash = new Dashboard();
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        // Username textbox placeholder behavior
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Username")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "Username";
                textBox3.ForeColor = Color.Silver;
            }
        }

        // Password textbox placeholder behavior
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtAdminPass.Text == "Password")
            {
                txtAdminPass.Text = "";
                txtAdminPass.ForeColor = Color.Black;
                txtAdminPass.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminPass.Text))
            {
                txtAdminPass.Text = "Password";
                txtAdminPass.ForeColor = Color.Silver;
                txtAdminPass.UseSystemPasswordChar = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnshowPass_Click(object sender, EventArgs e)
        {
            if (txtAdminPass.UseSystemPasswordChar)
            {
                // Show password
                txtAdminPass.UseSystemPasswordChar = false;
                btnshowPass.Image = BSIT_EVOTE.Properties.Resources.eye_30x30;
                btnshowPass.Refresh();
            }
            else
            {
                // Hide password
                txtAdminPass.UseSystemPasswordChar = true;
                btnshowPass.Image = BSIT_EVOTE.Properties.Resources.hidden_30x30;
                btnshowPass.Refresh();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            Visible = false;
        }
    }
}

