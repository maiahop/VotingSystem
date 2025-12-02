using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace OnlineVotingDraft
{
    public partial class Presidentvote : Form
    {
        private string connectionString = @"Data Source=LAPTOP-7N9A002P\SQLEXPRESS02;Initial Catalog=ElectionDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        private Dictionary<string, List<CheckBox>> positionCheckboxes = new Dictionary<string, List<CheckBox>>();

        // Candidate font settings
        private string candidateFontName = "Segoe UI";
        private float candidateFontSize = 18f;
        private Color candidateFontColor = Color.Black;

        // Layout settings
        private int firstRowY = 280;
        private int secondRowY = 635;
        private int firstRowSpacingX = 450;
        private int secondRowSpacingX = 450;
        private int spacingY = 35;
        private int firstRowStartX = 100;
        private int secondRowStartX = 100;
        private int firstRowCount = 4;
        private int secondRowCount = 3;

        private int _studNo; // store voter ID

        public Presidentvote(int studNo)
        {
            InitializeComponent();
            this.BackColor = Color.White;
            _studNo = studNo; // store the voter ID
        }

        private void Presidentvote_Load(object sender, EventArgs e)
        {
            LoadCandidatesForVoting();
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
        private void LoadCandidatesForVoting()
        {
            int latestElectionID = GetLatestElectionID();
            if (latestElectionID == 0)
            {
                MessageBox.Show("No active election. Contact admin.", "Error");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        @"SELECT P.PositionName, C.FullName, C.CandidID
                  FROM Candidates C
                  INNER JOIN Positions P ON C.PositionID = P.PositionID
                  WHERE C.ElectionID = @ElectionID
                  ORDER BY P.PositionOrder, C.CandidateOrder, C.CandidID", conn);
                    cmd.Parameters.AddWithValue("@ElectionID", latestElectionID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    var groupedPositions = dt.AsEnumerable()
                                             .GroupBy(r => r.Field<string>("PositionName"))
                                             .ToList();

                    positionCheckboxes.Clear();

                    for (int i = 0; i < groupedPositions.Count; i++)
                    {
                        string positionName = groupedPositions[i].Key;
                        var candidates = groupedPositions[i].ToList();

                        int row, col;
                        int xOffset, yOffset;

                        if (i < firstRowCount)
                        {
                            row = 0;
                            col = i;
                            yOffset = firstRowY;
                            xOffset = firstRowStartX + col * firstRowSpacingX;
                        }
                        else
                        {
                            row = 1;
                            col = i - firstRowCount;
                            yOffset = secondRowY;

                            int totalWidthFirstRow = (firstRowCount - 1) * firstRowSpacingX;
                            int totalWidthSecondRow = (secondRowCount - 1) * secondRowSpacingX;
                            int centerOffset = (totalWidthFirstRow - totalWidthSecondRow) / 2;

                            xOffset = secondRowStartX + centerOffset + col * secondRowSpacingX;
                        }

                        positionCheckboxes[positionName] = new List<CheckBox>();

                        foreach (var rowData in candidates)
                        {
                            CheckBox cb = new CheckBox
                            {
                                Text = rowData.Field<string>("FullName"),
                                Tag = positionName,
                                Location = new Point(xOffset + 10, yOffset),
                                AutoSize = true,
                                ForeColor = candidateFontColor,
                                BackColor = Color.Transparent,
                                Font = new Font(candidateFontName, candidateFontSize, FontStyle.Regular)
                            };
                            cb.CheckedChanged += CandidateCheckbox_CheckedChanged;

                            positionCheckboxes[positionName].Add(cb);
                            this.Controls.Add(cb);
                            yOffset += spacingY;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading candidates for voting: " + ex.Message);
            }
        }

        private void CandidateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is not CheckBox clicked) return;

            if (clicked.Checked)
            {
                foreach (var cb in positionCheckboxes[clicked.Tag.ToString()])
                {
                    if (cb != clicked)
                        cb.Checked = false;
                }
            }
        }

        // Next button click (was button1_Click)
        private void btnNext_Click(object sender, EventArgs e)
        {
            var selections = new Dictionary<string, string>();
            foreach (var kvp in positionCheckboxes)
            {
                string position = kvp.Key;
                CheckBox selected = kvp.Value.FirstOrDefault(cb => cb.Checked);
                if (selected == null)
                {
                    MessageBox.Show($"Please select a candidate for {position}.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                selections[position] = selected.Text;
            }

            // Pass StudNo to VotingReview
            VotingReview reviewForm = new VotingReview(selections, _studNo);
            reviewForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            VotingGuide guide = new VotingGuide();
            guide.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        public void SetCandidateStyle(string fontName, float fontSize, Color color)
        {
            candidateFontName = fontName;
            candidateFontSize = fontSize;
            candidateFontColor = color;

            foreach (var kvp in positionCheckboxes)
            {
                foreach (var cb in kvp.Value)
                {
                    cb.Font = new Font(candidateFontName, candidateFontSize, FontStyle.Regular);
                    cb.ForeColor = candidateFontColor;
                }
            }
        }

        // Optional Backward compatibility for old Designer events
        private void button1_Click(object sender, EventArgs e) => btnNext_Click(sender, e);
        private void button2_Click(object sender, EventArgs e) => btnBack_Click(sender, e);
        private void label1_Click(object sender, EventArgs e) { }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var selections = new Dictionary<string, string>();
            foreach (var kvp in positionCheckboxes)
            {
                string position = kvp.Key;
                CheckBox selected = kvp.Value.FirstOrDefault(cb => cb.Checked);
                if (selected == null)
                {
                    MessageBox.Show($"Please select a candidate for {position}.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                selections[position] = selected.Text;
            }

            // Pass StudNo to VotingReview
            VotingReview reviewForm = new VotingReview(selections, _studNo);
            reviewForm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VotingGuide guide = new VotingGuide();
            guide.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
