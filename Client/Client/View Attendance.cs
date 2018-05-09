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
    public partial class View_Attendance : Form
    {
        public View_Attendance()
        {
            InitializeComponent();
            BindingSource source = new BindingSource();
            server.Service1 server = new server.Service1();
            source.DataSource = server.ViewAttendance(server.loggedInStudent());
           dataGridView1.DataSource = source;
        }

        private void View_Attendance_Load(object sender, EventArgs e)
        {

        }

        private void linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Student form = new Student();
            this.Hide();
            form.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DMC frm1 = new DMC();
            this.Hide();
            frm1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegisterSubject frm2 = new frmRegisterSubject();
            this.Hide();
            frm2.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student_Chat frm3 = new Student_Chat();
            this.Hide();
            frm3.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student frm4 = new Student();
            this.Hide();
            frm4.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin frm5 = new frmAdminLogin();
            this.Hide();
            frm5.Show();
        }
    }
}
