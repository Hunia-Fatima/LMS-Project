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
            this.Messages.FormattingEnabled = true;
            this.Messages.Location = new System.Drawing.Point(11, 10);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(405, 316);
            this.Messages.TabIndex = 0;
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(336, 347);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(75, 23);
            this.cmdSend.TabIndex = 1;
            this.cmdSend.Text = "Send";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(11, 346);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(311, 20);
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
            this.ClientSize = new System.Drawing.Size(430, 403);
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