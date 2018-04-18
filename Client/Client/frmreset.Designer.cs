namespace CLient
{
    partial class frmreset
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpincode = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.chkteacher = new System.Windows.Forms.CheckBox();
            this.chkstudent = new System.Windows.Forms.CheckBox();
            this.cmdresetpassword = new System.Windows.Forms.Button();
            this.lbllogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(78, 38);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(167, 20);
            this.txtusername.TabIndex = 0;
            // 
            // txtpincode
            // 
            this.txtpincode.Location = new System.Drawing.Point(78, 91);
            this.txtpincode.Name = "txtpincode";
            this.txtpincode.Size = new System.Drawing.Size(167, 20);
            this.txtpincode.TabIndex = 1;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(12, 38);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(55, 13);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(12, 91);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(46, 13);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Pincode";
            // 
            // chkteacher
            // 
            this.chkteacher.AutoSize = true;
            this.chkteacher.Location = new System.Drawing.Point(30, 162);
            this.chkteacher.Name = "chkteacher";
            this.chkteacher.Size = new System.Drawing.Size(66, 17);
            this.chkteacher.TabIndex = 4;
            this.chkteacher.Text = "Teacher";
            this.chkteacher.UseVisualStyleBackColor = true;
            this.chkteacher.CheckedChanged += new System.EventHandler(this.chkteacher_CheckedChanged);
            // 
            // chkstudent
            // 
            this.chkstudent.AutoSize = true;
            this.chkstudent.Location = new System.Drawing.Point(30, 190);
            this.chkstudent.Name = "chkstudent";
            this.chkstudent.Size = new System.Drawing.Size(63, 17);
            this.chkstudent.TabIndex = 5;
            this.chkstudent.Text = "Student";
            this.chkstudent.UseVisualStyleBackColor = true;
            // 
            // cmdresetpassword
            // 
            this.cmdresetpassword.Location = new System.Drawing.Point(174, 176);
            this.cmdresetpassword.Name = "cmdresetpassword";
            this.cmdresetpassword.Size = new System.Drawing.Size(86, 43);
            this.cmdresetpassword.TabIndex = 6;
            this.cmdresetpassword.Text = "Reset Password";
            this.cmdresetpassword.UseVisualStyleBackColor = true;
            this.cmdresetpassword.Click += new System.EventHandler(this.cmdresetpassword_Click);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(23, 225);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(33, 13);
            this.lbllogin.TabIndex = 7;
            this.lbllogin.TabStop = true;
            this.lbllogin.Text = "Login";
            this.lbllogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllogin_LinkClicked);
            // 
            // frmreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.cmdresetpassword);
            this.Controls.Add(this.chkstudent);
            this.Controls.Add(this.chkteacher);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtpincode);
            this.Controls.Add(this.txtusername);
            this.Name = "frmreset";
            this.Text = "Resest Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpincode;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.CheckBox chkteacher;
        private System.Windows.Forms.CheckBox chkstudent;
        private System.Windows.Forms.Button cmdresetpassword;
        private System.Windows.Forms.LinkLabel lbllogin;
    }
}