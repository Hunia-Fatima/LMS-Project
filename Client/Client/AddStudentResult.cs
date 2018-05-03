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
    public partial class AddStudentResult : Form
    {
        public AddStudentResult()
        {
            InitializeComponent();
            server.Service1 myservice = new server.Service1();
            string[] s = myservice.registered_students();
            for (int i = 0; i < s.Length; i++ )
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

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            server.Service1 myservice = new server.Service1();
            myservice.Add_result(cmbStudents.Text, myservice.getLoggedInTeacher().subject, txtTotalMarks.Text, txtmarksobtained.Text);
            MessageBox.Show("Result added");
        }

        private void lnkuploadedresult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewUploadedResult view = new ViewUploadedResult();
            this.Hide();
            view.Show();

        }

        private void lnkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin form = new frmAdminLogin();
            this.Hide();
            form.Show();
        }

        private void cmbsection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbStudents_TextChanged(object sender, EventArgs e)
        {
            server.Service1 myservice = new server.Service1();
            foreach (server.Student s in myservice.get_registered_students())
            {
                if (cmbStudents.Text == s.Name)
                {
                    txtSec.Text = s.Section;
                }
            }
        }

        private void AddStudentResult_Load(object sender, EventArgs e)
        {
            cmbStudents.TextChanged += new EventHandler(cmbStudents_TextChanged);
        }

        private void lnkUplaodAttendance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Upload_Attendance up = new Upload_Attendance();
            this.Hide();
            up.Show();
        }
    }
}
