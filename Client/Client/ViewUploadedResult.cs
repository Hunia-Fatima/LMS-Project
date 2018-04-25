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
    public partial class ViewUploadedResult : Form
    {
        public ViewUploadedResult()
        {
            InitializeComponent();
        }

        private void lnkgoback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddStudentResult frm = new AddStudentResult();
            this.Hide();
            frm.Show();
        }

        private void cmdShowAll_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            server.Service1 server = new server.Service1();
            source.DataSource = server.showResult();
            dataGridView1.DataSource = source;
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            server.Service1 server = new server.Service1();

            if (txtsection.Text == "A" || txtsection.Text == "B" || txtsection.Text == "C" || txtsection.Text == "D")
            {
                source.DataSource = server.BySection(txtsection.Text);
            }
            else
            {
                MessageBox.Show("first fill the box!!");
            }
            dataGridView1.DataSource = source;
        }
    }
}
