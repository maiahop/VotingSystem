namespace OnlineVotingDraft
{
    partial class Candidates
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panelEndDate = new Panel();
            label3 = new Label();
            btnAdd = new Button();
            txtCandidateName = new TextBox();
            btnRemoveAll = new Button();
            comboBoxPositions = new ComboBox();
            btnDelete = new Button();
            dataGridViewCandidates = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            manageContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panelEndDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCandidates).BeginInit();
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
            panel2.Margin = new Padding(3, 4, 3, 4);
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
            btnElection.Location = new Point(0, 521);
            btnElection.Margin = new Padding(0);
            btnElection.Name = "btnElection";
            btnElection.Size = new Size(322, 91);
            btnElection.TabIndex = 14;
            btnElection.Text = "Election";
            btnElection.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnElection.UseVisualStyleBackColor = false;
            btnElection.Click += button8_Click;
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
            manageContainer.Size = new Size(325, 273);
            manageContainer.TabIndex = 13;
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
            btnVoters.Click += button4_Click_1;
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
            btnCandidates.Click += button5_Click;
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
            btnManage.Click += button6_Click;
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
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(322, 91);
            btnDashboard.TabIndex = 2;
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
            btnStopElection.ForeColor = Color.Black;
            btnStopElection.Location = new Point(0, 935);
            btnStopElection.Margin = new Padding(3, 4, 3, 4);
            btnStopElection.Name = "btnStopElection";
            btnStopElection.Size = new Size(322, 59);
            btnStopElection.TabIndex = 3;
            btnStopElection.Text = "Stop Election";
            btnStopElection.UseVisualStyleBackColor = false;
            btnStopElection.Click += btnStopElection_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.White;
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.Font = new Font("Microsoft Sans Serif", 12F);
            btnLogOut.Location = new Point(0, 994);
            btnLogOut.Margin = new Padding(3, 4, 3, 4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(322, 59);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 37, 75);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 157);
            panel1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(136, 55);
            label4.Name = "label4";
            label4.Size = new Size(121, 41);
            label4.TabIndex = 0;
            label4.Text = "ADMIN";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = BSIT_EVOTE.Properties.Resources._371335320_3632624587017625_5029958005259186519_n_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.BackgroundImage = BSIT_EVOTE.Properties.Resources.ADMIN;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(panelEndDate);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(324, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1897, 1055);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // panelEndDate
            // 
            panelEndDate.BackColor = Color.White;
            panelEndDate.Controls.Add(label3);
            panelEndDate.Controls.Add(btnAdd);
            panelEndDate.Controls.Add(txtCandidateName);
            panelEndDate.Controls.Add(btnRemoveAll);
            panelEndDate.Controls.Add(comboBoxPositions);
            panelEndDate.Controls.Add(btnDelete);
            panelEndDate.Controls.Add(dataGridViewCandidates);
            panelEndDate.Location = new Point(50, 13);
            panelEndDate.Margin = new Padding(3, 4, 3, 4);
            panelEndDate.Name = "panelEndDate";
            panelEndDate.Size = new Size(1184, 1007);
            panelEndDate.TabIndex = 1;
            panelEndDate.Paint += panelEndDate_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 21);
            label3.Name = "label3";
            label3.Size = new Size(252, 52);
            label3.TabIndex = 0;
            label3.Text = "Candidates";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 9F);
            btnAdd.Location = new Point(1001, 163);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 55);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCandidateName
            // 
            txtCandidateName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCandidateName.Location = new Point(46, 93);
            txtCandidateName.Margin = new Padding(3, 4, 3, 4);
            txtCandidateName.Name = "txtCandidateName";
            txtCandidateName.PlaceholderText = "Enter candidate name";
            txtCandidateName.Size = new Size(342, 34);
            txtCandidateName.TabIndex = 1;
            txtCandidateName.TextChanged += txtCandidateName_TextChanged;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Font = new Font("Microsoft Sans Serif", 9F);
            btnRemoveAll.Location = new Point(1001, 315);
            btnRemoveAll.Margin = new Padding(3, 4, 3, 4);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(138, 55);
            btnRemoveAll.TabIndex = 6;
            btnRemoveAll.Text = "Remove All";
            btnRemoveAll.Click += btnRemoveAll_Click;
            // 
            // comboBoxPositions
            // 
            comboBoxPositions.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPositions.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPositions.Location = new Point(448, 93);
            comboBoxPositions.Margin = new Padding(3, 4, 3, 4);
            comboBoxPositions.Name = "comboBoxPositions";
            comboBoxPositions.Size = new Size(313, 37);
            comboBoxPositions.TabIndex = 2;
            comboBoxPositions.SelectedIndexChanged += comboBoxPositions_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 9F);
            btnDelete.Location = new Point(1001, 240);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 55);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewCandidates
            // 
            dataGridViewCandidates.ColumnHeadersHeight = 29;
            dataGridViewCandidates.Location = new Point(46, 160);
            dataGridViewCandidates.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCandidates.Name = "dataGridViewCandidates";
            dataGridViewCandidates.ReadOnly = true;
            dataGridViewCandidates.RowHeadersWidth = 51;
            dataGridViewCandidates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCandidates.Size = new Size(914, 795);
            dataGridViewCandidates.TabIndex = 3;
            dataGridViewCandidates.CellContentClick += dataGridViewCandidates_CellContentClick;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Candidates
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Candidates";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Candidates_Load;
            panel2.ResumeLayout(false);
            manageContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panelEndDate.ResumeLayout(false);
            panelEndDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCandidates).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnStopElection;
        private Button btnLogOut;
        private Panel panel1;
        private Label label4;
        private Panel panel3;
        private Panel panelEndDate;
        private Label label3;
        private TextBox txtCandidateName;
        private ComboBox comboBoxPositions;
        private DataGridView dataGridViewCandidates;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnRemoveAll;
        private System.Windows.Forms.Timer timer1;
        private Button btnDashboard;
        private PictureBox pictureBox1;
        private Panel manageContainer;
        private Button btnVoters;
        private Button btnCandidates;
        private Button btnManage;
        private Button btnElection;
    }
}
