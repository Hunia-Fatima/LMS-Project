namespace CLient
{
    partial class Admin
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
            this.cmdRegisterUser = new System.Windows.Forms.Button();
            this.cmdUpdateResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkSignOut = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVData = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdRegisterUser
            // 
            this.cmdRegisterUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdRegisterUser.Location = new System.Drawing.Point(58, 52);
            this.cmdRegisterUser.Name = "cmdRegisterUser";
            this.cmdRegisterUser.Size = new System.Drawing.Size(129, 40);
            this.cmdRegisterUser.TabIndex = 0;
            this.cmdRegisterUser.Text = "Register Users";
            this.cmdRegisterUser.UseVisualStyleBackColor = false;
            this.cmdRegisterUser.Click += new System.EventHandler(this.cmdRegisterUser_Click);
            // 
            // cmdUpdateResult
            // 
            this.cmdUpdateResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdUpdateResult.Location = new System.Drawing.Point(58, 98);
            this.cmdUpdateResult.Name = "cmdUpdateResult";
            this.cmdUpdateResult.Size = new System.Drawing.Size(129, 40);
            this.cmdUpdateResult.TabIndex = 2;
            this.cmdUpdateResult.Text = "Update Result";
            this.cmdUpdateResult.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADMIN";
            // 
            // lnkSignOut
            // 
            this.lnkSignOut.AutoSize = true;
            this.lnkSignOut.Location = new System.Drawing.Point(207, 217);
            this.lnkSignOut.Name = "lnkSignOut";
            this.lnkSignOut.Size = new System.Drawing.Size(48, 13);
            this.lnkSignOut.TabIndex = 4;
            this.lnkSignOut.TabStop = true;
            this.lnkSignOut.Text = "Sign Out";
            this.lnkSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignOut_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "View Data of";
            // 
            // cmbVData
            // 
            this.cmbVData.FormattingEnabled = true;
            this.cmbVData.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.cmbVData.Location = new System.Drawing.Point(58, 184);
            this.cmbVData.Name = "cmbVData";
            this.cmbVData.Size = new System.Drawing.Size(185, 21);
            this.cmbVData.TabIndex = 6;
            this.cmbVData.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmbVData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkSignOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdUpdateResult);
            this.Controls.Add(this.cmdRegisterUser);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRegisterUser;
        private System.Windows.Forms.Button cmdUpdateResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkSignOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVData;
    }
}