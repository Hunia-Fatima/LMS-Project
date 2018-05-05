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
    }
}
