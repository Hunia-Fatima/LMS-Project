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
            this.lnkGoBack = new System.Windows.Forms.LinkLabel();
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
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(132, 25);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(214, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // cmbRegisterAs
            // 
            this.cmbRegisterAs.FormattingEnabled = true;
            this.cmbRegisterAs.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.cmbRegisterAs.Location = new System.Drawing.Point(132, 231);
            this.cmbRegisterAs.Name = "cmbRegisterAs";
            this.cmbRegisterAs.Size = new System.Drawing.Size(214, 21);
            this.cmbRegisterAs.TabIndex = 2;
            this.cmbRegisterAs.SelectedIndexChanged += new System.EventHandler(this.cmbRegisterAs_SelectedIndexChanged);
            // 
            // lnkGoBack
            // 
            this.lnkGoBack.AutoSize = true;
            this.lnkGoBack.Location = new System.Drawing.Point(12, 408);
            this.lnkGoBack.Name = "lnkGoBack";
            this.lnkGoBack.Size = new System.Drawing.Size(49, 13);
            this.lnkGoBack.TabIndex = 3;
            this.lnkGoBack.TabStop = true;
            this.lnkGoBack.Text = "Go Back";
            this.lnkGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoBack_LinkClicked);
            // 
            // cmdRegister
            // 
            this.cmdRegister.BackColor = System.Drawing.SystemColors.Info;
            this.cmdRegister.Location = new System.Drawing.Point(226, 383);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Size = new System.Drawing.Size(130, 38);
            this.cmdRegister.TabIndex = 4;
            this.cmdRegister.Text = "Register";
            this.cmdRegister.UseVisualStyleBackColor = false;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(132, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(132, 132);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(214, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(33, 89);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(29, 135);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblRegisterAs
            // 
            this.lblRegisterAs.AutoSize = true;
            this.lblRegisterAs.Location = new System.Drawing.Point(29, 231);
            this.lblRegisterAs.Name = "lblRegisterAs";
            this.lblRegisterAs.Size = new System.Drawing.Size(61, 13);
            this.lblRegisterAs.TabIndex = 9;
            this.lblRegisterAs.Text = "Register As";
            // 
            // txtpincode
            // 
            this.txtpincode.Location = new System.Drawing.Point(132, 180);
            this.txtpincode.Name = "txtpincode";
            this.txtpincode.PasswordChar = '*';
            this.txtpincode.Size = new System.Drawing.Size(214, 20);
            this.txtpincode.TabIndex = 10;
            // 
            // lblpincode
            // 
            this.lblpincode.AutoSize = true;
            this.lblpincode.Location = new System.Drawing.Point(29, 180);
            this.lblpincode.Name = "lblpincode";
            this.lblpincode.Size = new System.Drawing.Size(50, 13);
            this.lblpincode.TabIndex = 11;
            this.lblpincode.Text = "Pin Code";
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(132, 275);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(212, 20);
            this.txtSec.TabIndex = 12;
            this.txtSec.TextChanged += new System.EventHandler(this.txtSec_TextChanged);
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(36, 282);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(43, 13);
            this.lblSec.TabIndex = 13;
            this.lblSec.Text = "Section";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Items.AddRange(new object[] {
            "Subject1",
            "Subject2",
            "Subject3",
            "Subject4",
            "Subject5",
            "Subject6",
            "Subject7"});
            this.cmbSubject.Location = new System.Drawing.Point(132, 321);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(214, 21);
            this.cmbSubject.TabIndex = 14;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(36, 321);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
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
            this.cmbdepartment.Location = new System.Drawing.Point(131, 359);
            this.cmbdepartment.Name = "cmbdepartment";
            this.cmbdepartment.Size = new System.Drawing.Size(212, 21);
            this.cmbdepartment.TabIndex = 16;
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(33, 362);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(62, 13);
            this.lbldepartment.TabIndex = 17;
            this.lbldepartment.Text = "Department";
            // 
            // frmRegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 433);
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
            this.Controls.Add(this.lnkGoBack);
            this.Controls.Add(this.cmbRegisterAs);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtUserName);
            this.Name = "frmRegisterUser";
            this.Text = "frmRegisterUser";
            this.Load += new System.EventHandler(this.frmRegisterUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbRegisterAs;
        private System.Windows.Forms.LinkLabel lnkGoBack;
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
    }
}