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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void lnkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin form = new frmAdminLogin();
            this.Hide();
            form.Show();
        }

        private void cmdRegisterUser_Click(object sender, EventArgs e)
        {
            frmRegisterUser form = new frmRegisterUser();
            this.Hide();
            form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVData.Text == "Student")
            {
                Student_Data s = new Student_Data();
                s.Show();
                this.Hide();
            }
            if (cmbVData.Text == "Teacher")
            {
                Teacher_Data t = new Teacher_Data();
                t.Show();
                this.Hide();
            }
        }

        private void cmdUpdateResult_Click(object sender, EventArgs e)
        {
            Update_Result form = new Update_Result();
            form.Show();
            this.Hide();
        }
    }
}
