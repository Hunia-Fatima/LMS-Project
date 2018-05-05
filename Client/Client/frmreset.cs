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
            bool isvalid = true;;
            bool ok;
            server.Service1 server = new server.Service1();
            if (chkstudent.Checked == false && chkteacher.Checked == false)
            {
                MessageBox.Show("Please Check checkbox");
            }
            if (chkstudent.Checked == true && chkteacher.Checked == true)
            {
                MessageBox.Show("Check only one checkbox");
            }
            if (chkstudent.Checked == true && chkteacher.Checked == false)
            {

               
                server.RESETSTUDENT(txtusername.Text, txtpincode.Text, out isvalid, out ok);
                if (!isvalid)
                {
                    MessageBox.Show("Enter Correct pincode");
                }
                else
                {
                    PASSWORD frm = new PASSWORD();
                    this.Hide();
                    frm.Show();
                }    

            }


            if (chkstudent.Checked == false && chkteacher.Checked == true)
            {


                server.RESETTEACHER(txtusername.Text, txtpincode.Text, out isvalid, out ok);
                if (!isvalid)
                {
                    MessageBox.Show("Enter Correct pincode");
                }
                else
                {
                    PASSWORD_TEACHER frm = new PASSWORD_TEACHER();
                    this.Hide();
                    frm.Show();
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