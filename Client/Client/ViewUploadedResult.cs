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

        private void cmdShowAll_Click(object sender, EventArgs e)
        {
            server.Service1 myservice = new server.Service1();
            BindingSource source = new BindingSource();
            List<server.Result> s = myservice.get_result().ToList();
            source.DataSource = s;
            dataGridView1.DataSource = source;
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {

        }

        private void lnkUploadResult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddStudentResult frm = new AddStudentResult();
            this.Hide();
            frm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Teacher form = new Teacher();
            this.Hide();
            form.Show();
        }

        private void lnkUplaodAttendance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
