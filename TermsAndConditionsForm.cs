using OnlineVotingDraft;  // Assuming this is correct for your namespace
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSIT_EVOTE  // Your namespace
{
    public partial class TermsAndConditionsForm : Form
    {
        public TermsAndConditionsForm()
        {
            InitializeComponent();
        }

        private void rtbTerms_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkAgree_CheckedChanged(object sender, EventArgs e)
        {
            btnProceed.Enabled = chkAgree.Checked;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            // Set DialogResult to OK to signal agreement, then close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
            // Do NOT open VotingGuide here—let LoginForm handle it after the dialog closes
        }

        private void TermsAndConditionsForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}