namespace CLient
{
    partial class Teacher
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
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdUpldAtt = new System.Windows.Forms.Button();
            this.cmdUpldRes = new System.Windows.Forms.Button();
            this.lnkTSignOut = new System.Windows.Forms.LinkLabel();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(116, 195);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(137, 20);
            this.txtStatus.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Set Status";
            // 
            // cmdUpldAtt
            // 
            this.cmdUpldAtt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdUpldAtt.Location = new System.Drawing.Point(36, 113);
            this.cmdUpldAtt.Name = "cmdUpldAtt";
            this.cmdUpldAtt.Size = new System.Drawing.Size(216, 50);
            this.cmdUpldAtt.TabIndex = 6;
            this.cmdUpldAtt.Text = "Upload attendance";
            this.cmdUpldAtt.UseVisualStyleBackColor = false;
            this.cmdUpldAtt.Click += new System.EventHandler(this.cmdUpldAtt_Click);
            // 
            // cmdUpldRes
            // 
            this.cmdUpldRes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdUpldRes.Location = new System.Drawing.Point(35, 43);
            this.cmdUpldRes.Name = "cmdUpldRes";
            this.cmdUpldRes.Size = new System.Drawing.Size(218, 44);
            this.cmdUpldRes.TabIndex = 5;
            this.cmdUpldRes.Text = "Upload Result";
            this.cmdUpldRes.UseVisualStyleBackColor = false;
            this.cmdUpldRes.Click += new System.EventHandler(this.cmdUpldRes_Click);
            // 
            // lnkTSignOut
            // 
            this.lnkTSignOut.AutoSize = true;
            this.lnkTSignOut.Location = new System.Drawing.Point(217, 239);
            this.lnkTSignOut.Name = "lnkTSignOut";
            this.lnkTSignOut.Size = new System.Drawing.Size(46, 13);
            this.lnkTSignOut.TabIndex = 9;
            this.lnkTSignOut.TabStop = true;
            this.lnkTSignOut.Text = "Sign out";
            this.lnkTSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTSignOut_LinkClicked);
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.Location = new System.Drawing.Point(164, 9);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(101, 24);
            this.lblTeacher.TabIndex = 10;
            this.lblTeacher.Text = "TEACHER";
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lnkTSignOut);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdUpldAtt);
            this.Controls.Add(this.cmdUpldRes);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdUpldAtt;
        private System.Windows.Forms.Button cmdUpldRes;
        private System.Windows.Forms.LinkLabel lnkTSignOut;
        private System.Windows.Forms.Label lblTeacher;
    }
}