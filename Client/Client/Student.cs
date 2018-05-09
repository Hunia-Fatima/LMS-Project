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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            server.Service1 myservice = new server.Service1();
            lblStu.Text = myservice.loggedInStudent().Name; 
        }

        private void lnkSSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin L = new frmAdminLogin();
            L.Show();
            this.Hide();
        }

        private void cmdRegS_Click(object sender, EventArgs e)
        {
            frmRegisterSubject form = new frmRegisterSubject();
            this.Hide();
            form.Show();
        }

        private void cmdVDMC_Click(object sender, EventArgs e)
        {
            DMC form = new DMC();
            this.Hide();
            form.Show();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void cmdVA_Click(object sender, EventArgs e)
        {
            View_Attendance v = new View_Attendance();
            this.Hide();
            v.Show();
        }

        private void lblStu_Click(object sender, EventArgs e)
        {

        }

        private void cmdconvo_Click(object sender, EventArgs e)
        {
            Student_Chat Sc = new Student_Chat();
            Sc.Show();
            this.Hide();
            
            //ChatWithTeacher form = new ChatWithTeacher();
            //form.Show();
        }
    }
}
