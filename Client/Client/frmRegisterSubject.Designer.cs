namespace CLient
{
    partial class frmRegisterSubject
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
            this.lblName = new System.Windows.Forms.Label();
            this.gvRegisterSubjects = new System.Windows.Forms.DataGridView();
            this.Register = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkViewDMC = new System.Windows.Forms.LinkLabel();
            this.lnkViewAttendance = new System.Windows.Forms.LinkLabel();
            this.lnkConversation = new System.Windows.Forms.LinkLabel();
            this.lnkSignOut = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegisterSubjects)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblName.Location = new System.Drawing.Point(170, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // gvRegisterSubjects
            // 
            this.gvRegisterSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRegisterSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Register});
            this.gvRegisterSubjects.Location = new System.Drawing.Point(174, 74);
            this.gvRegisterSubjects.Name = "gvRegisterSubjects";
            this.gvRegisterSubjects.Size = new System.Drawing.Size(403, 352);
            this.gvRegisterSubjects.TabIndex = 1;
            this.gvRegisterSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRegisterUser_CellContentClick);
            // 
            // Register
            // 
            this.Register.HeaderText = "Resgiter/Unregister";
            this.Register.Name = "Register";
            this.Register.Text = "Resgiter/Unregister";
            this.Register.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.lnkSignOut);
            this.groupBox1.Controls.Add(this.lnkConversation);
            this.groupBox1.Controls.Add(this.lnkViewAttendance);
            this.groupBox1.Controls.Add(this.lnkViewDMC);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 414);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lnkViewDMC
            // 
            this.lnkViewDMC.AutoSize = true;
            this.lnkViewDMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkViewDMC.Location = new System.Drawing.Point(12, 62);
            this.lnkViewDMC.Name = "lnkViewDMC";
            this.lnkViewDMC.Size = new System.Drawing.Size(71, 17);
            this.lnkViewDMC.TabIndex = 0;
            this.lnkViewDMC.TabStop = true;
            this.lnkViewDMC.Text = "View DMC";
            this.lnkViewDMC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkViewDMC_LinkClicked);
            // 
            // lnkViewAttendance
            // 
            this.lnkViewAttendance.AutoSize = true;
            this.lnkViewAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkViewAttendance.Location = new System.Drawing.Point(12, 121);
            this.lnkViewAttendance.Name = "lnkViewAttendance";
            this.lnkViewAttendance.Size = new System.Drawing.Size(113, 17);
            this.lnkViewAttendance.TabIndex = 1;
            this.lnkViewAttendance.TabStop = true;
            this.lnkViewAttendance.Text = "View Attendance";
            // 
            // lnkConversation
            // 
            this.lnkConversation.AutoSize = true;
            this.lnkConversation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkConversation.Location = new System.Drawing.Point(12, 185);
            this.lnkConversation.Name = "lnkConversation";
            this.lnkConversation.Size = new System.Drawing.Size(120, 17);
            this.lnkConversation.TabIndex = 2;
            this.lnkConversation.TabStop = true;
            this.lnkConversation.Text = "Talk with Teacher";
            this.lnkConversation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConversation_LinkClicked);
            // 
            // lnkSignOut
            // 
            this.lnkSignOut.AutoSize = true;
            this.lnkSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkSignOut.Location = new System.Drawing.Point(12, 244);
            this.lnkSignOut.Name = "lnkSignOut";
            this.lnkSignOut.Size = new System.Drawing.Size(63, 17);
            this.lnkSignOut.TabIndex = 3;
            this.lnkSignOut.TabStop = true;
            this.lnkSignOut.Text = "Sign Out";
            this.lnkSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignOut_LinkClicked);
            // 
            // frmRegisterSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(589, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvRegisterSubjects);
            this.Controls.Add(this.lblName);
            this.Name = "frmRegisterSubject";
            this.Text = "frmRegisterSubject";
            ((System.ComponentModel.ISupportInitialize)(this.gvRegisterSubjects)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView gvRegisterSubjects;
        private System.Windows.Forms.DataGridViewButtonColumn Register;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkSignOut;
        private System.Windows.Forms.LinkLabel lnkConversation;
        private System.Windows.Forms.LinkLabel lnkViewAttendance;
        private System.Windows.Forms.LinkLabel lnkViewDMC;
    }
}