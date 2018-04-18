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
            else
            {
                server.Service1 server = new server.Service1();
                server.registerUser(txtUserName.Text, txtPassword.Text, txtEmail.Text, cmbRegisterAs.Text);
                MessageBox.Show("User Registered");
                txtPassword.Text = "";
                txtUserName.Text = "";
                txtEmail.Text = "";
                cmbRegisterAs.Text = "";
            }
        }

        private void lnkGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegisterUser form = new frmRegisterUser();
            this.Hide();
            form.Show();
        }
    }
}
