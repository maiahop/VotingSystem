namespace OnlineVotingDraft
{
    partial class CreateAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountForm));
            btnCreate = new Button();
            txtStudNo = new TextBox();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtAge = new TextBox();
            txtPasswordHash = new TextBox();
            txtRePasswordHash = new TextBox();
            panel1 = new Panel();
            btnToggleRePass = new Button();
            btnTogglePass = new Button();
            goback = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top;
            btnCreate.BackColor = Color.DarkOrange;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = SystemColors.ActiveCaptionText;
            btnCreate.Location = new Point(866, 844);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(135, 60);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += button1_Click_1;
            // 
            // txtStudNo
            // 
            txtStudNo.Anchor = AnchorStyles.Top;
            txtStudNo.Font = new Font("Segoe UI", 15F);
            txtStudNo.Location = new Point(841, 392);
            txtStudNo.Name = "txtStudNo";
            txtStudNo.Size = new Size(366, 41);
            txtStudNo.TabIndex = 16;
            txtStudNo.TextChanged += txtStudentNum_TextChanged;
            txtStudNo.Enter += txtStudentNum_Enter;
            txtStudNo.Leave += txtStudentNum_Leave;
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Top;
            txtFullName.Font = new Font("Segoe UI", 15F);
            txtFullName.Location = new Point(841, 465);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(366, 41);
            txtFullName.TabIndex = 17;
            txtFullName.Text = "\r\n";
            txtFullName.TextChanged += textBox2_TextChanged;
            txtFullName.Enter += txtFullName_Enter;
            txtFullName.Leave += txtFullName_Leave;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.Font = new Font("Segoe UI", 15F);
            txtEmail.Location = new Point(841, 546);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(366, 41);
            txtEmail.TabIndex = 18;
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtAge
            // 
            txtAge.Anchor = AnchorStyles.Top;
            txtAge.Font = new Font("Segoe UI", 15F);
            txtAge.Location = new Point(841, 623);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(366, 41);
            txtAge.TabIndex = 19;
            txtAge.Enter += txtAge_Enter;
            txtAge.Leave += txtAge_Leave;
            // 
            // txtPasswordHash
            // 
            txtPasswordHash.Anchor = AnchorStyles.Top;
            txtPasswordHash.Font = new Font("Segoe UI", 15F);
            txtPasswordHash.Location = new Point(841, 704);
            txtPasswordHash.Name = "txtPasswordHash";
            txtPasswordHash.Size = new Size(366, 41);
            txtPasswordHash.TabIndex = 20;
            txtPasswordHash.UseSystemPasswordChar = true;
            txtPasswordHash.Enter += txtPassword_Enter;
            txtPasswordHash.Leave += txtPassword_Leave;
            // 
            // txtRePasswordHash
            // 
            txtRePasswordHash.Anchor = AnchorStyles.Top;
            txtRePasswordHash.Font = new Font("Segoe UI", 15F);
            txtRePasswordHash.Location = new Point(841, 778);
            txtRePasswordHash.Name = "txtRePasswordHash";
            txtRePasswordHash.Size = new Size(366, 41);
            txtRePasswordHash.TabIndex = 21;
            txtRePasswordHash.UseSystemPasswordChar = true;
            txtRePasswordHash.Enter += txtRePassword_Enter;
            txtRePasswordHash.Leave += txtRePassword_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnToggleRePass);
            panel1.Controls.Add(btnTogglePass);
            panel1.Controls.Add(goback);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtRePasswordHash);
            panel1.Controls.Add(txtPasswordHash);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtStudNo);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 1055);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnToggleRePass
            // 
            btnToggleRePass.BackColor = Color.Transparent;
            btnToggleRePass.FlatStyle = FlatStyle.Flat;
            btnToggleRePass.Image = BSIT_EVOTE.Properties.Resources.hidden_30x30;
            btnToggleRePass.Location = new Point(1213, 783);
            btnToggleRePass.Name = "btnToggleRePass";
            btnToggleRePass.Size = new Size(37, 30);
            btnToggleRePass.TabIndex = 32;
            btnToggleRePass.UseVisualStyleBackColor = false;
            btnToggleRePass.Click += btnToggleRePass_Click;
            // 
            // btnTogglePass
            // 
            btnTogglePass.BackColor = Color.Transparent;
            btnTogglePass.FlatStyle = FlatStyle.Flat;
            btnTogglePass.Image = BSIT_EVOTE.Properties.Resources.hidden_30x30;
            btnTogglePass.Location = new Point(1213, 710);
            btnTogglePass.Name = "btnTogglePass";
            btnTogglePass.Size = new Size(37, 30);
            btnTogglePass.TabIndex = 31;
            btnTogglePass.UseVisualStyleBackColor = false;
            btnTogglePass.Click += btnTogglePass_Click;
            // 
            // goback
            // 
            goback.Anchor = AnchorStyles.Top;
            goback.BackColor = Color.FromArgb(9, 26, 72);
            goback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goback.ForeColor = Color.White;
            goback.Location = new Point(1050, 844);
            goback.Name = "goback";
            goback.Size = new Size(135, 60);
            goback.TabIndex = 30;
            goback.Text = "Cancel";
            goback.UseVisualStyleBackColor = false;
            goback.Click += goback_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(841, 750);
            label8.Name = "label8";
            label8.Size = new Size(178, 25);
            label8.TabIndex = 29;
            label8.Text = "Re-enter Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(841, 676);
            label7.Name = "label7";
            label7.Size = new Size(98, 25);
            label7.TabIndex = 28;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(841, 595);
            label6.Name = "label6";
            label6.Size = new Size(48, 25);
            label6.TabIndex = 27;
            label6.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(841, 518);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 26;
            label5.Text = "Email";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(841, 437);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 25;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(841, 364);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 24;
            label4.Text = "Student Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(866, 288);
            label2.Name = "label2";
            label2.Size = new Size(315, 39);
            label2.TabIndex = 22;
            label2.Text = "Create an Account";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = BSIT_EVOTE.Properties.Resources._371335320_3632624587017625_5029958005259186519_n_removebg_preview;
            pictureBox1.Location = new Point(914, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel1);
            Name = "CreateAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            WindowState = FormWindowState.Maximized;
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button btnCreate;
        private TextBox txtStudNo;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtAge;
        private TextBox txtPasswordHash;
        private TextBox txtRePasswordHash;
        private Panel panel1;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnTogglePass;
        private Button goback;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnToggleRePass;
    }
}