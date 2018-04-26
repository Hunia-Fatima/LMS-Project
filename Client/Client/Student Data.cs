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

        }
    }
}
