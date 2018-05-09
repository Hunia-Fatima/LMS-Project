namespace CLient
{
    partial class ChatWithTeacher
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
            this.components = new System.ComponentModel.Container();
            this.Messages = new System.Windows.Forms.ListBox();
            this.cmdSend = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Messages
            // 
            this.Messages.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Messages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Messages.FormattingEnabled = true;
            this.Messages.Location = new System.Drawing.Point(11, 10);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(467, 316);
            this.Messages.TabIndex = 0;
            this.Messages.SelectedIndexChanged += new System.EventHandler(this.Messages_SelectedIndexChanged);
            // 
            // cmdSend
            // 
            this.cmdSend.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSend.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdSend.Location = new System.Drawing.Point(357, 340);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(120, 45);
            this.cmdSend.TabIndex = 1;
            this.cmdSend.Text = "Send";
            this.cmdSend.UseVisualStyleBackColor = false;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMsg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMsg.Location = new System.Drawing.Point(11, 346);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(340, 20);
            this.txtMsg.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChatWithTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CLient.Properties.Resources.zero_g_theme_logon_background_by_lilmegz97_d4sliyn3;
            this.ClientSize = new System.Drawing.Size(641, 403);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.cmdSend);
            this.Controls.Add(this.Messages);
            this.Name = "ChatWithTeacher";
            this.Text = "ChatWithTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Messages;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Timer timer1;
    }
}