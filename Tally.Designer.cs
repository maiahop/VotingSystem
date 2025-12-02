namespace OnlineVotingDraft
{
    partial class Tally
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tally));
            panel2 = new Panel();
            dropdownContainer = new FlowLayoutPanel();
            panel4 = new Panel();
            btnManage = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnTally = new Button();
            btnOverview = new Button();
            btnStopElection = new Button();
            btnLogOut = new Button();
            panel1 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            dropdownContainer.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dropdownContainer);
            panel2.Controls.Add(btnTally);
            panel2.Controls.Add(btnOverview);
            panel2.Controls.Add(btnStopElection);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 1055);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // dropdownContainer
            // 
            dropdownContainer.BackColor = Color.White;
            dropdownContainer.Controls.Add(panel4);
            dropdownContainer.Controls.Add(button1);
            dropdownContainer.Controls.Add(button2);
            dropdownContainer.Controls.Add(button3);
            dropdownContainer.Dock = DockStyle.Top;
            dropdownContainer.Location = new Point(0, 277);
            dropdownContainer.MaximumSize = new Size(314, 283);
            dropdownContainer.MinimumSize = new Size(314, 69);
            dropdownContainer.Name = "dropdownContainer";
            dropdownContainer.Size = new Size(314, 69);
            dropdownContainer.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnManage);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(314, 69);
            panel4.TabIndex = 6;
            // 
            // btnManage
            // 
            btnManage.FlatAppearance.BorderSize = 0;
            btnManage.FlatStyle = FlatStyle.Flat;
            btnManage.Font = new Font("Segoe UI", 15F);
            btnManage.Image = (Image)resources.GetObject("btnManage.Image");
            btnManage.Location = new Point(0, 0);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(314, 75);
            btnManage.TabIndex = 5;
            btnManage.Text = "Manage";
            btnManage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(0, 69);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(314, 69);
            button1.TabIndex = 7;
            button1.Text = "Candidates";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(0, 138);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(314, 69);
            button2.TabIndex = 8;
            button2.Text = "Voters";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSeaGreen;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(0, 207);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(314, 69);
            button3.TabIndex = 9;
            button3.Text = "Election";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnTally
            // 
            btnTally.BackColor = Color.White;
            btnTally.Dock = DockStyle.Top;
            btnTally.FlatAppearance.BorderSize = 0;
            btnTally.FlatStyle = FlatStyle.Flat;
            btnTally.Font = new Font("Segoe UI", 15F);
            btnTally.Image = (Image)resources.GetObject("btnTally.Image");
            btnTally.Location = new Point(0, 206);
            btnTally.Name = "btnTally";
            btnTally.Size = new Size(293, 71);
            btnTally.TabIndex = 4;
            btnTally.Text = "Tally";
            btnTally.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTally.UseVisualStyleBackColor = false;
            btnTally.Click += btnTally_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.White;
            btnOverview.Dock = DockStyle.Top;
            btnOverview.FlatAppearance.BorderSize = 0;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("Segoe UI", 15F);
            btnOverview.Image = (Image)resources.GetObject("btnOverview.Image");
            btnOverview.Location = new Point(0, 135);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(293, 71);
            btnOverview.TabIndex = 0;
            btnOverview.Text = "Overview";
            btnOverview.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // btnStopElection
            // 
            btnStopElection.BackColor = Color.Red;
            btnStopElection.Dock = DockStyle.Bottom;
            btnStopElection.ForeColor = Color.White;
            btnStopElection.Location = new Point(0, 935);
            btnStopElection.Name = "btnStopElection";
            btnStopElection.Size = new Size(293, 59);
            btnStopElection.TabIndex = 3;
            btnStopElection.Text = "Stop Election";
            btnStopElection.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.Location = new Point(0, 994);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(293, 59);
            btnLogOut.TabIndex = 0;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 119, 27);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 135);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 43);
            label4.Name = "label4";
            label4.Size = new Size(251, 41);
            label4.TabIndex = 0;
            label4.Text = "BSIT 3C - ADMIN";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(295, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1629, 1055);
            panel3.TabIndex = 5;
            panel3.Visible = false;
            panel3.Paint += panel3_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 59);
            label5.Name = "label5";
            label5.Size = new Size(81, 41);
            label5.TabIndex = 4;
            label5.Text = "Tally";
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Tally
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Tally";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Tally_Load;
            panel2.ResumeLayout(false);
            dropdownContainer.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private FlowLayoutPanel dropdownContainer;
        private Panel panel4;
        private Button btnManage;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnTally;
        private Button btnOverview;
        private Button btnStopElection;
        private Button btnLogOut;
        private Panel panel1;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}