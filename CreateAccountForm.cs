using BCrypt.Net;
using BSIT_EVOTE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OnlineVotingDraft
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(
    @"Data Source=LAPTOP-7N9A002P\SQLEXPRESS02;Initial Catalog=ElectionDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginForm f2 = new LoginForm();
            f2.Show();
            Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Show Terms and Conditions immediately when form opens
            TermsAndConditionsForm tncForm = new TermsAndConditionsForm();
            if (tncForm.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("You must agree to the Terms and Conditions to create an account.", "Agreement Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();  // Close the form if not agreed
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Lanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string StudNo = txtStudNo.Text.Trim();
            string FullName = txtFullName.Text.Trim();
            string Email = txtEmail.Text.Trim();
            string Age = txtAge.Text.Trim();
            string PasswordHash = txtPasswordHash.Text.Trim();
            string rePasswordHash = txtRePasswordHash.Text.Trim();

            // Check if passwords match
            if (PasswordHash != rePasswordHash)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proceed with account creation (no T&C here)
            string hashedPassword = PasswordHash;  // Note: Consider hashing for security

            string connStr = @"Data Source=LAPTOP-7N9A002P\SQLEXPRESS02;Initial Catalog=ElectionDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Voters (StudNo, FullName, Email, Age, PasswordHash) VALUES (@StudNo, @FullName, @Email, @Age, @PasswordHash)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudNo", StudNo);
                    cmd.Parameters.AddWithValue("@FullName", FullName);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Age", Age);
                    cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Go back to login form
                    LoginForm f2 = new LoginForm();
                    f2.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentNum_Enter(object sender, EventArgs e)
        {
            if (txtStudNo.Text == "Student Number")
            {
                txtStudNo.Text = " ";
                txtStudNo.ForeColor = Color.Black;
            }
        }

        private void txtStudentNum_Leave(object sender, EventArgs e)
        {
            if (txtStudNo.Text == " ")
            {
                txtStudNo.Text = "Student Number";
                txtStudNo.ForeColor = Color.Silver;
            }
        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Full Name")
            {
                txtFullName.Text = " ";
                txtFullName.ForeColor = Color.Black;
            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (txtFullName.Text == " ")
            {
                txtFullName.Text = "Full Name";
                txtFullName.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = " ";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == " ")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtAge_Enter(object sender, EventArgs e)
        {
            if (txtAge.Text == "Age")
            {
                txtAge.Text = " ";
                txtAge.ForeColor = Color.Black;
            }
        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            if (txtAge.Text == " ")
            {
                txtAge.Text = "Age";
                txtAge.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPasswordHash.Text == "Password")
            {
                txtPasswordHash.Text = " ";
                txtPasswordHash.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPasswordHash.Text == " ")
            {
                txtPasswordHash.Text = "Password";
                txtPasswordHash.ForeColor = Color.Silver;
            }
        }

        private void txtRePassword_Enter(object sender, EventArgs e)
        {
            if (txtRePasswordHash.Text == "Re-enter Password")
            {
                txtRePasswordHash.Text = " ";
                txtRePasswordHash.ForeColor = Color.Black;
            }
        }

        private void txtRePassword_Leave(object sender, EventArgs e)
        {
            if (txtRePasswordHash.Text == " ")
                txtRePasswordHash.Text = "Re-enter Password";
            txtRePasswordHash.ForeColor = Color.Silver;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtStudentNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnTogglePass_Click(object sender, EventArgs e)
        {
            if (txtPasswordHash.UseSystemPasswordChar)
            {
                // Show password
                txtPasswordHash.UseSystemPasswordChar = false;
                btnTogglePass.Image = BSIT_EVOTE.Properties.Resources.eye_30x30;
                btnTogglePass.Refresh();
            }
            else
            {
                // Hide password
                txtPasswordHash.UseSystemPasswordChar = true;
                btnTogglePass.Image = BSIT_EVOTE.Properties.Resources.hidden_30x30;
                btnTogglePass.Refresh();
            }
        }

        private void btnToggleRePass_Click(object sender, EventArgs e)
        {
            if (txtRePasswordHash.UseSystemPasswordChar)
            {
                // Show password
                txtRePasswordHash.UseSystemPasswordChar = false;
                btnToggleRePass.Image = BSIT_EVOTE.Properties.Resources.eye_30x30;
                btnToggleRePass.Refresh();
            }
            else
            {
                // Hide password
                txtRePasswordHash.UseSystemPasswordChar = true;
                btnToggleRePass.Image = BSIT_EVOTE.Properties.Resources.hidden_30x30;
                btnToggleRePass.Refresh();
            }
        }

        private void goback_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            Visible = false;
        }
    }
}