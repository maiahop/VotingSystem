namespace OnlineVotingDraft
{
    partial class AdminLog
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
            colorDialog1 = new ColorDialog();
            button1 = new Button();
            textBox3 = new TextBox();
            txtAdminPass = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnReturn = new Button();
            btnshowPass = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(29, 78, 216);
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1339, 615);
            button1.Name = "button1";
            button1.Size = new Size(238, 64);
            button1.TabIndex = 8;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 15F);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(1289, 453);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(341, 36);
            textBox3.TabIndex = 11;
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // txtAdminPass
            // 
            txtAdminPass.Font = new Font("Microsoft Sans Serif", 15F);
            txtAdminPass.ForeColor = Color.Black;
            txtAdminPass.Location = new Point(1289, 536);
            txtAdminPass.Name = "txtAdminPass";
            txtAdminPass.Size = new Size(341, 36);
            txtAdminPass.TabIndex = 13;
            txtAdminPass.Text = "Password";
            txtAdminPass.UseSystemPasswordChar = true;
            txtAdminPass.TextChanged += textBox1_TextChanged;
            txtAdminPass.Enter += textBox1_Enter;
            txtAdminPass.Leave += textBox1_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1303, 326);
            label2.Name = "label2";
            label2.Size = new Size(305, 46);
            label2.TabIndex = 14;
            label2.Text = "ADMIN LOG IN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1289, 420);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 15;
            label1.Text = "AdminID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1289, 508);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 16;
            label3.Text = "Password";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Transparent;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.FromArgb(64, 64, 64);
            btnReturn.Location = new Point(1329, 687);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(256, 56);
            btnReturn.TabIndex = 22;
            btnReturn.Text = "← Return to Voters Portal";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnshowPass
            // 
            btnshowPass.BackColor = Color.Transparent;
            btnshowPass.FlatAppearance.BorderSize = 0;
            btnshowPass.FlatStyle = FlatStyle.Flat;
            btnshowPass.Image = BSIT_EVOTE.Properties.Resources.hidden_30x30;
            btnshowPass.Location = new Point(1636, 536);
            btnshowPass.Name = "btnshowPass";
            btnshowPass.Size = new Size(35, 30);
            btnshowPass.TabIndex = 23;
            btnshowPass.UseVisualStyleBackColor = false;
            btnshowPass.Click += btnshowPass_Click;
            // 
            // AdminLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            BackgroundImage = BSIT_EVOTE.Properties.Resources.ADMIN__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnshowPass);
            Controls.Add(btnReturn);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtAdminPass);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Name = "AdminLog";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private Button button1;
        private TextBox textBox3;
        private TextBox txtAdminPass;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnReturn;
        private Button btnshowPass;
    }
}