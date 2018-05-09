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
    public partial class Student_Data : Form
    {
        public Student_Data()
        {
            InitializeComponent();
        }

        private void lnkShowAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BindingSource source = new BindingSource();
            server.Service1 server = new server.Service1();
            source.DataSource = server.ShowAll();
            DGVdata.DataSource = source;
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            server.Service1 server = new server.Service1();
            if (txtSByName.Text != "" && txtSBySec.Text != "")
            {
                MessageBox.Show("Kindly fill only one box!!");          
            }
            else if (txtSByName.Text != "" && txtSBySec.Text == "")
            {
                source.DataSource = server.SearchByName(txtSByName.Text);
            }
            else if (txtSByName.Text == "" && txtSBySec.Text != "")
            {
                source.DataSource = server.SearchBySection(txtSBySec.Text);
            }
            else if (txtSByName.Text == "" && txtSBySec.Text == "")
            {
                MessageBox.Show("Please fill aleast one textbox for search!!");
            }
            DGVdata.DataSource = source;
         }

        private void lnkGoBck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin form = new Admin();
            this.Hide();
            form.Show();
        }

        private void DGVdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                DMCAdmin form = new DMCAdmin();
                form.Show();
            }
        }

        private void lnkteacherdata_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Teacher_Data form = new Teacher_Data();
            this.Hide();
            form.Show();
           
        }

        private void lnkRegisteUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegisterUser form = new frmRegisterUser();
            this.Hide();
            form.Show();
        }

        private void lnkUpdateResult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Update_Result form = new Update_Result();
            form.Show();
            this.Hide();
        }

        private void lnkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin form = new frmAdminLogin();
            form.Show();
            this.Hide();
        }
    }
}
