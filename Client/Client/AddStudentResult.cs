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
            if(textBox1.Text == "")
            {
                MessageBox.Show("Enter a Name");
            }
            else if (!textBox1.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Enter a  valid name");
            }
            else if(cmbsection.Text=="")
            {
                MessageBox.Show("Select any section From given options");

            }
            else if (!txtmarksobtained.Text.Any(char.IsDigit)&&txtmarksobtained.Text=="")
            {
                MessageBox.Show("Marks must be in digits");

            }
            else if (!textBox3.Text.Any(char.IsDigit)&&textBox3.Text=="")
            {
                MessageBox.Show("Marks must be in digits");

            }
            else if(cmbstatus.Text == "")
            {
                MessageBox.Show("Select any status from given option");
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
    }
}
