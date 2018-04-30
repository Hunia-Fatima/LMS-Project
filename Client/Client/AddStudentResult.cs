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
    public partial class AddStudentResult : Form
    {
        public AddStudentResult()
        {
            InitializeComponent();
        }

        private void lnkgoback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Teacher t = new Teacher();
            this.Hide();
            t.Show();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" || cmbsection.Text == "" || txtmarksobtained.Text == "" || textBox3.Text == "" || cmbstatus.Text == "")
            {
                MessageBox.Show("Please fill all Boxes");
            }
            else if (!textBox1.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Enter a  valid name");
            }
            else if (cmbsection.Text == "")
            {
                MessageBox.Show("Select any section from given options");
            }

            else if (!txtmarksobtained.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Marks must be in digits");

            }
            else if (!textBox3.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Marks must be in digits");

            }
            else if (cmbstatus.Text == "")
            {
                MessageBox.Show("Select section from given options");
            }
            else
            {
                server.Service1 server = new server.Service1();
        
                server.AddResult(textBox1.Text, cmbsection.Text, txtmarksobtained.Text, textBox3.Text, cmbstatus.Text);
                MessageBox.Show("Result has been Added");
                textBox1.Text = "";
                cmbsection.Text = "";
                txtmarksobtained.Text = "";
                textBox3.Text = "";
                cmbstatus.Text = "";
            }


        }

        private void lnkuploadedresult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewUploadedResult view = new ViewUploadedResult();
            this.Hide();
            view.Show();

        }

        private void lnkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin form = new frmAdminLogin();
            this.Hide();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            server.Service1 myserver = new server.Service1();
            if (e.ColumnIndex == 0)
            {
                Result_of_SectionA A = new Result_of_SectionA();
                this.Hide();
                A.Show();

            }
            else if (e.ColumnIndex == 1)
            {
                Result_of_SectionB B = new Result_of_SectionB();
                this.Hide();
                B.Show();

            }
            else if (e.ColumnIndex == 2)
            {
                Result_of_SectionC C = new Result_of_SectionC();
                this.Hide();
                C.Show();

            }
            else if (e.ColumnIndex == 3)
            {
                Result_of_SectionD D = new Result_of_SectionD();
                this.Hide();
                D.Show();

            }
        }
    }
}
