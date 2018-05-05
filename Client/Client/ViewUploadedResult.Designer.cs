namespace CLient
{
    partial class ViewUploadedResult
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmdShowAll = new System.Windows.Forms.Button();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkSignOut = new System.Windows.Forms.LinkLabel();
            this.lnkUplaodAttendance = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lnkUploadResult = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSearch
            // 
            this.cmdSearch.BackColor = System.Drawing.Color.Black;
            this.cmdSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearch.ForeColor = System.Drawing.Color.White;
            this.cmdSearch.Location = new System.Drawing.Point(374, 20);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(100, 39);
            this.cmdSearch.TabIndex = 9;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = false;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // cmdShowAll
            // 
            this.cmdShowAll.BackColor = System.Drawing.Color.Black;
            this.cmdShowAll.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdShowAll.ForeColor = System.Drawing.Color.White;
            this.cmdShowAll.Location = new System.Drawing.Point(374, 65);
            this.cmdShowAll.Name = "cmdShowAll";
            this.cmdShowAll.Size = new System.Drawing.Size(100, 34);
            this.cmdShowAll.TabIndex = 8;
            this.cmdShowAll.Text = "ShowAll";
            this.cmdShowAll.UseVisualStyleBackColor = false;
            this.cmdShowAll.Click += new System.EventHandler(this.cmdShowAll_Click);
            // 
            // txtsection
            // 
            this.txtsection.Location = new System.Drawing.Point(181, 74);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(173, 20);
            this.txtsection.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(167, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 280);
            this.dataGridView1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.BackgroundImage = global::CLient.Properties.Resources.Untitled_2;
            this.groupBox1.Controls.Add(this.lnkSignOut);
            this.groupBox1.Controls.Add(this.lnkUplaodAttendance);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.lnkUploadResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 396);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // lnkSignOut
            // 
            this.lnkSignOut.AutoSize = true;
            this.lnkSignOut.BackColor = System.Drawing.Color.Black;
            this.lnkSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkSignOut.LinkColor = System.Drawing.Color.White;
            this.lnkSignOut.Location = new System.Drawing.Point(7, 238);
            this.lnkSignOut.Name = "lnkSignOut";
            this.lnkSignOut.Size = new System.Drawing.Size(63, 17);
            this.lnkSignOut.TabIndex = 26;
            this.lnkSignOut.TabStop = true;
            this.lnkSignOut.Text = "Sign Out";
            // 
            // lnkUplaodAttendance
            // 
            this.lnkUplaodAttendance.AutoSize = true;
            this.lnkUplaodAttendance.BackColor = System.Drawing.Color.Black;
            this.lnkUplaodAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkUplaodAttendance.LinkColor = System.Drawing.Color.White;
            this.lnkUplaodAttendance.Location = new System.Drawing.Point(6, 54);
            this.lnkUplaodAttendance.Name = "lnkUplaodAttendance";
            this.lnkUplaodAttendance.Size = new System.Drawing.Size(129, 17);
            this.lnkUplaodAttendance.TabIndex = 25;
            this.lnkUplaodAttendance.TabStop = true;
            this.lnkUplaodAttendance.Text = "Upload Attendance";
            this.lnkUplaodAttendance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUplaodAttendance_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Black;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(6, 179);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 17);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go to Main Page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnkUploadResult
            // 
            this.lnkUploadResult.AutoSize = true;
            this.lnkUploadResult.BackColor = System.Drawing.Color.Black;
            this.lnkUploadResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkUploadResult.LinkColor = System.Drawing.Color.White;
            this.lnkUploadResult.Location = new System.Drawing.Point(7, 116);
            this.lnkUploadResult.Name = "lnkUploadResult";
            this.lnkUploadResult.Size = new System.Drawing.Size(97, 17);
            this.lnkUploadResult.TabIndex = 24;
            this.lnkUploadResult.TabStop = true;
            this.lnkUploadResult.Text = "Upload Result";
            this.lnkUploadResult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUploadResult_LinkClicked);
            // 
            // ViewUploadedResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::CLient.Properties.Resources.zero_g_theme_logon_background_by_lilmegz97_d4sliyn3;
            this.ClientSize = new System.Drawing.Size(624, 420);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.cmdShowAll);
            this.Controls.Add(this.txtsection);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewUploadedResult";
            this.Text = "ViewUploadedResult";
            this.Load += new System.EventHandler(this.ViewUploadedResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Button cmdShowAll;
        private System.Windows.Forms.TextBox txtsection;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkSignOut;
        private System.Windows.Forms.LinkLabel lnkUplaodAttendance;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lnkUploadResult;
    }
}