namespace CLient
{
    partial class frmRegisterSubject
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
            this.lblName = new System.Windows.Forms.Label();
            this.gvRegisterSubjects = new System.Windows.Forms.DataGridView();
            this.lnkGoBack = new System.Windows.Forms.LinkLabel();
            this.Register = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegisterSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // gvRegisterSubjects
            // 
            this.gvRegisterSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRegisterSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Register});
            this.gvRegisterSubjects.Location = new System.Drawing.Point(27, 77);
            this.gvRegisterSubjects.Name = "gvRegisterSubjects";
            this.gvRegisterSubjects.Size = new System.Drawing.Size(403, 289);
            this.gvRegisterSubjects.TabIndex = 1;
            this.gvRegisterSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRegisterUser_CellContentClick);
            // 
            // lnkGoBack
            // 
            this.lnkGoBack.AutoSize = true;
            this.lnkGoBack.Location = new System.Drawing.Point(375, 401);
            this.lnkGoBack.Name = "lnkGoBack";
            this.lnkGoBack.Size = new System.Drawing.Size(49, 13);
            this.lnkGoBack.TabIndex = 2;
            this.lnkGoBack.TabStop = true;
            this.lnkGoBack.Text = "Go Back";
            this.lnkGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoBack_LinkClicked);
            // 
            // Register
            // 
            this.Register.HeaderText = "Resgiter/Unregister";
            this.Register.Name = "Register";
            this.Register.Text = "Resgiter/Unregister";
            this.Register.UseColumnTextForButtonValue = true;
            // 
            // frmRegisterSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 438);
            this.Controls.Add(this.lnkGoBack);
            this.Controls.Add(this.gvRegisterSubjects);
            this.Controls.Add(this.lblName);
            this.Name = "frmRegisterSubject";
            this.Text = "frmRegisterSubject";
            ((System.ComponentModel.ISupportInitialize)(this.gvRegisterSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView gvRegisterSubjects;
        private System.Windows.Forms.LinkLabel lnkGoBack;
        private System.Windows.Forms.DataGridViewButtonColumn Register;
    }
}