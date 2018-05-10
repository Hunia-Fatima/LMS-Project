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
    public partial class Teacher_Data : Form
    {
        public Teacher_Data()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            if (txtname.Text == "" && cmbsearchbydep.Text != "" )
            {
                server.Service1 server = new server.Service1();
                server.SearchByDepartment(cmbsearchbydep.Text);

                source.DataSource = server.SearchByDepartment(cmbsearchbydep.Text);
                dgv.DataSource = source;
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].Visible = false;

            }
            else if (cmbsearchbydep.Text == "" && txtname.Text != "")
            {
                server.Service1 server = new server.Service1();
                server.SearchByname(txtname.Text);

                source.DataSource = server.SearchByname(txtname.Text);
                dgv.DataSource = source;
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].Visible = false;
            }
            else if (cmbsearchbydep.Text != "" && txtname.Text != "")
            {
                MessageBox.Show("Please fill only one box");
            }
            else
            {
                MessageBox.Show("Please Select the parameter for Searching");
            }
       

           
    }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BindingSource source = new BindingSource();
            server.Service1 server = new server.Service1();
            source.DataSource = server.showall();
            dgv.DataSource = source;
            dgv.Columns[0].Visible = false;
            dgv.Columns[1].Visible = false;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin form = new Admin();
            this.Hide();
            form.Show();
        }

        private void lnkRegisteUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegisterUser form = new frmRegisterUser();
            this.Hide();
            form.Show();
        }

        private void lnkstudentdata_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student_Data form = new Student_Data();
            this.Hide();
            form.Show();
        }

        private void lnkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin form = new frmAdminLogin();
            form.Show();
            this.Hide();
        }

        private void gbAdmin_Enter(object sender, EventArgs e)
        {

        }

        private void lnkUpdateResult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Update_Result form = new Update_Result();
            this.Hide();
            form.Show();
        }
    }
}
