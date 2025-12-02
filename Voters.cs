using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace OnlineVotingDraft
{
    public partial class Voters : Form
    {
        private readonly Color OriginalColor = Color.FromArgb(18, 44, 64);
        private readonly Color SelectedColor = Color.FromArgb(210, 113, 10);
        private Button currentSelectedButton = null;

        private string connectionString = @"Data Source=LAPTOP-7N9A002P\SQLEXPRESS02;Initial Catalog=ElectionDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        // Panels for voters management
        private FlowLayoutPanel panelVoterList;
        private Panel panelVoterDetail;

        public Voters()
        {
            InitializeComponent();
        }

        private void Voters_Load(object sender, EventArgs e)
        {
            // Keep your existing nav button logic
            btnVoters.Click += NavButton_Click;
            btnCandidates.Click += NavButton_Click;
            btnManage.Click += NavButton_Click;
            NavButton_Click(btnVoters, EventArgs.Empty);

            // Initialize our dynamic voters management panels
            InitializeVotersPanel();
        }

        private void InitializeVotersPanel()
        {
            // Left panel: voter list
            panelVoterList = new FlowLayoutPanel
            {
                BackColor = Color.White,
                Location = new Point(50, 100),
                Size = new Size(300, 650),
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };
            panel3.Controls.Add(panelVoterList);

            // Right panel: voter details
            panelVoterDetail = new Panel
            {
                BackColor = Color.WhiteSmoke,
                Location = new Point(400, 100),
                Size = new Size(500, 650),
                AutoScroll = true
            };
            panel3.Controls.Add(panelVoterDetail);

            LoadVoterList();
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

        private void LoadVoterList()
        {
            panelVoterList.Controls.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT StudNo, FullName FROM Voters ORDER BY CreatedAt DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Button voterBtn = new Button
                    {
                        Text = $"{reader["FullName"]} ({reader["StudNo"]})",
                        Tag = reader["StudNo"],
                        Width = panelVoterList.Width - 40,
                        Height = 60,
                        BackColor = Color.White,
                        FlatStyle = FlatStyle.Flat
                    };

                    // Center the button horizontally
                    voterBtn.Margin = new Padding((panelVoterList.Width - voterBtn.Width) / 2, 10, 0, 10);

                    voterBtn.Click += VoterBtn_Click;
                    panelVoterList.Controls.Add(voterBtn);
                }
            }
        }

        private void VoterBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int studNo = Convert.ToInt32(btn.Tag);
            LoadVoterDetail(studNo);
        }

        private void LoadVoterDetail(int studNo)
        {
            panelVoterDetail.Controls.Clear();
            int latestElectionID = GetLatestElectionID();

            if (latestElectionID == 0)
            {
                Label noElectionLbl = new Label
                {
                    Text = "No active election found.",
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true,
                    Location = new Point(10, 10)
                };
                panelVoterDetail.Controls.Add(noElectionLbl);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Get voter info (unchanged)
                string voterQuery = "SELECT StudNo, FullName, Email, Age, CreatedAt, VotedAt FROM Voters WHERE StudNo=@StudNo";
                SqlCommand voterCmd = new SqlCommand(voterQuery, conn);
                voterCmd.Parameters.AddWithValue("@StudNo", studNo);
                SqlDataReader voterReader = voterCmd.ExecuteReader();

                if (voterReader.Read())
                {
                    string voterInfo = $"Student #: {voterReader["StudNo"]}\n" +
                                       $"Full Name: {voterReader["FullName"]}\n" +
                                       $"Email: {voterReader["Email"]}\n" +
                                       $"Age: {voterReader["Age"]}\n" +
                                       $"Created At: {Convert.ToDateTime(voterReader["CreatedAt"]):MM/dd/yyyy hh:mm tt}\n" +
                                       $"Voted At: {(voterReader["VotedAt"] != DBNull.Value ? Convert.ToDateTime(voterReader["VotedAt"]).ToString("MM/dd/yyyy hh:mm tt") : "Not Yet")}";

                    Label lbl = new Label
                    {
                        Text = voterInfo,
                        Font = new Font("Segoe UI", 10),
                        AutoSize = true,
                        Location = new Point(10, 10)
                    };
                    panelVoterDetail.Controls.Add(lbl);
                }
                voterReader.Close();

                // Updated: Get votes for this voter in the current election only
                string voteQuery = @"
            SELECT p.PositionName, v.CandidateName 
            FROM Votes v
            INNER JOIN Positions p ON v.PositionID = p.PositionID
            WHERE v.StudNo=@StudNo AND v.ElectionID=@ElectionID
            ORDER BY p.PositionOrder";
                SqlCommand voteCmd = new SqlCommand(voteQuery, conn);
                voteCmd.Parameters.AddWithValue("@StudNo", studNo);
                voteCmd.Parameters.AddWithValue("@ElectionID", latestElectionID);
                SqlDataReader voteReader = voteCmd.ExecuteReader();

                int yOffset = 150;
                bool hasVotes = false;
                while (voteReader.Read())
                {
                    hasVotes = true;
                    Label voteLbl = new Label
                    {
                        Text = $"{voteReader["PositionName"]}: {voteReader["CandidateName"]}",
                        Font = new Font("Segoe UI", 10),
                        AutoSize = true,
                        Location = new Point(10, yOffset)
                    };
                    panelVoterDetail.Controls.Add(voteLbl);
                    yOffset += 30;
                }

                if (!hasVotes)
                {
                    Label noVotesLbl = new Label
                    {
                        Text = "No votes recorded for the current election.",
                        Font = new Font("Segoe UI", 10),
                        AutoSize = true,
                        Location = new Point(10, yOffset)
                    };
                    panelVoterDetail.Controls.Add(noVotesLbl);
                }
            }
        }
        // ===== Keep all your original button methods =====
        private void NavButton_Click(object sender, EventArgs e)
        { // 1. Get the button that triggered the event
            Button clickedButton = sender as Button;

            if (clickedButton == null)
                return;

            // 2. Reset the previously selected button's color
            if (currentSelectedButton != null)
            {
                // Set the previous button back to the original color
                currentSelectedButton.BackColor = OriginalColor;
            }

            // 3. Set the newly clicked button's color
            clickedButton.BackColor = SelectedColor;

            // 4. Update the tracker to the current button
            currentSelectedButton = clickedButton;
        }
        private void btnOverview_Click(object sender, EventArgs e) 
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            Visible = false;
        }
        private void btnTally_Click(object sender, EventArgs e) 
        {
            Tally tally = new Tally();
            tally.Show();
            Visible = false;
        }
        private void button1_Click(object sender, EventArgs e) 
        {
            Candidates candidates = new Candidates();
            candidates.Show();
            Visible = false;
        }
        private void button3_Click(object sender, EventArgs e) 
        {
            Election election = new Election();
            election.Show();
            Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e) {  }
        private void btnManage_Click(object sender, EventArgs e) {  }
        private void btnLogOut_Click(object sender, EventArgs e) 
        {
            LoginForm login = new LoginForm();
            login.Show();
            Visible = false;
        }
        private void panel3_Paint(object sender, PaintEventArgs e) {  }

        private void btnStopElection_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Get current election status
                    string checkQuery = "SELECT ElectionStopped FROM Settings WHERE SettingID = 1";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    bool currentStatus = (bool)checkCmd.ExecuteScalar();

                    // Toggle the status
                    bool newStatus = !currentStatus;

                    string updateQuery = "UPDATE Settings SET ElectionStopped = @newStatus WHERE SettingID = 1";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@newStatus", newStatus);
                    updateCmd.ExecuteNonQuery();

                    // Update button appearance
                    SetStopElectionButton(newStatus);

                    // Notify admin
                    string message = newStatus
                        ? "Election has been stopped. No new logins or votes are allowed."
                        : "Election has been resumed. Students can now log in and vote.";

                    MessageBox.Show(message, "Election Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to set the button appearance
        private void SetStopElectionButton(bool electionStopped)
        {
            if (electionStopped)
            {
                btnStopElection.BackColor = Color.Red;
                btnStopElection.Text = "Resume Election";
            }
            else
            {
                btnStopElection.BackColor = Color.Green;
                btnStopElection.Text = "Stop Election";
            }
        }

        // Call this in your Form_Load
        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ElectionStopped FROM Settings WHERE SettingID = 1";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    bool electionStopped = (bool)cmd.ExecuteScalar();

                    SetStopElectionButton(electionStopped);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while checking election status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnManage_Click_1(object sender, EventArgs e) 
        { 
            timer1.Start(); 
        }
        private void btnCandidates_Click(object sender, EventArgs e) 
        {
            Candidates candi = new Candidates();
            candi.Show();
            Visible = false;
        }
        private void btnVoters_Click(object sender, EventArgs e) 
        {
            Voters voters = new Voters();
            voters.Show();
            Visible = false;
        }
        private void btnElection_Click(object sender, EventArgs e) 
        {
            Election elec = new Election();
            elec.Show();
            Visible = false;
        }
    }
}
