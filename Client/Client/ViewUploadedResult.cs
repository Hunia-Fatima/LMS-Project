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
            BindingSource source = new BindingSource();
            server.Service1 server = new server.Service1();
            source.DataSource = server.Showalll();
            dataGridView1.DataSource = source;
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
            Upload_Attendance form = new Upload_Attendance();
            form.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ViewUploadedResult_Load(object sender, EventArgs e)
        {

        }

        private void lnkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin form = new frmAdminLogin();
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsection_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
