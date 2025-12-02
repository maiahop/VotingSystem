using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace OnlineVotingDraft
{
    public partial class VotingReview : Form
    {
        private Dictionary<string, string> _selectedCandidates; // Stores selected candidates
        private int _studNo; // Stores voter ID
        private string connectionString = @"Data Source=LAPTOP-7N9A002P\SQLEXPRESS02;Initial Catalog=ElectionDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public VotingReview(Dictionary<string, string> selectedCandidates, int studNo)
        {
            InitializeComponent();
            _selectedCandidates = selectedCandidates;
            _studNo = studNo;
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
        private void VotingReview_Load(object sender, EventArgs e)
        {
            // Display all selected candidates
            lblCandidateName.Text = ""; // clear first
            foreach (var position in _selectedCandidates.Keys)
            {
                lblCandidateName.Text += $"{position}: {_selectedCandidates[position]}\r\n";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to submit your vote?",
                "Confirm Vote",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        foreach (var kvp in _selectedCandidates)
                        {
                            string positionName = kvp.Key;
                            string candidateName = kvp.Value;

                            // Get CandidateID and PositionID from database
                            // Get CandidateID and PositionID from database (updated to filter by ElectionID)
                            string query = @"
    SELECT C.CandidID, P.PositionID
    FROM Candidates C
    INNER JOIN Positions P ON C.PositionID = P.PositionID
    WHERE C.FullName = @CandidateName AND P.PositionName = @PositionName AND C.ElectionID = @ElectionID";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@CandidateName", candidateName);
                                cmd.Parameters.AddWithValue("@PositionName", positionName);
                                cmd.Parameters.AddWithValue("@ElectionID", GetLatestElectionID());  // Add this parameter

                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        int candidID = reader.GetInt32(0);
                                        int positionID = reader.GetInt32(1);
                                        reader.Close();

                                        // Insert vote with ElectionID (unchanged)
                                        string insertVote = @"
                INSERT INTO Votes (StudNo, CandidID, PositionID, CandidateName, ElectionID)
                VALUES (@StudNo, @CandidID, @PositionID, @CandidateName, @ElectionID)";
                                        using (SqlCommand insertCmd = new SqlCommand(insertVote, conn))
                                        {
                                            insertCmd.Parameters.AddWithValue("@StudNo", _studNo);
                                            insertCmd.Parameters.AddWithValue("@CandidID", candidID);
                                            insertCmd.Parameters.AddWithValue("@PositionID", positionID);
                                            insertCmd.Parameters.AddWithValue("@CandidateName", candidateName);
                                            insertCmd.Parameters.AddWithValue("@ElectionID", GetLatestElectionID());
                                            insertCmd.ExecuteNonQuery();
                                        }
                                    }
                                    else
                                    {
                                        reader.Close();
                                        MessageBox.Show($"Candidate {candidateName} not found in the current election!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                        }

                            // Update voter as having voted (unchanged)
                            string updateVoter = @"
                    UPDATE Voters
                    SET HasVoted = 1,
                        VotedAt = GETDATE()
                    WHERE StudNo = @StudNo";

                        using (SqlCommand updateCmd = new SqlCommand(updateVoter, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@StudNo", _studNo);
                            updateCmd.ExecuteNonQuery();
                        }

                        conn.Close();
                    }

                    MessageBox.Show("Your vote has been submitted successfully!", "Vote Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ViewVote receipt = new ViewVote(_studNo);
                    receipt.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while submitting your vote: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Go back to Presidentvote form
            Presidentvote form = new Presidentvote(_studNo);
            form.Show();
            this.Hide();
        }

        private void lblCandidateName_TextChanged(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            // Logout button
            LoginForm login = new LoginForm();
            login.Show();
            Visible = false;
        }

    }
}
