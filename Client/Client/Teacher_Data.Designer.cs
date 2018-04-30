namespace CLient
{
    partial class Teacher_Data
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Department = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbsearchbydep = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.lnkRegisteUser = new System.Windows.Forms.LinkLabel();
            this.lnkUpdateResult = new System.Windows.Forms.LinkLabel();
            this.lnkstudentdata = new System.Windows.Forms.LinkLabel();
            this.lnkSignOut = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(221, 94);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(482, 217);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(278, 26);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(62, 13);
            this.Department.TabIndex = 1;
            this.Department.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(204, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search By";
            // 
            // cmbsearchbydep
            // 
            this.cmbsearchbydep.FormattingEnabled = true;
            this.cmbsearchbydep.Items.AddRange(new object[] {
            "EE",
            "CS",
            "CIVIL",
            "PETROLEUM",
            "MECHANICAL"});
            this.cmbsearchbydep.Location = new System.Drawing.Point(387, 18);
            this.cmbsearchbydep.Name = "cmbsearchbydep";
            this.cmbsearchbydep.Size = new System.Drawing.Size(168, 21);
            this.cmbsearchbydep.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(387, 63);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(167, 20);
            this.txtname.TabIndex = 5;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnsearch.Location = new System.Drawing.Point(591, 53);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(112, 30);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel1.Location = new System.Drawing.Point(8, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 17);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Show All Teachers";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel2.Location = new System.Drawing.Point(6, 223);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(114, 17);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Go to Main Page";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // gbAdmin
            // 
            this.gbAdmin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbAdmin.Controls.Add(this.lnkSignOut);
            this.gbAdmin.Controls.Add(this.lnkRegisteUser);
            this.gbAdmin.Controls.Add(this.linkLabel1);
            this.gbAdmin.Controls.Add(this.linkLabel2);
            this.gbAdmin.Controls.Add(this.lnkUpdateResult);
            this.gbAdmin.Controls.Add(this.lnkstudentdata);
            this.gbAdmin.Location = new System.Drawing.Point(12, 9);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(175, 301);
            this.gbAdmin.TabIndex = 25;
            this.gbAdmin.TabStop = false;
            // 
            // lnkRegisteUser
            // 
            this.lnkRegisteUser.AutoSize = true;
            this.lnkRegisteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkRegisteUser.Location = new System.Drawing.Point(5, 123);
            this.lnkRegisteUser.Name = "lnkRegisteUser";
            this.lnkRegisteUser.Size = new System.Drawing.Size(95, 17);
            this.lnkRegisteUser.TabIndex = 20;
            this.lnkRegisteUser.TabStop = true;
            this.lnkRegisteUser.Text = "Register User";
            this.lnkRegisteUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegisteUser_LinkClicked);
            // 
            // lnkUpdateResult
            // 
            this.lnkUpdateResult.AutoSize = true;
            this.lnkUpdateResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkUpdateResult.Location = new System.Drawing.Point(8, 74);
            this.lnkUpdateResult.Name = "lnkUpdateResult";
            this.lnkUpdateResult.Size = new System.Drawing.Size(98, 17);
            this.lnkUpdateResult.TabIndex = 0;
            this.lnkUpdateResult.TabStop = true;
            this.lnkUpdateResult.Text = "Update Result";
            // 
            // lnkstudentdata
            // 
            this.lnkstudentdata.AutoSize = true;
            this.lnkstudentdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkstudentdata.Location = new System.Drawing.Point(5, 173);
            this.lnkstudentdata.Name = "lnkstudentdata";
            this.lnkstudentdata.Size = new System.Drawing.Size(140, 17);
            this.lnkstudentdata.TabIndex = 19;
            this.lnkstudentdata.TabStop = true;
            this.lnkstudentdata.Text = "View Data of Student";
            this.lnkstudentdata.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkstudentdata_LinkClicked);
            // 
            // lnkSignOut
            // 
            this.lnkSignOut.AutoSize = true;
            this.lnkSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkSignOut.Location = new System.Drawing.Point(8, 264);
            this.lnkSignOut.Name = "lnkSignOut";
            this.lnkSignOut.Size = new System.Drawing.Size(63, 17);
            this.lnkSignOut.TabIndex = 28;
            this.lnkSignOut.TabStop = true;
            this.lnkSignOut.Text = "Sign Out";
            this.lnkSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignOut_LinkClicked);
            // 
            // Teacher_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 322);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.cmbsearchbydep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.dgv);
            this.Name = "Teacher_Data";
            this.Text = "Teacher_Data";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbsearchbydep;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.LinkLabel lnkRegisteUser;
        private System.Windows.Forms.LinkLabel lnkUpdateResult;
        private System.Windows.Forms.LinkLabel lnkstudentdata;
        private System.Windows.Forms.LinkLabel lnkSignOut;
    }
}