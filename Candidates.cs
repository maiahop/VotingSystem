using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace OnlineVotingDraft
{
    public partial class Candidates : Form
    {
        int key = 0;
        private string connectionString = @"Data Source=LAPTOP-7N9A002P\SQLEXPRESS02;Initial Catalog=ElectionDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        bool expand = false;

        // Define the colors using the specified RGB values
        private readonly Color OriginalColor = Color.FromArgb(18, 44, 64);
        private readonly Color SelectedColor = Color.FromArgb(210, 113, 10);

        // Track the currently selected button
        private Button currentSelectedButton = null;

        public Candidates()
        {
            InitializeComponent();

            btnVoters.Click += NavButton_Click;
            btnCandidates.Click += NavButton_Click;
            btnManage.Click += NavButton_Click;

            NavButton_Click(btnCandidates, EventArgs.Empty);

        }

        private void Candidates_Load(object sender, EventArgs e)
        {
            LoadPositions(); // Populate positions dropdown
            LoadCandidates();
        }

        #region Original Navigation Buttons
        private void btnOverview_Click(object sender, EventArgs e)
        {
            Dashboard overview = new Dashboard();
            overview.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!expand)
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
        #endregion

        #region Manage Candidates Functions
        private void LoadPositions()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Use PositionOrder to get positions in desired order
                    SqlCommand cmd = new SqlCommand(
                        "SELECT PositionID, PositionName FROM Positions ORDER BY PositionOrder", conn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBoxPositions.DisplayMember = "PositionName";
                    comboBoxPositions.ValueMember = "PositionID";
                    comboBoxPositions.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading positions: " + ex.Message);
            }
        }

        private void LoadCandidates()
        {
            if (comboBoxPositions.SelectedValue == null) return;

            int positionId = Convert.ToInt32(comboBoxPositions.SelectedValue);
            int latestElectionID = GetLatestElectionID();

            if (latestElectionID == 0)
            {
                MessageBox.Show("No active election. Add one first.", "No Election");
                dataGridViewCandidates.DataSource = null;
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT CandidID, FullName FROM Candidates WHERE PositionID=@PositionID AND ElectionID=@ElectionID ORDER BY CandidateOrder, CandidID", conn);
                    cmd.Parameters.AddWithValue("@PositionID", positionId);
                    cmd.Parameters.AddWithValue("@ElectionID", latestElectionID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewCandidates.DataSource = dt;
                    if (dataGridViewCandidates.Columns.Contains("CandidID"))
                        dataGridViewCandidates.Columns["CandidID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading candidates: " + ex.Message);
            }
        }

        private void comboBoxPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCandidates();
        }

        private int GetLatestElectionID()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 ElectionID FROM Elections ORDER BY ElectionID DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? (int)result : 0;  // 0 if no elections
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCandidateName.Text) || comboBoxPositions.SelectedValue == null)
            {
                MessageBox.Show("Enter candidate name and select a position.");
                return;
            }

            int positionId = Convert.ToInt32(comboBoxPositions.SelectedValue);
            string candidateName = txtCandidateName.Text.Trim();
            int latestElectionID = GetLatestElectionID();

            if (latestElectionID == 0)
            {
                MessageBox.Show("No active election. Add one first in the Election form.", "No Election");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Candidates (FullName, PositionID, ElectionID) VALUES (@FullName, @PositionID, @ElectionID)", conn);
                    cmd.Parameters.AddWithValue("@FullName", candidateName);
                    cmd.Parameters.AddWithValue("@PositionID", positionId);
                    cmd.Parameters.AddWithValue("@ElectionID", latestElectionID);
                    cmd.ExecuteNonQuery();
                }

                LoadCandidates();
                txtCandidateName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding candidate: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCandidates.CurrentRow == null) return;

            int candidateId = Convert.ToInt32(dataGridViewCandidates.CurrentRow.Cells["CandidID"].Value);
            int latestElectionID = GetLatestElectionID();

            if (latestElectionID == 0) return;  // Safety check

            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete this candidate?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Candidates WHERE CandidID=@CandidID AND ElectionID=@ElectionID", conn);
                    cmd.Parameters.AddWithValue("@CandidID", candidateId);
                    cmd.Parameters.AddWithValue("@ElectionID", latestElectionID);
                    cmd.ExecuteNonQuery();
                }

                LoadCandidates();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting candidate: " + ex.Message);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (comboBoxPositions.SelectedValue == null) return;

            int positionId = Convert.ToInt32(comboBoxPositions.SelectedValue);
            int latestElectionID = GetLatestElectionID();

            if (latestElectionID == 0) return;  // Safety check

            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete all candidates for this position in the current election?",
                "Confirm Delete All", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Candidates WHERE PositionID=@PositionID AND ElectionID=@ElectionID", conn);
                    cmd.Parameters.AddWithValue("@PositionID", positionId);
                    cmd.Parameters.AddWithValue("@ElectionID", latestElectionID);
                    cmd.ExecuteNonQuery();
                }

                LoadCandidates();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing all candidates: " + ex.Message);
            }
        }
        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            // Optional placeholder
        }

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
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCandidateName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Candidates candi = new Candidates();
            candi.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Election elec = new Election();
            elec.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Voters voters = new Voters();
            voters.Show();
            this.Hide();
        }

        private void btnStopElection_Click(object sender, EventArgs e)
        {

        }

        private void panelEndDate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewCandidates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {


        }
    }
}
