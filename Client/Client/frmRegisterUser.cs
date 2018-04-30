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
    public partial class frmRegisterUser : Form
    {
        public frmRegisterUser()
        {
            InitializeComponent();
            cmbSubject.Hide();
            lblSubject.Hide();
            txtSec.Hide();
            lblSec.Hide();
            cmbdepartment.Hide();
            lbldepartment.Hide();
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            bool empty = false;
            if (txtUserName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtpincode.Text == "")
            {
                empty = true;
            }
            else if (!txtEmail.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("ENTER A VALID EMAIL");
            }
            else if (!txtPassword.Text.Any(Char.IsDigit) || !txtPassword.Text.Any(Char.IsLetter) || txtPassword.Text.Length < 8)
            {
                MessageBox.Show("PASSWORD MUST BE ALPHANUMERIC AND 8 CHARACTERS LONG");
            }
            else if (txtpincode.Text.Any(Char.IsLetter) || txtpincode.Text.Length < 4)
            {
                MessageBox.Show("pincode must be numeric and has min length 4");
            }
            else if (cmbRegisterAs.Text == "Teacher")
            {
                if (cmbdepartment.Text == "" || cmbSubject.Text == "")
                {
                    MessageBox.Show("Please Fill all the required Boxes");
                }
                else
                {
                    server.Service1 server = new server.Service1();
                    server.registerTeacher(txtUserName.Text, txtPassword.Text, txtEmail.Text, txtpincode.Text, cmbSubject.Text, cmbdepartment.Text);
                    MessageBox.Show("User Registered");
                }
            }
            else
            {
                if (txtSec.Text == "")
                {
                    MessageBox.Show("Please Fill all the required Boxes");
                }
                else
                {
                    server.Service1 server = new server.Service1();
                    server.registerStudent(txtUserName.Text, txtPassword.Text, txtEmail.Text, txtpincode.Text, txtSec.Text);
                    MessageBox.Show("User Registered");
                }
            }
            if (empty)
            {
                MessageBox.Show("Please Fill all the required Boxes");
            }
            else
            {
                txtPassword.Text = "";
                txtUserName.Text = "";
                txtEmail.Text = "";
                cmbRegisterAs.Text = "";
                txtpincode.Text = "";
                cmbSubject.Text = "";
                lblSubject.Hide();
                cmbSubject.Hide();
                txtSec.Text = "";
                txtSec.Hide();
                cmbdepartment.Text = "";
                cmbdepartment.Hide();
                lbldepartment.Hide();

                lblSec.Hide();
            }
        }

        private void lnkGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin form = new Admin();
            this.Hide();
            form.Show();
        }

        protected void cmbRegisterAs_TextChanged(object sender, EventArgs e)
        {
            if (cmbRegisterAs.Text == "Teacher")
            {
                cmbSubject.Show();
                lblSubject.Show();
                cmbdepartment.Show();
                lbldepartment.Show();
                txtSec.Hide();
                lblSec.Hide();
            }
            if (cmbRegisterAs.Text == "Student")
            {
                txtSec.Show();
                lblSec.Show();
                cmbSubject.Hide();
                lblSubject.Hide();
                cmbdepartment.Hide();
                lbldepartment.Hide();
            }
        }

        private void frmRegisterUser_Load(object sender, EventArgs e)
        {
            cmbRegisterAs.TextChanged += new EventHandler(cmbRegisterAs_TextChanged);
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSec_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRegisterAs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lnkUpdateResult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkteacherdata_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Teacher_Data form = new Teacher_Data();
            form.Show();
            this.Hide();
        }

        private void lnkstudentdata_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student_Data form = new Student_Data();
            form.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkteacherData_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Teacher_Data form = new Teacher_Data();
            this.Hide();
            form.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student_Data form = new Student_Data();
            this.Hide();
            form.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin form = new Admin();
            this.Hide();
            form.Show();
        }

        private void lnkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin form = new frmAdminLogin();
            this.Hide();
            form.Show();
        }
    }
}
