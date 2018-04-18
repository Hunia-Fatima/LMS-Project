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
            if (chkAdmin.Checked == true)
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
        }
    }
}
