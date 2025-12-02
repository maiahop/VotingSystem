using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineVotingDraft
{
    public partial class ViewVote : Form
    {
        private int _studNo;
        private string connectionString = @"Data Source=LAPTOP-7N9A002P\SQLEXPRESS02;Initial Catalog=ElectionDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;Connection Timeout=30"; 
        public ViewVote(int studNo)
        {
            InitializeComponent();
            _studNo = studNo;
        }

        private void ViewVote_Load(object sender, EventArgs e)
        {
            LoadVoteReceipt();
        }

        private int GetLatestElectionID()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 ElectionID FROM Elections ORDER BY ElectionID DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? (int)result : 0;
            }
        }
        private void LoadVoteReceipt()
        {
            int latestElectionID = GetLatestElectionID();
            if (latestElectionID == 0)
            {
                lblReceipt.Text = "No active election.";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT P.PositionName, V.CandidateName
                FROM Votes V
                INNER JOIN Positions P ON V.PositionID = P.PositionID
                WHERE V.StudNo = @StudNo AND V.ElectionID = @ElectionID
                ORDER BY P.PositionOrder";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudNo", _studNo);
                        cmd.Parameters.AddWithValue("@ElectionID", latestElectionID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            lblReceipt.Text = ""; // Clear first
                            bool hasVotes = false;
                            while (reader.Read())
                            {
                                hasVotes = true;
                                string position = reader["PositionName"].ToString();
                                string candidate = reader["CandidateName"].ToString();
                                lblReceipt.Text += $"{position}: {candidate}\r\n";
                            }
                            if (!hasVotes)
                            {
                                lblReceipt.Text = "No votes found for the current election.";
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database Error: " + sqlEx.Number + " - " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Logout and return to login form
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
        // Add other event handlers as needed (e.g., for UI elements like labels or panels)
        private void lblReceipt_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
