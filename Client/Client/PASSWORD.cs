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
    public partial class PASSWORD : Form
    {
        public PASSWORD()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            bool isvalid = true;
            bool ok = true;
            server.Service1 server = new server.Service1();
            server.SETST(txtname.Text,txtpassword.Text, out isvalid, out ok);
            if (!isvalid)
            {
                MessageBox.Show("Please enter correct info");
            }
            else
            { MessageBox.Show("Password has been reset"); }
        }

        private void lbllogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin frm = new frmAdminLogin();
            this.Hide();
            frm.Show();
        }
    }
}
