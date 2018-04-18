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
            this.cmdViewData = new System.Windows.Forms.Button();
            this.cmdUpdateResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkSignOut = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cmdRegisterUser
            // 
            this.cmdRegisterUser.Location = new System.Drawing.Point(12, 50);
            this.cmdRegisterUser.Name = "cmdRegisterUser";
            this.cmdRegisterUser.Size = new System.Drawing.Size(129, 40);
            this.cmdRegisterUser.TabIndex = 0;
            this.cmdRegisterUser.Text = "Register Users";
            this.cmdRegisterUser.UseVisualStyleBackColor = true;
            this.cmdRegisterUser.Click += new System.EventHandler(this.cmdRegisterUser_Click);
            // 
            // cmdViewData
            // 
            this.cmdViewData.Location = new System.Drawing.Point(12, 108);
            this.cmdViewData.Name = "cmdViewData";
            this.cmdViewData.Size = new System.Drawing.Size(129, 40);
            this.cmdViewData.TabIndex = 1;
            this.cmdViewData.Text = "View Data";
            this.cmdViewData.UseVisualStyleBackColor = true;
            // 
            // cmdUpdateResult
            // 
            this.cmdUpdateResult.Location = new System.Drawing.Point(12, 165);
            this.cmdUpdateResult.Name = "cmdUpdateResult";
            this.cmdUpdateResult.Size = new System.Drawing.Size(129, 40);
            this.cmdUpdateResult.TabIndex = 2;
            this.cmdUpdateResult.Text = "Update Result";
            this.cmdUpdateResult.UseVisualStyleBackColor = true;
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
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lnkSignOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdUpdateResult);
            this.Controls.Add(this.cmdViewData);
            this.Controls.Add(this.cmdRegisterUser);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRegisterUser;
        private System.Windows.Forms.Button cmdViewData;
        private System.Windows.Forms.Button cmdUpdateResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkSignOut;
    }
}