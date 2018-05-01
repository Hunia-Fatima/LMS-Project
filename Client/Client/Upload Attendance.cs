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
    public partial class Upload_Attendance : Form
    {
        public Upload_Attendance()
        {
            InitializeComponent();
            
            server.Service1 myservice = new server.Service1();
            string[] s = myservice.registered_students();
            for (int i = 0; i < s.Length; i++)
            {
               cmbStudents.Items.Add(s[i]);
                  
            }
            cmbStudents.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void lnkgoback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Teacher t = new Teacher();
            this.Hide();
            t.Show();
        }

        private void lnkUplaodAttendance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddStudentResult Ad = new AddStudentResult();
            this.Hide();
            Ad.Show();
        }

        private void lnkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin form = new frmAdminLogin();
            this.Hide();
            form.Show();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            server.Service1 myserver = new server.Service1();
            myserver.AddAttendance(cmbStudents.Text, txtPerc.Text, txtSec.Text, txtSbj.Text, myserver.getLoggedInTeacher());
            MessageBox.Show("Attendance has been added");
                      
            
        }
    }
}
