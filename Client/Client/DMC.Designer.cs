namespace CLient
{
    partial class DMC
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
            this.dgvDMC = new System.Windows.Forms.DataGridView();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkSignOut = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lnkUpdateResult = new System.Windows.Forms.LinkLabel();
            this.lnkstudentdata = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMC)).BeginInit();
            this.gbAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDMC
            // 
            this.dgvDMC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMC.Location = new System.Drawing.Point(157, 5);
            this.dgvDMC.Name = "dgvDMC";
            this.dgvDMC.Size = new System.Drawing.Size(512, 423);
            this.dgvDMC.TabIndex = 0;
            this.dgvDMC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDMC_CellContentClick);
            // 
            // gbAdmin
            // 
            this.gbAdmin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbAdmin.Controls.Add(this.label1);
            this.gbAdmin.Controls.Add(this.lnkSignOut);
            this.gbAdmin.Controls.Add(this.linkLabel1);
            this.gbAdmin.Controls.Add(this.lnkUpdateResult);
            this.gbAdmin.Controls.Add(this.lnkstudentdata);
            this.gbAdmin.Location = new System.Drawing.Point(-3, 5);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(144, 408);
            this.gbAdmin.TabIndex = 26;
            this.gbAdmin.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 386);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "LMS";
            // 
            // lnkSignOut
            // 
            this.lnkSignOut.AutoSize = true;
            this.lnkSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkSignOut.Location = new System.Drawing.Point(15, 203);
            this.lnkSignOut.Name = "lnkSignOut";
            this.lnkSignOut.Size = new System.Drawing.Size(63, 17);
            this.lnkSignOut.TabIndex = 28;
            this.lnkSignOut.TabStop = true;
            this.lnkSignOut.Text = "Sign Out";
            this.lnkSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignOut_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel1.Location = new System.Drawing.Point(15, 115);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 17);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "My Account";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnkUpdateResult
            // 
            this.lnkUpdateResult.AutoSize = true;
            this.lnkUpdateResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkUpdateResult.Location = new System.Drawing.Point(6, 161);
            this.lnkUpdateResult.Name = "lnkUpdateResult";
            this.lnkUpdateResult.Size = new System.Drawing.Size(127, 17);
            this.lnkUpdateResult.TabIndex = 0;
            this.lnkUpdateResult.TabStop = true;
            this.lnkUpdateResult.Text = "Attendence Report";
            this.lnkUpdateResult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdateResult_LinkClicked);
            // 
            // lnkstudentdata
            // 
            this.lnkstudentdata.AutoSize = true;
            this.lnkstudentdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkstudentdata.Location = new System.Drawing.Point(71, 161);
            this.lnkstudentdata.Name = "lnkstudentdata";
            this.lnkstudentdata.Size = new System.Drawing.Size(0, 17);
            this.lnkstudentdata.TabIndex = 19;
            // 
            // DMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 432);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.dgvDMC);
            this.Name = "DMC";
            this.Text = "DMC";
            this.Load += new System.EventHandler(this.DMC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMC)).EndInit();
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDMC;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.LinkLabel lnkSignOut;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lnkUpdateResult;
        private System.Windows.Forms.LinkLabel lnkstudentdata;
        private System.Windows.Forms.Label label1;
    }
}