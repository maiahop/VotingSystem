namespace OnlineVotingDraft
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            btnElection = new Button();
            manageContainer = new Panel();
            btnVoters = new Button();
            btnCandidates = new Button();
            btnManage = new Button();
            btnDashboard = new Button();
            btnStopElection = new Button();
            btnLogOut = new Button();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            panelPastResults = new FlowLayoutPanel();
            comboBoxElections = new ComboBox();
            label8 = new Label();
            panel2.SuspendLayout();
            manageContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 37, 75);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnElection);
            panel2.Controls.Add(manageContainer);
            panel2.Controls.Add(btnDashboard);
            panel2.Controls.Add(btnStopElection);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 1055);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnElection
            // 
            btnElection.BackColor = Color.FromArgb(23, 37, 75);
            btnElection.Dock = DockStyle.Top;
            btnElection.FlatAppearance.BorderSize = 0;
            btnElection.FlatStyle = FlatStyle.Flat;
            btnElection.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnElection.ForeColor = Color.White;
            btnElection.Image = BSIT_EVOTE.Properties.Resources.execution_30x30;
            btnElection.Location = new Point(0, 339);
            btnElection.Margin = new Padding(0);
            btnElection.Name = "btnElection";
            btnElection.Size = new Size(322, 91);
            btnElection.TabIndex = 16;
            btnElection.Text = "Election";
            btnElection.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnElection.UseVisualStyleBackColor = false;
            btnElection.Click += btnElection_Click_1;
            // 
            // manageContainer
            // 
            manageContainer.BackColor = Color.FromArgb(23, 37, 75);
            manageContainer.Controls.Add(btnVoters);
            manageContainer.Controls.Add(btnCandidates);
            manageContainer.Controls.Add(btnManage);
            manageContainer.Dock = DockStyle.Top;
            manageContainer.Font = new Font("Microsoft Sans Serif", 15F);
            manageContainer.ForeColor = Color.White;
            manageContainer.Location = new Point(0, 248);
            manageContainer.Margin = new Padding(0);
            manageContainer.MaximumSize = new Size(325, 273);
            manageContainer.MinimumSize = new Size(325, 91);
            manageContainer.Name = "manageContainer";
            manageContainer.Size = new Size(325, 91);
            manageContainer.TabIndex = 15;
            // 
            // btnVoters
            // 
            btnVoters.BackColor = Color.FromArgb(18, 44, 64);
            btnVoters.Dock = DockStyle.Top;
            btnVoters.FlatAppearance.BorderSize = 0;
            btnVoters.FlatStyle = FlatStyle.Flat;
            btnVoters.Font = new Font("Segoe UI", 15F);
            btnVoters.Location = new Point(0, 182);
            btnVoters.Margin = new Padding(0);
            btnVoters.Name = "btnVoters";
            btnVoters.Size = new Size(325, 91);
            btnVoters.TabIndex = 8;
            btnVoters.Text = "Voters";
            btnVoters.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVoters.UseVisualStyleBackColor = false;
            btnVoters.Click += btnVoters_Click;
            // 
            // btnCandidates
            // 
            btnCandidates.BackColor = Color.FromArgb(18, 44, 64);
            btnCandidates.Dock = DockStyle.Top;
            btnCandidates.FlatAppearance.BorderSize = 0;
            btnCandidates.FlatStyle = FlatStyle.Flat;
            btnCandidates.Font = new Font("Segoe UI", 15F);
            btnCandidates.Location = new Point(0, 91);
            btnCandidates.Margin = new Padding(0);
            btnCandidates.Name = "btnCandidates";
            btnCandidates.Size = new Size(325, 91);
            btnCandidates.TabIndex = 7;
            btnCandidates.Text = "Candidates";
            btnCandidates.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCandidates.UseVisualStyleBackColor = false;
            btnCandidates.Click += btnCandidates_Click_1;
            // 
            // btnManage
            // 
            btnManage.Dock = DockStyle.Top;
            btnManage.FlatAppearance.BorderSize = 0;
            btnManage.FlatStyle = FlatStyle.Flat;
            btnManage.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManage.Image = BSIT_EVOTE.Properties.Resources.user_setting_1_2_40x40;
            btnManage.Location = new Point(0, 0);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(325, 91);
            btnManage.TabIndex = 5;
            btnManage.Text = "Manage";
            btnManage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(23, 37, 75);
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = BSIT_EVOTE.Properties.Resources.objects_column_30x30;
            btnDashboard.Location = new Point(0, 157);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(322, 91);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += button3_Click_1;
            // 
            // btnStopElection
            // 
            btnStopElection.BackColor = Color.DarkOrange;
            btnStopElection.Dock = DockStyle.Bottom;
            btnStopElection.Font = new Font("Microsoft Sans Serif", 12F);
            btnStopElection.ForeColor = Color.Black;
            btnStopElection.Location = new Point(0, 935);
            btnStopElection.Name = "btnStopElection";
            btnStopElection.Size = new Size(322, 59);
            btnStopElection.TabIndex = 3;
            btnStopElection.Text = "See Current Status";
            btnStopElection.UseVisualStyleBackColor = false;
            btnStopElection.Click += btnStopElection_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.Font = new Font("Microsoft Sans Serif", 12F);
            btnLogOut.Location = new Point(0, 994);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(322, 59);
            btnLogOut.TabIndex = 0;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += button1_Click_2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 37, 75);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 157);
            panel1.TabIndex = 0;
            panel1.Paint += panel3_Paint_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(136, 55);
            label4.Name = "label4";
            label4.Size = new Size(121, 41);
            label4.TabIndex = 2;
            label4.Text = "ADMIN";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = BSIT_EVOTE.Properties.Resources._371335320_3632624587017625_5029958005259186519_n_removebg_preview;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 157);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.BackgroundImage = BSIT_EVOTE.Properties.Resources.ADMIN;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(panelPastResults);
            panel3.Controls.Add(comboBoxElections);
            panel3.Controls.Add(label8);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(324, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1600, 1055);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint_2;
            // 
            // panelPastResults
            // 
            panelPastResults.AutoScroll = true;
            panelPastResults.FlowDirection = FlowDirection.TopDown;
            panelPastResults.Location = new Point(54, 85);
            panelPastResults.Name = "panelPastResults";
            panelPastResults.Size = new Size(537, 346);
            panelPastResults.TabIndex = 9;
            panelPastResults.WrapContents = false;
            // 
            // comboBoxElections
            // 
            comboBoxElections.FormattingEnabled = true;
            comboBoxElections.Location = new Point(54, 51);
            comboBoxElections.Name = "comboBoxElections";
            comboBoxElections.Size = new Size(372, 28);
            comboBoxElections.TabIndex = 8;
            comboBoxElections.SelectedIndexChanged += comboBoxElections_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Calibri", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(926, 46);
            label8.Name = "label8";
            label8.Size = new Size(258, 54);
            label8.TabIndex = 6;
            label8.Text = "Voters Voted";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Voting System";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            manageContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Label label4;
        private Button btnStopElection;
        private Button btnLogOut;
        private Button btnDashboard;
        private Button btnManage;
        private Button btnTally;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private FlowLayoutPanel dropdownContainer;
        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private Panel panel3;
        private Label label3;
        private Panel panelEndDate;
        private Label label2;
        private Panel panelStartDate;
        private Label label1;
        private Button btnElection;
        private Panel manageContainer;
        private Button btnVoters;
        private Button btnCandidates;
        private PictureBox pictureBox2;
        private Label label8;
        private ComboBox comboBoxElections;
        private FlowLayoutPanel panelPastResults;
    }
}
