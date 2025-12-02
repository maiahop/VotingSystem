using System;
using System.Windows.Forms;

namespace OnlineVotingDraft
{
    public partial class Tally : Form
    {
        private bool expand = false;

        public Tally()
        {
            InitializeComponent();
        }

        // Overview button click - opens the Dashboard form
        private void btnOverview_Click(object sender, EventArgs e)
        {
            Dashboard overview = new Dashboard();
            overview.Show();
            this.Visible = false;
        }

        // Timer tick event for expanding/collapsing dropdown
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!expand)
            {
                dropdownContainer.Height += 15;
                if (dropdownContainer.Height >= dropdownContainer.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }
            }
            else
            {
                dropdownContainer.Height -= 15;
                if (dropdownContainer.Height <= dropdownContainer.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                }
            }
        }

        // Manage button click - triggers dropdown animation
        private void btnManage_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        // Candidates button click - opens Candidates form
        private void button1_Click(object sender, EventArgs e)
        {
            Candidates candidates = new Candidates();
            candidates.Show();
            this.Visible = false;
        }

        // Voters button click - opens Voters form
        private void button2_Click(object sender, EventArgs e)
        {
            Voters voters = new Voters();
            voters.Show();
            this.Visible = false;
        }

        // Election button click - opens Election form
        private void button3_Click(object sender, EventArgs e)
        {
            Election election = new Election();
            election.Show();
            this.Visible = false;
        }

        // Panel2 paint event (currently empty)
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        // Tally button click (currently empty)
        private void btnTally_Click(object sender, EventArgs e)
        {
        }

        // Log out button click - opens AdminLog form
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            AdminLog adLog = new AdminLog();
            adLog.Show();
            this.Visible = false;
        }

        // Panel3 paint event (currently empty)
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tally_Load(object sender, EventArgs e)
        {

        }
    }
}
