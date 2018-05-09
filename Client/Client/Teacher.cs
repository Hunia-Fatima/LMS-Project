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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
            server.Service1 srvc = new server.Service1();
            lblTeacher.Text = srvc.getLoggedInTeacher().name;
        }

        private void lnkTSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin L = new frmAdminLogin();
            L.Show();
            this.Hide();
            

        }

        private void cmdUpldRes_Click(object sender, EventArgs e)
        {
            AddStudentResult fr = new AddStudentResult();
            this.Hide();
            fr.Show();
        }

        private void cmdUpldAtt_Click(object sender, EventArgs e)
        {
            Upload_Attendance up = new Upload_Attendance();
            this.Hide();
            up.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChatwithStudent form = new ChatwithStudent();
            form.Show();
        }

        protected void cmbbact_TextChanged(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            server.Service1 server = new server.Service1();

            if (cmbact.SelectedText == "Busy")
            {
                server.getLoggedInTeacher().Status = false;

            }
            else if (cmbact.SelectedText == "Free")
            {
                server.getLoggedInTeacher().Status = true;
            }

        }
        private void Teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
