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
    public partial class frmRegisterSubject : Form
    {
        public frmRegisterSubject()
        {
            InitializeComponent();
            server.Service1 myservice = new server.Service1();
            BindingSource source = new BindingSource();
            List<server.Subject> s = myservice.getSubjects().ToList();
            source.DataSource = s;
            lblName.Text = myservice.loggedInStudent().Name;
            gvRegisterSubjects.DataSource = source;
        }

        private void gvRegisterUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            server.Service1 myserver = new server.Service1();
            bool is_found = false;
            if (e.ColumnIndex == 0)
            {
                foreach (server.Subject s in myserver.loggedInStudentSubject())
                {
                    if (s == myserver.getSubjects()[e.RowIndex])
                    {
                        myserver.unregisterSubject(myserver.loggedInStudent(), myserver.getSubjects()[e.RowIndex]);
                        MessageBox.Show("Subject Unregistered");
                        is_found = true;

                    }
                }
                if(!is_found)
                {
                myserver.registerSubject(myserver.loggedInStudent(),myserver.getSubjects()[e.RowIndex]);
                DataGridViewTextBoxCell sc = new DataGridViewTextBoxCell();
                sc.Value = "Registered";
                gvRegisterSubjects.Rows[e.RowIndex].Cells[0] = sc;
                MessageBox.Show("You are registered in the subject");
                }
            }                              
        }

        private void lnkGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student form = new Student();
            form.Show(); ;
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin form = new frmAdminLogin();
            form.Show();
            this.Hide();
        }

        private void lnkConversation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student_Chat form = new Student_Chat();
            form.Show();
            this.Hide();
        }

        private void lnkViewDMC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMC form = new DMC();
            form.Show();
            this.Hide();
        }

        private void lnkViewAttendance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            View_Attendance form = new View_Attendance();
            this.Hide();
            form.Show();
        }
    }
}
