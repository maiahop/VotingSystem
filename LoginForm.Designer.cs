namespace OnlineVotingDraft
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            studentNumber = new TextBox();
            linkLabel2 = new LinkLabel();
            shopass = new CheckBox();
            label1 = new Label();
            pass = new TextBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // studentNumber
            // 
            studentNumber.Anchor = AnchorStyles.Top;
            studentNumber.Font = new Font("Microsoft Sans Serif", 15F);
            studentNumber.ForeColor = Color.Black;
            studentNumber.Location = new Point(129, 292);
            studentNumber.Name = "studentNumber";
            studentNumber.Size = new Size(409, 36);
            studentNumber.TabIndex = 5;
            studentNumber.Enter += textBox2_Enter;
            studentNumber.Leave += textBox2_Leave;
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.Top;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.Location = new Point(328, 642);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(181, 29);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Register Here";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // shopass
            // 
            shopass.Anchor = AnchorStyles.Top;
            shopass.AutoSize = true;
            shopass.BackColor = Color.Transparent;
            shopass.Font = new Font("Microsoft Sans Serif", 15F);
            shopass.Location = new Point(227, 433);
            shopass.Name = "shopass";
            shopass.Size = new Size(216, 33);
            shopass.TabIndex = 8;
            shopass.Text = "Show Password";
            shopass.UseVisualStyleBackColor = false;
            shopass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 15F);
            label1.Location = new Point(175, 642);
            label1.Name = "label1";
            label1.Size = new Size(144, 29);
            label1.TabIndex = 2;
            label1.Text = "New Voter?";
            // 
            // pass
            // 
            pass.Anchor = AnchorStyles.Top;
            pass.Font = new Font("Microsoft Sans Serif", 15F);
            pass.ForeColor = Color.Black;
            pass.Location = new Point(129, 375);
            pass.Name = "pass";
            pass.Size = new Size(409, 36);
            pass.TabIndex = 4;
            pass.Text = "Password";
            pass.UseSystemPasswordChar = true;
            pass.TextChanged += pass_TextChanged_1;
            pass.Enter += pass_Enter;
            pass.Leave += pass_Leave;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 15F);
            linkLabel1.Location = new Point(251, 596);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(162, 29);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Admin Log in";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(224, 119, 27);
            button1.Font = new Font("Microsoft Sans Serif", 15F);
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(181, 503);
            button1.Name = "button1";
            button1.Size = new Size(305, 65);
            button1.TabIndex = 0;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(pass);
            panel1.Controls.Add(studentNumber);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(shopass);
            panel1.Location = new Point(1142, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 749);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 15F);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(129, 343);
            label5.Name = "label5";
            label5.Size = new Size(124, 29);
            label5.TabIndex = 19;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 15F);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(129, 260);
            label4.Name = "label4";
            label4.Size = new Size(197, 29);
            label4.TabIndex = 16;
            label4.Text = "Student Number";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(129, 168);
            label6.Name = "label6";
            label6.Size = new Size(410, 35);
            label6.TabIndex = 14;
            label6.Text = "College of Informatics Voting Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(85, 117);
            label3.Name = "label3";
            label3.Size = new Size(512, 41);
            label3.TabIndex = 11;
            label3.Text = "Philippine Christian University";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox studentNumber;
        private LinkLabel linkLabel2;
        private CheckBox shopass;
        private Label label1;
        private TextBox pass;
        private LinkLabel linkLabel1;
        private Button button1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}