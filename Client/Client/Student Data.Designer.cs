namespace CLient
{
    partial class Student_Data
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
            this.lnkShowAll = new System.Windows.Forms.LinkLabel();
            this.txtSBySec = new System.Windows.Forms.TextBox();
            this.txtSByName = new System.Windows.Forms.TextBox();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSby = new System.Windows.Forms.Label();
            this.DGVdata = new System.Windows.Forms.DataGridView();
            this.DMC = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.lnkGoBck = new System.Windows.Forms.LinkLabel();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.lnkUpdateResult = new System.Windows.Forms.LinkLabel();
            this.lnkteacherdata = new System.Windows.Forms.LinkLabel();
            this.lnkRegisteUser = new System.Windows.Forms.LinkLabel();
            this.lnkSignOut = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdata)).BeginInit();
            this.gbAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkShowAll
            // 
            this.lnkShowAll.AutoSize = true;
            this.lnkShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkShowAll.Location = new System.Drawing.Point(7, 53);
            this.lnkShowAll.Name = "lnkShowAll";
            this.lnkShowAll.Size = new System.Drawing.Size(121, 17);
            this.lnkShowAll.TabIndex = 0;
            this.lnkShowAll.TabStop = true;
            this.lnkShowAll.Text = "Show All Students";
            this.lnkShowAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowAll_LinkClicked);
            // 
            // txtSBySec
            // 
            this.txtSBySec.Location = new System.Drawing.Point(288, 38);
            this.txtSBySec.Name = "txtSBySec";
            this.txtSBySec.Size = new System.Drawing.Size(213, 20);
            this.txtSBySec.TabIndex = 1;
            // 
            // txtSByName
            // 
            this.txtSByName.Location = new System.Drawing.Point(288, 76);
            this.txtSByName.Name = "txtSByName";
            this.txtSByName.Size = new System.Drawing.Size(213, 20);
            this.txtSByName.TabIndex = 2;
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(211, 41);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(43, 13);
            this.lblSec.TabIndex = 3;
            this.lblSec.Text = "Section";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(211, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblSby
            // 
            this.lblSby.AutoSize = true;
            this.lblSby.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSby.Location = new System.Drawing.Point(165, 9);
            this.lblSby.Name = "lblSby";
            this.lblSby.Size = new System.Drawing.Size(72, 18);
            this.lblSby.TabIndex = 5;
            this.lblSby.Text = "Search by:";
            // 
            // DGVdata
            // 
            this.DGVdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DMC});
            this.DGVdata.Location = new System.Drawing.Point(176, 142);
            this.DGVdata.Name = "DGVdata";
            this.DGVdata.Size = new System.Drawing.Size(642, 322);
            this.DGVdata.TabIndex = 6;
            this.DGVdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVdata_CellContentClick);
            // 
            // DMC
            // 
            this.DMC.HeaderText = "View DMC";
            this.DMC.Name = "DMC";
            this.DMC.Text = "DMC";
            this.DMC.UseColumnTextForButtonValue = true;
            // 
            // cmdSearch
            // 
            this.cmdSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdSearch.Location = new System.Drawing.Point(559, 41);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(108, 44);
            this.cmdSearch.TabIndex = 7;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = false;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // lnkGoBck
            // 
            this.lnkGoBck.AutoSize = true;
            this.lnkGoBck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkGoBck.Location = new System.Drawing.Point(5, 250);
            this.lnkGoBck.Name = "lnkGoBck";
            this.lnkGoBck.Size = new System.Drawing.Size(114, 17);
            this.lnkGoBck.TabIndex = 8;
            this.lnkGoBck.TabStop = true;
            this.lnkGoBck.Text = "Go to Main Page";
            this.lnkGoBck.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoBck_LinkClicked);
            // 
            // gbAdmin
            // 
            this.gbAdmin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbAdmin.Controls.Add(this.lnkSignOut);
            this.gbAdmin.Controls.Add(this.lnkRegisteUser);
            this.gbAdmin.Controls.Add(this.lnkUpdateResult);
            this.gbAdmin.Controls.Add(this.lnkGoBck);
            this.gbAdmin.Controls.Add(this.lnkteacherdata);
            this.gbAdmin.Controls.Add(this.lnkShowAll);
            this.gbAdmin.Location = new System.Drawing.Point(1, 9);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(162, 460);
            this.gbAdmin.TabIndex = 23;
            this.gbAdmin.TabStop = false;
            // 
            // lnkUpdateResult
            // 
            this.lnkUpdateResult.AutoSize = true;
            this.lnkUpdateResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkUpdateResult.Location = new System.Drawing.Point(8, 101);
            this.lnkUpdateResult.Name = "lnkUpdateResult";
            this.lnkUpdateResult.Size = new System.Drawing.Size(98, 17);
            this.lnkUpdateResult.TabIndex = 0;
            this.lnkUpdateResult.TabStop = true;
            this.lnkUpdateResult.Text = "Update Result";
            this.lnkUpdateResult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdateResult_LinkClicked);
            // 
            // lnkteacherdata
            // 
            this.lnkteacherdata.AutoSize = true;
            this.lnkteacherdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkteacherdata.Location = new System.Drawing.Point(5, 202);
            this.lnkteacherdata.Name = "lnkteacherdata";
            this.lnkteacherdata.Size = new System.Drawing.Size(144, 17);
            this.lnkteacherdata.TabIndex = 19;
            this.lnkteacherdata.TabStop = true;
            this.lnkteacherdata.Text = "View Data of Teacher";
            this.lnkteacherdata.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkteacherdata_LinkClicked);
            // 
            // lnkRegisteUser
            // 
            this.lnkRegisteUser.AutoSize = true;
            this.lnkRegisteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkRegisteUser.Location = new System.Drawing.Point(5, 153);
            this.lnkRegisteUser.Name = "lnkRegisteUser";
            this.lnkRegisteUser.Size = new System.Drawing.Size(95, 17);
            this.lnkRegisteUser.TabIndex = 20;
            this.lnkRegisteUser.TabStop = true;
            this.lnkRegisteUser.Text = "Register User";
            this.lnkRegisteUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegisteUser_LinkClicked);
            // 
            // lnkSignOut
            // 
            this.lnkSignOut.AutoSize = true;
            this.lnkSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkSignOut.Location = new System.Drawing.Point(8, 305);
            this.lnkSignOut.Name = "lnkSignOut";
            this.lnkSignOut.Size = new System.Drawing.Size(63, 17);
            this.lnkSignOut.TabIndex = 28;
            this.lnkSignOut.TabStop = true;
            this.lnkSignOut.Text = "Sign Out";
            this.lnkSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignOut_LinkClicked);
            // 
            // Student_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.cmdSearch;
            this.ClientSize = new System.Drawing.Size(823, 469);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.DGVdata);
            this.Controls.Add(this.lblSby);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.txtSByName);
            this.Controls.Add(this.txtSBySec);
            this.Name = "Student_Data";
            this.Text = "Student_Data";
            ((System.ComponentModel.ISupportInitialize)(this.DGVdata)).EndInit();
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkShowAll;
        private System.Windows.Forms.TextBox txtSBySec;
        private System.Windows.Forms.TextBox txtSByName;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSby;
        private System.Windows.Forms.DataGridView DGVdata;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.DataGridViewButtonColumn DMC;
        private System.Windows.Forms.LinkLabel lnkGoBck;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.LinkLabel lnkUpdateResult;
        private System.Windows.Forms.LinkLabel lnkteacherdata;
        private System.Windows.Forms.LinkLabel lnkRegisteUser;
        private System.Windows.Forms.LinkLabel lnkSignOut;
    }
}