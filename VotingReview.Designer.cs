namespace OnlineVotingDraft
{
    partial class VotingReview
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VotingReview));
            lblTitle = new Label();
            lblCandidateName = new TextBox();
            btnConfirm = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            btnLogout = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(613, 133);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(699, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Review Your Voted Candidates";
            // 
            // lblCandidateName
            // 
            lblCandidateName.BackColor = Color.White;
            lblCandidateName.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCandidateName.ForeColor = Color.DarkBlue;
            lblCandidateName.Location = new Point(640, 233);
            lblCandidateName.Multiline = true;
            lblCandidateName.Name = "lblCandidateName";
            lblCandidateName.ReadOnly = true;
            lblCandidateName.ScrollBars = ScrollBars.Vertical;
            lblCandidateName.Size = new Size(634, 462);
            lblCandidateName.TabIndex = 1;
            lblCandidateName.TabStop = false;
            lblCandidateName.TextChanged += lblCandidateName_TextChanged;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.DarkOrange;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(970, 772);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(291, 71);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm Vote";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(28, 66, 97);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(646, 772);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(291, 71);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 37, 75);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 75);
            panel1.TabIndex = 20;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Right;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1771, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(133, 75);
            btnLogout.TabIndex = 19;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(114, 13);
            label2.Name = "label2";
            label2.Size = new Size(249, 45);
            label2.TabIndex = 11;
            label2.Text = "BSIT 3C E-Vote";
            // 
            // VotingReview
            // 
            BackColor = SystemColors.Control;
            BackgroundImage = BSIT_EVOTE.Properties.Resources.ADMIN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnConfirm);
            Controls.Add(lblCandidateName);
            Controls.Add(lblTitle);
            Name = "VotingReview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Voting Review";
            WindowState = FormWindowState.Maximized;
            Load += VotingReview_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox lblCandidateName; // Changed from Label to TextBox
        private Button btnConfirm;
        private Button btnBack;
        private Panel panel1;
        private Button btnLogout;
        private PictureBox pictureBox2;
        private Label label2;
    }
}
