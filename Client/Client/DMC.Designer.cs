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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDMC
            // 
            this.dgvDMC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMC.Location = new System.Drawing.Point(14, 12);
            this.dgvDMC.Name = "dgvDMC";
            this.dgvDMC.Size = new System.Drawing.Size(255, 237);
            this.dgvDMC.TabIndex = 0;
            this.dgvDMC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDMC_CellContentClick);
            // 
            // DMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgvDMC);
            this.Name = "DMC";
            this.Text = "DMC";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDMC;
    }
}