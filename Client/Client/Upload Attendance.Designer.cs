namespace CLient
{
    partial class Upload_Attendance
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkSignOut = new System.Windows.Forms.LinkLabel();
            this.lnkUplaodAttendance = new System.Windows.Forms.LinkLabel();
            this.lnkgoback = new System.Windows.Forms.LinkLabel();
            this.lblUpAt = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lblsection = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.lblPer = new System.Windows.Forms.Label();
            this.txtPerc = new System.Windows.Forms.TextBox();
            this.txtSbj = new System.Windows.Forms.TextBox();
            this.lblSub = new System.Windows.Forms.Label();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSemes = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.lnkSignOut);
            this.groupBox1.Controls.Add(this.lnkUplaodAttendance);
            this.groupBox1.Controls.Add(this.lnkgoback);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 380);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // lnkSignOut
            // 
            this.lnkSignOut.AutoSize = true;
            this.lnkSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkSignOut.Location = new System.Drawing.Point(6, 185);
            this.lnkSignOut.Name = "lnkSignOut";
            this.lnkSignOut.Size = new System.Drawing.Size(63, 17);
            this.lnkSignOut.TabIndex = 26;
            this.lnkSignOut.TabStop = true;
            this.lnkSignOut.Text = "Sign Out";
            this.lnkSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignOut_LinkClicked);
            // 
            // lnkUplaodAttendance
            // 
            this.lnkUplaodAttendance.AutoSize = true;
            this.lnkUplaodAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkUplaodAttendance.Location = new System.Drawing.Point(6, 115);
            this.lnkUplaodAttendance.Name = "lnkUplaodAttendance";
            this.lnkUplaodAttendance.Size = new System.Drawing.Size(97, 17);
            this.lnkUplaodAttendance.TabIndex = 25;
            this.lnkUplaodAttendance.TabStop = true;
            this.lnkUplaodAttendance.Text = "Upload Result";
            this.lnkUplaodAttendance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUplaodAttendance_LinkClicked);
            // 
            // lnkgoback
            // 
            this.lnkgoback.AutoSize = true;
            this.lnkgoback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkgoback.Location = new System.Drawing.Point(6, 148);
            this.lnkgoback.Name = "lnkgoback";
            this.lnkgoback.Size = new System.Drawing.Size(114, 17);
            this.lnkgoback.TabIndex = 23;
            this.lnkgoback.TabStop = true;
            this.lnkgoback.Text = "Go to Main Page";
            this.lnkgoback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkgoback_LinkClicked);
            // 
            // lblUpAt
            // 
            this.lblUpAt.AutoSize = true;
            this.lblUpAt.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpAt.Location = new System.Drawing.Point(261, 43);
            this.lblUpAt.Name = "lblUpAt";
            this.lblUpAt.Size = new System.Drawing.Size(166, 22);
            this.lblUpAt.TabIndex = 27;
            this.lblUpAt.Text = "Uploading Attendance";
            // 
            // cmdAdd
            // 
            this.cmdAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdAdd.Location = new System.Drawing.Point(379, 355);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(133, 37);
            this.cmdAdd.TabIndex = 38;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // lblsection
            // 
            this.lblsection.AutoSize = true;
            this.lblsection.Location = new System.Drawing.Point(202, 148);
            this.lblsection.Name = "lblsection";
            this.lblsection.Size = new System.Drawing.Size(43, 13);
            this.lblsection.TabIndex = 34;
            this.lblsection.Text = "Section";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(202, 100);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 33;
            this.lblname.Text = "Name";
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(293, 148);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(191, 20);
            this.txtSec.TabIndex = 28;
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Location = new System.Drawing.Point(140, 197);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(122, 13);
            this.lblPer.TabIndex = 39;
            this.lblPer.Text = "Percentage attendance ";
            // 
            // txtPerc
            // 
            this.txtPerc.Location = new System.Drawing.Point(295, 197);
            this.txtPerc.Name = "txtPerc";
            this.txtPerc.Size = new System.Drawing.Size(189, 20);
            this.txtPerc.TabIndex = 40;
            // 
            // txtSbj
            // 
            this.txtSbj.Location = new System.Drawing.Point(293, 248);
            this.txtSbj.Name = "txtSbj";
            this.txtSbj.Size = new System.Drawing.Size(193, 20);
            this.txtSbj.TabIndex = 41;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(202, 255);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(43, 13);
            this.lblSub.TabIndex = 42;
            this.lblSub.Text = "Subject";
            // 
            // cmbStudents
            // 
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(293, 100);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(191, 21);
            this.cmbStudents.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Semester";
            // 
            // txtSemes
            // 
            this.txtSemes.Location = new System.Drawing.Point(293, 294);
            this.txtSemes.Name = "txtSemes";
            this.txtSemes.Size = new System.Drawing.Size(195, 20);
            this.txtSemes.TabIndex = 45;
            // 
            // Upload_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 414);
            this.Controls.Add(this.txtSemes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.txtSbj);
            this.Controls.Add(this.txtPerc);
            this.Controls.Add(this.lblPer);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.lblsection);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.lblUpAt);
            this.Controls.Add(this.groupBox1);
            this.Name = "Upload_Attendance";
            this.Text = "Upload_Attendance";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkSignOut;
        private System.Windows.Forms.LinkLabel lnkUplaodAttendance;
        private System.Windows.Forms.LinkLabel lnkgoback;
        private System.Windows.Forms.Label lblUpAt;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label lblsection;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.TextBox txtPerc;
        private System.Windows.Forms.TextBox txtSbj;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSemes;
    }
}