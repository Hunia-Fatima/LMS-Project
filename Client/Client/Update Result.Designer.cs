namespace CLient
{
    partial class Update_Result
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkSignOut = new System.Windows.Forms.LinkLabel();
            this.lnkteacherData = new System.Windows.Forms.LinkLabel();
            this.lnkGoBack = new System.Windows.Forms.LinkLabel();
            this.lnkRegisterUser = new System.Windows.Forms.LinkLabel();
            this.lnkStudentData = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(206, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 353);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.BackgroundImage = global::CLient.Properties.Resources.Untitled_2;
            this.groupBox1.Controls.Add(this.lnkSignOut);
            this.groupBox1.Controls.Add(this.lnkteacherData);
            this.groupBox1.Controls.Add(this.lnkGoBack);
            this.groupBox1.Controls.Add(this.lnkRegisterUser);
            this.groupBox1.Controls.Add(this.lnkStudentData);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 391);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // lnkSignOut
            // 
            this.lnkSignOut.AutoSize = true;
            this.lnkSignOut.BackColor = System.Drawing.Color.Black;
            this.lnkSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkSignOut.LinkColor = System.Drawing.Color.White;
            this.lnkSignOut.Location = new System.Drawing.Point(8, 285);
            this.lnkSignOut.Name = "lnkSignOut";
            this.lnkSignOut.Size = new System.Drawing.Size(63, 17);
            this.lnkSignOut.TabIndex = 27;
            this.lnkSignOut.TabStop = true;
            this.lnkSignOut.Text = "Sign Out";
            this.lnkSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignOut_LinkClicked);
            // 
            // lnkteacherData
            // 
            this.lnkteacherData.AutoSize = true;
            this.lnkteacherData.BackColor = System.Drawing.Color.Black;
            this.lnkteacherData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkteacherData.LinkColor = System.Drawing.Color.White;
            this.lnkteacherData.Location = new System.Drawing.Point(5, 132);
            this.lnkteacherData.Name = "lnkteacherData";
            this.lnkteacherData.Size = new System.Drawing.Size(144, 17);
            this.lnkteacherData.TabIndex = 20;
            this.lnkteacherData.TabStop = true;
            this.lnkteacherData.Text = "View Data of Teacher";
            this.lnkteacherData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkteacherData_LinkClicked);
            // 
            // lnkGoBack
            // 
            this.lnkGoBack.AutoSize = true;
            this.lnkGoBack.BackColor = System.Drawing.Color.Black;
            this.lnkGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkGoBack.LinkColor = System.Drawing.Color.White;
            this.lnkGoBack.Location = new System.Drawing.Point(6, 232);
            this.lnkGoBack.Name = "lnkGoBack";
            this.lnkGoBack.Size = new System.Drawing.Size(114, 17);
            this.lnkGoBack.TabIndex = 8;
            this.lnkGoBack.TabStop = true;
            this.lnkGoBack.Text = "Go to Main Page";
            this.lnkGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoBack_LinkClicked);
            // 
            // lnkRegisterUser
            // 
            this.lnkRegisterUser.AutoSize = true;
            this.lnkRegisterUser.BackColor = System.Drawing.Color.Black;
            this.lnkRegisterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkRegisterUser.LinkColor = System.Drawing.Color.White;
            this.lnkRegisterUser.Location = new System.Drawing.Point(8, 83);
            this.lnkRegisterUser.Name = "lnkRegisterUser";
            this.lnkRegisterUser.Size = new System.Drawing.Size(95, 17);
            this.lnkRegisterUser.TabIndex = 0;
            this.lnkRegisterUser.TabStop = true;
            this.lnkRegisterUser.Text = "Register User";
            this.lnkRegisterUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegisterUser_LinkClicked);
            // 
            // lnkStudentData
            // 
            this.lnkStudentData.AutoSize = true;
            this.lnkStudentData.BackColor = System.Drawing.Color.Black;
            this.lnkStudentData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnkStudentData.LinkColor = System.Drawing.Color.White;
            this.lnkStudentData.Location = new System.Drawing.Point(5, 182);
            this.lnkStudentData.Name = "lnkStudentData";
            this.lnkStudentData.Size = new System.Drawing.Size(140, 17);
            this.lnkStudentData.TabIndex = 19;
            this.lnkStudentData.TabStop = true;
            this.lnkStudentData.Text = "View Data of Student";
            this.lnkStudentData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStudentData_LinkClicked);
            // 
            // Update_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::CLient.Properties.Resources.zero_g_theme_logon_background_by_lilmegz97_d4sliyn3;
            this.ClientSize = new System.Drawing.Size(786, 415);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Update_Result";
            this.Text = "Update Result";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkSignOut;
        private System.Windows.Forms.LinkLabel lnkteacherData;
        private System.Windows.Forms.LinkLabel lnkGoBack;
        private System.Windows.Forms.LinkLabel lnkRegisterUser;
        private System.Windows.Forms.LinkLabel lnkStudentData;
    }
}