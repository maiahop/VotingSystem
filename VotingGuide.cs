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
    public partial class VotingGuide : Form
    {
        private int _studNo; // Store voter ID

        // Default constructor for Designer
        public VotingGuide()
        {
            InitializeComponent();
            _studNo = -1; // default value
        }

        // Constructor used after login
        public VotingGuide(int studNo)
        {
            InitializeComponent();
            _studNo = studNo;
        }

        bool expand = false;

        private void label1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pass voter ID to Presidentvote
            Presidentvote pv = new Presidentvote(_studNo);
            pv.Show();
            this.Hide();
        }

        private void VotingGuide_Load(object sender, EventArgs e) { }

        private void timer1_Tick(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void menuContainer_Paint(object sender, PaintEventArgs e) { }

        private void button4_Click(object sender, EventArgs e) { }
    }
}
