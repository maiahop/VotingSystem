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
    public partial class Election : Form
    {
        // Define the colors using the specified RGB values
        private readonly Color OriginalColor = Color.FromArgb(23, 37, 75);
        private readonly Color SelectedColor = Color.FromArgb(210, 113, 10);

        private string connectionString =
    @"Data Source=LAPTOP-7N9A002P\SQLEXPRESS02;Initial Catalog=ElectionDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        // Track the currently selected button
        private Button currentSelectedButton = null;
        public Election()
        {
            InitializeComponent();
        }
        bool expand = false;

        private void NavButton_Click(object sender, EventArgs e)
        {
            // 1. Get the button that triggered the event
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtElectionName.Text))
            {
                MessageBox.Show("Please enter an election name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Only reset voters (preserve all past votes and candidates)
                        SqlCommand resetVoters = new SqlCommand(
                            "UPDATE Voters SET HasVoted = 0, VotedAt = NULL;",
                            conn, transaction
                        );
                        resetVoters.ExecuteNonQuery();

                        // Insert the new election
                        SqlCommand insertElection = new SqlCommand(
                            "INSERT INTO Elections (ElectionName, ElectionDate) OUTPUT INSERTED.ElectionID VALUES (@Name, @Date);",
                            conn, transaction
                        );
                        insertElection.Parameters.AddWithValue("@Name", txtElectionName.Text.Trim());
                        insertElection.Parameters.AddWithValue("@Date", dtpElectionDate.Value);
                        int newID = (int)insertElection.ExecuteScalar();

                        transaction.Commit();

                        MessageBox.Show($"New election added with ID: {newID}.\nVoters can vote again. All past votes and candidates are preserved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtElectionName.Clear();
                        dtpElectionDate.Value = DateTime.Now;
                        LoadElections();  // Refresh the DataGridView
                    }
                    catch (Exception innerEx)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Failed to add election. Rolled back. Error: {innerEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void panelEndDate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                manageContainer.Height += 15;
                if (manageContainer.Height >= manageContainer.MaximumSize.Height)
                {
                    timer2.Stop();
                    expand = true;
                }
            }
            else
            {
                manageContainer.Height -= 15;
                if (manageContainer.Height <= manageContainer.MinimumSize.Height)
                {
                    timer2.Stop();
                    expand = false;
                }
            }
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            Dashboard overview = new Dashboard();
            overview.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Voters voters = new Voters();
            voters.Show();
            Visible = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManage_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
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
            this.Hide();
        }

        private void btnElection_Click(object sender, EventArgs e)
        {
            Election elec = new Election();
            elec.Show();
            this.Hide();
        }

        private void Election_Load(object sender, EventArgs e)
        {
            btnDashboard.Click += NavButton_Click;
            btnManage.Click += NavButton_Click;
            btnCandidates.Click += NavButton_Click;
            btnVoters.Click += NavButton_Click;
            btnElection.Click += NavButton_Click;

            NavButton_Click(btnElection, EventArgs.Empty);

            LoadElections();
        }

        private void btnResetElection_Click(object sender, EventArgs e)
        {
        }

        private int AddElection(string name, DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Elections (ElectionName, ElectionDate) OUTPUT INSERTED.ElectionID VALUES (@Name, @Date)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Date", date);
                conn.Open();
                return (int)cmd.ExecuteScalar();  // Returns the new ElectionID
            }
        }
        private void LoadElections()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ElectionID, ElectionName, ElectionDate, Status FROM Elections ORDER BY ElectionDate DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvElections.DataSource = dt;
            }
        }

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

        private void btnStopElection_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Get current election status from Settings
                    string checkQuery = "SELECT ElectionStopped FROM Settings WHERE SettingID = 1";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    bool currentStatus = (bool)checkCmd.ExecuteScalar();

                    // Toggle the status
                    bool newStatus = !currentStatus;

                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Update Settings
                        string updateQuery = "UPDATE Settings SET ElectionStopped = @newStatus WHERE SettingID = 1";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction);
                        updateCmd.Parameters.AddWithValue("@newStatus", newStatus);
                        updateCmd.ExecuteNonQuery();

                        // If stopping the election, mark the latest election as Completed
                        if (newStatus)  // newStatus is true when stopping
                        {
                            int latestID = GetLatestElectionID();
                            if (latestID > 0)
                            {
                                string completeQuery = "UPDATE Elections SET Status = 'Completed' WHERE ElectionID = @ElectionID";
                                SqlCommand completeCmd = new SqlCommand(completeQuery, conn, transaction);
                                completeCmd.Parameters.AddWithValue("@ElectionID", latestID);
                                completeCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();

                        // Update button appearance (call your existing method)
                        SetStopElectionButton(newStatus);

                        // Notify admin
                        string message = newStatus
                            ? "Election has been stopped and marked as completed. Historical results are now available in the dashboard."
                            : "Election has been resumed. Students can now log in and vote.";

                        MessageBox.Show(message, "Election Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        transaction.Rollback();
                        MessageBox.Show("Failed to update election status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
