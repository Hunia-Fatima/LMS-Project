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
            ((System.ComponentModel.ISupportInitialize)(this.DGVdata)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkShowAll
            // 
            this.lnkShowAll.AutoSize = true;
            this.lnkShowAll.LinkColor = System.Drawing.Color.Purple;
            this.lnkShowAll.Location = new System.Drawing.Point(613, 57);
            this.lnkShowAll.Name = "lnkShowAll";
            this.lnkShowAll.Size = new System.Drawing.Size(48, 13);
            this.lnkShowAll.TabIndex = 0;
            this.lnkShowAll.TabStop = true;
            this.lnkShowAll.Text = "Show All";
            this.lnkShowAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowAll_LinkClicked);
            // 
            // txtSBySec
            // 
            this.txtSBySec.Location = new System.Drawing.Point(161, 38);
            this.txtSBySec.Name = "txtSBySec";
            this.txtSBySec.Size = new System.Drawing.Size(213, 20);
            this.txtSBySec.TabIndex = 1;
            // 
            // txtSByName
            // 
            this.txtSByName.Location = new System.Drawing.Point(161, 73);
            this.txtSByName.Name = "txtSByName";
            this.txtSByName.Size = new System.Drawing.Size(213, 20);
            this.txtSByName.TabIndex = 2;
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.ForeColor = System.Drawing.Color.Purple;
            this.lblSec.Location = new System.Drawing.Point(94, 45);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(43, 13);
            this.lblSec.TabIndex = 3;
            this.lblSec.Text = "Section";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Purple;
            this.lblName.Location = new System.Drawing.Point(94, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblSby
            // 
            this.lblSby.AutoSize = true;
            this.lblSby.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSby.Location = new System.Drawing.Point(25, 20);
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
            this.DGVdata.Location = new System.Drawing.Point(41, 111);
            this.DGVdata.Name = "DGVdata";
            this.DGVdata.Size = new System.Drawing.Size(629, 322);
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
            // DMC
            // 
            this.DMC.HeaderText = "View DMC";
            this.DMC.Name = "DMC";
            this.DMC.Text = "DMC";
            this.DMC.UseColumnTextForButtonValue = true;
            // 
            // cmdSearch
            // 
            this.cmdSearch.BackColor = System.Drawing.Color.LemonChiffon;
            this.cmdSearch.Location = new System.Drawing.Point(394, 45);
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
            this.lnkGoBck.LinkColor = System.Drawing.Color.Purple;
            this.lnkGoBck.Location = new System.Drawing.Point(25, 447);
            this.lnkGoBck.Name = "lnkGoBck";
            this.lnkGoBck.Size = new System.Drawing.Size(49, 13);
            this.lnkGoBck.TabIndex = 8;
            this.lnkGoBck.TabStop = true;
            this.lnkGoBck.Text = "Go Back";
            this.lnkGoBck.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoBck_LinkClicked);
            // 
            // Student_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 469);
            this.Controls.Add(this.lnkGoBck);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.DGVdata);
            this.Controls.Add(this.lblSby);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.txtSByName);
            this.Controls.Add(this.txtSBySec);
            this.Controls.Add(this.lnkShowAll);
            this.Name = "Student_Data";
            this.Text = "Student_Data";
            ((System.ComponentModel.ISupportInitialize)(this.DGVdata)).EndInit();
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
    }
}