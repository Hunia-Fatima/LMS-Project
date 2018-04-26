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
            this.lnkgoback = new System.Windows.Forms.LinkLabel();
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
            this.SuspendLayout();
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(295, 212);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 25;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // lnkuploadedresult
            // 
            this.lnkuploadedresult.AutoSize = true;
            this.lnkuploadedresult.Location = new System.Drawing.Point(27, 269);
            this.lnkuploadedresult.Name = "lnkuploadedresult";
            this.lnkuploadedresult.Size = new System.Drawing.Size(86, 13);
            this.lnkuploadedresult.TabIndex = 24;
            this.lnkuploadedresult.TabStop = true;
            this.lnkuploadedresult.Text = "Uploaded Result";
            this.lnkuploadedresult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkuploadedresult_LinkClicked);
            // 
            // lnkgoback
            // 
            this.lnkgoback.AutoSize = true;
            this.lnkgoback.Location = new System.Drawing.Point(316, 257);
            this.lnkgoback.Name = "lnkgoback";
            this.lnkgoback.Size = new System.Drawing.Size(54, 13);
            this.lnkgoback.TabIndex = 23;
            this.lnkgoback.TabStop = true;
            this.lnkgoback.Text = "GO BACK";
            this.lnkgoback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkgoback_LinkClicked);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(27, 167);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(37, 13);
            this.lblstatus.TabIndex = 22;
            this.lblstatus.Text = "Status";
            // 
            // lbltotalmarks
            // 
            this.lbltotalmarks.AutoSize = true;
            this.lbltotalmarks.Location = new System.Drawing.Point(13, 127);
            this.lbltotalmarks.Name = "lbltotalmarks";
            this.lbltotalmarks.Size = new System.Drawing.Size(60, 13);
            this.lbltotalmarks.TabIndex = 21;
            this.lbltotalmarks.Text = "TotalMarks";
            // 
            // lblmarksobtained
            // 
            this.lblmarksobtained.AutoSize = true;
            this.lblmarksobtained.Location = new System.Drawing.Point(13, 85);
            this.lblmarksobtained.Name = "lblmarksobtained";
            this.lblmarksobtained.Size = new System.Drawing.Size(79, 13);
            this.lblmarksobtained.TabIndex = 20;
            this.lblmarksobtained.Text = "MarksObtained";
            // 
            // lblsection
            // 
            this.lblsection.AutoSize = true;
            this.lblsection.Location = new System.Drawing.Point(27, 40);
            this.lblsection.Name = "lblsection";
            this.lblsection.Size = new System.Drawing.Size(43, 13);
            this.lblsection.TabIndex = 19;
            this.lblsection.Text = "Section";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(29, 12);
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
            this.cmbstatus.Location = new System.Drawing.Point(110, 164);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(238, 21);
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
            this.cmbsection.Location = new System.Drawing.Point(110, 40);
            this.cmbsection.Name = "cmbsection";
            this.cmbsection.Size = new System.Drawing.Size(238, 21);
            this.cmbsection.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(238, 20);
            this.textBox3.TabIndex = 15;
            // 
            // txtmarksobtained
            // 
            this.txtmarksobtained.Location = new System.Drawing.Point(110, 82);
            this.txtmarksobtained.Name = "txtmarksobtained";
            this.txtmarksobtained.Size = new System.Drawing.Size(238, 20);
            this.txtmarksobtained.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 20);
            this.textBox1.TabIndex = 13;
            // 
            // AddStudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 303);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.lnkuploadedresult);
            this.Controls.Add(this.lnkgoback);
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
            this.Text = "AddStudentResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.LinkLabel lnkuploadedresult;
        private System.Windows.Forms.LinkLabel lnkgoback;
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
    }
}