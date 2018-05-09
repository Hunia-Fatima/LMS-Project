namespace CLient
{
    partial class DMCAdmin
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
            this.gvAdminDMC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdminDMC)).BeginInit();
            this.SuspendLayout();
            // 
            // gvAdminDMC
            // 
            this.gvAdminDMC.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gvAdminDMC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAdminDMC.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gvAdminDMC.Location = new System.Drawing.Point(0, 12);
            this.gvAdminDMC.Name = "gvAdminDMC";
            this.gvAdminDMC.Size = new System.Drawing.Size(497, 308);
            this.gvAdminDMC.TabIndex = 0;
            this.gvAdminDMC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DMCAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CLient.Properties.Resources.zero_g_theme_logon_background_by_lilmegz97_d4sliyn2;
            this.ClientSize = new System.Drawing.Size(679, 340);
            this.Controls.Add(this.gvAdminDMC);
            this.Name = "DMCAdmin";
            this.Text = "DMCAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.gvAdminDMC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvAdminDMC;
    }
}