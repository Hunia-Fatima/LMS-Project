using System;
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
    public partial class ChatwithStudent : Form
    {
        public ChatwithStudent()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            server.Service1 myService = new server.Service1();
            myService.setStudentMessage(txtMsg.Text);
            Messages.Items.Add("Me>>  " + txtMsg.Text);
            txtMsg.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            server.Service1 srvc = new server.Service1();
            string msg = srvc.getTeacherMessage();
            if (msg != null)
            {
                Messages.Items.Add("Student>>  " + msg);
                srvc.setTeacherMessage(null);
            }
        }
    }
}
