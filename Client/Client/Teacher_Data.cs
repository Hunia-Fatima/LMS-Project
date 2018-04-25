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
            if (txtname.Text == "")
            {
                server.Service1 server = new server.Service1();
                server.SearchByDepartment(cmbsearchbydep.Text);

                source.DataSource = server.SearchByDepartment(cmbsearchbydep.Text);
                dgv.DataSource = source;

            }
            else if (cmbsearchbydep.Text == "")
            {
                server.Service1 server = new server.Service1();
                server.SearchByname(txtname.Text);

                // List<Teacher> arr = WcfService2.TeacherDl.SearchByname(txtname.Text);

                source.DataSource = server.SearchByname(txtname.Text);
                dgv.DataSource = source;
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
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin form = new Admin();
            this.Hide();
            form.Show();
        }
    }
}
