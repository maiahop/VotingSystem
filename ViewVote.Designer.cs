namespace OnlineVotingDraft
{
    partial class ViewVote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVote));
            panel1 = new Panel();
            btnLogout = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            lblReceipt = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(1924, 75);
            panel1.TabIndex = 17;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Dock = DockStyle.Right;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.ImeMode = ImeMode.NoControl;
            btnLogout.Location = new Point(1791, 0);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(133, 75);
            btnLogout.TabIndex = 20;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
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
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(114, 13);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(278, 46);
            label2.TabIndex = 11;
            label2.Text = "BSIT 3C Election";
            // 
            // lblReceipt
            // 
            lblReceipt.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReceipt.ForeColor = Color.DarkBlue;
            lblReceipt.Location = new Point(640, 241);
            lblReceipt.Multiline = true;
            lblReceipt.Name = "lblReceipt";
            lblReceipt.ReadOnly = true;
            lblReceipt.ScrollBars = ScrollBars.Vertical;
            lblReceipt.Size = new Size(671, 503);
            lblReceipt.TabIndex = 1;
            lblReceipt.TabStop = false;
            lblReceipt.TextChanged += lblReceipt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(790, 144);
            label1.Name = "label1";
            label1.Size = new Size(380, 54);
            label1.TabIndex = 18;
            label1.Text = "Submitted Votes";
            label1.Click += label1_Click;
            // 
            // ViewVote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            BackgroundImage = BSIT_EVOTE.Properties.Resources.ADMIN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label1);
            Controls.Add(lblReceipt);
            Controls.Add(panel1);
            Name = "ViewVote";
            Text = "Form3";
            Load += ViewVote_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox lblReceipt;
        private Button btnLogout;
        private Label label1;
    }
}