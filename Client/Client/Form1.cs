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
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (chkAdmin.Checked == true && chkStudent.Checked == false && chkTeacher.Checked == false)
            {
                server.Service1 server = new server.Service1();
                bool isvalid;
                bool isvalidaccess;
                server.IsValid(txtName.Text, txtPassword.Text, out isvalid, out isvalidaccess);
                if (isvalid)
                {
                    Admin admin = new Admin();
                    this.Hide();
                    admin.Show();

                }
                else
                {
                    MessageBox.Show("Invalid user");
                }
            }
            else if (chkTeacher.Checked == true && chkAdmin.Checked == false && chkStudent.Checked == false)
            {
                server.Service1 myserver = new server.Service1();
                bool isValidTeacher;
                bool isValidTeacheraccess;
                myserver.IsValidTeacher(txtName.Text, txtPassword.Text, out  isValidTeacher, out isValidTeacheraccess);
                if (isValidTeacher)
                {
                    Teacher t = new Teacher();
                    this.Hide();
                    t.Show();
                }
                else 
                {
                    MessageBox.Show("Invalid user");
                }
            }
            else if (chkStudent.Checked == true && chkAdmin.Checked == false && chkTeacher.Checked == false)
            {
                server.Service1 ser = new server.Service1();
                bool ValidStu;
                bool ValidStuaccess;
                ser.IsValidStu(txtName.Text, txtPassword.Text, out  ValidStu, out ValidStuaccess);
                if (ValidStu)
                {
                    Student s = new Student();
                    s.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid user");
                }
            }
            else
            {
                MessageBox.Show("Check only one checkbox!!");
            }
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
