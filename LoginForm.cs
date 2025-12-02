using BSIT_EVOTE;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineVotingDraft
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            pass.UseSystemPasswordChar = true;
        }

        SqlConnection connection = new SqlConnection(
            @"Data Source=LAPTOP-7N9A002P\SQLEXPRESS02;Initial Catalog=ElectionDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        // ================== BLOCK REGISTRATION IF ELECTION STOPPED ==================
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                connection.Open();

                string checkElectionQuery = "SELECT ElectionStopped FROM Settings WHERE SettingID = 1";
                SqlCommand cmd = new SqlCommand(checkElectionQuery, connection);
                bool electionStopped = Convert.ToBoolean(cmd.ExecuteScalar());

                if (electionStopped)
                {
                    MessageBox.Show("The election is currently stopped. New accounts cannot be created.", "Election Paused", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Proceed directly to CreateAccountForm (T&C will pop up there)
                    CreateAccountForm f3 = new CreateAccountForm();
                    f3.Show();
                    Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking election status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            string studNoText = studentNumber.Text.Trim();
            string passwordInput = pass.Text.Trim();
            if (string.IsNullOrEmpty(studNoText) || studNoText == "Student Number" ||
                string.IsNullOrEmpty(passwordInput) || passwordInput == "Password")
            {
                MessageBox.Show("Please enter both Student Number and Password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(studNoText, out int studNo))
            {
                MessageBox.Show("Invalid Student Number format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                connection.Open();
                // Check if election is stopped for login
                string electionQuery = "SELECT ElectionStopped FROM Settings WHERE SettingID = 1";
                SqlCommand electionCmd = new SqlCommand(electionQuery, connection);
                bool electionStopped = Convert.ToBoolean(electionCmd.ExecuteScalar());
                if (electionStopped)
                {
                    MessageBox.Show("The election is currently stopped. Students cannot log in.", "Election Paused", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string query = "SELECT PasswordHash, HasVoted FROM Voters WHERE StudNo = @StudNo";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@StudNo", studNo);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string storedHash = reader["PasswordHash"].ToString();
                    bool hasVoted = Convert.ToBoolean(reader["HasVoted"]);

                    // TODO: Use BCrypt to verify hashed passwords
                    if (passwordInput == storedHash)
                    {
                        reader.Close();
                        if (hasVoted)
                        {
                            // Allow re-login to view receipt (no T&C popup)
                            ViewVote receipt = new ViewVote(studNo);
                            receipt.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Proceed directly to VotingGuide (no T&C here)
                            MessageBox.Show("Login successful!");
                            VotingGuide f4 = new VotingGuide(studNo);
                            f4.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Student number not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        // ... (rest of your methods remain unchanged)
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLog adlog = new AdminLog();
            adlog.Show();
            Visible = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pass.UseSystemPasswordChar = !shopass.Checked;
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (studentNumber.Text == "Student Number")
            {
                studentNumber.Text = " ";
                studentNumber.ForeColor = Color.Black;
            }
        }
        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Password")
            {
                pass.Text = " ";
                pass.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (studentNumber.Text == " ")
            {
                studentNumber.Text = "Student Number";
                studentNumber.ForeColor = Color.Silver;
            }
        }
        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == " ")
            {
                pass.Text = "Password";
                pass.ForeColor = Color.Silver;
            }
        }
        private void label2_Click(object sender, EventArgs e) { }
        private void pass_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pass_TextChanged_1(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}