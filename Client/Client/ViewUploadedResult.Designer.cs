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
            this.lnkgoback = new System.Windows.Forms.LinkLabel();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmdShowAll = new System.Windows.Forms.Button();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkgoback
            // 
            this.lnkgoback.AutoSize = true;
            this.lnkgoback.Location = new System.Drawing.Point(324, 296);
            this.lnkgoback.Name = "lnkgoback";
            this.lnkgoback.Size = new System.Drawing.Size(51, 13);
            this.lnkgoback.TabIndex = 10;
            this.lnkgoback.TabStop = true;
            this.lnkgoback.Text = "GOBACK";
            this.lnkgoback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkgoback_LinkClicked);
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(224, 23);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 9;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // cmdShowAll
            // 
            this.cmdShowAll.Location = new System.Drawing.Point(224, 73);
            this.cmdShowAll.Name = "cmdShowAll";
            this.cmdShowAll.Size = new System.Drawing.Size(75, 23);
            this.cmdShowAll.TabIndex = 8;
            this.cmdShowAll.Text = "ShowAll";
            this.cmdShowAll.UseVisualStyleBackColor = true;
            this.cmdShowAll.Click += new System.EventHandler(this.cmdShowAll_Click);
            // 
            // txtsection
            // 
            this.txtsection.Location = new System.Drawing.Point(86, 23);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(100, 20);
            this.txtsection.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // ViewUploadedResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 332);
            this.Controls.Add(this.lnkgoback);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.cmdShowAll);
            this.Controls.Add(this.txtsection);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewUploadedResult";
            this.Text = "ViewUploadedResult";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkgoback;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Button cmdShowAll;
        private System.Windows.Forms.TextBox txtsection;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}