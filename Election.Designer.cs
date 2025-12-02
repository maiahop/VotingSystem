namespace OnlineVotingDraft
{
    partial class Election
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            panel3 = new Panel();
            dgvElections = new DataGridView();
            panelEndDate = new Panel();
            dtpElectionDate = new DateTimePicker();
            label5 = new Label();
            label2 = new Label();
            txtElectionName = new TextBox();
            btnAddElection = new Button();
            label1 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            manageContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvElections).BeginInit();
            panelEndDate.SuspendLayout();
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
            panel2.TabIndex = 4;
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
            btnElection.Click += btnElection_Click;
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
            btnCandidates.Click += btnCandidates_Click;
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
            btnManage.Click += btnManage_Click_1;
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
            btnDashboard.Padding = new Padding(3);
            btnDashboard.Size = new Size(322, 91);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnOverview_Click;
            // 
            // btnStopElection
            // 
            btnStopElection.BackColor = Color.Red;
            btnStopElection.Dock = DockStyle.Bottom;
            btnStopElection.Font = new Font("Microsoft Sans Serif", 12F);
            btnStopElection.ForeColor = Color.White;
            btnStopElection.Location = new Point(0, 935);
            btnStopElection.Name = "btnStopElection";
            btnStopElection.Size = new Size(322, 59);
            btnStopElection.TabIndex = 3;
            btnStopElection.Text = "Stop Election";
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
            btnLogOut.Click += btnLogOut_Click;
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
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(322, 157);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(136, 55);
            label4.Name = "label4";
            label4.Size = new Size(121, 41);
            label4.TabIndex = 4;
            label4.Text = "ADMIN";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = BSIT_EVOTE.Properties.Resources._371335320_3632624587017625_5029958005259186519_n_removebg_preview;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.BackgroundImage = BSIT_EVOTE.Properties.Resources.ADMIN;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(dgvElections);
            panel3.Controls.Add(panelEndDate);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(324, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1600, 1055);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // dgvElections
            // 
            dgvElections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElections.Location = new Point(692, 60);
            dgvElections.Name = "dgvElections";
            dgvElections.ReadOnly = true;
            dgvElections.RowHeadersWidth = 51;
            dgvElections.Size = new Size(748, 624);
            dgvElections.TabIndex = 2;
            // 
            // panelEndDate
            // 
            panelEndDate.BackColor = Color.White;
            panelEndDate.BackgroundImageLayout = ImageLayout.Stretch;
            panelEndDate.Controls.Add(dtpElectionDate);
            panelEndDate.Controls.Add(label5);
            panelEndDate.Controls.Add(label2);
            panelEndDate.Controls.Add(txtElectionName);
            panelEndDate.Controls.Add(btnAddElection);
            panelEndDate.Controls.Add(label1);
            panelEndDate.Location = new Point(33, 56);
            panelEndDate.Name = "panelEndDate";
            panelEndDate.Size = new Size(575, 392);
            panelEndDate.TabIndex = 1;
            panelEndDate.Paint += panelEndDate_Paint;
            // 
            // dtpElectionDate
            // 
            dtpElectionDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpElectionDate.Location = new Point(191, 163);
            dtpElectionDate.Name = "dtpElectionDate";
            dtpElectionDate.Size = new Size(325, 30);
            dtpElectionDate.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(29, 168);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 14;
            label5.Text = "Election Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(26, 102);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 13;
            label2.Text = "Election Name";
            // 
            // txtElectionName
            // 
            txtElectionName.Font = new Font("Microsoft Sans Serif", 12F);
            txtElectionName.Location = new Point(191, 102);
            txtElectionName.Name = "txtElectionName";
            txtElectionName.Size = new Size(325, 30);
            txtElectionName.TabIndex = 10;
            // 
            // btnAddElection
            // 
            btnAddElection.BackColor = Color.DarkOrange;
            btnAddElection.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddElection.Location = new Point(397, 234);
            btnAddElection.Name = "btnAddElection";
            btnAddElection.Size = new Size(119, 60);
            btnAddElection.TabIndex = 6;
            btnAddElection.Text = "Save";
            btnAddElection.UseVisualStyleBackColor = false;
            btnAddElection.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(130, 41);
            label1.TabIndex = 6;
            label1.Text = "Election";
            label1.Click += label1_Click;
            // 
            // timer2
            // 
            timer2.Interval = 1;
            timer2.Tick += timer2_Tick;
            // 
            // Election
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Election";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Election_Load;
            panel2.ResumeLayout(false);
            manageContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvElections).EndInit();
            panelEndDate.ResumeLayout(false);
            panelEndDate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnDashboard;
        private Button btnStopElection;
        private Button btnLogOut;
        private Panel panel1;
        private Panel panel3;
        private Panel panelEndDate;
        private Button btnAddElection;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txtElectionName;
        private Label label6;
        private Label label5;
        private Label label2;
        private System.Windows.Forms.Timer timer2;
        private Button btnElection;
        private Panel manageContainer;
        private Button btnVoters;
        private Button btnCandidates;
        private Button btnManage;
        private Label label4;
        private PictureBox pictureBox2;      
        private DataGridView dgvElections;
        private DateTimePicker dtpElectionDate;
    }
}