﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLient
{
    public partial class ChatWithTeacher : Form
    {
        public ChatWithTeacher()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            server.Service1 srvc = new server.Service1();
            string msg = srvc.getStudentMessage();
            if (msg != null)
            {
                Messages.Items.Add("Teacher>>  " + msg);
                srvc.setStudentMessage(null);
            }
        }
    }
}
