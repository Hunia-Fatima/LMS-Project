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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdUpldAtt = new System.Windows.Forms.Button();
            this.cmdUpldRes = new System.Windows.Forms.Button();
            this.lnkTSignOut = new System.Windows.Forms.LinkLabel();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.cmbact = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Set Status";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdUpldAtt
            // 
            this.cmdUpldAtt.BackColor = System.Drawing.Color.Black;
            this.cmdUpldAtt.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpldAtt.ForeColor = System.Drawing.Color.White;
            this.cmdUpldAtt.Location = new System.Drawing.Point(149, 170);
            this.cmdUpldAtt.Name = "cmdUpldAtt";
            this.cmdUpldAtt.Size = new System.Drawing.Size(216, 50);
            this.cmdUpldAtt.TabIndex = 6;
            this.cmdUpldAtt.Text = "Upload attendance";
            this.cmdUpldAtt.UseVisualStyleBackColor = false;
            this.cmdUpldAtt.Click += new System.EventHandler(this.cmdUpldAtt_Click);
            // 
            // cmdUpldRes
            // 
            this.cmdUpldRes.BackColor = System.Drawing.Color.Black;
            this.cmdUpldRes.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpldRes.ForeColor = System.Drawing.Color.White;
            this.cmdUpldRes.Location = new System.Drawing.Point(148, 100);
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
            this.lnkTSignOut.BackColor = System.Drawing.Color.Black;
            this.lnkTSignOut.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkTSignOut.LinkColor = System.Drawing.Color.White;
            this.lnkTSignOut.Location = new System.Drawing.Point(530, 358);
            this.lnkTSignOut.Name = "lnkTSignOut";
            this.lnkTSignOut.Size = new System.Drawing.Size(78, 22);
            this.lnkTSignOut.TabIndex = 9;
            this.lnkTSignOut.TabStop = true;
            this.lnkTSignOut.Text = "Sign out";
            this.lnkTSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTSignOut_LinkClicked);
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.BackColor = System.Drawing.Color.Black;
            this.lblTeacher.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.ForeColor = System.Drawing.Color.White;
            this.lblTeacher.Location = new System.Drawing.Point(12, 9);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(165, 36);
            this.lblTeacher.TabIndex = 10;
            this.lblTeacher.Text = "TEACHER";
            // 
            // cmbact
            // 
            this.cmbact.FormattingEnabled = true;
            this.cmbact.Items.AddRange(new object[] {
            "Busy",
            "Free"});
            this.cmbact.Location = new System.Drawing.Point(149, 260);
            this.cmbact.Name = "cmbact";
            this.cmbact.Size = new System.Drawing.Size(238, 21);
            this.cmbact.TabIndex = 12;
            this.cmbact.SelectedIndexChanged += new System.EventHandler(this.cmbact_SelectedIndexChanged);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::CLient.Properties.Resources.zero_g_theme_logon_background_by_lilmegz97_d4sliyn3;
            this.ClientSize = new System.Drawing.Size(620, 389);
            this.Controls.Add(this.cmbact);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lnkTSignOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdUpldAtt);
            this.Controls.Add(this.cmdUpldRes);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdUpldAtt;
        private System.Windows.Forms.Button cmdUpldRes;
        private System.Windows.Forms.LinkLabel lnkTSignOut;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.ComboBox cmbact;
    }
}