namespace CLient
{
    partial class Student
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
            this.cmdconvo = new System.Windows.Forms.Button();
            this.cmdVA = new System.Windows.Forms.Button();
            this.cmdRegS = new System.Windows.Forms.Button();
            this.cmdVDMC = new System.Windows.Forms.Button();
            this.lnkSSignOut = new System.Windows.Forms.LinkLabel();
            this.lblStu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdconvo
            // 
            this.cmdconvo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdconvo.Location = new System.Drawing.Point(36, 187);
            this.cmdconvo.Name = "cmdconvo";
            this.cmdconvo.Size = new System.Drawing.Size(213, 38);
            this.cmdconvo.TabIndex = 7;
            this.cmdconvo.Text = "Conversation";
            this.cmdconvo.UseVisualStyleBackColor = false;
            // 
            // cmdVA
            // 
            this.cmdVA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdVA.Location = new System.Drawing.Point(36, 134);
            this.cmdVA.Name = "cmdVA";
            this.cmdVA.Size = new System.Drawing.Size(213, 38);
            this.cmdVA.TabIndex = 6;
            this.cmdVA.Text = "View Attendance";
            this.cmdVA.UseVisualStyleBackColor = false;
            this.cmdVA.Click += new System.EventHandler(this.cmdVA_Click);
            // 
            // cmdRegS
            // 
            this.cmdRegS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdRegS.Location = new System.Drawing.Point(36, 90);
            this.cmdRegS.Name = "cmdRegS";
            this.cmdRegS.Size = new System.Drawing.Size(213, 38);
            this.cmdRegS.TabIndex = 5;
            this.cmdRegS.Text = "Register Subjects";
            this.cmdRegS.UseVisualStyleBackColor = false;
            this.cmdRegS.Click += new System.EventHandler(this.cmdRegS_Click);
            // 
            // cmdVDMC
            // 
            this.cmdVDMC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdVDMC.Location = new System.Drawing.Point(36, 36);
            this.cmdVDMC.Name = "cmdVDMC";
            this.cmdVDMC.Size = new System.Drawing.Size(213, 38);
            this.cmdVDMC.TabIndex = 4;
            this.cmdVDMC.Text = "View DMC";
            this.cmdVDMC.UseVisualStyleBackColor = false;
            this.cmdVDMC.Click += new System.EventHandler(this.cmdVDMC_Click);
            // 
            // lnkSSignOut
            // 
            this.lnkSSignOut.AutoSize = true;
            this.lnkSSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkSSignOut.Location = new System.Drawing.Point(217, 239);
            this.lnkSSignOut.Name = "lnkSSignOut";
            this.lnkSSignOut.Size = new System.Drawing.Size(60, 17);
            this.lnkSSignOut.TabIndex = 8;
            this.lnkSSignOut.TabStop = true;
            this.lnkSSignOut.Text = "Sign out";
            this.lnkSSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSSignOut_LinkClicked);
            // 
            // lblStu
            // 
            this.lblStu.AutoSize = true;
            this.lblStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStu.Location = new System.Drawing.Point(198, 9);
            this.lblStu.Name = "lblStu";
            this.lblStu.Size = new System.Drawing.Size(74, 24);
            this.lblStu.TabIndex = 9;
            this.lblStu.Text = "Student";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(305, 288);
            this.Controls.Add(this.lblStu);
            this.Controls.Add(this.lnkSSignOut);
            this.Controls.Add(this.cmdconvo);
            this.Controls.Add(this.cmdVA);
            this.Controls.Add(this.cmdRegS);
            this.Controls.Add(this.cmdVDMC);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdconvo;
        private System.Windows.Forms.Button cmdVA;
        private System.Windows.Forms.Button cmdRegS;
        private System.Windows.Forms.Button cmdVDMC;
        private System.Windows.Forms.LinkLabel lnkSSignOut;
        private System.Windows.Forms.Label lblStu;
    }
}