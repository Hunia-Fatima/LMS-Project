namespace CLient
{
    partial class Student_Chat
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
            this.DGVteachers = new System.Windows.Forms.DataGridView();
            this.lblConvo = new System.Windows.Forms.Label();
            this.cmdStConvo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVteachers)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVteachers
            // 
            this.DGVteachers.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVteachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVteachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVteachers.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGVteachers.Location = new System.Drawing.Point(-1, 90);
            this.DGVteachers.Name = "DGVteachers";
            this.DGVteachers.Size = new System.Drawing.Size(501, 182);
            this.DGVteachers.TabIndex = 6;
            // 
            // lblConvo
            // 
            this.lblConvo.AutoSize = true;
            this.lblConvo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConvo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConvo.Location = new System.Drawing.Point(21, 27);
            this.lblConvo.Name = "lblConvo";
            this.lblConvo.Size = new System.Drawing.Size(211, 21);
            this.lblConvo.TabIndex = 5;
            this.lblConvo.Text = "Conversation with teacher";
            // 
            // cmdStConvo
            // 
            this.cmdStConvo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdStConvo.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStConvo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdStConvo.Location = new System.Drawing.Point(198, 310);
            this.cmdStConvo.Name = "cmdStConvo";
            this.cmdStConvo.Size = new System.Drawing.Size(194, 49);
            this.cmdStConvo.TabIndex = 4;
            this.cmdStConvo.Text = "Start Conversation";
            this.cmdStConvo.UseVisualStyleBackColor = false;
            this.cmdStConvo.Click += new System.EventHandler(this.cmdStConvo_Click);
            // 
            // Student_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CLient.Properties.Resources.zero_g_theme_logon_background_by_lilmegz97_d4sliyn3;
            this.ClientSize = new System.Drawing.Size(500, 409);
            this.Controls.Add(this.DGVteachers);
            this.Controls.Add(this.lblConvo);
            this.Controls.Add(this.cmdStConvo);
            this.Name = "Student_Chat";
            this.Text = "Student_Chat";
            this.Load += new System.EventHandler(this.Student_Chat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVteachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVteachers;
        private System.Windows.Forms.Label lblConvo;
        private System.Windows.Forms.Button cmdStConvo;
    }
}