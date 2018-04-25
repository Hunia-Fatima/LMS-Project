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
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("ENTER VALID EMAIL");
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
                server.Service1 server = new server.Service1();
                server.registerTeacher(txtUserName.Text, txtPassword.Text, txtEmail.Text, txtpincode.Text, lblSubject.Text ,cmbdepartment.Text);

            }
            else
            {
                server.Service1 server = new server.Service1();
                server.registerStudent(txtUserName.Text, txtPassword.Text, txtEmail.Text, txtpincode.Text,txtSec.Text);
            }
            MessageBox.Show("User Registered");
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

            lblSec.Hide();
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
            }
            if (cmbRegisterAs.Text == "Student")
            {
                txtSec.Show();
                lblSec.Show();
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
    }
}
