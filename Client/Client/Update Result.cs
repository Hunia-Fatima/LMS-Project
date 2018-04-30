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
    public partial class Update_Result : Form
    {
        public Update_Result()
        {
            InitializeComponent();
            server.Service1 myservice = new server.Service1();
            BindingSource source = new BindingSource();
            List<server.Result> s = myservice.get_result().ToList();
            source.DataSource = s;
            dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            server.Service1 myservice = new server.Service1();
            if (e.ColumnIndex == 0)
            {
                myservice.update_result(myservice.get_result()[e.RowIndex]);
                MessageBox.Show("result updated");
            }
        }

        private void lnkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin form = new Admin();
            this.Hide();
            form.Show();
        }

        private void lnkteacherData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Teacher_Data form = new Teacher_Data();
            this.Hide();
            form.Show();
        }

        private void lnkStudentData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student_Data form = new Student_Data();
            this.Hide();
            form.Show();
        }

        private void lnkGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin form = new Admin();
            this.Hide();
            form.Show();
        }

        private void lnkRegisterUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegisterUser form = new frmRegisterUser();
            this.Hide();
            form.Show();
        }
    }
}
