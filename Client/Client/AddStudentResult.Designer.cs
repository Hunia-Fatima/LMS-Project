namespace CLient
{
    partial class AddStudentResult
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
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lnkuploadedresult = new System.Windows.Forms.LinkLabel();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lbltotalmarks = new System.Windows.Forms.Label();
            this.lblmarksobtained = new System.Windows.Forms.Label();
            this.lblsection = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.cmbsection = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtmarksobtained = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkSignOut = new System.Windows.Forms.LinkLabel();
            this.lnkUplaodAttendance = new System.Windows.Forms.LinkLabel();
            this.lnkgoback = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SectionA = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SectionB = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SectionC = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SectionD = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAdd
            // 
            this.cmdAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdAdd.Location = new System.Drawing.Point(366, 328);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 25;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // lnkuploadedresult
            // 
            this.lnkuploadedresult.AutoSize = true;
            this.lnkuploadedresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkuploadedresult.Location = new System.Drawing.Point(7, 118);
            this.lnkuploadedresult.Name = "lnkuploadedresult";
            this.lnkuploadedresult.Size = new System.Drawing.Size(113, 17);
            this.lnkuploadedresult.TabIndex = 24;
            this.lnkuploadedresult.TabStop = true;
            this.lnkuploadedresult.Text = "Uploaded Result";
            this.lnkuploadedresult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkuploadedresult_LinkClicked);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(161, 267);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(37, 13);
            this.lblstatus.TabIndex = 22;
            this.lblstatus.Text = "Status";
            // 
            // lbltotalmarks
            // 
            this.lbltotalmarks.AutoSize = true;
            this.lbltotalmarks.Location = new System.Drawing.Point(161, 211);
            this.lbltotalmarks.Name = "lbltotalmarks";
            this.lbltotalmarks.Size = new System.Drawing.Size(60, 13);
            this.lbltotalmarks.TabIndex = 21;
            this.lbltotalmarks.Text = "TotalMarks";
            // 
            // lblmarksobtained
            // 
            this.lblmarksobtained.AutoSize = true;
            this.lblmarksobtained.Location = new System.Drawing.Point(155, 153);
            this.lblmarksobtained.Name = "lblmarksobtained";
            this.lblmarksobtained.Size = new System.Drawing.Size(79, 13);
            this.lblmarksobtained.TabIndex = 20;
            this.lblmarksobtained.Text = "MarksObtained";
            // 
            // lblsection
            // 
            this.lblsection.AutoSize = true;
            this.lblsection.Location = new System.Drawing.Point(155, 95);
            this.lblsection.Name = "lblsection";
            this.lblsection.Size = new System.Drawing.Size(43, 13);
            this.lblsection.TabIndex = 19;
            this.lblsection.Text = "Section";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(155, 38);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 18;
            this.lblname.Text = "Name";
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "PASS",
            "FAIL",
            "PENDING"});
            this.cmbstatus.Location = new System.Drawing.Point(250, 261);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(191, 21);
            this.cmbstatus.TabIndex = 17;
            // 
            // cmbsection
            // 
            this.cmbsection.FormattingEnabled = true;
            this.cmbsection.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbsection.Location = new System.Drawing.Point(248, 89);
            this.cmbsection.Name = "cmbsection";
            this.cmbsection.Size = new System.Drawing.Size(191, 21);
            this.cmbsection.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(250, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 20);
            this.textBox3.TabIndex = 15;
            // 
            // txtmarksobtained
            // 
            this.txtmarksobtained.Location = new System.Drawing.Point(248, 148);
            this.txtmarksobtained.Name = "txtmarksobtained";
            this.txtmarksobtained.Size = new System.Drawing.Size(191, 20);
            this.txtmarksobtained.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.lnkSignOut);
            this.groupBox1.Controls.Add(this.lnkUplaodAttendance);
            this.groupBox1.Controls.Add(this.lnkgoback);
            this.groupBox1.Controls.Add(this.lnkuploadedresult);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 342);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // lnkSignOut
            // 
            this.lnkSignOut.AutoSize = true;
            this.lnkSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkSignOut.Location = new System.Drawing.Point(7, 238);
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
            this.lnkUplaodAttendance.Location = new System.Drawing.Point(6, 54);
            this.lnkUplaodAttendance.Name = "lnkUplaodAttendance";
            this.lnkUplaodAttendance.Size = new System.Drawing.Size(129, 17);
            this.lnkUplaodAttendance.TabIndex = 25;
            this.lnkUplaodAttendance.TabStop = true;
            this.lnkUplaodAttendance.Text = "Upload Attendance";
            // 
            // lnkgoback
            // 
            this.lnkgoback.AutoSize = true;
            this.lnkgoback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkgoback.Location = new System.Drawing.Point(6, 179);
            this.lnkgoback.Name = "lnkgoback";
            this.lnkgoback.Size = new System.Drawing.Size(114, 17);
            this.lnkgoback.TabIndex = 23;
            this.lnkgoback.TabStop = true;
            this.lnkgoback.Text = "Go to Main Page";
            this.lnkgoback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkgoback_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SectionA,
            this.SectionB,
            this.SectionC,
            this.SectionD});
            this.dataGridView1.Location = new System.Drawing.Point(471, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 62);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SectionA
            // 
            this.SectionA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SectionA.HeaderText = "Result of SectionA";
            this.SectionA.Name = "SectionA";
            this.SectionA.Text = "Result of SectionA";
            this.SectionA.UseColumnTextForButtonValue = true;
            // 
            // SectionB
            // 
            this.SectionB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SectionB.HeaderText = "Result of SectionB";
            this.SectionB.Name = "SectionB";
            this.SectionB.Text = "Result of SectionB";
            this.SectionB.UseColumnTextForButtonValue = true;
            // 
            // SectionC
            // 
            this.SectionC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SectionC.HeaderText = "Result of SectionC";
            this.SectionC.Name = "SectionC";
            this.SectionC.Text = "Result of SectionC";
            this.SectionC.UseColumnTextForButtonValue = true;
            // 
            // SectionD
            // 
            this.SectionD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SectionD.HeaderText = "Result of SectionD";
            this.SectionD.Name = "SectionD";
            this.SectionD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SectionD.Text = "Result of SectionD";
            this.SectionD.UseColumnTextForButtonValue = true;
            // 
            // AddStudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(911, 363);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lbltotalmarks);
            this.Controls.Add(this.lblmarksobtained);
            this.Controls.Add(this.lblsection);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.cmbsection);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtmarksobtained);
            this.Controls.Add(this.textBox1);
            this.Name = "AddStudentResult";
            this.Text = "Uplaod Result";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.LinkLabel lnkuploadedresult;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lbltotalmarks;
        private System.Windows.Forms.Label lblmarksobtained;
        private System.Windows.Forms.Label lblsection;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.ComboBox cmbsection;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtmarksobtained;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkUplaodAttendance;
        private System.Windows.Forms.LinkLabel lnkSignOut;
        private System.Windows.Forms.LinkLabel lnkgoback;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn SectionA;
        private System.Windows.Forms.DataGridViewButtonColumn SectionB;
        private System.Windows.Forms.DataGridViewButtonColumn SectionC;
        private System.Windows.Forms.DataGridViewButtonColumn SectionD;
    }
}