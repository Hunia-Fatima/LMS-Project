namespace CLient
{
    partial class frmRegisterUser
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbRegisterAs = new System.Windows.Forms.ComboBox();
            this.cmdRegister = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRegisterAs = new System.Windows.Forms.Label();
            this.txtpincode = new System.Windows.Forms.TextBox();
            this.lblpincode = new System.Windows.Forms.Label();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.lblSec = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cmbdepartment = new System.Windows.Forms.ComboBox();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkSignOut = new System.Windows.Forms.LinkLabel();
            this.lnkteacherData = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(301, 23);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(214, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(221, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // cmbRegisterAs
            // 
            this.cmbRegisterAs.FormattingEnabled = true;
            this.cmbRegisterAs.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.cmbRegisterAs.Location = new System.Drawing.Point(300, 222);
            this.cmbRegisterAs.Name = "cmbRegisterAs";
            this.cmbRegisterAs.Size = new System.Drawing.Size(214, 21);
            this.cmbRegisterAs.TabIndex = 2;
            this.cmbRegisterAs.SelectedIndexChanged += new System.EventHandler(this.cmbRegisterAs_SelectedIndexChanged);
            // 
            // cmdRegister
            // 
            this.cmdRegister.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdRegister.BackgroundImage = global::CLient.Properties.Resources.zero_g_theme_logon_background_by_lilmegz97_d4sliyn3;
            this.cmdRegister.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegister.ForeColor = System.Drawing.Color.White;
            this.cmdRegister.Location = new System.Drawing.Point(375, 387);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Size = new System.Drawing.Size(130, 38);
            this.cmdRegister.TabIndex = 4;
            this.cmdRegister.Text = "Register";
            this.cmdRegister.UseVisualStyleBackColor = false;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(300, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(300, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(214, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(224, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(224, 122);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 15);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblRegisterAs
            // 
            this.lblRegisterAs.AutoSize = true;
            this.lblRegisterAs.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblRegisterAs.ForeColor = System.Drawing.Color.White;
            this.lblRegisterAs.Location = new System.Drawing.Point(221, 230);
            this.lblRegisterAs.Name = "lblRegisterAs";
            this.lblRegisterAs.Size = new System.Drawing.Size(69, 15);
            this.lblRegisterAs.TabIndex = 9;
            this.lblRegisterAs.Text = "Register As";
            // 
            // txtpincode
            // 
            this.txtpincode.Location = new System.Drawing.Point(300, 177);
            this.txtpincode.Name = "txtpincode";
            this.txtpincode.PasswordChar = '*';
            this.txtpincode.Size = new System.Drawing.Size(214, 20);
            this.txtpincode.TabIndex = 10;
            // 
            // lblpincode
            // 
            this.lblpincode.AutoSize = true;
            this.lblpincode.BackColor = System.Drawing.Color.Transparent;
            this.lblpincode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblpincode.ForeColor = System.Drawing.Color.Transparent;
            this.lblpincode.Location = new System.Drawing.Point(224, 180);
            this.lblpincode.Name = "lblpincode";
            this.lblpincode.Size = new System.Drawing.Size(57, 15);
            this.lblpincode.TabIndex = 11;
            this.lblpincode.Text = "Pin Code";
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(303, 279);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(212, 20);
            this.txtSec.TabIndex = 12;
            this.txtSec.TextChanged += new System.EventHandler(this.txtSec_TextChanged);
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(223, 288);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(43, 13);
            this.lblSec.TabIndex = 13;
            this.lblSec.Text = "Section";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Items.AddRange(new object[] {
            "CALCULUS",
            "ICS",
            "PF",
            "COAL",
            "OOAD",
            "DSA",
            "DET"});
            this.cmbSubject.Location = new System.Drawing.Point(300, 279);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(214, 21);
            this.cmbSubject.TabIndex = 14;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSubject.ForeColor = System.Drawing.Color.White;
            this.lblSubject.Location = new System.Drawing.Point(222, 286);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(48, 15);
            this.lblSubject.TabIndex = 15;
            this.lblSubject.Text = "Subject";
            // 
            // cmbdepartment
            // 
            this.cmbdepartment.FormattingEnabled = true;
            this.cmbdepartment.Items.AddRange(new object[] {
            "EE",
            "CS",
            "CIVIL",
            "PETROLEUM",
            "MECHANICAL"});
            this.cmbdepartment.Location = new System.Drawing.Point(300, 324);
            this.cmbdepartment.Name = "cmbdepartment";
            this.cmbdepartment.Size = new System.Drawing.Size(212, 21);
            this.cmbdepartment.TabIndex = 16;
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.BackColor = System.Drawing.Color.Transparent;
            this.lbldepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbldepartment.ForeColor = System.Drawing.Color.White;
            this.lbldepartment.Location = new System.Drawing.Point(223, 330);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(72, 15);
            this.lbldepartment.TabIndex = 17;
            this.lbldepartment.Text = "Department";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.BackgroundImage = global::CLient.Properties.Resources.Untitled_2;
            this.groupBox1.Controls.Add(this.lnkSignOut);
            this.groupBox1.Controls.Add(this.lnkteacherData);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.linkLabel4);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 413);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lnkSignOut
            // 
            this.lnkSignOut.AutoSize = true;
            this.lnkSignOut.BackColor = System.Drawing.Color.Transparent;
            this.lnkSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkSignOut.LinkColor = System.Drawing.Color.White;
            this.lnkSignOut.Location = new System.Drawing.Point(8, 287);
            this.lnkSignOut.Name = "lnkSignOut";
            this.lnkSignOut.Size = new System.Drawing.Size(63, 17);
            this.lnkSignOut.TabIndex = 27;
            this.lnkSignOut.TabStop = true;
            this.lnkSignOut.Text = "Sign Out";
            this.lnkSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignOut_LinkClicked);
            // 
            // lnkteacherData
            // 
            this.lnkteacherData.AutoSize = true;
            this.lnkteacherData.BackColor = System.Drawing.Color.Transparent;
            this.lnkteacherData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkteacherData.LinkColor = System.Drawing.Color.White;
            this.lnkteacherData.Location = new System.Drawing.Point(5, 134);
            this.lnkteacherData.Name = "lnkteacherData";
            this.lnkteacherData.Size = new System.Drawing.Size(144, 17);
            this.lnkteacherData.TabIndex = 20;
            this.lnkteacherData.TabStop = true;
            this.lnkteacherData.Text = "View Data of Teacher";
            this.lnkteacherData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkteacherData_LinkClicked_1);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(6, 234);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(114, 17);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Go to Main Page";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(8, 85);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(98, 17);
            this.linkLabel3.TabIndex = 0;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Update Result";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel4.LinkColor = System.Drawing.Color.White;
            this.linkLabel4.Location = new System.Drawing.Point(5, 184);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(140, 17);
            this.linkLabel4.TabIndex = 19;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "View Data of Student";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // frmRegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::CLient.Properties.Resources.zero_g_theme_logon_background_by_lilmegz97_d4sliyn3;
            this.ClientSize = new System.Drawing.Size(536, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.cmbdepartment);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.lblpincode);
            this.Controls.Add(this.txtpincode);
            this.Controls.Add(this.lblRegisterAs);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cmdRegister);
            this.Controls.Add(this.cmbRegisterAs);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtUserName);
            this.Name = "frmRegisterUser";
            this.Text = "Register User";
            this.Load += new System.EventHandler(this.frmRegisterUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbRegisterAs;
        private System.Windows.Forms.Button cmdRegister;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRegisterAs;
        private System.Windows.Forms.TextBox txtpincode;
        private System.Windows.Forms.Label lblpincode;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cmbdepartment;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkteacherData;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel lnkSignOut;
    }
}