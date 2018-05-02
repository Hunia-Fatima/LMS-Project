namespace CLient
{
    partial class frmAdminLogin
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.chkTeacher = new System.Windows.Forms.CheckBox();
            this.chkStudent = new System.Windows.Forms.CheckBox();
            this.lnkforgetpassword = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.Black;
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(218, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(12, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(175, 45);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "User Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Location = new System.Drawing.Point(12, 143);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(140, 36);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.BackColor = System.Drawing.Color.Transparent;
            this.chkAdmin.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdmin.ForeColor = System.Drawing.Color.White;
            this.chkAdmin.Location = new System.Drawing.Point(35, 252);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(69, 22);
            this.chkAdmin.TabIndex = 4;
            this.chkAdmin.Text = "Admin";
            this.chkAdmin.UseVisualStyleBackColor = false;
            this.chkAdmin.CheckedChanged += new System.EventHandler(this.chkAdmin_CheckedChanged);
            // 
            // cmdLogin
            // 
            this.cmdLogin.BackColor = System.Drawing.Color.Black;
            this.cmdLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.ForeColor = System.Drawing.Color.White;
            this.cmdLogin.Location = new System.Drawing.Point(377, 252);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(124, 45);
            this.cmdLogin.TabIndex = 5;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = false;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // chkTeacher
            // 
            this.chkTeacher.AutoSize = true;
            this.chkTeacher.BackColor = System.Drawing.Color.Transparent;
            this.chkTeacher.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTeacher.ForeColor = System.Drawing.Color.White;
            this.chkTeacher.Location = new System.Drawing.Point(35, 275);
            this.chkTeacher.Name = "chkTeacher";
            this.chkTeacher.Size = new System.Drawing.Size(78, 22);
            this.chkTeacher.TabIndex = 6;
            this.chkTeacher.Text = "Teacher";
            this.chkTeacher.UseVisualStyleBackColor = false;
            // 
            // chkStudent
            // 
            this.chkStudent.AutoSize = true;
            this.chkStudent.BackColor = System.Drawing.Color.Transparent;
            this.chkStudent.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStudent.ForeColor = System.Drawing.Color.White;
            this.chkStudent.Location = new System.Drawing.Point(35, 303);
            this.chkStudent.Name = "chkStudent";
            this.chkStudent.Size = new System.Drawing.Size(74, 22);
            this.chkStudent.TabIndex = 7;
            this.chkStudent.Text = "Student";
            this.chkStudent.UseVisualStyleBackColor = false;
            // 
            // lnkforgetpassword
            // 
            this.lnkforgetpassword.AutoEllipsis = true;
            this.lnkforgetpassword.AutoSize = true;
            this.lnkforgetpassword.BackColor = System.Drawing.Color.Transparent;
            this.lnkforgetpassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkforgetpassword.ForeColor = System.Drawing.Color.Transparent;
            this.lnkforgetpassword.Location = new System.Drawing.Point(339, 317);
            this.lnkforgetpassword.Name = "lnkforgetpassword";
            this.lnkforgetpassword.Size = new System.Drawing.Size(143, 22);
            this.lnkforgetpassword.TabIndex = 8;
            this.lnkforgetpassword.TabStop = true;
            this.lnkforgetpassword.Text = "Forget Password";
            this.lnkforgetpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkforgetpassword_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(218, 159);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(242, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // frmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CLient.Properties.Resources.zero_g_theme_logon_background_by_lilmegz97_d4sliyn3;
            this.ClientSize = new System.Drawing.Size(696, 375);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lnkforgetpassword);
            this.Controls.Add(this.chkStudent);
            this.Controls.Add(this.chkTeacher);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAdminLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmAdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.CheckBox chkTeacher;
        private System.Windows.Forms.CheckBox chkStudent;
        private System.Windows.Forms.LinkLabel lnkforgetpassword;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

