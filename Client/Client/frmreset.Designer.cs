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
            this.txtusername.Location = new System.Drawing.Point(219, 83);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(167, 20);
            this.txtusername.TabIndex = 0;
            // 
            // txtpincode
            // 
            this.txtpincode.Location = new System.Drawing.Point(219, 132);
            this.txtpincode.Name = "txtpincode";
            this.txtpincode.Size = new System.Drawing.Size(167, 20);
            this.txtpincode.TabIndex = 1;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.White;
            this.lblusername.Location = new System.Drawing.Point(91, 83);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(98, 24);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.White;
            this.lblpassword.Location = new System.Drawing.Point(93, 135);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(80, 24);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Pincode";
            // 
            // chkteacher
            // 
            this.chkteacher.AutoSize = true;
            this.chkteacher.BackColor = System.Drawing.Color.Transparent;
            this.chkteacher.ForeColor = System.Drawing.Color.White;
            this.chkteacher.Location = new System.Drawing.Point(24, 210);
            this.chkteacher.Name = "chkteacher";
            this.chkteacher.Size = new System.Drawing.Size(66, 17);
            this.chkteacher.TabIndex = 4;
            this.chkteacher.Text = "Teacher";
            this.chkteacher.UseVisualStyleBackColor = false;
            this.chkteacher.CheckedChanged += new System.EventHandler(this.chkteacher_CheckedChanged);
            // 
            // chkstudent
            // 
            this.chkstudent.AutoSize = true;
            this.chkstudent.BackColor = System.Drawing.Color.Transparent;
            this.chkstudent.ForeColor = System.Drawing.Color.White;
            this.chkstudent.Location = new System.Drawing.Point(24, 247);
            this.chkstudent.Name = "chkstudent";
            this.chkstudent.Size = new System.Drawing.Size(63, 17);
            this.chkstudent.TabIndex = 5;
            this.chkstudent.Text = "Student";
            this.chkstudent.UseVisualStyleBackColor = false;
            // 
            // cmdresetpassword
            // 
            this.cmdresetpassword.BackColor = System.Drawing.Color.Black;
            this.cmdresetpassword.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdresetpassword.ForeColor = System.Drawing.Color.White;
            this.cmdresetpassword.Location = new System.Drawing.Point(362, 225);
            this.cmdresetpassword.Name = "cmdresetpassword";
            this.cmdresetpassword.Size = new System.Drawing.Size(190, 77);
            this.cmdresetpassword.TabIndex = 6;
            this.cmdresetpassword.Text = "Reset Password";
            this.cmdresetpassword.UseVisualStyleBackColor = false;
            this.cmdresetpassword.Click += new System.EventHandler(this.cmdresetpassword_Click);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.Color.Transparent;
            this.lbllogin.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.Color.White;
            this.lbllogin.LinkColor = System.Drawing.Color.White;
            this.lbllogin.Location = new System.Drawing.Point(2, 285);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(62, 24);
            this.lbllogin.TabIndex = 7;
            this.lbllogin.TabStop = true;
            this.lbllogin.Text = "Login";
            this.lbllogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllogin_LinkClicked);
            // 
            // frmreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::CLient.Properties.Resources.zero_g_theme_logon_background_by_lilmegz97_d4sliyn3;
            this.ClientSize = new System.Drawing.Size(564, 314);
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