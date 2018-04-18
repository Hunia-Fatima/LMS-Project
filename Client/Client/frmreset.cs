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
    public partial class frmreset : Form
    {
        public frmreset()
        {
            InitializeComponent();
        }

        private void cmdresetpassword_Click(object sender, EventArgs e)
        {
            string password = "1234abcd";
            bool isvalid;
            bool isvalidacces;
            string user = "user";
            if (chkstudent.Checked == true)
            {
                user = "Student";
            }
            else if (chkteacher.Checked == true)
            {
                user = "Teacher";
            }
            server.Service1 server = new server.Service1();
            server.resetpaswrd(txtusername.Text, txtpincode.Text, user, out isvalid, out isvalidacces);
            if (isvalid)
            {
                MessageBox.Show("Password has been reset to 1234abcd");
            }
            else
            {
                MessageBox.Show("Enter correct pincode ");

            }
        }
        private void lbllogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin frm = new frmAdminLogin();
            this.Hide();
            frm.Show();
        }
        

        private void chkteacher_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}