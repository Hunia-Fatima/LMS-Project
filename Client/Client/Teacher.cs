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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void lnkTSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin L = new frmAdminLogin();
            L.Show();
            this.Hide();
            

        }

        private void cmdUpldRes_Click(object sender, EventArgs e)
        {
            AddStudentResult fr = new AddStudentResult();
            this.Hide();
            fr.Show();
        }
    }
}
