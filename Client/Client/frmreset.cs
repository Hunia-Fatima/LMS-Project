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
           
            bool isvalid;
            bool isvalidacces;
            string user = "user";
            if (chkstudent.Checked == true && chkteacher.Checked == false)
            {
                user = "Student";
            }
            else if (chkteacher.Checked == true && chkstudent.Checked == false)
            {
                user = "Teacher";
            }
            else if (chkteacher.Checked == true && chkstudent.Checked == true)
            {
                user = "Nobody";
            }
            else if (chkteacher.Checked == false && chkstudent.Checked == false)
            {
                user = "nobody";
            }
            server.Service1 server = new server.Service1();
            server.resetpaswrd(txtusername.Text, txtpincode.Text, user, out isvalid, out isvalidacces);
            
            if (user == "Nobody")
            {
                MessageBox.Show("Please check only one check box");
            }
            else if (user == "nobody")
            {
                MessageBox.Show("Select the user through checkbox first");
            }
            else
            {
                if (isvalid)
                {
                    MessageBox.Show("Password has been reset to 1234asdf");
                }
                else if (!isvalid)
                {
                    MessageBox.Show("Please Enter correct pincode");

                }

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