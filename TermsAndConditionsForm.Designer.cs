namespace BSIT_EVOTE
{
    partial class TermsAndConditionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermsAndConditionsForm));
            rtbTerms = new RichTextBox();
            btnProceed = new Button();
            chkAgree = new CheckBox();
            SuspendLayout();
            // 
            // rtbTerms
            // 
            rtbTerms.Location = new Point(58, 46);
            rtbTerms.Name = "rtbTerms";
            rtbTerms.ReadOnly = true;
            rtbTerms.Size = new Size(689, 296);
            rtbTerms.TabIndex = 0;
            rtbTerms.Text = resources.GetString("rtbTerms.Text");
            rtbTerms.TextChanged += rtbTerms_TextChanged;
            // 
            // btnProceed
            // 
            btnProceed.DialogResult = DialogResult.OK;
            btnProceed.Enabled = false;
            btnProceed.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProceed.Location = new Point(631, 358);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(116, 47);
            btnProceed.TabIndex = 1;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += btnProceed_Click;
            // 
            // chkAgree
            // 
            chkAgree.AutoSize = true;
            chkAgree.Location = new Point(58, 358);
            chkAgree.Name = "chkAgree";
            chkAgree.Size = new Size(270, 24);
            chkAgree.TabIndex = 2;
            chkAgree.Text = "I agree to the Terms and Conditions.";
            chkAgree.UseVisualStyleBackColor = true;
            chkAgree.CheckedChanged += chkAgree_CheckedChanged;
            // 
            // TermsAndConditionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkAgree);
            Controls.Add(btnProceed);
            Controls.Add(rtbTerms);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TermsAndConditionsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Terms And Conditions";
            Load += TermsAndConditionsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbTerms;
        private Button btnProceed;
        private CheckBox chkAgree;
    }
}