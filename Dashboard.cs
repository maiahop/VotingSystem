using BSIT_EVOTE.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace OnlineVotingDraft
{
    public partial class Dashboard : Form
    {
        // Define the colors using the specified RGB values
        private readonly Color OriginalColor = Color.FromArgb(23, 37, 75);
        private readonly Color SelectedColor = Color.FromArgb(210, 113, 10);

        // Track the currently selected button
        private Button currentSelectedButton = null;

        // Connection string for database
        private string connectionString = @"Data Source=LAPTOP-7N9A002P\SQLEXPRESS02;Initial Catalog=ElectionDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        // Timer for live tally updates
        private System.Windows.Forms.Timer tallyTimer;

        // FlowLayoutPanel for dynamic candidate labels
        private FlowLayoutPanel panelTally;

        // FlowLayoutPanel for voters panel
        private FlowLayoutPanel panelVoters;

        public Dashboard()
        {
            InitializeComponent();
        }

        bool expand = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeTallyBoard();      // Creates panelTally
            InitializeVotersPanel();
            LoadElectionComboBox();

            // Add this: Initialize panelPastResults
            panelPastResults = new FlowLayoutPanel
            {
                Name = "panelPastResults",
                BackColor = Color.White,
                Location = new Point(54, 85),  // Right of panelTally
                Size = new Size(537, 346),
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };
            panel3.Controls.Add(panelPastResults);

            panelTally.Visible = true;   // Always visible
            panelPastResults.Visible = false;  // Hidden initially

            btnDashboard.Click += NavButton_Click;
            btnManage.Click += NavButton_Click;
            btnCandidates.Click += NavButton_Click;
            btnVoters.Click += NavButton_Click;
            btnElection.Click += NavButton_Click;

            NavButton_Click(btnDashboard, EventArgs.Empty);
        }


        private void NavButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == null)
                return;

            if (currentSelectedButton != null)
            {
                currentSelectedButton.BackColor = OriginalColor;
            }

            clickedButton.BackColor = SelectedColor;
            currentSelectedButton = clickedButton;
        }

        private void InitializeTallyBoard()
        {
            panelTally = new FlowLayoutPanel
            {
                Name = "panelTally",
                BackColor = Color.White,
                Location = new Point(38, 450),
                Size = new Size(700, 500),
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };
            panel3.Controls.Add(panelTally);

            tallyTimer = new System.Windows.Forms.Timer
            {
                Interval = 10000 // refresh every 10 seconds
            };
            tallyTimer.Tick += (s, e) => UpdateTally();
            tallyTimer.Start();

            UpdateTally();
        }

        private void InitializeVotersPanel()
        {
            panelVoters = new FlowLayoutPanel
            {
                Name = "panelVoters",
                BackColor = Color.White,
                Location = new Point(900, 100), // Right of tally panel
                Size = new Size(300, 450),
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };
            panel3.Controls.Add(panelVoters);

            // Load voters initially
            UpdateVotersPanel();

            // Optional: refresh every 10 seconds
            var votersTimer = new System.Windows.Forms.Timer { Interval = 10000 };
            votersTimer.Tick += (s, e) => UpdateVotersPanel();
            votersTimer.Start();
        }

        private void UpdateVotersPanel()
        {
            int latestElectionID = GetLatestElectionID();
            if (latestElectionID == 0) return;  // No election, skip

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Filter voters who have voted in the current election (assuming Votes table has ElectionID)
                    string query = @"SELECT DISTINCT V.StudNo, V.VotedAt 
                             FROM Voters V 
                             INNER JOIN Votes VT ON V.StudNo = VT.StudNo AND VT.ElectionID = @ElectionID 
                             WHERE V.HasVoted = 1 
                             ORDER BY V.VotedAt DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ElectionID", latestElectionID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable voters = new DataTable();
                    adapter.Fill(voters);

                    panelVoters.Controls.Clear();

                    foreach (DataRow row in voters.Rows)
                    {
                        int studNo = Convert.ToInt32(row["StudNo"]);
                        DateTime votedAt = Convert.ToDateTime(row["VotedAt"]);

                        Label lbl = new Label
                        {
                            Text = $"Student: {studNo} \nTime: {votedAt:MM/dd/yyyy hh:mm tt}",
                            Font = new Font("Segoe UI", 10),
                            AutoSize = true,
                            Margin = new Padding(5)
                        };
                        panelVoters.Controls.Add(lbl);
                    }
                }
            }
            catch (Exception ex)
            {
                // Optional: log errors
            }
        }

        private void UpdateTally()
        {
            int latestElectionID = GetLatestElectionID();
            if (latestElectionID == 0 || IsElectionCompleted(latestElectionID))
            {
                panelTally.Controls.Clear();
                Label lblNoCurrent = new Label
                {
                    Text = "No ongoing election.",
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    AutoSize = true
                };
                panelTally.Controls.Add(lblNoCurrent);
                return;
            }

            // Proceed with live tally for ongoing election
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string posQuery = "SELECT PositionID, PositionName FROM Positions ORDER BY PositionOrder";
                    SqlDataAdapter posAdapter = new SqlDataAdapter(posQuery, conn);
                    DataTable positions = new DataTable();
                    posAdapter.Fill(positions);

                    panelTally.Controls.Clear();

                    foreach (DataRow posRow in positions.Rows)
                    {
                        int positionID = Convert.ToInt32(posRow["PositionID"]);
                        string positionName = posRow["PositionName"].ToString();

                        Label lblPosition = new Label
                        {
                            Text = positionName,
                            Font = new Font("Segoe UI", 14, FontStyle.Bold),
                            AutoSize = true
                        };
                        panelTally.Controls.Add(lblPosition);

                        string voteQuery = @"
                      SELECT C.FullName, COUNT(V.VoteID) AS Votes
                      FROM Candidates C
                      LEFT JOIN Votes V ON C.CandidID = V.CandidID AND V.ElectionID = @ElectionID
                      WHERE C.PositionID = @PositionID AND C.ElectionID = @ElectionID
                      GROUP BY C.FullName
                      ORDER BY Votes DESC";

                        using (SqlCommand cmd = new SqlCommand(voteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@PositionID", positionID);
                            cmd.Parameters.AddWithValue("@ElectionID", latestElectionID);
                            SqlDataAdapter voteAdapter = new SqlDataAdapter(cmd);
                            DataTable votes = new DataTable();
                            voteAdapter.Fill(votes);

                            foreach (DataRow voteRow in votes.Rows)
                            {
                                string candidate = voteRow["FullName"].ToString();
                                int voteCount = Convert.ToInt32(voteRow["Votes"]);

                                Label lblCandidate = new Label
                                {
                                    Text = $"   {candidate}: {voteCount} vote(s)",
                                    Font = new Font("Segoe UI", 12),
                                    AutoSize = true
                                };
                                panelTally.Controls.Add(lblCandidate);
                            }

                            panelTally.Controls.Add(new Label { Height = 15 });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Optional: log errors
            }
        }


        private bool IsElectionCompleted(int electionID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Status FROM Elections WHERE ElectionID = @ElectionID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ElectionID", electionID);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null && result.ToString() == "Completed";
            }
        }

        // ========================
        // Empty stubs for Designer events to prevent compile errors
        // ========================
        private void panel3_Paint_1(object sender, PaintEventArgs e) { }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            Visible = false;
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            LoginForm f2 = new LoginForm();
            f2.Show();
            Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                manageContainer.Height += 15;
                if (manageContainer.Height >= manageContainer.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }
            }
            else
            {
                manageContainer.Height -= 15;
                if (manageContainer.Height <= manageContainer.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                }
            }
        }

        private void panel3_Paint_2(object sender, PaintEventArgs e) { }
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

        private void panelEndDate_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void btnManage_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void btnCandidates_Click_1(object sender, EventArgs e)
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
        private void btnElection_Click_1(object sender, EventArgs e)
        {
            Election elec = new Election();
            elec.Show();
            Visible = false;
        }

        private void dgvElections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void comboBoxElections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxElections.SelectedValue == null) return;

            // Fix casting: Check if it's an int or DataRowView
            int selectedID;
            if (comboBoxElections.SelectedValue is int)
            {
                selectedID = (int)comboBoxElections.SelectedValue;
            }
            else if (comboBoxElections.SelectedValue is System.Data.DataRowView drv)
            {
                selectedID = Convert.ToInt32(drv["ElectionID"]);
            }
            else
            {
                return;  // Invalid selection
            }

            if (selectedID == -1)  // Current election - just refresh tally (no past results)
            {
                panelPastResults.Visible = false;
                UpdateTally();  // Refresh live tally
            }
            else  // Past election - show past results in panelPastResults
            {
                panelPastResults.Visible = true;
                LoadPastElectionResults(selectedID);
            }
        }

        private void LoadPastElectionResults(int electionID)
        {
            panelPastResults.Controls.Clear();

            Label headerLabel = new Label
            {
                Text = $"Results for: {comboBoxElections.Text}",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                AutoSize = true
            };
            panelPastResults.Controls.Add(headerLabel);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string posQuery = "SELECT PositionID, PositionName FROM Positions ORDER BY PositionOrder";
                    SqlDataAdapter posAdapter = new SqlDataAdapter(posQuery, conn);
                    DataTable positions = new DataTable();
                    posAdapter.Fill(positions);

                    foreach (DataRow posRow in positions.Rows)
                    {
                        int positionID = Convert.ToInt32(posRow["PositionID"]);
                        string positionName = posRow["PositionName"].ToString();

                        Label lblPosition = new Label
                        {
                            Text = positionName,
                            Font = new Font("Segoe UI", 12, FontStyle.Bold),
                            AutoSize = true
                        };
                        panelPastResults.Controls.Add(lblPosition);

                        // Get winner (top candidate) for this position and election
                        string winnerQuery = @"
                      SELECT TOP 1 C.FullName, COUNT(V.VoteID) AS Votes
                      FROM Candidates C
                      LEFT JOIN Votes V ON C.CandidID = V.CandidID AND V.ElectionID = @ElectionID
                      WHERE C.PositionID = @PositionID AND C.ElectionID = @ElectionID
                      GROUP BY C.FullName
                      ORDER BY Votes DESC";

                        using (SqlCommand cmd = new SqlCommand(winnerQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@PositionID", positionID);
                            cmd.Parameters.AddWithValue("@ElectionID", electionID);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable winnerTable = new DataTable();
                            adapter.Fill(winnerTable);

                            if (winnerTable.Rows.Count > 0)
                            {
                                DataRow row = winnerTable.Rows[0];
                                string winner = row["FullName"].ToString();
                                int votes = Convert.ToInt32(row["Votes"]);

                                Label lblWinner = new Label
                                {
                                    Text = $"   Winner: {winner} ({votes} votes)",
                                    Font = new Font("Segoe UI", 10),
                                    AutoSize = true
                                };
                                panelPastResults.Controls.Add(lblWinner);
                            }
                            else
                            {
                                Label lblNoWinner = new Label
                                {
                                    Text = "   No votes recorded.",
                                    Font = new Font("Segoe UI", 10),
                                    AutoSize = true
                                };
                                panelPastResults.Controls.Add(lblNoWinner);
                            }
                        }

                        panelPastResults.Controls.Add(new Label { Height = 10 });  // Spacer
                    }
                }
            }
            catch (Exception ex)
            {
                panelPastResults.Controls.Add(new Label { Text = $"Error: {ex.Message}", AutoSize = true });
            }
        }


        private void UpdateTallyForElection(int electionID)
        {
            // Removed: int electionID = GetLatestElectionID();  // Don't shadow the parameter
            if (electionID == 0) return;  // No election, skip

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string posQuery = "SELECT PositionID, PositionName FROM Positions ORDER BY PositionOrder";
                    SqlDataAdapter posAdapter = new SqlDataAdapter(posQuery, conn);
                    DataTable positions = new DataTable();
                    posAdapter.Fill(positions);

                    panelTally.Controls.Clear();

                    foreach (DataRow posRow in positions.Rows)
                    {
                        int positionID = Convert.ToInt32(posRow["PositionID"]);
                        string positionName = posRow["PositionName"].ToString();

                        Label lblPosition = new Label
                        {
                            Text = positionName,
                            Font = new Font("Segoe UI", 14, FontStyle.Bold),
                            AutoSize = true
                        };
                        panelTally.Controls.Add(lblPosition);

                        string voteQuery = @"
                    SELECT C.FullName, COUNT(V.VoteID) AS Votes
                    FROM Candidates C
                    LEFT JOIN Votes V ON C.CandidID = V.CandidID AND V.ElectionID = @ElectionID
                    WHERE C.PositionID = @PositionID AND C.ElectionID = @ElectionID
                    GROUP BY C.FullName
                    ORDER BY Votes DESC";

                        using (SqlCommand cmd = new SqlCommand(voteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@PositionID", positionID);
                            cmd.Parameters.AddWithValue("@ElectionID", electionID);  // Uses the passed parameter
                            SqlDataAdapter voteAdapter = new SqlDataAdapter(cmd);
                            DataTable votes = new DataTable();
                            voteAdapter.Fill(votes);

                            foreach (DataRow voteRow in votes.Rows)
                            {
                                string candidate = voteRow["FullName"].ToString();
                                int voteCount = Convert.ToInt32(voteRow["Votes"]);

                                Label lblCandidate = new Label
                                {
                                    Text = $"   {candidate}: {voteCount} vote(s)",
                                    Font = new Font("Segoe UI", 12),
                                    AutoSize = true
                                };
                                panelTally.Controls.Add(lblCandidate);
                            }

                            panelTally.Controls.Add(new Label { Height = 15 });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Optional: log errors or show message
            }
        }

        private void LoadElectionComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Load completed elections
                    string query = "SELECT ElectionID, ElectionName FROM Elections WHERE Status = 'Completed' ORDER BY ElectionDate DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Add "Current" as the first option
                    DataRow currentRow = dt.NewRow();
                    currentRow["ElectionID"] = -1;  // Special ID for current
                    currentRow["ElectionName"] = "Current (Ongoing Election)";
                    dt.Rows.InsertAt(currentRow, 0);

                    // SET THESE FIRST (important!)
                    comboBoxElections.DisplayMember = "ElectionName";
                    comboBoxElections.ValueMember = "ElectionID";

                    // THEN APPLY DATASOURCE
                    comboBoxElections.DataSource = dt;

                    comboBoxElections.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading elections: " + ex.Message);
            }
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
    }
}
